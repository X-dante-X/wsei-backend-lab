namespace BlazorChat.Services;

public interface IUserService
{
    public void Add(string connectionId, string username);
    public void RemoveByName(string username);
    public string GetConnectioIdByName(string username);
    public IEnumerable<(string ConnectionId, string Username)> GetAll();


}
