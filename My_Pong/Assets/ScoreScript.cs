using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int P1_Score = 0;
    public Text P1_ScoreText;
    private int P2_Score = 0;
    public Text P2_ScoreText;

    public void incrementP1Score() {
        P1_Score++;
        P1_ScoreText.text = P1_Score.ToString();
    }

    public void incrementP2Score() {
        P2_Score++;
        P2_ScoreText.text = P2_Score.ToString();
    }
}
