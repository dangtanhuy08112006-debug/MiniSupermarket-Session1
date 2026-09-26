namespace MiniSupermarket.API.Models
    //Lớp biểu diễn thực thể Nhóm Hàng hóa trong siêu thi mini
{
    public class Category
    {
        //Mã định danh nhóm hàng(Khóa chính)
        public int CategoryId { get; set; }
        //Tên hóm hàng (Bắt buộc, không được để trống)
        public string CategoryName {  get; set; }=string.Empty;
        //Mô tả chi tiết về nhóm hàng (Có thể để trống)
        public string? Description { get; set; }
    }
}
