using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrajectoryServer.lib.Helper;

namespace grpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server
            {
                Ports = { new ServerPort(Constant.Host, Constant.Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"server listening on port = {Constant.Port}");
            Console.WriteLine("Press any key to stop the server");
            Console.ReadKey();
            
            server.ShutdownAsync().Wait();
        }
    }
}
