using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarUIController : MonoBehaviour {

    public Text scoreText;
    public GameObject car;
    public CarController carController;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = carController.score.ToString("Distance: " + carController.score + "M");

    }
}
