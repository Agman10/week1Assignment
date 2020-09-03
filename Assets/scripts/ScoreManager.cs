using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMpro;
using System.ComponentModel;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int gemValue)
    {
        score += gemValue;
        text.text = "Gems: " + score.ToString();
    }
}
