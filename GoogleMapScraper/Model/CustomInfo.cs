namespace GMapExtractor
{
    public class CustomInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Reviews { get; set; }
        public string Category { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string PlusCode { get; set; }
        public string Image { get; set; }

    }

    public class EmailIn
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class EmailOut
    {
        public string Id { get; set; }
        public string Email { get; set; }

    }
}
