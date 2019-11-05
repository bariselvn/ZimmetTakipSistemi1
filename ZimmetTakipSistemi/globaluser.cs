using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmetTakipSistemi
{
    public static class globaluser
    {
        private static Kullanıcı kulıd;
        public static Kullanıcı Kulıd
        {
            get { return kulıd; }
            set { kulıd = value; }
        }
    }
}
