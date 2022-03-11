using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kayit
    {
        public Guid id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string adres { get; set; }
        public string emailAdres { get; set; }
        public string webSite { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return $"{ad} {soyad}";
        }
    }
}
