using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrajectoryServer;
using TrajectoryServer.lib.Helper;

namespace TrajectoryServer.lib.GrpcServerImpl
{
    public class ServerServices
    {
        public static void RunServer()
        {
            var server = new Server
            {
                Services = { DroneService.BindService(new ResponseImpl())},
                Ports = { new ServerPort(Environment.GetEnvironmentVariable("Host"), Int32.Parse(Environment.GetEnvironmentVariable("Port")), ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"server listening on port = {Environment.GetEnvironmentVariable("Port")}");
            Console.WriteLine("Press any key to stop the server");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}