using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;


public class LineText
{
    public readonly int line;
    public readonly string text;
    public LineText(int line, string text)
    {
        this.line = line;
        this.text = text;
    }
}

public class EmployeeText
{
    public string location;

    public int count = 0;
    public Hashtable lineTextListHashtable = new Hashtable();

    private void forMeOnly()
    {
        Console.WriteLine("Private Method");
    }


    public void addToHashTable(int lineNumber, string text)
    {
        count++;
        LineText combo = new LineText(lineNumber, text);
        lineTextListHashtable.Add(count, combo);
    }

    public Hashtable GetHashtable()
    {
        return lineTextListHashtable;
    }

}
