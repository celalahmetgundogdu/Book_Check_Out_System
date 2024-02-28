namespace Book_Check_Out_System.Models
{
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public int pageNumber { get; set; }
        public DateTime dueDate { get; set; }
        public TimeSpan remainingTime { get; set; }
    }
}
