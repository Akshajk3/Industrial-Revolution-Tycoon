using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PlayerMovement player;
    public MachineManager machine;
    
    void Start()
    {
        player.LoadPlayer();
        machine.LoadMoney();
    }
}
