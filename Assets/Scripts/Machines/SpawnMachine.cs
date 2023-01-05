using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnMachine : MonoBehaviour
{
    public GameObject machinePrefab;
    public Transform spawnLocation;
    public GameObject machineManager;
    public TextMeshPro priceText;
    public float cost;
    public int numWorkers = 2;
    public WorkerManager wm;
    public AstarPath AStar;

    private MachineManager mc;
    private DialogueTrigger dt;
    
    private Quaternion rotation = Quaternion.identity;
        
    void Start()
    {
        mc = machineManager.GetComponent<MachineManager>();
        dt = GetComponent<DialogueTrigger>();
        priceText.text = ("$" + cost.ToString());
        priceText.gameObject.SetActive(false);
    }

    void Update()
    {
        if(mc.money >= cost)
        {
            priceText.color = Color.green;
        }
        else if(mc.money < cost)
        {
            priceText.color = Color.red;
        }
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
            wm.SpawnWorker(numWorkers);
            AStar.Scan();
            Destroy();
            dt.TriggerDialogue();
        }

    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

    public void DisplayPrice()
    {
        priceText.gameObject.SetActive(true);
    }

    public void HideCost()
    {
        priceText.gameObject.SetActive(false);
    }
}
