using System;
public class Person
{
    static public string GetName() 
    {
        return "許光漢";
    }
    static public string GetName(string title)
    {
        return title + "許光漢";
    }
    static public string GetName(string title,string dept)
    {
        return title + dept+"許光漢";
    }
    static public int GetNumber(int a)
    {
        return a;
    }
    static public float GetNumber(float)
    {
        return a;
    }
}
