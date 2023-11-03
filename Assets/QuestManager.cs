using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager
{
    public QuestManager()
    {
        Quests = new List<Quest>();
    }
    public List<Quest> Quests { get; set; }


    public void AddQuest(Quest quest)
    {
        Quests.Add(quest);
    }
}

