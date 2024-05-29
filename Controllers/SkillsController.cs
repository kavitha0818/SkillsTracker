using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker;

public class SkillsController : Controller
{
   [HttpGet("/skills")]
   public IActionResult DisplaySkills()
   {
      string html = "<h1>Skill Tracker</h1>" + "<h2>Programming Languages</h2>" + "<ol>" + "<li>JavaScript</li>" + "<li>C#</li>" + "<li>Python</li>" + "</ol>";
      return Content(html, "text/html");
   }
   [HttpGet("/skills/form")]
   public IActionResult DisplayForm()
   {
      string html = "<form action='/skills/form' method='POST'>" + 
      "<p>Date: </p>" + "<input type='date' name='date' />" + 
      "<p>JavaScript</p>" + 
      "<select name='javaScriptProgress'><option value='basics'>Basics</option><option value='intermediate'>Intermediate</option><option value='expert'>Expert</option></select>" + 
      "<p>C#</p>" + 
      "<select name='cSharpProgress'><option value='basics'>Basics</option><option value='intermediate'>Intermediate</option><option value='expert'>Expert</option></select>" + 
      "<p>Python</p>" + 
      "<select name='pythonProgress'><option value='basics'>Basics</option><option value='intermediate'>Intermediate</option><option value='expert'>Expert</option></select>" + 
      "<button type='submit'>Submit</button>" + 
      "</form>";
      return Content(html, "text/html");
   }
   [HttpPost("/skills/form")]
   public IActionResult GetUserInput(string date, string javaScriptProgress, string cSharpProgress, string pythonProgress)
   {
      string html = "<h1>" +
         date + 
         "</h1>" +
         "<ol>" +
         "<li>JavaScript: " +
         javaScriptProgress +
         "</li>" +
         "<li>C#: " +
         cSharpProgress +
         "</li>" +
         "<li>Python: " +
         pythonProgress +
         "</li>" +
         "</ol>";
      return Content(html, "text/html");
   }
}