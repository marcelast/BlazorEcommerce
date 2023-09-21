namespace BlazorEcommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film. The Hitchhiker's Guide to the Galaxy is an international multimedia phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    ImageUrl = "https://static.fnac-static.com/multimedia/ES/images_produits/ES/grandes110/6/3/4/9780307887436/tsp20110829190609/Ready-player-one.gif",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. ",
                    ImageUrl = "https://images.booksense.com/images/935/524/9780451524935.jpg",
                    Price = 6.99m
                }
                );
        }

        public DbSet<Product>  Products{ get; set; }
        
    }
}
