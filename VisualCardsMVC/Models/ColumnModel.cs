using System.Collections.Generic;

namespace VisualCardsMVC.Models
{
    public class ColumnModel
    {
        public int ColumnId { get; set; }
        public string Title { get; set; }
        public List<CardModel> CardList { get; set; }
        public ColumnModel(int columnId = -1, string title = "", List<CardModel> cardList = null)
        {
            ColumnId = columnId;
            CardList = cardList;
            Title = title;
        }
    }
}