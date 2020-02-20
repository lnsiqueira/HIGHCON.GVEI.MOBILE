using System.Threading.Tasks;

namespace HIGHCON.GVEI.MOBILE.Interfaces
{
    public interface IAsyncInitialization
    {
        Task Initialization { get; }
    }
}