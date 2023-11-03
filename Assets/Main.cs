using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static QuestManager;

public class Main : MonoBehaviour
{
    public QuestManager questManager; // главный класс, в будущем будет привязан к аккаунту

    public TMP_InputField inputFieldQuestName;
    private void Start()
    {
        QuestManager questManager = new QuestManager();

    }
    
    public void CreateNewQuest(string inputFieldQuestName)
    {
        //Quest newQuest = new Quest(inputFieldQuestName);  тут проблема
        //questManager.AddQuest(newQuest);                   и тут проблема
    }

    
}
