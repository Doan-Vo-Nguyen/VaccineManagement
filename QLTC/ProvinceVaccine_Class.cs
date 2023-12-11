using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC
{
    public class Province
    {
        public string? Name { get; set; }
        public List<VaccineCenter>? VaccineCenters { get; set; }
    }

    public class VaccineCenter
    {
        public string? Name { get; set; }
        public string? Province { get; set; }
    }
    public class ProvinceDataManager
        {
            public List<Province> GetProvinces()
            {
                List<Province> provinces = new List<Province>();
                    string sql = "SELECT DISTINCT province FROM Centers";
                    using (SqlCommand command = new SqlCommand(sql, DataAccess.conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string? provinceName = reader["province"].ToString();
                            provinces.Add(new Province { Name = provinceName });
                        }
                }

                return provinces;
            }

            public List<VaccineCenter> GetVaccineCentersByProvince(string provinceName)
            {
                List<VaccineCenter> vaccineCenters = new List<VaccineCenter>();
                {

                    string sql = "SELECT DISTINCT center_name FROM Centers WHERE province = @Province"; 

                    using (SqlCommand command = new SqlCommand(sql, DataAccess.conn))
                    {
                        command.Parameters.AddWithValue("@Province", provinceName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string? centerName = reader["center_name"].ToString();
                                vaccineCenters.Add(new VaccineCenter {Name = centerName, Province = provinceName });
                            }
                        }
                    }
                }

                return vaccineCenters;
            }
        }
    }
