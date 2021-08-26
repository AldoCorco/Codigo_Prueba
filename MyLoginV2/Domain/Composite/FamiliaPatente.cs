using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Composite
{
    public abstract class FamiliaPatente
    {
        public FamiliaPatente()
        {

        }

        /// <param name="component"></param>
		public abstract void Add(FamiliaPatente component);

        /// 
        /// <param name="component"></param>
        public abstract void Remove(FamiliaPatente component);

        public abstract int ChildrenCount();

    }
}
