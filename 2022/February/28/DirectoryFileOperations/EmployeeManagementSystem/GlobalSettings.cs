namespace EmployeeManagementSystem
{
    public static class GlobalSettings
    {
        public const string WAITING_UPLOADS_PATH = @"C:/AppFiles/WaitingUpload/";
        public const string IMAGE_PATH = @"C:/AppFiles/Images/";
        public const string CV_PATH = @"C:/AppFiles/CVs/";
        public const string LOGS_PATH = @"C:/AppFiles/Logs/";
        public static string LastUploadedCv { get; set; }
        public static string LastUploadedImage { get; set; }
    }
}
