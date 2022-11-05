namespace StageTwo.Models;

public class Response
{
    public string SlackUsername { get; set; }
    public int Result { get; set; }
    public OperationType Operation_type { get; set; }

    public Response(string slackusername, int result, OperationType operationType)
    {
        SlackUsername = slackusername;
        Result = result;
        Operation_type = operationType;

    }
}