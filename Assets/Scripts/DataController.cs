using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private int m_gold = 0;
    private int m_goldPerClick = 0;

    private void Awake()
    {
        //GetInt는 키값과 매칭되는 데이터를 가져오는 함수
        m_gold = PlayerPrefs.GetInt("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick", 1);

    }


    public void SetGold(int newGold)
    {
        //GetInt는 키값과 매칭되는 데이터를 저장하는 함수
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold);
    }

    public void SetGoldPerClick(int newGold)
    {
        m_goldPerClick = newGold;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);
    }

    public void AddGold(int newGold)
    {
        m_gold += newGold;
        SetGold(m_gold);
    }
    public void SubGold(int newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }

    public int GetGold()
    {
        return m_gold;
    }

    public int GetGoldPerClick()
    {
        return m_goldPerClick;
    }
}
