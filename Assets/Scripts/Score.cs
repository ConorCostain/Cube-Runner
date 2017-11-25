using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private int score;
    private int tempScore;
    public int scoreMultiplier = 1;
	
	// Update is called once per frame
	void Update () {
        tempScore = score;
        score = (int)player.position.z * scoreMultiplier;
        if(tempScore < score)
        {
        scoreText.text = score.ToString() + "m";
        }

	}
}
