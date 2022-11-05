using Microsoft.AspNetCore.Mvc;
using StageTwo.Models;

namespace StageTwo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OperationController : ControllerBase
{
    [HttpPost]
    public  ActionResult Calculate(Operation operation)
    {
         try
        {
            int result = 0;
            string[] adds = {"add", "addition", "plus", "+", "sum", "total", "added"};
            string[] subtracts = {"subtraction", "minus", "-","difference", "remove", "deduct", "subtract", "subtracted"};
            string[] times = {"product", "by", "times","*", "multiplication", "multiply", "off", "x", "multiplied"};
            
            if(operation == null) return BadRequest();

            //check if string is more than 1
            if(operation.operation_type.Split(" ").Length > 1)
            {   
                string[] words = operation.operation_type.Split(" ");
                
                foreach (string word in words)
                {
                    if(adds.Contains(word.ToLower()))
                    {
                        result = operation.x + operation.y;
                        var test =  new Response("Ese_O", result, OperationType.addition);
                        return  Ok(test);
                    }
                    else if(subtracts.Contains(word.ToLower()))
                    {
                        result = operation.x - operation.y;
                        var test =  new Response("Ese_O", result, OperationType.subtraction);
                        return  Ok(test);
                    }
                    else if(times.Contains(word.ToLower()))
                    {
                        result = operation.x * operation.y;
                        var test =  new Response("Ese_O", result, OperationType.multiplication);
                        return  Ok(test);
                        
                    }
                    
                }
            }
            else
            {
                if(adds.Contains(operation.operation_type))
                {
                    result = operation.x + operation.y;
                    var test =  new Response("Ese_O", result, OperationType.addition);
                    return  Ok(test);
                }
                else if(subtracts.Contains(operation.operation_type))
                {
                     result = operation.x - operation.y;
                    var test =  new Response("Ese_O", result, OperationType.subtraction);
                    return  Ok(test);
                }
                else if(times.Contains(operation.operation_type))
                {
                    result = operation.x * operation.y;
                    var test =  new Response("Ese_O", result, OperationType.multiplication);
                    return  Ok(test);
                }
                
                // var opType = Enum.Parse<OperationType>(operation.operation_type);
                

            }

            return BadRequest();

        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }

    }
}