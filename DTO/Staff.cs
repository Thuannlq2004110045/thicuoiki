using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private string id;
        private string tenNV;
        private string tuoi;
        private string sodt;
        private string password;

        public Staff()
        { }
        public Staff(string id, string tenNV, String tuoi, string sodt, string password)
        {
            this.id = id;
            this.TenNV = tenNV;
            this.Tuoi = tuoi;
            this.Sodt = sodt;
            this.Password = password;
        }

        public string TenNV { get => tenNV; set => tenNV = value; }
        public String Tuoi { get => tuoi; set => tuoi = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Password { get => password; set => password = value; }
        public string Id { get => id; }
    }
}
