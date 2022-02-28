using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fileContent = FileAndDirectoryHelper.ReadFileContent(@"C:\LessonTests\AppendAllText_method.txt");
            //FileAndDirectoryHelper.AppendTextToFile(@"C:\LessonTests\AppendAllText_method.txt", "Suleyman");

            //var names = new List<string>()
            //{
            //    "Suleyman",
            //    "Teymur",
            //    "Cavid"
            //};
            //FileAndDirectoryHelper.AppendMultipnleTextsToFile(@"C:\LessonTests\AppendAllText_method.txt", names);

            string[] lines = FileAndDirectoryHelper.ReadFileContentByLine(@"C:\LessonTests\AppendAllText_method.txt");
        }
    }
}
