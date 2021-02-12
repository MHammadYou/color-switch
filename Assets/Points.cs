using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text score;

    private int _score;
    public void OnTriggerEnter2D(Collider2D self)
    {
        if (self.tag == "PointStar")
        {
            _score++;
            score.text = $"Score: {_score}";
            Destroy(self.gameObject);
        }
    }
}
