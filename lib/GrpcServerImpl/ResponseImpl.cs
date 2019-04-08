using System.Threading.Tasks;
using Grpc.Core;
using TrajectoryServer;
using static TrajectoryServer.DroneService;

namespace TrajectoryServer.lib.GrpcServerImpl
{
    public class ResponseImpl : DroneServiceBase
    {
        // Implement here other Request for the drone request
        public override Task<Response> SendRequest(Request request, ServerCallContext context)
        {
            return Task.FromResult(new Response { Message = "Hello World" + request.Name });
        }
    }
}