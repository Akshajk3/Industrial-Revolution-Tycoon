using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MachineManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public float moneyCDTime = 1f;
    public PauseMenu menuManager;

    public float money;
    public float profits;
    public float startingMoney = 10f;

    private bool active;

    void Start()
    {
        money = startingMoney;
    }

    void Update()
    {
        moneyText.text = ("$" + money.ToString());
        if(money == 150000)
        {
            menuManager.EndGame();
        }
    }
}
