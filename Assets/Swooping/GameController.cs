using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject bird;
    public float timer = 2;
    public GameObject player;

    public Transform FirstSpawnpoint;
    public Transform SecondSpawnpoint;
    public Transform ThirdSpawnpoint;

    public UIController UIController;

    public bool canSpawn = true;
    public int score;
    private int spawnPoint;


	// Use this for initialization
	void Start () {
        score = 0;
        player = GameObject.FindGameObjectWithTag("Player");
 
	}
	
	// Update is called once per frame
	void Update () {

        UIController.score = score;

        if (player == null)
        {
            canSpawn = false;
        }

        //----------------------- Timer and Spawn -----------------------------
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (canSpawn == true)
            {
                SpawnCircle();
                timer = 1;
            }
            
        }

        //-----------------------------------------------------------


        //if (GameObject.FindGameObjectsWithTag ("Circle") == null)
        //{
        //    score++;
        //}
        
	}

    void SpawnCircle()
    {
        spawnPoint = Random.Range(0, 3);

        switch (spawnPoint)
        {
            case 0:
                Instantiate(bird, FirstSpawnpoint.position, FirstSpawnpoint.rotation);
                break;

            case 1:
                Instantiate(bird, SecondSpawnpoint.position, SecondSpawnpoint.rotation);
                break;

            case 2:
                Instantiate(bird, ThirdSpawnpoint.position, ThirdSpawnpoint.rotation);
                break;

        }
    }
}
