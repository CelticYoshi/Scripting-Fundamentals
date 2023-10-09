using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "Drake";

    private int _health = 100;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore()
    {
        Score = Score + 10;
    }
    
    public void PrintPlayerName()
    {
        PlayerName = "Drake";
    }

    private void DecreaseHealth()
    {
        _health -= 20;
    }

}
