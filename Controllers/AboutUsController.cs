using AutoMapper;
using CelilCavus.GreenHosting.Dto.About;
using CelilCavus.GreenHosting.Entitys;
using CelilCavus.GreenHosting.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.GreenHosting.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IMapper _map;
        private readonly IUow _uow;

        public AboutUsController(IMapper map, IUow uow)
        {
            _map = map;
            _uow = uow;
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpPost]
        public IActionResult About(AboutAddDto about)
        {
            var mappingAbout = _map.Map<AboutUs>(about);
            _uow.GetRepository<AboutUs>().Add(mappingAbout);
            _uow.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult AboutList()
        {
            var getList = _uow.GetRepository<AboutUs>().GetAll();
            // var listMapping = _map.Map<List<AboutListDto>>(getList);
            return View(getList);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var getList = _uow.GetRepository<AboutUs>().GetById(id);
            return View(getList);
        }

        [HttpPost]
        public IActionResult Update(AboutAddDto about)
        {
            var mappingAbout = _map.Map<AboutUs>(about);
            _uow.GetRepository<AboutUs>().Update(mappingAbout);
            _uow.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult Delete(int id)
        {
            var value = _uow.GetRepository<AboutUs>().GetById(id);
            _uow.GetRepository<AboutUs>().Delete(value);
            _uow.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}