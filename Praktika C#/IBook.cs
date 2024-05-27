using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_
{
    public interface IBook
    {
        public string Title {  get; set; }
        public string Autor {  get; set; }
        public string Genre {  get; set; }
        public double Price {  get; set; }
        public int PublicationYear {  get; set; }
    }
}
