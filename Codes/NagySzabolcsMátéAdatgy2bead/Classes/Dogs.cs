using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagySzabolcsMátéAdatgy2bead
{
    class Dogs
    {
        public Dogs(int AnimalownerId, int ID, string AnimalName, DateTime BirthDate, AnimalGender Neme, byte Neutered, string Specie, byte IsChipped, string ChipID)
            :base(AnimalownerId, ID, AnimalName, BirthDate, Neme, Neutered)
        {
            this.Specie = Specie;
            this.IsChipped = IsChipped;
            this.ChipID = ChipID;
        }

        private int dogid;
        public int Dogid
        {
            get { return dogid; }
            set { dogid = value; }
        }
        private string specie;
        public string Specie
        {
            private set
            {
                if (value == null)
                {
                    throw new Exception("A Fajta neve nem lehet null");
                }
                if (value.Length <= 0)
                {
                    throw new Exception("A fajta neve legalább 1 karakter hosszúnak kell lenni");
                }
                if (value.Length > 100)
                {
                    throw new Exception("Maximum 100 karakteres lehet a fajtája");
                }
                specie = value;
            }

            get
            {
                return specie;
            }
        }

        private byte isChipped;
        public byte IsChipped
        {
            set
            {
                if (isChipped == 1)
                {
                    throw new Exception("Egyszer chipelhető egy kutya");
                }
                if (isChipped >= 1)
                {
                    throw new Exception("0 és 1 értékek adható csak meg");
                }
                isChipped = value;
            }
            get
            {
                return isChipped;
            }
        }

        public string betu = "qwertzuiopőúasdfghjkléáűíyxcvbnmöüó";
        private string chipID;
        public string ChipID
        {
            set
            {
                if (isChipped == 0)
                {
                    throw new Exception("Ha nincs chip a kutyában, nem lehet azonosítója");
                }
                if (value != null || value.Length != 15)
                {
                    throw new Exception("Hamis chip érték formátum");
                }
                if (value.ToLower().Contains(betu))
                {
                    throw new Exception("Chip azonosítója nem tartalmazhat betűt");
                }
                chipID = value;
            }
            get
            {
                return chipID;
            }
        }


        public override string ToString()
        {
            return string.Format(
                "Dog ID: {0} \n" +
                "Dog specie: {1}\n" +
                "Chipped: {2}\n" +
                "ChipId: {3}\n",
                this.Dogid,
                this.Specie,
                this.IsChipped == 0 ? "false" : "true",
                this.ChipID);
        }
    }
}
