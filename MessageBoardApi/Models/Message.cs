namespace MessageBoardApi.Models;

public class Message
{
    public int MessageId { get; set; }
    public string MessageText { get; set; }
    public DateTime PostDate { get; set; }

    public int GroupId { get; set; }
    // public Group Group { get; set; }

}
