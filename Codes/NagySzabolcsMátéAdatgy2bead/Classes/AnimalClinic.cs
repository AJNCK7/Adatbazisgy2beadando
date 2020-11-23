using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagySzabolcsMátéAdatgy2bead
{
    class AnimalClinic
    {
        #region Mezők és propertyk

        private string name;
        public string Name
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Az érték nem lehet null");
                }
                if (value.Length == 0)
                {
                    throw new Exception("A név nem lehet 0 karakter hosszúságú");
                }
                name = value;
            }
            get
            {
                return name;
            }
        }
        #endregion
    }
}
