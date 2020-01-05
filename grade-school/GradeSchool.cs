using System;
using System.Collections.Generic;

public class GradeSchool
{
    public List<string> theRoster { get; set; } = new List<string>();
    public List<string> withGrades { get; set; } = new List<string>();
    public List<string> gradeList { get; set; }

    public void Add(string student, int grade)
    {
        //need to add students in order. 
        //year 1 is first, then 2, then 3 etc.
        //students then sorted alphabetically after grade sorting.

        //then get index via a for loop and put it into this.theRoster in the same order.

        this.withGrades.Add( $"{student}{grade}" );
        // this.sortByGrade(this.withGrades);
        this.withGrades.Sort(sortByGrade);
    }

    private static int sortByGrade (string x, string y)
    {
        var parseX = x[x.Length - 1];
        var numX = int.Parse(parseX.ToString());

        var parseY = y[y.Length - 1];
        var numY = int.Parse(parseY.ToString());

        if(numX > numY) {
            return 1;
        } else if (numX < numY ) 
        {
            return -1;
        } else {
            var compare = string.Compare(x, y);
            if (compare > 0 ) 
            {
                return 1;
            } else if (compare < 0) 
            {
                return -1;
            } else 
            {
                return 0;
            }
        }
    }

    public IEnumerable<string> Roster()
    {
        for(int i = 0; i < withGrades.Count; i++)
        {
            var newItem = withGrades[i].Remove(withGrades[i].Length - 1);
            this.theRoster.Add(newItem);

            Console.WriteLine(newItem);
        }
        return this.theRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        this.gradeList = new List<string>();

        foreach(var item in this.withGrades)
        {
            var theGrade = int.Parse(item[item.Length - 1].ToString());
            var theItem = item.Remove(item.Length - 1); 
            if(theGrade == grade)
            {
                this.gradeList.Add(theItem);
            } 
        }

        return this.gradeList;
    }



        public void displaySorted () 
    {
        System.Console.WriteLine("======================");
        foreach (var item in withGrades)
        {
            System.Console.WriteLine(item);
        }
    }
}