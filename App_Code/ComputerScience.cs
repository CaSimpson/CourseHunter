using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ComputerScience
/// </summary>
public class ComputerScience
{
    String[] takenArray;
    String[] recArray;



	public ComputerScience(String[] inputArray)
	{
        takenArray = inputArray;
       
	}

    public String[] getRecommended()
    {
        Recommend(takenArray);
        return recArray;
    }

    private String[] Recommend(String[] inputArray)
    {
        List<String> recList = new List<String>();
        
        //Communication recommended courses
            if (!inputArray.Contains("ENG-101"))
            {
                recList.Add("ENG-101");
            }
            else if (!inputArray.Contains("ENG-102"))
            {
                recList.Add("ENG-102");
            }
            else if (!inputArray.Contains("SPH-201"))
            {
                recList.Add("SPH-201");
            }
         //End Comm courses

        //Mathematics recommended courses
            if(!inputArray.Contains("MAT-174"))
            {
                recList.Add("MAT-174");
            }
            
            if(!inputArray.Contains("MAT-141"))
            {
               recList.Add("MAT-141");
            }
            else if(!inputArray.Contains("MAT-142") || !inputArray.Contains("MAT-315"))
            {
                if(!inputArray.Contains("MAT-142"))
                {
                    recList.Add("MAT-142");
                }
                if(!inputArray.Contains("MAT-315"))
                {
                    recList.Add("MAT-315");
                }
            }
        //End math courses

        //Natural Sciences recommended courses
            if(!inputArray.Contains("BIO-101") || !inputArray.Contains("CHM-111") || !inputArray.Contains("PHS-211"))
            {
                recList.Add("BIO-101");
                recList.Add("CHM-111");
                recList.Add("PHS-211");
            }
            else
            {
                if (inputArray.Contains("BIO-101"))
                {
                    recList.Add("BIO-102");
                }
                else
                {
                    recList.Add("BIO-101");
                }
                if(inputArray.Contains("CHM-111"))
                {
                    recList.Add("CHM-112");
                }
                else
                {
                    recList.Add("CHM-111");
                }
                if(inputArray.Contains("PHS-211"))
                {
                    recList.Add("PHS-212");
                }
                else
                {
                    recList.Add("PHS-211");
                }
            }
        //End Nat. Sciences

        //Arts/Humanities
        int artCounter = 0;
        //List<String> bList = new List<String>();
        List<String> aList = new List<String>();
        String[] artArray = {"AAS-204", "ATH-101", "ATH-105", "ATH-106", "MUS-110", "THE-161", "THE-170"};
        foreach(String s in artArray)
        {
            aList.Add(s);
        }
            //removes all classes from art list that have been complete and counts # complete
            foreach(String s in artArray)
            {
              if(inputArray.Contains(s))
              {
                  aList.Remove(s);
                  artCounter++;
              }
            }

            if(artCounter < 2)
            {
                foreach (String s in aList)
                {
                    recList.Add(s);
                }
            }
        //END A/H

        //Foriegn Languages
            if(!inputArray.Contains("CHI-102") || !inputArray.Contains("FRN-102") || 
                !inputArray.Contains("GRM-102") || !inputArray.Contains("SPN-102"))
            {
                recList.Add("CHI-102");
                recList.Add("FRN-102");
                recList.Add("GRM-102");
                recList.Add("SPN-102");
            }
        //End F. Languages

        //History
            if(!inputArray.Contains("HST-101") || !inputArray.Contains("HST-102") || 
                !inputArray.Contains("HST-105") || !inputArray.Contains("HST-106"))
            {
                recList.Add("HST-101");
                recList.Add("HST-102");
                recList.Add("HST-105");
                recList.Add("HST-106");
            }
        //End History

        //Social/Behavioral Sciences

        int sbCounter = 0;
        List<String> sbList = new List<String>();
        String[] sbArray = {"AAS-201", "ANT-102", "ECO-221", "ECO-222", "GEG-101", "GEG-103", 
                           "GIS-101", "GIS-200", "GIS-320", "PSY-101", "SOC-101", "WST-101" };
        foreach(String s in artArray)
        {
            sbList.Add(s);
        }
            //removes all classes from sb list that have been complete and counts # complete
            foreach(String s in artArray)
            {
              if(inputArray.Contains(s))
              {
                  sbList.Remove(s);
                  sbCounter++;
              }
            }

            if(artCounter < 2)
            {
                foreach(String s in aList)
                {
                    recList.Add(s);
                }
            }

        //End S/B Sciences

        // Computer Science Courses
        if(!inputArray.Contains("CSC-150"))
        {
            recList.Add("CSC-150");
        }
        else if(!inputArray.Contains("CSC-200"))
        {
            recList.Add("CSC-200");
        }
        else
        {
            if(!inputArray.Contains("CSC-234") || !inputArray.Contains("CSC-238"))
            {
                recList.Add("CSC-234");
                recList.Add("CSC-238");
            }
            if(!inputArray.Contains("CSC-210"))
            {
                recList.Add("CSC-210");
            }
            else if(!inputArray.Contains("CSC-310"))
            {
                recList.Add("CSC-310");
            }
            if(!inputArray.Contains("CSC-300"))
            {
                recList.Add("CSC-300");
            }
            else if(!inputArray.Contains("CSC-321"))
            {
                recList.Add("CSC-321");
            }
            else if(!inputArray.Contains("CSC-421") || !inputArray.Contains("CSC-540"))
            {
                if(!inputArray.Contains("CSC-421"))
                {
                    recList.Add("CSC-421");
                }
                if(!inputArray.Contains("CSC-540"))
                {
                    recList.Add("CSC-540");
                }
            }
            if(!inputArray.Contains("CSC-511") || !inputArray.Contains("CSC-530") &&
                inputArray.Contains("CSC-321") && inputArray.Contains("CSC-210"))
            {
                if(!inputArray.Contains("CSC-511"))
                {
                    recList.Add("CSC-511");
                }
                if(!inputArray.Contains("CSC-530"))
                {
                    recList.Add("CSC-530");
                }
            }
        }
        //END Comp Science

        //Comp Science Electives
        int CSCounter = 0;
        List<String> csList = new List<String>();
        String[] csArray = {"CSC-314", "CSC-370", "CSC-525", "CSC-580", "CSC-585", "CSC-399", 
                               "CSC-499", "CSC-412", "CSC-450", "CSC-455", "CSC-520", "CSC-525"};
        foreach(String s in csArray)
        {
            csList.Add(s);
        }
            foreach(String s in csArray)
            {
                if(inputArray.Contains(s))
                {
                    csList.Remove(s);
                    CSCounter++;
                }
            }

        if(CSCounter < 3)
        {
            foreach(String s in csList)
            {
                recList.Add(s);
            }
        }
        //END CS electives

        recArray = recList.ToArray();

        return recArray;
    }




}