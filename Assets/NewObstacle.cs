using UnityEngine;

public class NewObstacle : MonoBehaviour
{

    public GameObject smallCircle;
    public GameObject mediumCircle;
    public GameObject circleCircles;
    public GameObject windMill;
    
    public GameObject colorChanger;

    private float height = 13;

    void Start()
    {
        AddObstacle();
        
    }


    void AddObstacle()
    {
        for (int i = 1; i < 6; i++)
        {
            GameObject newObstacle = GetRandomObstacle();
            Vector3 newObstaclePos = newObstacle.transform.position;

            Instantiate(colorChanger, new Vector3(0, height - 5, 0), Quaternion.identity);
            Instantiate(newObstacle, new Vector3(newObstaclePos.x, height, newObstaclePos.z), Quaternion.identity);
            height += 10;
        }


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
