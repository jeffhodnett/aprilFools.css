using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace aprilFools.css
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: Should write a copy from the root directory the fresh april fools css

            // Get common.css path
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var targetPath = string.Format("{0}\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\User StyleSheets\\Custom.css", userPath);

            // Clear text
            File.WriteAllText(targetPath, string.Empty);
            
            // Get css file
            const string cssFile = "aprilFools.css";
            string css = string.Empty;
            using (var reader = new StreamReader(cssFile))
            {
                css += reader.ReadToEnd();
            }

            // Inject css
            File.WriteAllText(targetPath, css);
        }
    }
}
