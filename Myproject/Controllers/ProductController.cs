using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;
using Myproject.Models;

namespace Myproject.Controllers
{
    public class ProductController : Controller
    {
     
        public IActionResult Index2()
        {

            var model = new List<CustomerViewModel> {
            new CustomerViewModel{Id=12151, Name="Bir İdam Mahkümunun Son Günü",Yazar="Victor Hugo" },
            new CustomerViewModel{Id=16492, Name="İnsan Neyle Yaşar",Yazar="L.N Tolstoy" },
            new CustomerViewModel{Id=10968, Name="Suç Ve Ceza",Yazar="Dostoyevski" },
            new CustomerViewModel{Id=11632, Name="Yeraltından Notlar",Yazar="Dostoyevski" },
            new CustomerViewModel{Id=11632, Name="Gurur Ve Önyargı",Yazar="Jane Austen" },
            };

            return View(model);

        }

    
          
    }
}
