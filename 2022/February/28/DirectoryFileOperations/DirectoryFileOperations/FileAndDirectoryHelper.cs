using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryFileOperations
{
    public static class FileAndDirectoryHelper
    {
        public static void CreateNewFolder(string path)
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(path);
        }

        public static void CreateFolderIfNotExist(string path)
        {
            bool directoryExist = Directory.Exists(path);

            if (!directoryExist)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(path);
            }
        }

        public static void DeleteFolder(string path)
        {
            Directory.Delete(path, true);
        }

        public static void MoveFolder(string source, string destination)
        {
            Directory.Move(source, destination);
        }

        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public static void CreateFile(string path)
        {
            if (!FileExists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
                /*
                File.Create ilə və ya hər hansısa bir şəkildə bir faylı sistemlə istifadə etdiyiniz zaman mütləq onu FileStream kimi alıb
                sonra close etməlisiniz. Məsələn File.Create() dediyiniz zaman fayl yaranacaq ancaq siz onu rename edə və ya aça bilməyəcəksiniz.
                fileStream.Close() dediyiniz anda isə artıq fayl istifadədə olmayacaq və sərbəst buraxılacaq. Close methodu dedikdə faylı açıb bağlamaqdan
                söhbət getmir. Faylın həbs edilib sərbəst buraxılmasından söhbət gedir.
                */
            }
            else
            {
                System.Console.WriteLine(path + " fayli artiq movcuddur!");
            }
        }

        public static void DeleteFile(string path)
        {
            if (FileExists(path))
                File.Delete(path);
            else
                Console.WriteLine(path + " fayli movcud deyil!");
        }

        public static void MoveFile(string from, string to)
        {
            if (FileExists(from))
                File.Move(from, to);
            else
                Console.WriteLine(from + " fayli movcud deyil!");
        }

        public static void CopyFile(string from, string to)
        {
            if (FileExists(from))
                File.Copy(from, to);
            else
                Console.WriteLine(from + " fayli movcud deyil!");
        }

        public static void AppendTextToFile(string path, string textToAdd)
        {
            File.AppendAllText(path, textToAdd);
            /*
             Birinci faylin content'ini text olaraq goturur sonra elave olunacaq texti iki stringi birlesdirirmis kimi elave edir ("text" + "text")
             */
        }

        public static string ReadFileContent(string path)
        {
            string fileContent = File.ReadAllText(path);
            return fileContent;
        }

        public static void AppendMultipnleTextsToFile(string path, List<string> texts)
        {
            File.AppendAllLines(path, texts);
            /*
             Setir setir elave edir. Axirinci list memberinden sonra /r/n ozu atir.
             */
        }

        public static string[] ReadFileContentByLine(string path)
        {
            string[] contents = File.ReadAllLines(path);
            return contents;
            /*
             Faylin icindeki contenti her line olaraq bolur. Meselen 5 setir yazi varsa her setiri bir array elementi olaraq elave edir.
             */
        }
    }
}
