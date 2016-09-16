using WriteUnitTest.Services;

namespace WriteUnitTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lessonSvc = new LessonService();

            var lessonId = 12;

            var grade = 98.2d;

            lessonSvc.UpdateLessonGrade(lessonId, grade);
        }
    }
}