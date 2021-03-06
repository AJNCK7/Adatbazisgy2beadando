﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagySzabolcsMátéAdatgy2bead
{
    public class Animals
    {
        #region propertyik

        private int animalownerId;
        public int AnimalownerId
        {
            set
            {
                animalownerId = value;
            }
            get
            {
                return animalownerId;
            }
        }

        private int id;
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        private string animalName;
        public string AnimalName
        {
             set
            {
                if (value == null)
                {
                    throw new Exception("Az állat neve nem lehet null");
                }
                if (value.Length <= 0)
                {
                    throw new Exception("Az állat neve legalább 1 karakter hosszúnak kell lenni");
                }
                animalName = value;
            }

            get
            {
                return animalName;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A születési dátum nem lehet null értékű");
                }
                birthDate = value;
            }

            get
            {
                return birthDate;
            }
        }

        private string neme;
        public string Neme
        {
            set
            {
                neme = value;
            }
            get
            {
                return neme;
            }
        }

        private byte neutered;
        public byte Neutered
        {
            set
            {
                if (neutered == 1)
                {
                    throw new Exception("Az ivartalanított nem lehet újra nemző képes");
                }
                neutered = value;
            }
            get
            {
                return neutered;
            }
        }

    }
    #endregion
}
