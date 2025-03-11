using Microsoft.EntityFrameworkCore;
using ProductoAPI.Models;

namespace ProductoAPI.Data;

public class AppDbContext(AppDBContextOption<AppDbContext> option) : DBContext(option)
{
    public DbSet<Product> Products { get; set; }
    
}

