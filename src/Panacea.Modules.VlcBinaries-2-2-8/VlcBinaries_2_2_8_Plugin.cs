using Panacea.Modularity.VlcMediaPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.VlcBinaries_2_2_8
{
    public class VlcBinaries_2_2_8_Plugin : IVlcBinariesPlugin
    {
        public Task BeginInit()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            
        }

        public Task EndInit()
        {
            return Task.CompletedTask;
        }

        public string GetBinariesPath()
        {
            string path;
            switch (IntPtr.Size)
            {
                case 4:
                    path = "x86";
                    break;
                case 8:
                    path = "x64";
                    break;
                default:
                    throw new Exception("Unsuported architecture");
            }
            
            return Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Vlc",
                path);
        }

        public string GetVersion() => "2.2.8";

        public Task Shutdown()
        {
            return Task.CompletedTask;
        }
    }
}
