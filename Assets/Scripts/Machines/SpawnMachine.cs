using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMachine : MonoBehaviour
{
    public GameObject machinePrefab;
    public Transform spawnLocation;
    public GameObject machineManager;
    public float cost;

    private MachineManager mc;
    
    private Quaternion rotation = Quaternion.identity;
        
    void Start()
    {
        mc = machineManager.GetComponent<MachineManager>();
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        if (mc.money >= cost)
        {
            mc.money -= cost;
            GameObject Machine = Instantiate(machinePrefab, spawnLocation) as GameObject;
            Machine.transform.SetParent(machineManager.transform, false);
            Machine.transform.position = spawnLocation.position;
            Machine.name = machinePrefab.name;
        }
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
