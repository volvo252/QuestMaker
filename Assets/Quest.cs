using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest 
{
    public string questName { get; set; }
    public Dictionary<int, string> book { get; set; }  
    public Quest(string name)
    {
        questName = name;
        book = new Dictionary<int, string>();
    }
}


    //public void AddPage(int stepNumber, string stepText)
    //{
    //    book.Add(stepNumber, stepText);
    //}

