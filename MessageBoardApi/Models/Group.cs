namespace MessageBoardApi.Models;

public class Group
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public virtual List<Message> Messages { get; set; }
    

}
