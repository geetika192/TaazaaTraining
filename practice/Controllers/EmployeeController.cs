using Microsoft.AspNetCore.Mvc;
using practice.Repository;
using practice.Models;

namespace practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
      IEmployee Iemployee;
      public EmployeeController(IEmployee emp1)
      {
         Iemployee=emp1;
      }
       [HttpPost("createcontact")]
      public IActionResult CreateEmployee(Employee employee)
      {
          Iemployee.AddEmployee(employee);
          return(Ok("Record is added"));
      }
      [HttpDelete("DeleteRecord{Id:int}")]
      public IActionResult DeleteEmployee(int Id)
      {
        Iemployee.Delete(Id);
        return Ok("Record is Removed");
      }
      [HttpGet("showAll")]
      public IActionResult ShowAll()
      {
          var temp1=Iemployee.GetAll();
          return(Ok(temp1));
      }
      [HttpPut("Update")]
      public IActionResult UpdateEmployee(Employee employee)
      {
        Iemployee.Update(employee);
        return(Ok("Record is updated"));
      }
      [HttpGet("search")]
      public IActionResult searchEmployee(int Id)
      {
        var temp=Iemployee.Find(Id);
        return(Ok(temp));

      }

    }
}