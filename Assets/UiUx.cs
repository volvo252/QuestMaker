using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiUx : MonoBehaviour
{
    public GameObject CreateNewQuestPan;

    public void ActivePanCreateNewQuest() 
    {
        CreateNewQuestPan.SetActive(!CreateNewQuestPan.activeSelf);
    }

}
