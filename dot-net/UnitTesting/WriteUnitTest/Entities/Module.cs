using System.Collections.Generic;

namespace WriteUnitTest.Entities
{
    public class Module
    {
        public int ModuleId;
        public int MinimumPassingGrade;
        public List<Lesson> Lessons;
    }
}