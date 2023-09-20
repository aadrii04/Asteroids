using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehavior : MonoBehaviour
{

    private float time;
    public float initialTime;
    public bool countDown;   
    public UnityEvent<float> OnTime;
    public UnityEvent OnTimeOut;
    // Start is called before the first frame update
    void Start()
    {
        RestartTime();
    }


    public void RestartTime()
    {
        time = initialTime;
        OnTime.Invoke(time);
    }

    public void StopTime()
    {
        time = 0;
        OnTime.Invoke(time);
    }
    // Update is called once per frame
    void Update()
    {
        if (countDown)
        {
            time -= Time.deltaTime;
            if (time <= 0)
                OnTimeOut.Invoke();
        }
        else
            time += Time.deltaTime;
        OnTime.Invoke(time);
    }
}
