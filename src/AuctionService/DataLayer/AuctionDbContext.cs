using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.DataLayer;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Auction> Auctions { get; set; }

}
