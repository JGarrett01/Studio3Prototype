using UnityEngine;
using System.Collections;

public class CarGameController : MonoBehaviour {

    public Transform Spawn1;
    public Transform Spawn2;
    public Transform Spawn3;
    public GameObject aiCar;
    private int spawnPoint;

    public float spawnTime = 1.3f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            SpawnCivCar();
            spawnTime = 1.3f;
        }
    }

    void SpawnCivCar()
    {
        spawnPoint = Random.Range(0, 3);

        switch (spawnPoint)
        {
            case 0:
                Instantiate(aiCar, Spawn1.position, Spawn1.rotation);
                break;

            case 1:
                Instantiate(aiCar, Spawn2.position, Spawn2.rotation);
                break;

            case 2:
                Instantiate(aiCar, Spawn3.position, Spawn3.rotation);
                break;

        }
    }
}
