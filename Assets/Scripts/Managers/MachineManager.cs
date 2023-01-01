using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MachineManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public float moneyCDTime = 1f;

    public float money;
    public float profits;

    private bool active;

    void Start()
    {
        InvokeRepeating("AddProfits", moneyCDTime, moneyCDTime);
    }

    void Update()
    {
        moneyText.text = ("$" + money.ToString());
    }

    public void AddProfits()
    {
        money += profits;
    }
}
