using WebAPiWithDapper.Entities;

namespace WebAPiWithDapper.IRepo
{
    public interface IUsersRepo
    {
        public Task<IEnumerable<Users1>> GetUserData(string userId, string password);
    }
}
