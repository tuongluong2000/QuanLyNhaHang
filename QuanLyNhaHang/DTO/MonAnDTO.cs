using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaHang.DTO
{
    class MonAnDTO
    {
        private int id;
        private string tenmonan;
        private string motamonan;
        private int gia;

        public int Id { get => id; set => id = value; }
        public string Tenmonan { get => tenmonan; set => tenmonan = value; }
        public string Motamonan { get => motamonan; set => motamonan = value; }
        public int Gia { get => gia; set => gia = value; }


        public MonAnDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenmonan = row["tenmonan"].ToString();
            this.Motamonan = row["motamonan"].ToString();
            this.Gia = (int)row["gia"];
        }


        public MonAnDTO()
        {
            this.Id = 0;
            this.Tenmonan = "";
            this.Motamonan = "";
            this.Gia = 0;
        }
    

    }
}
