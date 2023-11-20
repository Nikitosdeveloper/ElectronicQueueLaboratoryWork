using ElectronicQuere;
using Microsoft.AspNetCore.Mvc;
using StudentPerson;

namespace API;


[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] Person model)
    {
        // Проверка, что и логин, и пароль не являются пустыми
        if (!string.IsNullOrWhiteSpace(model.Username) && !string.IsNullOrWhiteSpace(model.Password))
        {
            Student student = new Student();
            student.Login = model.Username;
            student.Password = model.Password;
            return Ok();
        }

        // Если логин или пароль пустые, вернуть BadRequest
        return BadRequest("Логин и пароль не могут быть пустыми.");
    }
}
