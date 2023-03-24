using ProtoBuf.Grpc;
using System.ServiceModel;
using System.Threading.Tasks;
using static BindingAccords.Bindings;

namespace BindingAccords
{
    [ServiceContract]
    public interface ICastingService
    {
        [OperationContract]
        Task<ResponseStatus> Cast(BundledScrolls request, CallContext context = default);
    }
}
