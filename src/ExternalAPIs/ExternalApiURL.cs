namespace EFAndLinqPractice_SchoolAPI.ExternalAPIs
{
    public static class ExternalApiUrl
    {
        public static string AddStudent = "http://localhost:6000/external-api/students/add";
        public static string GetById = "http://localhost:6000/external-api/students/1";
        public static string GetAll = "http://localhost:6000/external-api/students/";
        public static string GetStudentByCourseId = "http://localhost:6000/external-api/students/course/1";
        public static string Update = "http://localhost:6000/external-api/students/1";

    }
}