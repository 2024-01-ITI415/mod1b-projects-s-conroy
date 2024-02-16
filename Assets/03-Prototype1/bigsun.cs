using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigsun : MonoBehaviour
{
    
    public GameObject  Obstacleprefab;
    public float       secondsBetweenObstacleDrops = 1f;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropObstacle", 2f);
    }

    void DropObstacle() 
    {
        GameObject Obstacle = Instantiate<GameObject>(Obstacleprefab);
        Obstacle.transform.position = transform.position;
        Invoke("DropObstacle", secondsBetweenObstacleDrops);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
