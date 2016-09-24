using UnityEngine;
using System.Collections;

public class CircleController : MonoBehaviour
{

    public GameObject player;
    public float speed;

    public GameController gameController;
    public GameObject controllerManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controllerManager = GameObject.FindGameObjectWithTag("ControllerManager");

        gameController = controllerManager.GetComponent<GameController>();


    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Destroy(this.gameObject);
        }

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
        
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        gameController.score++;
    }

      
}
  
