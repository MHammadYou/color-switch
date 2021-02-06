using UnityEngine;

public class NewObstacle : MonoBehaviour
{

    public GameObject smallCircle;
    public GameObject mediumCircle;
    public GameObject circleCircles;
    public GameObject windMill;
    
    public GameObject colorChanger;

    void Start()
    {
        Debug.Log(GetRandomObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
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
