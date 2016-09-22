using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int health = 3;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
