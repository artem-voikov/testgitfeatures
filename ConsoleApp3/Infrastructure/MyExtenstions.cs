using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace ConsoleApp3.Infrastructure
{
    public static class MyExtenstions
    {
        public static string ToJsonDebug(this object obj)
        {
            var sb = new StringBuilder();
            try
            {
                var sr = new JsonSerializer();
                sr.NullValueHandling = NullValueHandling.Ignore;
                sr.ObjectCreationHandling = ObjectCreationHandling.Auto;
                sr.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                sr.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                sr.StringEscapeHandling = StringEscapeHandling.EscapeHtml;

                
                using var jtw = new JsonTextWriter(new StringWriter(sb));
                sr.Serialize(jtw, obj);
            }
            catch (Exception ex)
            {

                return $"{{ \"Error\":\"{ex.Message}\"}}";
            }

            return sb.ToString();
        }
    }
}
