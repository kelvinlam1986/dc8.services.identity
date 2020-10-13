using Convey.CQRS.Events;
using System.Threading.Tasks;

namespace Dc8.Services.Identity.Application.Services
{
    public interface IMessageBroker
    {
        Task PublishAsync(params IEvent[] events);
    }
}
