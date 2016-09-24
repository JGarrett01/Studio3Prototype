using UnityEngine;
using System.Collections;


public class CarController : MonoBehaviour {

    public int score = 0;
    private Vector3 mousePos;
    public float moveSpeed = 0.2f;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update ()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = Vector2.Lerp(transform.position, mousePos, moveSpeed);

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.1f ,0.9f);
        pos.y = Mathf.Clamp(pos.y, 0.2f, 0.9f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        score++;

       
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "aiCar")
        {
            Destroy(this.gameObject);
        }
    }

}
