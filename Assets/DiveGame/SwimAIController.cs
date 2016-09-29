using UnityEngine;
using System.Collections;

public class SwimAIController : MonoBehaviour {

    public float moveSpeed;
    private float deathTimer = 5f;
	
	void Start ()
    {
	
	}
	
	void Update ()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        deathTimer -= Time.deltaTime;

        if (deathTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
