using Grpc.Core;
using System.ServiceModel;
using static BindingAccords.Bindings;

namespace BindingAccords
{
    [ServiceContract]
    public interface ICastingService
    {
        [OperationContract]
        ResponseStatus Cast(BundledScrolls request, ServerCallContext context);
    }
}
