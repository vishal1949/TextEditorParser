using System;
using System.Collections;
using System.Collections.Generic;


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
    private readonly string name;
    public string location;

    public int count = 0;
    private Hashtable lineTextListHashtable = new Hashtable();
    public EmployeeText(string name, string location, int line, string text) // this is the constructor
    {
        this.name = name;
        this.location = location;
        int firstLineNum = line;
        string firstText = text;
        addToHashTable(firstLineNum, firstText);
    }

    public String getName()
    {
        return name;
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

