using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public Text goldPerClickDisplayer;
    //public DataController dataController;
    

    private void Update()
    {
        goldDisplayer.text = "Gold: " + DataController.GetInstance().GetGold();
        goldPerClickDisplayer.text = "Gold Per Click: " + DataController.GetInstance().GetGoldPerClick();
    }
}
