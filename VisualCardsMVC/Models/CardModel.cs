
namespace VisualCardsMVC.Models
{
    public class CardModel
    {
        public int CardId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ColumnId { get; set; }

        public CardModel(int cardId = -1, string title = "", string description = "", int columnId = -1)
        {
            CardId = cardId;
            Title = title;
            Description = description;
            ColumnId = columnId;
        }
    }
}