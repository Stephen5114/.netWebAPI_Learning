namespace lesson1.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt(){ ShirtId=1, Brand="Nike", Color="Red", Size=42,  Gender = "Men", price = 3},
            new Shirt(){ ShirtId=2, Brand="Nike", Color="Blue", Size=42,  Gender = "Men", price = 33},
            new Shirt(){ ShirtId=3, Brand="Nike", Color="Pink", Size=42,  Gender = "Men", price = 23},
            new Shirt(){ ShirtId=4, Brand="Nike", Color="Yello", Size=42,  Gender = "Men", price = 63}
        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
