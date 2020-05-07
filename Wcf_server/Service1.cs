using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Drawing.Imaging;

namespace Wcf_server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        public ServerUser Connect(string name)
        {

            ServerUser user = new ServerUser();

            return user;
        }

        public bool UpdateData(string name, Bitmap bitmap)
        {
            FileStream file = new FileStream(@".\testDB.txt", FileMode.OpenOrCreate, FileAccess.Write);

            
            bitmap.Save(file, ImageFormat.Png);

            //TODO: созранение в еткстовй файл инфу 

            file.Close();

            return true;
        }
    }
}
