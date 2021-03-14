using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.DAL
{
    public class DataContextFactory
    {
        private static sistemaDataContext dataContext;//Conexao
        public static sistemaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;
            }
        }
    }
}
