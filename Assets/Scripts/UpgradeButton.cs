using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public TextMeshProUGUI upgradeDisplayer;

    public string upgradeName;

    [HideInInspector]
    public int goldByUpgrade;
    public int startGoldByUpgrade = 1;

    [HideInInspector]
    public int currentCost;
    public int startCurrentCost = 1;

    [HideInInspector]
    public int level = 1;
    public float upgradePow = 1.07f;
    public float costPow = 3.14f;

    private void Start()
    {
        currentCost = startCurrentCost;
        goldByUpgrade = startGoldByUpgrade;

        UpdateUI();
    }

    public void PurchaseUpgrade()
    {
        if (DataController.GetInstance().GetGold() >= currentCost)
        {
            DataController.GetInstance().SubGold(currentCost);
            level++;
            DataController.GetInstance().AddGoldPerClick(goldByUpgrade);

            UpdateUpgrade();
            UpdateUI();
        }
    }

    public void UpdateUpgrade()
    {
        goldByUpgrade = startGoldByUpgrade * (int)MathF.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)MathF.Pow(costPow, level);
    }

    public void UpdateUI()
    {
        upgradeDisplayer.text = upgradeName + "\nCost: " + currentCost + "\nLevel: " + level + "\nNext New GoldPerClick: " + goldByUpgrade;
    }
}