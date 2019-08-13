using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetworkToJSon
{
    public static class NeuralNetworkDisplayer
    {
        public static string ShowNeuralNetwork(VisualizeNeuralNetworkInformations networkInfos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            string json = JsonConvert.SerializeObject(networkInfos, settings);
            string url = GetExecutingAssemblyPath();
            url = url + "/Resources/index.html";
            WriteJsonToJS(json);
            System.Diagnostics.Process.Start(url); // OR REPLACE JAVASCRIPT FILE
            return json;
        }

        private static void WriteJsonToJS(string json)
        {
            string buildFolder = GetExecutingAssemblyPath();
            File.WriteAllText(buildFolder + "/Resources/data.js", $"var _dataString = '{json}'");
        }

        private static string GetExecutingAssemblyPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        private static string GetSystemDefaultBrowser()
        {
            string name = string.Empty;
            RegistryKey regKey = null;

            try
            {
                //set the registry key we want to open
                regKey = Registry.ClassesRoot.OpenSubKey("HTTP\\shell\\open\\command", false);

                //get rid of the enclosing quotes
                name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

                //check to see if the value ends with .exe (this way we can remove any command line arguments)
                if (!name.EndsWith("exe"))
                    //get rid of all command line arguments (anything after the .exe must go)
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            }
            catch (Exception ex)
            {
                name = string.Format("ERROR: An exception of type: {0} occurred in method: {1} in the following module: {2}", ex.GetType(), ex.TargetSite, "");
            }
            finally
            {
                //check and see if the key is still open, if so
                //then close it
                if (regKey != null)
                    regKey.Close();
            }
            //return the value
            return name;

        }

   

    }
}
