using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MonsterNotebook.ControlCenter.Helpers
{
    public static class Json
    {
        public static async Task<T> ToObjectAsync<T>(string value)
        {
            try
            {
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(value));
            }
            catch
            {
                return default(T);
            }
        }

        public static async Task<string> StringifyAsync(object value)
        {
            return await Task.Run(() => JsonConvert.SerializeObject(value));
        }
    }
}
