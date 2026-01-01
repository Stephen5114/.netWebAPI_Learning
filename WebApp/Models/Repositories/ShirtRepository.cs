namespace WebApp.Models.Repositories
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

        public static Shirt? GetShirtByProperties(string? brand, string? gender, string? color, int? size)
        {
            return shirts.FirstOrDefault(x => 
                !string.IsNullOrWhiteSpace(brand) && 
                !string.IsNullOrWhiteSpace(x.Brand) && 
                x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(gender) &&
                !string.IsNullOrWhiteSpace(x.Gender) &&
                x.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(color) &&
                !string.IsNullOrWhiteSpace(x.Color) &&
                x.Color.Equals(color, StringComparison.OrdinalIgnoreCase) &&
                size.HasValue &&
                x.Size.HasValue &&
                size.Value == x.Size.Value);
        }

        public static void AddShirt(Shirt shirt)
        {
            int maxId = shirts.Max(x => x.ShirtId);
            shirt.ShirtId = maxId + 1;
            shirts.Add(shirt);
        }

        public static void UpdateShirt(Shirt shirt)
        {
            var shirtToUpdate = shirts.First(x => x.ShirtId == shirt.ShirtId);
            shirtToUpdate.Brand = shirt.Brand;
            shirtToUpdate.price = shirt.price;
            shirtToUpdate.Size = shirt.Size;
            shirtToUpdate.Color = shirt.Color;
            shirtToUpdate.Gender = shirt.Gender;
        }

        public static void DeleteShirt(int  shirtId)
        {
            var shirt = GetShirtById(shirtId);
            if (shirt != null)
            {
                shirts.Remove(shirt);
            }

        }
    }
}
