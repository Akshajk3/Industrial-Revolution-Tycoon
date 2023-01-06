using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MoneyData
{
    public float money;

    public MoneyData(MachineManager machineManager)
    {
        money = machineManager.money;
    }
}
