using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
    Dictionary<string, int> studentList = new Dictionary<string, int>();

    IEnumerable<string> sortedStudentList;

    IOrderedEnumerable<KeyValuePair<string, int>> forSortingStudents;

    public void Sort()
    {
        forSortingStudents = studentList
                                .OrderBy(x => x.Value)
                                .ThenBy(x => x.Key);

        sortedStudentList = forSortingStudents.ToDictionary<KeyValuePair<string, int>, string, int>
                                                                (pair => pair.Key, pair => pair.Value)
                                                                .Keys;
    }

    public void Add(string student, int grade)
    {
        studentList.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        Sort();        

        return sortedStudentList.ToArray<string>();
    }

    public IEnumerable<string> Grade(int grade)
    {
        foreach(KeyValuePair<string, int> k in studentList)
        {
            if (k.Value != grade)
            {
               studentList.Remove(k.Key);
            }
        }

        Sort();        
        
        return sortedStudentList.ToArray<string>();
    }
}