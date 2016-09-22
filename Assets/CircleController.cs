using UnityEngine;
using System.Collections;

public class CircleController : MonoBehaviour
{

    public GameObject player;
    public float speed;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }       
            
               
            
          
}
  
