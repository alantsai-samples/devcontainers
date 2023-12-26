// 使用 ExpenseContext 來代表資料庫

using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base(options)
        {
            return;
        }

        // 資料產生，要包含category
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().HasData(
                new Expense
                {
                    Id = 1,
                    Date = new System.DateTime(2021, 4, 1),
                    Description = "午餐",
                    Amount = 150,
                    Category = "餐飲"
                },
                new Expense
                {
                    Id = 2,
                    Date = new System.DateTime(2021, 4, 1),
                    Description = "捷運",
                    Amount = 120,
                    Category = "交通"
                },
                new Expense
                {
                    Id = 3,
                    Date = new System.DateTime(2021, 4, 1),
                    Description = "電影",
                    Amount = 250,
                    Category = "娛樂"
                },
                new Expense
                {
                    Id = 4,
                    Date = new System.DateTime(2021, 4, 2),
                    Description = "晚餐",
                    Amount = 200,
                    Category = "餐飲"
                },
                new Expense
                {
                    Id = 5,
                    Date = new System.DateTime(2021, 4, 2),
                    Description = "計程車",
                    Amount = 350,
                    Category = "交通"
                },
                new Expense
                {
                    Id = 6,
                    Date = new System.DateTime(2021, 4, 2),
                    Description = "遊戲",
                    Amount = 1000,
                    Category = "娛樂"
                },
                new Expense
                {
                    Id = 7,
                    Date = new System.DateTime(2021, 4, 3),
                    Description = "早餐",
                    Amount = 100,
                    Category = "餐飲"
                },
                new Expense
                {
                    Id = 8,
                    Date = new System.DateTime(2021, 4, 3),
                    Description = "捷運",
                    Amount = 120,
                    Category = "交通"
                },
                new Expense
                {
                    Id = 9,
                    Date = new System.DateTime(2021, 4, 3),
                    Description = "電影",
                    Amount = 250,

        public DbSet<Expense> Expenses { get; set; }
    }
}