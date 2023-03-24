using Grpc.Core;
using System.ServiceModel;

namespace BindingAccords
{
    [ServiceContract]
    public interface ICastingService
    {
        [OperationContract]
        Task<ResponseStatus> Cast(Bindings request, ServerCallContext context);
    }
}
