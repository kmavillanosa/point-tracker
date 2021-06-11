using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Repositories
{
    public class StateSaver<T> : IDisposable
        where T : class
    {
        public string SavePath { get; }
        public T Instance { get; }

        public StateSaver(string savePath, T instance)
        {
            if (!File.Exists(savePath))
                File.WriteAllText(savePath,null);

            SavePath = savePath;
            Instance = instance;
        }

        public void Dispose()
        {
            File.WriteAllText(SavePath, JsonConvert.SerializeObject(Instance));
        }
    }
}
