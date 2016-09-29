using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float swimForce;
    public float curSpeed;
    public float maxSpeed = 4;
    public int score = 0;
    private float scoreCount = 1f;
   

    // Use this for initialization
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        curSpeed = rb.velocity.magnitude;

        scoreCount -= Time.deltaTime;
        if (scoreCount <= 0)
        {
            score++;
            scoreCount = 1f;
        }
       
       
       
    }

    void Movement()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(new Vector2(0,swimForce), ForceMode2D.Impulse);
        }
    

        if (Input.touchCount > 0)
        {
            rb.AddForce(new Vector2(0, swimForce), ForceMode2D.Impulse);
        }

        if (curSpeed > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ShipAI")
        {
            Destroy(this.gameObject); 
        }
    }
}
