using csharp_oop_shop_composizione;

Shop supermercato = new Shop("Esselunga", "Bergamo", "Via Verdi", 2);
Product pane = new Product("Pane", "Pane multicerali", 0.30, 4);
Product latte = new Product("Latte", "Latte fresco", 1.29, 4);
Product farina = new Product("Farina", "Farina 00", 0.89, 4);

List<Product> prodottiSupermercato = new List<Product> { pane, latte, farina };

Console.WriteLine(supermercato.StringShopRappresent());
