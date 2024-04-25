using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public DataController dataController;

    private void Update()
    {
        goldDisplayer.text = "Gold: " + dataController.GetGold();
    }
}
