using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio
{
    internal class Cerchio
    {
        public float Raggio { get; set; }

        public Cerchio( float raggio)
        {
            this.Raggio = raggio;
        }

        public float Area()
        {
            return (float)(Math.PI* Raggio*Raggio);
        }

        public float Perimetro()
        {
            return (float)(2 * Raggio * Math.PI);
        }
    }
}
