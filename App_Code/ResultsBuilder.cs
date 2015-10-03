using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResultsBuilder
/// </summary>
public class ResultsBuilder
{
    List<String> neededCourses = new List<String>();
    List<String> possibleCourses = new List<String>();
	public ResultsBuilder(List<String> need)
	{
        neededCourses = need;
	}

    // getter - returns all courses where requirements are met
    public List<String> getPossible()
    {
        return possibleCourses;
    }

    private void findPossible()
    {
        // code to get all courses able to take

    }


}