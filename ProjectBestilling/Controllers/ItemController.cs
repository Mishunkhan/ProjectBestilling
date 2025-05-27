using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Item Class identify
using ProjectBestilling.Models;

namespace ProjectBestilling.Controllers
{
    
    public class ItemController : Controller
    {
        public IActionResult Table()
        {
            //list of item
            var items = new List<Item>();

            //making two instances of Item 
            var item1 = new Item();
            item1.ItemId = 1;
            item1.Name = "Test";
            item1.Price = 100;
            item1.Description = "Test";


            var item2 = new Item
            {
               ItemId = 2,
               Name = "Test2",
               Price = 200,
               Description = "Test2"
            };

            items.Add(item1);
            items.Add(item2);

            ViewBag.CurrentViewName = "List of Items";
            return View(items);

        }

    }
}
