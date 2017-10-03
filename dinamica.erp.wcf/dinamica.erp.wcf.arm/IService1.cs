using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dinamica.erp.wcf.arm
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        ArticuloDto GetDataUsingDataContract(ArticuloDto composite);

        [OperationContract]
        IQueryable<ArticuloDto> GetArticulos(Expression<Func<Artículos, bool>> where);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "dinamica.erp.wcf.arm.ContractType".
    [DataContract]
    public class ArticuloDto
    {
        string titulo = "Hello ";

        [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
    }
}
