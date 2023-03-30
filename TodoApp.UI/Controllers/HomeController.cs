using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.Interfaces;
using TodoApp.Dtos.WorkDtos;
using TodoApp.UI.Extensions;

namespace TodoApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkServices _workServices;
        public HomeController(IWorkServices workServices)
        {
            _workServices = workServices;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _workServices.GetAll();
            return View(response.Data);
        }
        public IActionResult Create()
        {
            return View(new WorkCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
            var response = await _workServices.Create(dto);
            return this.ResponseRedirectToAction(response, "Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var response = await _workServices.GetById<WorkUpdateDto>(id);
            return this.ResponseView(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto)
        {
            var response = await _workServices.Update(dto);
            return this.ResponseRedirectToAction(response, "Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            var response = await _workServices.Remove(id);
            return this.ResponseRedirectToAction(response, "Index");
        }

        public IActionResult NotFound(int code)
        {
            return View();
        }
    }
}