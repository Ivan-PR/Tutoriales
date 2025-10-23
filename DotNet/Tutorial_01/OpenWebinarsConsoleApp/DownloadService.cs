using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenWebinarsConsoleApp
{
    public class DownloadService
    {
        public Byte[] Download(string songName)
        {
            Thread.Sleep(1000);
            return new byte[] { };
        }

        public Task<byte[]> DownloadAsync(string songName)
        {
            Thread.Sleep(1000);
            return Task.FromResult(new byte[] { });
        }
    }
}