using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTextUpdater : MonoBehaviour
{

    public void SetTimetext(float time)
    {
        GetComponent<TMP_Text>().text = "Time: " + System.Math.Round(time, 1);
    }
}
    // Start is called before the first frame update
    
