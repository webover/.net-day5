using System.Collections.Generic;

namespace DependencyInversionDatabaseAfter.Contracts
{
    public interface IData
    {
        IEnumerable<int> CourseIds();

        IEnumerable<string> CourseNames();

        IEnumerable<string> Search(string substring);

        string GetCourseById(int id);
    }
}
