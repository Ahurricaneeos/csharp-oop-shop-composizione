using csharp_oop_shop_composizione;

Shop supermercato = new Shop("Esselunga", "Bergamo", "Via Verdi", 2);
Product pane = new Product("Pane", "Pane multicerali", 0.30, 4);
Product latte = new Product("Latte", "Latte fresco", 1.29, 4);
Product farina = new Product("Farina", "Farina 00", 0.89, 4);
Product patatine = new Product("Patatine", "Patatine gusto pomodoro", 1.59, 10);
Product cioccolato = new Product("Cioccolato", "Cioccolato al latte", 1, 10);
Product videogame = new Product("Videogame", "Spyro", 15.99, 22);

supermercato.addProduct(pane);
supermercato.addProduct(latte);
supermercato.addProduct(farina);

List<Product> prodottiSupermercato = new List<Product> { patatine, cioccolato, videogame };

supermercato.addListProducts(prodottiSupermercato);

Console.WriteLine(supermercato.StringShopRappresent());