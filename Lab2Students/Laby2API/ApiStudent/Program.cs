// See https://aka.ms/new-console-template for more information

using ApiStudent;

ApiStudentFetcher apiStudentFetcher = new ApiStudentFetcher();
string resultFetcher = apiStudentFetcher.getData();
Console.WriteLine(resultFetcher);
StudentDeserializer studentDeserializer = new StudentDeserializer();
List<Student> students = studentDeserializer.deseralizeStudents(resultFetcher);

foreach (var student in students)
{
    Console.WriteLine(student);
}
