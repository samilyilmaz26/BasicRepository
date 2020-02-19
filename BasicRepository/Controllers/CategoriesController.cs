using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicRepository.Business;
using BasicRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicRepository.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesRepository _catRep;
        CategoriesModel _model;
        public CategoriesController(CategoriesRepository catRep, CategoriesModel model)
        {
            _catRep = catRep;
            _model = model;
        }

        public IActionResult Index()
        {
            _model.CatList = _catRep.GetCategories();
            return View(_model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            _model.Categories = await _catRep.Bul(id);
            return View(_model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoriesModel model)
        {
            await  _catRep.Guncel(model.Categories);
            return RedirectToAction("Index");
        }
         [HttpGet]
        public   IActionResult  Create ()
        { 
            return View(_model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoriesModel model)
        {
            await _catRep.Ekle(model.Categories);
            return RedirectToAction("Index");
        }
        
        public async Task< IActionResult> Delete(int id)
        {
            await _catRep.Sil(id);
            return RedirectToAction("Index");
        }
         
    }
}