using System;
using System.Drawing;
using System.ServiceModel;

namespace Wcf_server
{
    public class ServerUser
    {
        public string Name { get; set; }
        
        public string Dieta { get; set; }

        public string Training { get; set; }

        public DateTime DateTime { get; set; }

        public Bitmap Bitmap { get; set; }



        public OperationContext OperationContext { get; set; }
    }
}
