using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class NewObstacle : MonoBehaviour
{

    public GameObject player;

    public GameObject smallCircle;
    public GameObject mediumCircle;
    public GameObject circleCircles;
    public GameObject windMill;
    
    public GameObject colorChanger;

    
    private Queue<GameObject> currentObstacles = new Queue<GameObject>();
    
    private float _height = 11;

    void Start()
    {
        for (var i = 0; i < 3; i++)
        {
            GameObject newObstacle = AddObstacle();
            currentObstacles.Enqueue(newObstacle);
        }
    }

    void Update()
    {
        GameObject bottomObstacle = currentObstacles.Peek();

        if (player.transform.position.y > bottomObstacle.transform.position.y + 10)
        {
            currentObstacles.Dequeue();
            Destroy(bottomObstacle);
            currentObstacles.Enqueue(AddObstacle());
        }
    }

    GameObject AddObstacle()
    {
        GameObject newObstacle = GetRandomObstacle();
        Vector3 newObstaclePos = newObstacle.transform.position;

        Instantiate(colorChanger, new Vector3(0, _height - 4, 0), Quaternion.identity);
        GameObject obstacle = Instantiate(newObstacle, new Vector3(newObstaclePos.x, _height, newObstaclePos.z), Quaternion.identity);
        _height += 8;
        return obstacle;
    }

    private GameObject GetRandomObstacle()
    {
        int index = Random.Range(0, 4);
        GameObject obstacle = null;

        switch (index) 
        {
            case 0:
                obstacle = smallCircle;
                break;
            case 1:
                obstacle = mediumCircle;
                break;
            case 2:
                obstacle = circleCircles;
                break;
            case 3:
                obstacle = windMill;
                break;
        }
        return obstacle;
    }
    

} 
