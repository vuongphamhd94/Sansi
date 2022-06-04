using AdminLTE.Models.SansiModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AdminLTE.Controllers.Sansi
{
    public class SansiHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexQuanLyDonHang()
        {
            return View();
        }
        public IActionResult IndexSuaDon()
        {
            return View();
        }
        public IActionResult IndexCaiDatThayDoiThongTin()
        {
            return View();
        }
        public IActionResult IndexTaoDonHangKyGui()
        {
            return View();
        }
        public IActionResult IndexTimKiemSanPham()
        {
            return View();
        }
        public IActionResult IndexCaiDatDiaChiGiaoHang()
        {
            return View();
        }
        public IActionResult IndexCaiDatThayDoiMatKhau()
        {
            return View();
        }
        public IActionResult IndexDanhMucSanPham(int id)
        {
            var listDanhMucSanPham = new List<DanhMucSanPhamModel>();

            var danhMucSanPham1 = new DanhMucSanPhamModel
            {
                Id = 1,
                DoGiaDung = new List<SanPhamModel>
                {
                    new SanPhamModel
                    {
                        Id = 1,
                        UrlImage = "/images/Danh-muc-sp/03_Home-1-4.jpg",
                    },

                    new SanPhamModel {
                        Id = 2,
                        GiaSanPham = 46.2,
                        TenSanPham = "Sexy Dresses",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.1.jpg",

                    },
                    new SanPhamModel
                    {
                        Id = 3,
                        GiaSanPham = 41.2,
                        UrlImage = "Sexy Dresses 2",
                        TenSanPham = "/images/Danh-muc-sp/Rectangle 6.jpg",
                    },
                    new SanPhamModel
                    {
                        Id = 4,
                        GiaSanPham = 32.2,
                        TenSanPham = "Sexy Dresses 3",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.2.jpg",
                    },
                    new SanPhamModel
                    {
                        Id = 5,
                        GiaSanPham = 62.1,
                        TenSanPham = "Sexy Dresses",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.3.jpg",
                    },
                },
                TheThao = new List<SanPhamModel>
                {
                    new SanPhamModel
                    {
                        Id = 1,
                        UrlImage = "/images/Danh-muc-sp/03_Home-1-4 (1).jpg",
                    },

                    new SanPhamModel
                    {
                        Id = 2,
                        GiaSanPham = 12.1,
                        TenSanPham = "Sản phẩm 1",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6 (1).jpg",

                    },

                    new SanPhamModel
                    {
                        Id = 3,
                        GiaSanPham = 14.1,
                        TenSanPham = "Sản phẩm 2",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.1 (1).jpg",

                    },

                    new SanPhamModel
                    {
                        Id = 4,
                        GiaSanPham = 16.1,
                        TenSanPham = "Sản phẩm 3",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.2 (1).jpg",

                    },

                    new SanPhamModel
                    {
                        Id = 5,
                        GiaSanPham = 65.2,
                        TenSanPham = "Sản phẩm 3",
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.3 (1).jpg",

                    }

                },
                ThoiTrang = new List<SanPhamModel>
                {
                    new SanPhamModel
                    {
                        Id = 1,
                        UrlImage = "/images/Danh-muc-sp/03_Home-1-4 (2).jpg",
                    },
                    new SanPhamModel
                    {
                        Id = 2,
                        GiaSanPham = 13.1,
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6 (2).jpg",
                        TenSanPham = "Bếp điênh",
                    },
                    new SanPhamModel
                    {
                        Id = 3,
                        GiaSanPham = 16.1,
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.1 (1).jpg",
                        TenSanPham = "Giầy thể thao",
                    },
                    new SanPhamModel
                    {
                        Id = 4,
                        GiaSanPham = 45.1,
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.2 (2).jpg",
                        TenSanPham = "Bếp điện 2",
                    },
                    new SanPhamModel
                    {
                        Id = 5,
                        GiaSanPham = 45.1,
                        UrlImage = "/images/Danh-muc-sp/Rectangle 6.3 (2).jpg",
                        TenSanPham = "Bếp điện 3",
                    },

                }
            };

            listDanhMucSanPham.Add(danhMucSanPham1);

            var danhMucSP = listDanhMucSanPham.FirstOrDefault(x => x.Id == id);
            return View(danhMucSP);
        }
        public IActionResult IndexKhieuNai()
        {
            return View();
        }
        public IActionResult IndexChiTietDonHang()
        {
            return View();
        }
        public IActionResult IndexNhaCungCap()
        {
            return View();
        }
        public IActionResult IndexThemMoiNhaCungCap()
        {
            return View();
        }
        public IActionResult IndexQuanLyDonKyGui()
        {
            return View();
        }
        public IActionResult IndexThanhToan()
        {
            return View();
        }
        public IActionResult IndexTinTuc01()
        {
            return View();
        }
        public IActionResult IndexChiTietTin(int id)
        {
            var lstModel = new List<ChiTietTinModel>();
            var model1 = new ChiTietTinModel
            {
                Id = 1,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần,"+
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui,"+
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng,"+
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2= "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là"+
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage= "/images/thong-tin-them/01.svg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            var model2 = new ChiTietTinModel
            {
                Id = 2,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần," +
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui," +
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng," +
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2 = "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là" +
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage = "/images/thong-tin-them/02.svg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            var model3 = new ChiTietTinModel
            {
                Id = 3,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần," +
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui," +
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng," +
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2 = "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là" +
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage = "/images/thong-tin-them/03.jpg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            var model4 = new ChiTietTinModel
            {
                Id = 4,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần," +
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui," +
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng," +
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2 = "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là" +
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage = "/images/thong-tin-them/04.jpg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            var model5 = new ChiTietTinModel
            {
                Id = 5,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần," +
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui," +
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng," +
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2 = "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là" +
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage = "/images/thong-tin-them/05.jpg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            var model6 = new ChiTietTinModel
            {
                Id = 6,
                Content1 = "Khi bán hàng online tăng trưởng thần tốc nhờ... giao hàng hỏa tốc Không còn cảnh chờ đợi 3," +
                "4 ngày hoặc vài tuần," +
               " người tiêu dùng trực tuyến bây giờ có khi chỉ cần 2 đến 4 giờ là cầm được trong tay món hàng ưng ý.Người ta nói vui," +
               " đặt hàng online nhanh hơn nhiều so với việc sắp xếp được công việc để tới tận cửa hàng," +
                "hay vượt kẹt xe từ quận này sang quận kia để mua sắm.Tốc độ giao hàng “khủng” của các dịch vụ giao hàng hỏa tốc đang thực sự nhăm nhe giành thị trường của giao hàng truyền thống.",

                Content2 = "Phục vụ tận răng “cơn khát” chốt đơn hàng của thị trường thương mại điện tử Cuộc đua của các chủ shop" +
                " online không chỉ nằm ở việc kênh bán hàng “hot\" tới đâu, livestream sản phẩm bao nhiêu lượt “hóng”. Hơn nhau là" +
                "còn ở hiệu quả và tốc độ của việc chốt đơn, giao hàng. Nếu như trước đây, khi hàng được giao xong, chủ shop vẫn phải" +
                " chờ đợi đối soát mới nhận lại được tiền mua hàng, tỷ lệ trả hàng cao với nhiều lí do khó kiểm soát từ phía người mua," +
                " thì với các dịch vụ giao hàng hỏa tốc nội thành, các vấn đề này được giải quyết ở mức cao nhất, tốc độ “khủng” của kiểu giao hàng mới," +
                " tiền ứng (COD) được shipper giao ngay lập tức cho chủ shop. Điểm yếu của giao hàng hỏa tốc là giá thành tính theo khoảng cách," +
                " chi phí sẽ nhỉnh hơn khi áp dụng cho những đơn hàng có khoảng cách lớn. Tuy nhiên, tính toán, so sánh hiệu quả, điểm yếu này hoàn toàn" +
                " nhỏ hơn so với lợi ích chung cuộc mà chủ shop có được khi sử dụng dịch vụ giao hàng có tốc độ cao và phương thức giao hàng hiệu quả hơn." +
                " Chính vì vậy nên dù chỉ mới nổi lên từ 2 - 3 năm gần đây, giao hàng hỏa tốc nội thành đang rất được lòng các chủ shop online. Có thể nói, " +
                "ngành dịch vụ này đang thực sự giành lấy một phần miếng bánh thị trường sôi động. Cuộc đánh lớn của các tay chơi mạnh công nghệ Giữa rất nhiều " +
                "cái tên trong lĩnh vực giao nhận hàng hóa hỏa tốc, AhaMove nổi lên như một đơn vị hàng đầu. Chỉ sau vài năm ngắn ngủi, AhaMove tập hợp được lượng " +
                "tài xế đông đảo, chuyên nghiệp, là đối tác của những hệ thống kinh doanh bán lẻ năng động, được yêu thích nhất của giới trẻ, có thể kể đến như Lazada " +
                "và Sendo… Mới đây, AhaMove tuyên bố nâng cấp dịch vụ trong ngày, rút ngắn thời gian giao hàng từ 6 giờ xuống còn 4 giờ (với khoảng cách dưới 15km) " +
                "tại Hà Nội và TP.HCM với giá cước chỉ 22.000 đồng cho 10km đầu tiên. Dịch vụ giao hàng AhaMove Trong Ngày ra đời từ 1.4.2019 đã phục vụ tốt nhu cầu giao " +
                "hàng tức thời với thời gian ngắn hơn giao hàng trong ngày, qua ngày nhưng giá cước vẫn đảm bảo ở mức hấp dẫn. Điều quan trọng là dịch vụ này đã giúp xử lý " +
                "được được “nỗi đau” lớn nhất của các chủ shop online là giao hàng ngay với khoảng cách xa, giá dễ chịu, giảm đáng kể tỷ lệ hoàn hủy của khách đặt đơn. " +
                "Ông Phạm Hữu Ngôn - CEO AhaMove cho biết: \"Trong vòng 4 tháng qua,\" anh em công nghệ, phân tích và vận hành AhaMove đã ngày đêm nghiên cứu để cải thiện " +
                "chất lượng dịch vụ hiệu quả hơn.Sau khi xử lý một lượng lớn dữ liệu về chuyến giao hàng, bản đồ, thông tin về các khu vực tập trung nhiều đơn hàng; " +
                "nghiên cứu các mô hình giao hàng trên thế giới và khu vực chúng tôi đã cải thiện để nâng cấp thành công dịch vụ giao hàng trong ngày thành giao hàng 4H\". " +
                "Một đơn hàng của dịch vụ trong ngày (4H) giờ chỉ còn giao dưới 4 tiếng so với 6 tiếng trước đây, tuy nhiên giá không đổi và chỉ ngang giá với đơn hàng giao hàng trong ngày, " +
                "qua ngày. Ngoài ra, cải tiến về dịch vụ cũng giúp thu nhập tài xế tăng từ 22% - 31% trên cùng quãng đường so với trước kia. Giao hàng 2 giờ – 4 giờ nội thành đang " +
                "trở thành chuẩn mực tốc độ mới của cuộc chơi thương mại điện tử",

                Header = "KHI BÁN HÀNG ONLINE TĂNG TRƯỞNG THẦN TỐC NHỜ... GIAO HÀNG HỎA TỐC",

                UrlImage = "/images/thong-tin-them/06.jpg",

                ListTinMoi = new List<TinMoiModel> {
                    new TinMoiModel {
                        Header="HƯỚNG DẪN CÁCH ĐĂNG KÝ TÀI KHOẢN TRÊN TAOBAO BẰNG ĐIỆN THOẠI.",
                        Id=1,
                        Note="Để tạo tài khoản trên www.taobao.com, bạn vui lòng làm theo các bước hướng dẫn...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/01.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=2,
                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",
                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/02.svg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=3,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/03.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=4,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/04.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=5,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/05.jpg"
                    },
                    new TinMoiModel {
                        Header="Hướng dẫn cách đăng ký tài khoản trên Taobao bằng điện thoại",
                        Id=6,

                        Note="Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ. Không còn cảnh chờ đợi 3, 4 ngày " +
                        "hoặc vài tuần, người tiêu dùng trực tuyến bây giờ... Không còn cảnh chờ đợi 3, 4 ngày hoặc vài tuần, người tiêu dùng trực tuyến bây giờ...",

                        Time= System.DateTime.Now,
                        UrlImage="/images/thong-tin-them/06.jpg"
                    },
                }
            };
            lstModel.Add(model1);
            lstModel.Add(model2);
            lstModel.Add(model3);
            lstModel.Add(model4);
            lstModel.Add(model5);
            lstModel.Add(model6);
            var model = lstModel.FirstOrDefault(x => x.Id == id);
            
            return View(model);
        }
        public IActionResult IndexTinTuc2()
        {
            return View();
        }
        public IActionResult IndexLichSuGiaoDich()
        {
            return View();
        }
        public IActionResult IndexRutTien()
        {
            return View();
        }
        public IActionResult IndexTaoDonHang()
        {
            return View();
        }
        public IActionResult IndexUuDai()
        {
            return View();
        }
    }
}
