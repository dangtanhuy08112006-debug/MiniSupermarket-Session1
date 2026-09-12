using Microsoft.AspNetCore.Mvc;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private static readonly List<Category> _categories = new()
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "Bánh kẹo & Đồ ăn vặt",
                Description = "Snack, bánh quy, kẹo dẻo"
            },

            new Category
            {
                CategoryId = 2,
                CategoryName = "Nước giải khát & Trà",
                Description = "Nước ngọt, nước khoáng, trà"
            },

            new Category
            {
                CategoryId = 3,
                CategoryName = "Sữa & Sản phẩm từ sữa",
                Description = "Sữa tươi, sữa chua, phô mai"
            },

            new Category
            {
                CategoryId = 4,
                CategoryName = "Mì gói & Thực phẩm ăn liền",
                Description = "Mì ăn liền, phở khô, cháo gói"
            },

            new Category
            {
                CategoryId = 5,
                CategoryName = "Gia vị & Dầu ăn",
                Description = "Nước mắm, hạt nêm, dầu thực vật"
            }
        };

        // GET: api/categories
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        // GET: api/categories/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound(new
                {
                    message = "Không tìm thấy nhóm hàng!"
                });
            }

            return Ok(category);
        }

        // GET: api/categories/search?keyword=banh
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest(new
                {
                    message = "Vui lòng nhập từ khóa!"
                });
            }

            var result = _categories
                .Where(c => c.CategoryName.Contains(
                    keyword,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(result);
        }

        // POST: api/categories
        [HttpPost]
        public IActionResult Create([FromBody] Category newCategory)
        {
            if (string.IsNullOrWhiteSpace(newCategory.CategoryName))
            {
                return BadRequest(new
                {
                    message = "Tên nhóm hàng không được để trống!"
                });
            }

            newCategory.CategoryId =
                _categories.Count > 0
                    ? _categories.Max(c => c.CategoryId) + 1
                    : 1;

            _categories.Add(newCategory);

            return CreatedAtAction(
                nameof(GetById),
                new { id = newCategory.CategoryId },
                newCategory);
        }

        // PUT: api/categories/1
        [HttpPut("{id}")]
        public IActionResult Update(
            int id,
            [FromBody] Category updateCategory)
        {
            var category = _categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound(new
                {
                    message = "Không tìm thấy nhóm hàng cần sửa!"
                });
            }

            if (string.IsNullOrWhiteSpace(updateCategory.CategoryName))
            {
                return BadRequest(new
                {
                    message = "Tên nhóm hàng không được để trống!"
                });
            }

            category.CategoryName = updateCategory.CategoryName;
            category.Description = updateCategory.Description;

            return NoContent();
        }

        // DELETE: api/categories/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound(new
                {
                    message = "Không tìm thấy nhóm hàng cần xóa!"
                });
            }

            _categories.Remove(category);

            return NoContent();
        }
    }
}
