using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace My
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tc = new TcpChannel(8010);
            ChannelServices.RegisterChannel(tc, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MyBl.MyBlCLass), "RemoteClass", WellKnownObjectMode.Singleton);
            Console.Write("************** Server ready******************");
            Console.Read();
        }
    }
}
