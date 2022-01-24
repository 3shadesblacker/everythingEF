using Microsoft.EntityFrameworkCore;
//using Everything.Data;

namespace Everything.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EverythingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EverythingContext>>()))
            {
                if (context == null || context.Transaction == null)
                {
                    throw new ArgumentNullException("Null RazorPagesTransactionContext");
                }

                // Look for any Transactions.
                if (context.Transaction.Any())
                {
                    return;   // DB has been seeded
                }

                context.Transaction.AddRange(
                    new Transaction
                    {
                        Article = "When Harry Met Sally",
                        Date = DateTime.Parse("1989-2-12"),
                        Quantity = 1,
                        Price = 7.99
                    },

                    new Transaction
                    {
                        Article = "Ghostbusters ",
                        Date = DateTime.Parse("1984-3-13"),
                        Quantity = 1,
                        Price = 8.99
                    },

                    new Transaction
                    {
                        Article = "Ghostbusters 2",
                        Date = DateTime.Parse("1986-2-23"),
                        Quantity = 1,
                        Price = 9.99
                    },

                    new Transaction
                    {
                        Article = "Rio Bravo",
                        Date = DateTime.Parse("1959-4-15"),
                        Quantity = 1,
                        Price = 3.99
                    }
                );
                context.SaveChanges();
            }
        }
    }
}