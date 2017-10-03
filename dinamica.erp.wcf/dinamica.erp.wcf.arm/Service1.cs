using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dinamica.erp.wcf.arm
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public ArticuloDto GetDataUsingDataContract(ArticuloDto composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            return composite;
        }

        public IQueryable<ArticuloDto> GetArticulos(Expression<Func<Artículos, bool>> where) //Por que artículos acá? (tabla Artículos de EntityFX)
        {
            return (new ElediEntities()).Artículos.Where(where).Select(x => new ArticuloDto { Titulo = x.Título });
    }
}
}
