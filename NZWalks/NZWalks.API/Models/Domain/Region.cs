namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        // Navigation Property
        public IEnumerable<Walk> Walks { get; set; }

        // 14.satırda Entity framework'e bir regionun birden fazla walk'ı olabilir diyoruz
        // yani Region objesi ile Walk objesini birbiri ile ilişkilendirdik bu şekilde.
    }
}
