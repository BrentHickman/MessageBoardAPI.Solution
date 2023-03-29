using Microsoft.EntityFrameworkCore;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : DbContext
  {
    public DbSet<Message> Messages { get; set; }
    public DbSet<Group> Groups { get; set; }

    public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, GroupName = "Group 1"},
          new Group { GroupId = 2, GroupName = "Group 2"},
          new Group { GroupId = 3, GroupName = "Group 3"}
        );
      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, MessageText = "Hello World", PostDate = DateTime.Now, GroupId = 1 },
          new Message { MessageId = 2, MessageText = "Whattup World", PostDate = new DateTime(2011, 2, 10), GroupId = 2 },
          new Message { MessageId = 3, MessageText = "Hi There World", PostDate = new DateTime(2012, 3, 15), GroupId = 3 }
        );
    }
    
  }
}