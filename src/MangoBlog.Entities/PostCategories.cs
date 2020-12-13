namespace MangoBlog.Entities
{
    public class PostCategories
    {
        public string PostId { get; set; }

        public string CategoryId { get; set; }

        public virtual Post Post { get; set; }

        public virtual Category Category { get; set; }
    }
}
