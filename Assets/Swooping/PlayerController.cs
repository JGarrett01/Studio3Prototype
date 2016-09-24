using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

    public GameController gameController;
    public int health = 3;
    
	// Use this for initialization
	void Start () {
        gameController = GetComponent<GameController>();
       
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(this.gameObject);
           
        }

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Circle")
        {
            health--;
            Destroy(other.gameObject);
        }
    }
}
