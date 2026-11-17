using Microsoft.AspNetCore.Mvc;
using PhamNgocKhai_241230754.Models;

namespace PhamNgocKhai_241230754.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {

        private readonly QlhangHoaContext _db;

        public LoaiHangViewComponent(QlhangHoaContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {

            var dsHangHoa = _db.LoaiHangs.ToList();
            return View(dsHangHoa);
        }
    }
}
