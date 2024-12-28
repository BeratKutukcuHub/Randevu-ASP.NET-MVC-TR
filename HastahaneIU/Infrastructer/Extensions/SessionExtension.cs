

using System.Text.Json;

namespace HastahaneIU.Extensions
{
    public static class SessionExtension
        
    {
        public static void SetJson(this ISession session , string key , object value)
        {
            session.SetString(key , JsonSerializer.Serialize(value));
        }
        public static void SetJson<T>(this ISession session , string key , T value)
        {
            session.SetString(key , JsonSerializer.Serialize<T>(value));
        }

        public static T? GetJson<T>(this ISession session , string key)
        {
            var controllersession = session.GetString(key);
            return controllersession is null ? default(T) : JsonSerializer.Deserialize<T>(controllersession);
        }
    }
    
}