using System.ComponentModel.DataAnnotations;

namespace testarmersaker.Models
{
    public class PadelPlayers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)] public DateTime Date { get; set; }
        public string Strengths { get; set; }
        public string Position { get; set; }
        public string Hand { get; set; }
        public string Shot { get; set; }
    }
}
