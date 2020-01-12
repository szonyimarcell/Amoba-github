using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amőba
{
    class Gombtarolo : IComparable<Gombtarolo>
    {
        public bool enable { get; set; }
        public string xo { get; set; }
        public byte bajt { get; set; }

        public int CompareTo(Gombtarolo other) => throw new NotImplementedException();
    }
}
