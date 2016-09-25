using UnityEngine;
using System.Collections;

public class CivilianScript : MonoBehaviour
{

    public float moveSpeed;
    public float deathTimer = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        deathTimer -= Time.deltaTime;

        if (deathTimer <= 0)
        {
            Destroy(this.gameObject);
        }


    }

    
}
