using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextBehavior : MonoBehaviour
{

    public void SetScoretext(int score)
    {
        GetComponent<TMP_Text>().text = "Score: " + score;
    }
}
// Start is called before the first frame update

