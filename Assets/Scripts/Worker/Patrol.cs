using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float maxXPos;
    public float minXPos;
    public float maxYPos;
    public float minYPos;

    public AIDestinationSetter Worker;
    public LayerMask workerLayer;

    private float xPos;
    private float yPos;
    private float newPosTimer;
    private Vector3 targetPosition;

    void Start()
    {   
        GetRandomPosition();
        InvokeRepeating("GetRandomPosition", 5f, 5f);
    }

    public void GetRandomPosition()
    {
        xPos = Random.Range(minXPos, maxXPos);
        yPos = Random.Range(minYPos, maxYPos);

        transform.position = new Vector2(xPos, yPos);

        newPosTimer = Random.Range(0, 10);
    }
}
