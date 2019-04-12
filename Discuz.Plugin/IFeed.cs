namespace Discuz.Plugin
{
    public interface IFeed
    {
        string GetFeed(int ttl, int uid);

        string GetFeed(int ttl);
    }
}
