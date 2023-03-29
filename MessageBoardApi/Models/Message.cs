using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageBoardApi.Models;

public class Message
{
    public int MessageId { get; set; }
    [ForeignKey("Group")]
    public int GroupId { get; set; }

    public string MessageText { get; set; }
    public DateTime PostDate { get; set; }
     public string UserName { get; set; }


}
