using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC
{
    public class Province
    {
        public string Name { get; set; }
        public List<VaccineCenter> VaccineCenters { get; set; }
    }

    public class VaccineCenter
    {
        public string Name { get; set; }
    }

    public class ProvinceDataManager
    {
        private List<Province> provinces;

        public ProvinceDataManager()
        {
            provinces = new List<Province>
            {
                new Province
                {
                    Name = "Bình Định",
                    VaccineCenters = new List<VaccineCenter>
                    {
                    new VaccineCenter { Name = "VFA An Nhơn"},
                    new VaccineCenter { Name = "VFA Quy Nhơn"}
                    }
                },
                new Province
                {
                    Name = "Hồ Chí Minh",
                    VaccineCenters = new List<VaccineCenter>
                    {
                        new VaccineCenter { Name = "VFA Tân Bình"},
                        new VaccineCenter { Name = "VFA Tân Phú"},
                        new VaccineCenter { Name = "VFA Bình Thạnh"},
                        new VaccineCenter { Name = "VFA Gò Vấp"},
                        new VaccineCenter { Name = "VFA Bình Thạnh"},
                        new VaccineCenter { Name = "VFA Quận 10"},
                        new VaccineCenter { Name = "VFA Cần Giờ"},
                        new VaccineCenter { Name = "VFA Quận 1"},
                        new VaccineCenter { Name = "VFA Thủ Đức"},
                        new VaccineCenter { Name = "VFA Quận 6"},
                        new VaccineCenter { Name = "VFA Quận 12"},
                        new VaccineCenter { Name = "VFA Quận 3"},
                    }
                },
                new Province
                {
                    Name = "Hà Nội",
                    VaccineCenters = new List<VaccineCenter>
                    {
                        new VaccineCenter { Name = "VFA Hai Bà Trưng"},
                        new VaccineCenter { Name = "VFA Hoàn Kiếm"},
                        new VaccineCenter { Name = "VFA Hoàng Mai"},
                        new VaccineCenter { Name = "VFA Gò Vấp"},
                        new VaccineCenter { Name = "VFA Tây Hồ"},
                        new VaccineCenter { Name = "VFA Nam Từ Liêm"},
                        new VaccineCenter { Name = "VFA Thanh Xuân"},
                        new VaccineCenter { Name = "VFA Mê Linh"},
                        new VaccineCenter { Name = "VFA Gia Lâm"},
                        new VaccineCenter { Name = "VFA Ba Vì"},
                        new VaccineCenter { Name = "VFA Thanh Oai"},
                        new VaccineCenter { Name = "VFA Sơn Tây"},
                    }
                 },

                 new Province
                {
                    Name = "Đà Nẵng",
                    VaccineCenters = new List<VaccineCenter>
                    {
                        new VaccineCenter { Name = "VFA Hải Chây"},
                        new VaccineCenter { Name = "VFA Cẩm Lệ"},
                        new VaccineCenter { Name = "VFA Hoà Vang"},
                        new VaccineCenter { Name = "VFA Hoàng Sa"},
                        new VaccineCenter { Name = "VFA Liên Chiểu"},
                        new VaccineCenter { Name = "VFA Sơn Trà"},

                    }
                },
                new Province
                {
                    Name = "Nha Trang",
                    VaccineCenters = new List<VaccineCenter>
                    {
                        new VaccineCenter { Name = "VFA Nha Trang"},
                        new VaccineCenter { Name = "VFA Cam Ranh"},
                        new VaccineCenter { Name = "VFA Ninh Hoà"},
                        new VaccineCenter { Name = "VFA Vạn Ninh"},
                        new VaccineCenter { Name = "VFA Diên Khánh"},
                        new VaccineCenter { Name = "VFA Khánh Vĩnh"},

                    }
                }
            };
        }

        public List<Province> GetProvinces()
        {
            return provinces;
        }

        public List<VaccineCenter> GetVaccineCentersByProvince(string provinceName)
        {
            Province selectedProvince = provinces.Find(p => p.Name == provinceName);
            return selectedProvince?.VaccineCenters ?? new List<VaccineCenter>();
        }
    }

    
}
