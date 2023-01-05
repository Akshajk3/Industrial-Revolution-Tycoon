using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerManager : MonoBehaviour
{
    public GameObject workerPrefab1;
    public Transform SpawnPosition;

    public void SpawnWorker(int number)
    {
        for(int i = 0; i < number; i++)
        {
            GameObject worker = Instantiate(workerPrefab1);
            worker.transform.position = transform.position;
        }
    }
}
