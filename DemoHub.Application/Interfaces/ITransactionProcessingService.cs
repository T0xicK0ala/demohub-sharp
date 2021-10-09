
using System.Threading.Tasks;

namespace DemoHub.Application.Interfaces
{
    public interface ITransactionProcessingService
    {
        //Transaction transaction { get; }
    }
    //maybe pipeline is suitable
    public interface IPipelineStep<INPUT, OUTPUT>
    {
        OUTPUT Process(INPUT input);
    }
}
