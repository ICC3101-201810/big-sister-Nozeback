using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabPOO;
delegate Product CheckCompra(Product p);

namespace LabPOO
{
    class hermana_mayor
    {
        List<Product> Receta;
        public hermana_mayor(List<Product> Receta) {
            this.Receta = Receta;
        }
        public bool Chequeo(Product p)
        {
            foreach (Product f in Receta)
            {
                if (p.Name == f.Name)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
