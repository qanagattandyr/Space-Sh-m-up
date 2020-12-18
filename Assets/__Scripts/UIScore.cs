using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro scoreGT;
    public GameObject highScore;
    static public int score = 0;

    private int hScore;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hScore = PlayerPrefs.GetInt("HighScore");
        }

        PlayerPrefs.SetInt("HighScore", hScore);
        highScore.GetComponent<Text>().text = "High Score: " + hScore;
    }
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        if(scoreGO != null)
        {
            print("Score found!");
        }
        scoreGT = scoreGO.GetComponent<TextMeshPro>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreGT.text = "Score: " + score;

        if(score > hScore)
        {
            highScore.GetComponent<Text>().text = "High Score: " + score;
            PlayerPrefs.SetInt("HighScore", score);
        }

    }
}
