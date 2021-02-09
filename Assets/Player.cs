using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float jumpForce = 10f;
    public string currentColor;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;

    private bool _gravityFuncCalled = false;

    public void Start()
    {
        SetRandomColor();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;

            if (!_gravityFuncCalled)
            {
                SetPlayerGravity();
            }
        }

    }

    private void SetPlayerGravity()
    {
        player.GetComponent<Rigidbody2D>().gravityScale = 3;
        _gravityFuncCalled = true;
    }
    
    public void OnTriggerEnter2D(Collider2D self)
    {
        if (self.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(self.gameObject);
            return;
        }
        
        if (self.tag != currentColor)
        {
            // Just a quick fix to stop collisions with Star
            if (!(self.tag == "PointStar"))
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
            }
            
        }
    }

    private void SetRandomColor()
    {
        var index = Random.Range(0, 4);

        switch (index) 
        {
            case 0:
                if (currentColor.Equals("Cyan"))
                {
                    SetRandomColor();
                }
                else
                {
                    currentColor = "Cyan";
                    sr.color = colorCyan;
                }
                break;
            case 1:
                if (currentColor.Equals("Yellow"))
                {
                    SetRandomColor();
                }
                else
                {
                    currentColor = "Yellow";
                    sr.color = colorYellow;    
                }
                break;
            case 2:
                if (currentColor.Equals("Magenta"))
                {
                    SetRandomColor();
                }
                else
                {
                    currentColor = "Magenta";
                    sr.color = colorMagenta;                    
                }
                break;
            case 3:
                if (currentColor.Equals("Pink"))
                {
                    SetRandomColor();
                }
                else
                {
                    currentColor = "Pink";
                    sr.color = colorPink;   
                }
                break;
        }
    }
}
