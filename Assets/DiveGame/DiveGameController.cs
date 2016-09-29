using UnityEngine;
using System.Collections;

public class DiveGameController : MonoBehaviour
{

    public Transform Spawn1;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;
    public Transform Spawn5;
    public GameObject aiShip;
    private int spawnPoint;
    public float spawnTime = 1.3f;

    void Start()
    {

    }


    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            SpawnAI();
            spawnTime = 1.3f;
        }
    }

    void SpawnAI()
    {
        spawnPoint = Random.Range(0, 5);

        switch (spawnPoint)
        {
            case 0:
                Instantiate(aiShip, Spawn1.position, Spawn1.rotation);
                break;

            case 1:
                Instantiate(aiShip, Spawn2.position, Spawn2.rotation);
                break;

            case 2:
                Instantiate(aiShip, Spawn3.position, Spawn3.rotation);
                break;

            case 3:
                Instantiate(aiShip, Spawn4.position, Spawn4.rotation);
                break;

            case 4:
                Instantiate(aiShip, Spawn5.position, Spawn5.rotation);
                break;

        }
    }
}
