using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    public GameObject pointStar;
    public Text score;

    private int _score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D self)
    {
        if (self.tag == "PointStar")
        {
            _score++;
            score.text = $"Score: {_score}";
            Destroy(self.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
