using _06_SOLID_SRP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SOLID_SRP.Helpers
{
    internal static class ContactListHandleFile
    {
        public static void SaveToJsonFile(List<ContactModel> list, string filePath)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(list));
        }
    }
}
