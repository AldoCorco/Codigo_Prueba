using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Composite
{
    public class Familia : FamiliaPatente
    {
        private List<FamiliaPatente> listaFamiliaPatente = new List<FamiliaPatente>();

        public Familia(FamiliaPatente familiaPatente)
        {
            Add(familiaPatente);
        }

        /// <param name="component"></param>
		public override void Add(FamiliaPatente component)
        {

            listaFamiliaPatente.Add(component);

        }

        public override int ChildrenCount()
        {
            return listaFamiliaPatente.Count;
        }

        /// <param name="component"></param>
        public override void Remove(FamiliaPatente component)
        {

            
            listaFamiliaPatente.Remove(component);

        }

        public List<FamiliaPatente> Permisos
        {
            get
            {
                return this.listaFamiliaPatente;
            }
        }
    }
}
