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
            Server server = null;
            try
            {
                server = new Server
                {
                    Services = { DroneService.BindService(new ResponseImpl()) },
                    Ports = { new ServerPort(Environment.GetEnvironmentVariable("Host"), Int32.Parse(Environment.GetEnvironmentVariable("Port")), ServerCredentials.Insecure) }
                };

                server.Start();

                Console.WriteLine($"Server listening on port = {Environment.GetEnvironmentVariable("Port")}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                server.ShutdownAsync().Wait();
                Console.WriteLine($"An error occur, Server is shutdown with an error of {e.ToString()}");
            }
        }
    }
}