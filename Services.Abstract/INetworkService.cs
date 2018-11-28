using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface INetworkService
    {
        NetworkStream GetData();
        void SendData(List<FileInfo> files);
    }
}
