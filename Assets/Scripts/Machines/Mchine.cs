using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mchine : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject outputItem;
    public float spawnTimer;
    public float value;

    private MachineManager mc;

    private void Start()
    {
        mc = this.GetComponentInParent<MachineManager>();
        mc.profits += value;
    }

}
