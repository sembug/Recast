using System.Threading.Tasks;
using Recast.WebApp.Models.Entities;

namespace Recast.WebApp.Models
{
    public interface IFeedsService
    {
        Task<Feed> Get(string userName, string feedName);
        bool Insert(Feed feed);
    }
}