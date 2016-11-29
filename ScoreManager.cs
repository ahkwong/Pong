using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int scoreLeft;
    public static int scoreRight;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        scoreLeft = 0;
        scoreRight = 0;
    }

    void Update()
    {
        text.text = scoreLeft + "     " + scoreRight;
    }
}
