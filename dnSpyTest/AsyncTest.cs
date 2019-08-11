using System;
using System.Threading.Tasks;

namespace dnSpyTest
{
    public class AsyncTest
    {
        private static async Task<T> RequestResultAsync<T>()
        {
            return await Task.Run(async delegate {
                return default(T);
            });
        }
    }
}
