using System;
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

        public async Task<IActionResult> ViewCard(int cardId)
        {
            var card = await HttpGetCard(cardId);
            return View(card);
        }

        public async Task<IActionResult> EditCard(int cardId)
        {
            var card = await HttpGetCard(cardId);
            return View(card);
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

        public async Task<CardModel> HttpPostCard(CardModel cardModel)
        {
            var response = await _client.PostAsJsonAsync($"{_path}", cardModel);
            CardModel newCard = null;
            if (response.IsSuccessStatusCode)
            {
                newCard = await response.Content.ReadAsAsync<CardModel>();
            }

            return newCard;
        }

        public async Task<IActionResult> DeleteCard(int cardId)
        {
            await _client.DeleteAsync($"{_path}/{cardId}");
            return RedirectToAction("Columns", "Column");
        }

        public async Task<IActionResult> UpdateCard(int cardId, string title, string description, int columnId)
        {
            var card = new CardModel(cardId, title, description, columnId);
            await _client.PutAsJsonAsync($"{_path}/{cardId}", card);
            return RedirectToAction("Columns", "Column");
        }

        public IActionResult AddCard(int columnId)
        {
            var card = new CardModel(0, "", "", columnId);
            return View(card);
        }
        
        public async Task<IActionResult> SaveCard(string title, string description, int columnId)
        {
            var card = new CardModel(0, title, description, columnId);
            await _client.PostAsJsonAsync($"{_path}", card);
            return RedirectToAction("Columns", "Column");
        }
    }
}