using dotenv.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data.Data
{
    public static class EnvConfig
    {
        static EnvConfig()
        {
            DotEnv.Load();
        }

        public static string GetEnvVariable(string key)
        {
            return Environment.GetEnvironmentVariable(key) ?? throw new Exception($"Environment variable {key} not found");
        }
    }
}
