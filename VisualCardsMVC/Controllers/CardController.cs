using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisualCardsMVC.Models;

namespace VisualCardsMVC.Controllers
{
    public class CardController : Controller
    {
        static HttpClient _client = new HttpClient();
        private static string _path = "http://localhost:8000/api/cards";

        public async Task<IActionResult> EditCard(int cardId)
        {
            var card = await HttpGetCard(cardId);
            return View(card);
        }
        
        public IActionResult AddCard(int columnId)
        {
            var card = new CardModel(0, "", "", columnId);
            return View(card);
        }
        
        public async Task<IActionResult> UpdateCard(int cardId, string title, string description, int columnId)
        {
            var card = new CardModel(cardId, title, description, columnId);
            await _client.PutAsJsonAsync($"{_path}/{cardId}", card);
            return RedirectToAction("Columns", "Column");
        }
        
        public async Task<CardModel> HttpGetCard(int id)
        {
            CardModel card = null;
            var response = await _client.GetAsync($"{_path}/{id}");
            if (response.IsSuccessStatusCode)
            {
                card = await response.Content.ReadAsAsync<CardModel>();
            }
            return card;
        }

        public async Task<IActionResult> HttpDeleteCard(int cardId)
        {
            await _client.DeleteAsync($"{_path}/{cardId}");
            return RedirectToAction("Columns", "Column");
        }
        
        public async Task<IActionResult> HttpSaveCard(string title, string description, int columnId)
        {
            var card = new CardModel(0, title, description, columnId);
            await _client.PostAsJsonAsync($"{_path}", card);
            return RedirectToAction("Columns", "Column");
        }
        
        public async Task<IActionResult> SearchCardByTitle(string searchTitle)
        {
            var cardList = new List<CardModel>();
            var resp = await _client.GetAsync($"{_path}/search?title={searchTitle}");
            if (resp.IsSuccessStatusCode)
            {
                cardList = await resp.Content.ReadAsAsync<List<CardModel>>();
            }

            return View(cardList);
        }
    }
}