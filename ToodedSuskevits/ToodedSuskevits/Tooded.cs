using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToodedSuskevits
{
    internal class Tooded
    {
        public int Id{ get; set; }
        public string Toodenimetus { get; set; }

        public int Kogus { get; set; }
        public float Hind{ get; set; }
        public string Pilte { get; set; }
        public IEnumerable<Kategooria> Kategooria { get; set; }

    }
    public class Kategooria
    {
        public int Id { get; set; }
        public string Kategooria_nimetus { get; set; }

        public string Kitjeldus { get; set; }
    }
}
