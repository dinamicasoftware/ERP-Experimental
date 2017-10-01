using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamica.erp.wcfclient
{
    class Program
    {
        static void Main(string[] args)
        {
            ERPService.ERPContext context = new ERPService.ERPContext(new Uri("http://localhost:1749/Erp.svc"));
            var clients = context.ClientsDao.Where(cli => cli.CodigoPostal == "T5402DCB").Take(100).ToList();
            var clients2 = context.ClientsDao.Take(100).ToList();

        }
    }
}
