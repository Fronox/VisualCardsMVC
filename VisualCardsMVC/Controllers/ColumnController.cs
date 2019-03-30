using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisualCardsMVC.Models;

namespace VisualCardsMVC.Controllers
{
    public class ColumnController : Controller
    {
        static HttpClient _client = new HttpClient();
        private string _path = "http://localhost:8000/api/columns";
        
        public async Task<IActionResult> Columns()
        {
            List<ColumnModel> columns = await HttpGetColumns();
            return View(columns);
        }
        
        public async Task<List<CardModel>> HttpGetColumn()
        {
            List<CardModel> card = null;
            var response = await _client.GetAsync(_path);
            if (response.IsSuccessStatusCode)
            {
                card = await response.Content.ReadAsAsync<List<CardModel>>();
            }
            return card;
        }

        public async Task<List<ColumnModel>> HttpGetColumns()
        {
            List<ColumnModel> columns = null;
            var resp = await _client.GetAsync(_path);
            if (resp.IsSuccessStatusCode)
            {
                columns = await resp.Content.ReadAsAsync<List<ColumnModel>>();
            }

            return columns;
        }

        public async Task<IActionResult> DeleteColumn(int columnId)
        {
            await _client.DeleteAsync($"{_path}/{columnId}");
            return RedirectToAction("Columns", "Column");
        }
        
        public IActionResult AddColumn()
        {
            var column = new ColumnModel(0);
            return View(column);
        }
        
        public async Task<IActionResult> SaveColumn(string title)
        {
            var column = new ColumnModel(0, title, new List<CardModel>());
            await _client.PostAsJsonAsync($"{_path}", column);
            return RedirectToAction("Columns", "Column");
        }
    }
}