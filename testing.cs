using System.Linq;
using StageTwo.Models;

namespace StageTwo;

public class testing
{
    List<OperationType> ops = Enum.GetValues(typeof(OperationType)).Cast<OperationType>().ToList();
    
}