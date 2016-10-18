using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPICore1.Helpers
{
    public class Serializer
    {
        // Convert an object to a byte array
        internal string ObjectToString(Object obj)
        {
            if (obj == null)
                return null;
            return JsonConvert.SerializeObject(obj);
        }
        internal byte[] ObjectToByte(Object obj)
        {
            if (obj == null)
                return null;
            return System.Text.Encoding.UTF8.GetBytes( JsonConvert.SerializeObject(obj));
        }

        // Convert a byte array to an Object
        internal UserProfile StringToObject(string str)
        {           
            return JsonConvert.DeserializeObject<UserProfile>(str);
        }
        internal UserProfile ByteToObject(byte[] obj)
        {
            return JsonConvert.DeserializeObject<UserProfile>(System.Text.Encoding.UTF8.GetString(obj));
        }
    }
}
