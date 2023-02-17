using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myScoreText;
    private int scoreNum;

    private void Start()
    {
        scoreNum = 0;
        myScoreText.text = "Score:" + scoreNum;

    }

    private void OnTriggerEnter(Collider coins)
    {
        if(coins.tag == "Coin")
        {
            scoreNum += 1;
            Destroy(coins.gameObject);
            myScoreText.text = "Score:" + scoreNum;
        }
    }
}
