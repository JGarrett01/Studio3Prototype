using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject bird;
    public float timer = 2;

    public Transform FirstSpawnpoint;
    public Transform SecondSpawnpoint;
    public Transform ThirdSpawnpoint;

    private int spawnPoint;


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

        //----------------------- Timer and Spawn -----------------------------
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnCircle();
            timer = 1;
            
        }
       
        //-----------------------------------------------------------


        
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
