using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Composite
{
    public class Patente : FamiliaPatente
    {
        public Patente()
        {

        }

        public override int ChildrenCount()
        {
            return 0;
        }

        public override void Add(FamiliaPatente component)
        {
            
            throw new Exception("No puedo agregar elementos. Soy primitivo.");
        }

        public override void Remove(FamiliaPatente component)
        {
            
            throw new Exception("No puedo quitar elementos. Soy primitivo.");
        }

    }
}
