﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
 public   class Lacze
    {
        protected int identyfikatorKrawedzi;
        protected int wezelpierwszy;
        protected int wezeldrugi;
        protected float waga;

        public int idKrawedzi
        {
            get { return identyfikatorKrawedzi; }
            set { identyfikatorKrawedzi = value; }
        }

        public int wezel1
        {
            get { return wezelpierwszy; }
            set { wezelpierwszy = value; }
        }

        public int wezel2
        {
            get { return wezeldrugi; }
            set { wezeldrugi = value; }
        }
        public float Waga
        {
            get { return waga; }
            set { waga = value; }
        }
    }
}
