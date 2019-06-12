using System.Collections.Generic;
using System.Threading.Tasks;
using Recast.WebApp.Models.Entities;

namespace Recast.WebApp.Models
{
    public interface IPostsService
    {
        Task Delete(string userName, string feedName, string title);
        Task<Post> Get(string userName, string feedName, string title);
        Task<IEnumerable<Post>> GetForFeed(Feed feed);
        bool Insert(Post post);
        Task Update(Post post);
    }
}