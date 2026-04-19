// ⁠1. You have a List<Transaction> (where each object has an Amount, Category, and Date).
public class Transaction
{
    public int ID{get; set;}
    public double Amount { get; set; }
    public string Category { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Transaction> transaction = new List<Transaction>
        {
            new Transaction { ID = 1, Amount = 2500, Category = "Food", Date = new DateTime(2026, 1, 10) },
            new Transaction { ID = 2, Amount = 1200, Category = "Transport", Date = new DateTime(2026, 3, 25) },
            new Transaction { ID = 3, Amount = 5000, Category = "Shopping", Date = new DateTime(2026, 4, 5) },
            new Transaction { ID = 4, Amount = 800, Category = "Food", Date = new DateTime(2026, 4, 15) },
            new Transaction { ID = 5, Amount = 1500, Category = "Bills", Date = new DateTime(2026, 3, 20) },
            new Transaction { ID = 6, Amount = 2200, Category = "Transport", Date = new DateTime(2026, 4, 1) },
            new Transaction { ID = 7, Amount = 900, Category = "Transport", Date = new DateTime(2026, 4, 12) },
            new Transaction { ID = 8, Amount = 3000, Category = "Food", Date = new DateTime(2026, 3, 30) },
            new Transaction { ID = 9, Amount = 4500, Category = "Shopping", Date = new DateTime(2026, 4, 18) },
            new Transaction { ID = 10, Amount = 700, Category = "Bills", Date = new DateTime(2026, 2, 28) },
            new Transaction { ID = 11, Amount = 1100, Category = "Transport", Date = new DateTime(2026, 4, 3) },
            new Transaction { ID = 12, Amount = 2600, Category = "Food", Date = new DateTime(2026, 3, 7) },
            new Transaction { ID = 13, Amount = 3200, Category = "Shopping", Date = new DateTime(2026, 3, 22) },
            new Transaction { ID = 14, Amount = 1000, Category = "Bills", Date = new DateTime(2026, 1, 14) },
            new Transaction { ID = 15, Amount = 1800, Category = "Food", Date = new DateTime(2025, 12, 9) }
        };
        // a. Uses LINQ to filter transactions from the last 30 days.

        Console.WriteLine("\n\n===============|Last 30 Days Transactions|===============");
        DateTime last30Days = DateTime.Now.AddDays(-30);
        var lastSales = transaction.Where(t => t.Date >= last30Days).ToList();
        int count = 0;
        foreach (var s in lastSales)
        {
            Console.WriteLine($"ID: {s.ID}, Amount: {s.Amount}, Category: {s.Category}, Date: {s.Date}");
            count++;
        }
        Console.WriteLine($"\nTotal transactions in the last 30 days: {count}");

//     b. Groups these transactions by Category and calculates the total sum per category.
//     c. Store these results into a Dictionary<string, decimal> (Category as key, Sum as value).
       
        Console.WriteLine("\n\n===============|Total Amount per Category|===============");
        var totalAmountPerCategory = transaction.GroupBy(t => t.Category).ToDictionary(
            a =>  a.Key,
            a => a.Sum(t => t.Amount)
        );

        foreach(var item in totalAmountPerCategory)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }



//     d. Finally, uses LINQ to return a List of the top 3 categories with the highest spending, sorted descending.
        Console.WriteLine("\n\n===============|Top 3 Categories with Highest Spending|===============");
        var topThree = transaction.GroupBy(t => t.Category).Select(b => 
        new
        {
            Category = b.Key,
            Amount = b.Sum(t => t.Amount) 
        }
        ).OrderByDescending(t => t.Amount).Take(3).ToList();

        foreach (var z in topThree)
        {
            Console.WriteLine($"{z.Category} : {z.Amount}");
        }
        Console.WriteLine("\n");
    }

}




// 2. Design a simple 'Recent Items' cache system.
//     a. Use a Queue<string> to track the order of items added.
//     b. Use a HashSet<string> to ensure that no duplicate items are ever added to the queue (check the set before enqueuing).
//     c. When the queue exceeds 10 items, remove the oldest item from both the Queue and the HashSet.
//     d. Write a method that returns the current cache items as a sorted string[] (Array) using LINQ.


// 3. You have a List<User> where each user has an Id, Username, and a List<int> of scores.
//     a. Create a Dictionary<int, int> where the key is the UserId and the value is the sum of that user's scores (calculated via LINQ).
//     b. Using this dictionary, write a LINQ query to find all Usernames whose total score is above the average of all users.
//     c. Return the final list of usernames as a List<string> sorted alphabetically.


// 4. You have a Dictionary<string, List<Employee>> where the key is the Department Name and the value is a list of employees in that department.
//     a. Use LINQ SelectMany to flatten all employees from all departments into one single sequence.
//     b. Filter this sequence to find employees who earn more than $50,000.
//     c. Transform (Project) these employees into a List of their full names (FirstName + LastName).
//     d. Convert the final result into an Array.
