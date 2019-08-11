using System.Threading.Tasks;

namespace dnSpyTest
{
    public class AsyncTest
    {
        public static async Task<T> RequestResultAsync<T>()
        {
            return await Task.Run(async delegate {
                return default(T);
            });
        }
    }
}
