using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MiniSupermarket.API.Models;
using System.Reflection.Metadata.Ecma335;

namespace MiniSupermarket.API.Controllers
{
    [Route("api/[controller]")] // Định tuyến cơ sở: /api/categories
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {

        //Dữ liệu mẫu lưu tạm trên bộ nhớ RAM (In-Memory) phục vụ kiểm thử khi chưa có Database
        private static readonly List<Category> _categories = new()
        {
            new Category {CategoryId = 1,CategoryName="Bánh kẹo & Đồ ăn vặt",Description="Snack, bánh quy, kẹo dẻo"},
            new Category {CategoryId = 2,CategoryName="Nước giải khát & Trà",Description="Nước ngọt, nước khoáng, trà"},
            new Category {CategoryId = 3,CategoryName="Sữa & Sản phẩm từ sữa",Description="Sữa tươi, sữa chua, phô mai"},
            new Category {CategoryId = 4,CategoryName="Mì gói & Thực phẩm ăn liền",Description="Mì ăn liền, phở khô, cháo gói"},
            new Category {CategoryId = 5,CategoryName="Gia vị & Dầu ăn",Description="Nước mắm, hạt nêm, dầu thực vật"},
        };

        //1.READ: Lấy toàn bộ danh sách nhóm hàng (GET/api/categories)
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        //2.READ: Lấy chi tiết một nhóm hàng theo ID (GET/api/categories/{id})
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng!" });
            }
            return Ok(cat);
        }

        //3.SEARCH: Tìm kiếm nhóm hàng theo từ khóa qua Query String (GET/api/categories/search?keyword=...)
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest(new { message = "Vui lòng nhập từ khóa!" });
            }
            var ressult = _categories
                .Where(c => c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(ressult);
        }

        //4.CREATE: Thêm mới nhóm hàng (POST/api/categories) - CHỈ ADMIN
        [HttpPost]
        [Authorize(Roles = "Admin")] // <--- Thêm phân quyền tại đây
        public IActionResult Create([FromBody] Category newCat)
        {
            if (string.IsNullOrWhiteSpace(newCat.CategoryName))
            {
                return BadRequest(new { message = "Tên không được trống!" });
            }
            newCat.CategoryId = _categories.Count > 0 ? _categories.Max(c => c.CategoryId) + 1 : 1;
            _categories.Add(newCat);
            return CreatedAtAction(nameof(GetById), new { id = newCat.CategoryId }, newCat);
        }

        //5.UPDATE: Cập nhật thông tin nhóm hàng (PUT/api/categories/{id}) - CHỈ ADMIN
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // <--- Thêm phân quyền tại đây
        public IActionResult Update(int id, [FromBody] Category updateCat)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần sửa!" });
            }
            cat.CategoryName = updateCat.CategoryName;
            cat.Description = updateCat.Description;

            return NoContent();
        }

        //6. DELETE: Xóa nhóm hàng theo ID (DELETE /api/categories/{id}) - CHỈ ADMIN
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")] // <--- Thêm phân quyền tại đây
        public IActionResult Delete(int id)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần xóa!" });
            }
            _categories.Remove(cat);
            return NoContent();
        }

        // 7. Kiểm tra quyền Admin
        [HttpGet("admin-dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminDashboard()
        {
            return Ok(new { message = "Chào mừng Admin! Bạn có toàn quyền quản trị hệ thống siêu thị mini." });
        }

        // 8. Kiểm tra quyền chung cho nhân viên
        [HttpGet("staff-pos")]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult GetStaffPos()
        {
            return Ok(new { message = "Màn hình POS Thu ngân sẵn sàng phục vụ bán hàng." });
        }
    }
}