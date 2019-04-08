using System;
using TrajectoryServer.lib.GrpcServerImpl;

namespace grpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerServices.RunServer();
        }
    }
}
