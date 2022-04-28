using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace EFAndLinqPractice_SchoolAPI.ExternalAPIs
{
    public class ExternalSchoolHttpClient
    {
        private readonly HttpClient _httpClient;
            

        public ExternalSchoolHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Student> AddStudent(Student student)
        {
            var studentString = JsonConvert.SerializeObject(student);
            var content = new StringContent(studentString, Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync(ExternalApiUrl.AddStudent, content);
            var body = await result.Content.ReadAsStringAsync();

            var resultStudent = JsonConvert.DeserializeObject<Student>(body);

            return resultStudent;
        }
        
        public async Task<Student> GetStudentById(int id)
        {
            var result = await _httpClient.GetAsync(ExternalApiUrl.GetById);
            var body = await result.Content.ReadAsStringAsync();

            var resultStudent = JsonConvert.DeserializeObject<Student>(body);

            return resultStudent;
        }
        
        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await _httpClient.GetAsync(ExternalApiUrl.GetAll);
            var body = await result.Content.ReadAsStringAsync();

            var resultStudents = JsonConvert.DeserializeObject<IEnumerable<Student>>(body);

            return resultStudents;
        }
        
        public async Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId)
        {
            var result = await _httpClient.GetAsync(ExternalApiUrl.GetStudentByCourseId);
            var body = await result.Content.ReadAsStringAsync();

            var resultStudents = JsonConvert.DeserializeObject<IEnumerable<Student>>(body);

            return resultStudents;
        }
        
        public async Task<Student> UpdateStudent(int id, Student student)
        {
            var studentString = JsonConvert.SerializeObject(student);
            var content = new StringContent(studentString, Encoding.UTF8, "application/json");

            var result = await _httpClient.PutAsync(ExternalApiUrl.Update, content);
            var body = await result.Content.ReadAsStringAsync();

            var resultStudent = JsonConvert.DeserializeObject<Student>(body);

            return resultStudent;
        }
        
        
    }
}