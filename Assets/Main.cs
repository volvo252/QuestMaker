using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static QuestManager;

public class Main : MonoBehaviour
{
    public QuestManager questManager; // ������� �����, � ������� ����� �������� � ��������

    public TMP_InputField inputFieldQuestName;
    private void Start()
    {
        QuestManager questManager = new QuestManager();

    }
    
    public void CreateNewQuest(string inputFieldQuestName)
    {
        //Quest newQuest = new Quest(inputFieldQuestName);  ��� ��������
        //questManager.AddQuest(newQuest);                   � ��� ��������
    }

    
}
