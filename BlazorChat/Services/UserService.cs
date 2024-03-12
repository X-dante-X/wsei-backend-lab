
namespace BlazorChat.Services;

public class UserService : IUserService
{
    public Dictionary<string, string> Data = new Dictionary<string, string>();
    public void Add(string connectionId, string username)
    {
        Data.Add(connectionId, username);
    }

    public IEnumerable<(string ConnectionId, string Username)> GetAll()
    {
        return Data.Select(pair => (pair.Key, pair.Value));
    }

    public string GetConnectioIdByName(string username)
    {
        return Data.FirstOrDefault;
    }

    public void RemoveByName(string username)
    {
        Data.Remove(username);
    }
}
