using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    float scoreCount = 0f;

    public bool isDead = false;

    void Update()
    {
        if (isDead == false)
        {
            scoreCount += Time.deltaTime;
        }

        scoreText.text = "" + Mathf.RoundToInt(scoreCount);

    }

}
