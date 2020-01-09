namespace DependencyInversionDatabaseAfter
{
    using DependencyInversionDatabaseAfter.Contracts;
    public class Courses
    {
        private readonly IData database;
        public Courses(IData database)
        {
            this.database = database;
        }

        public void PrintAll()
        {
            var courses = database.CourseNames();

            // print courses
        }

        public void PrintIds()
        {
            var courses = database.CourseIds();

            // print courses
        }

        public void PrintById(int id)
        {
            var courses = database.GetCourseById(id);

            // print courses
        }

        public void Search(string substring)
        {
            var courses = database.Search(substring);

            // print courses
        }
    }
}
