using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WfmWeb.Models;

namespace WfmWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly string apiBaseAddress = "https://localhost:44364/api/";
        public const string SessionToken = "_token";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Users users)
        {
            if (ModelState.IsValid)
            {
                ResponseUsers result;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseAddress);
                    HttpResponseMessage response = await client.PostAsJsonAsync("Users/authenticate", users);
                    var emp = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContext.Session.SetString(SessionToken, result.token);
                        if (result.role == "manager")
                        {
                            return RedirectToAction("manager");
                        }
                        else if(result.role == "wfm-member")
                        {
                            return RedirectToAction("Wfmmember");
                        }
                        else
                        {
                            ViewBag.message = "Not a valid role";
                        }
                    }
                    else
                    {
                        ViewBag.message = result.message;
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Wfmmember()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.GetAsync("Softlocks/GetAllSoftlocks");
                var emp = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<Softlocks> result = JsonConvert.DeserializeObject<IEnumerable<Softlocks>>(emp);
                    return View(result);
                }
                else
                {
                    ResponseUsers users = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    ViewBag.message = users.message;
                    return View("Index");
                }
            }
        }

        [HttpGet]
        public ActionResult _request(Softlocks softlocks)
        {
             return  PartialView(softlocks);
        }

        [HttpPost]
        public async Task<ActionResult> _Request(Softlocks softlocks)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.PutAsJsonAsync("Softlocks/UpdateSoftlocks", softlocks);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("lastupdate", new { employeeid = softlocks.employee_id, status = softlocks.managerstatus});
                }
            }
            return RedirectToAction("Wfmmember");
        }

        public async Task<ActionResult> lastupdate(int employeeid,string status)
        {
            Employees employees = new Employees();
            employees.employee_id = employeeid;
            if(status == "accepted")
                employees.lockstatus = "locked";
            else
                employees.lockstatus = "not_requested";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.PutAsJsonAsync("Employees/UpdateEmployees", employees);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Wfmmember");
                }
                else
                {
                    var emp = response.Content.ReadAsStringAsync().Result;
                    ResponseUsers users = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    ViewBag.message = users.message;
                    return View("Index");
                }
            }
        }

    public async Task<IActionResult> manager()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.GetAsync("Employees/GetEmployees");
                var emp = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<Employeeswithskills> result = JsonConvert.DeserializeObject<IEnumerable<Employeeswithskills>>(emp);
                    return View(result);
                }
                else
                {
                    ResponseUsers users = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    ViewBag.message = users.message;
                    return View("Index");
                }
            }
        }

        [HttpGet]
        public async Task<ActionResult> _lock(int id)
        {
            Softlocks softlocks = new Softlocks();
            softlocks.employee_id = id;
            return PartialView(softlocks);
        }

        [HttpPost]
        public async Task<ActionResult> _lock(Softlocks softlocks)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.PostAsJsonAsync("Softlocks/InsertSoftlocks",softlocks);
                var emp = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("updateemployee", new { employeeid = softlocks.employee_id });
                }
                else
                {
                    ResponseUsers users = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    ViewBag.message = users.message;
                    return View("Index");
                }
            }
        }

        public async Task<ActionResult> updateemployee(int employeeid)
        {
            Employees employees = new Employees();
            employees.employee_id = employeeid;
            employees.lockstatus = "request_waiting";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseAddress);
                var token = HttpContext.Session.GetString(SessionToken);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = await client.PutAsJsonAsync("Employees/UpdateEmployees", employees);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("manager");
                }
                else
                {
                    var emp = response.Content.ReadAsStringAsync().Result;
                    ResponseUsers users = JsonConvert.DeserializeObject<ResponseUsers>(emp);
                    ViewBag.message = users.message;
                    return View("Index");
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}