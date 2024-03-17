using Microsoft.AspNetCore.Mvc;
using EcommerceMVC.Data;
using EcommerceMVC.ViewModels;

namespace EcommerceMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly Hshop2023Context _context;
        public MenuLoaiViewComponent(Hshop2023Context context) => _context = context;

        public IViewComponentResult Invoke()
        {
            var data = _context.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);
            return View(data);
        }
    }
}
