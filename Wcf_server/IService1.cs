using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IService1CallBack))]
    public interface IService1
    {
        [OperationContract]
        ServerUser Connect(string name);

        [OperationContract]
        bool UpdateData(string name, Bitmap bitmap);
    }

    public interface IService1CallBack
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallback(string msg);
    }

}
