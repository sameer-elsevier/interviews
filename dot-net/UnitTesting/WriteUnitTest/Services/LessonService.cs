using WriteUnitTest.Repositories;

namespace WriteUnitTest.Services
{
    public class LessonService
    {
        public LessonService()
        {
        }

        public void UpdateLessonGrade(int lessonId, double grade)
        {
            var lessonRepo = new LessonRepository();
            var lesson = lessonRepo.GetLesson(lessonId);

            lesson.Grade = grade;

            if (!lesson.IsPassed)
            {
                var moduleRepository = new ModuleRepository();
                var module = moduleRepository.GetModule(lessonId);

                if (grade >= module.MinimumPassingGrade)
                {
                    lesson.IsPassed = true;
                }
                else
                {
                    lesson.IsPassed = false;
                }
            }
        }
    }
}