using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField] Text scoreText;

    void Start()
    {
        int currentScore = PlayerPrefs.GetInt("HighestScore", 0);
        scoreText.text = "Game Over!!!!\nHighest Score: " + currentScore.ToString();

    }
}
