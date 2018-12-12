using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyManager : MonoBehaviour {
    [SerializeField]
    private UIManager uimanager;

    [SerializeField]
    private int Money = 0;

    [SerializeField]
    private const int baseIncome = 100;

    public int ExtraIncome = 0;
    
    public void GetIncome()
    {
        Money += baseIncome + ExtraIncome;
        uimanager.txt_Money.text = "$" + Money;
    }
}
