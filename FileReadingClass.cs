using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_8___Exception_Handling
{
    internal class FileReadingClass
    {
        //FIELDS

        //PROPERTIES
        public IEnumerable<string> Content { get; set; }
        //CONSTRUCTORS
        public FileReadingClass(IEnumerable<string> content)
        {
            Content = content;

        }

        // ======================  METHODS ====================  
        public IEnumerable<string> FileReadLines(string path)
        {
            try
            {
                var content = File.ReadLines($"{path}");
                return content;

            }
            catch (System.IO.FileNotFoundException ex) { Console.WriteLine($"error: {ex.Message}"); }
            catch (DirectoryNotFoundException ex) { Console.WriteLine($"error: {ex.Message}"); }
            catch (ArgumentException ex) { Console.WriteLine($"error: {ex.Message}"); }
            catch (UnauthorizedAccessException ex) { Console.WriteLine($"error: {ex.Message}"); }
            catch (IOException ex) { Console.WriteLine($"error: {ex.Message}"); }


            //per finally needeti return

            return new List<string>();


        }

        public IEnumerable<string> FileReadLinesOK(string path) => File.ReadLines($"{path}");

        //

        // ================== END OF METHODS ==================

    }
}
