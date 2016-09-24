using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text scoreText;
    public Text hpText;
    public PlayerController playerController;
    public GameController gameController;
    public CircleController circleController;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {

        hpText.text = playerController.health.ToString("Health: " + playerController.health);
        scoreText.text = gameController.score.ToString("Score: " + gameController.score);
	
	}
}
