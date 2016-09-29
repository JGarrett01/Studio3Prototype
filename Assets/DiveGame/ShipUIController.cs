using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipUIController : MonoBehaviour {

    public Text scoreText;
    public GameObject ship;
    public ShipController shipController;
         
	void Start ()
    {
	
	}
	
	void Update ()
    {
        scoreText.text = shipController.score.ToString("Score:" + shipController.score);
	}
}
