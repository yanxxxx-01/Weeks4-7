using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0f;
    public float timeMax = 10f;
    public Slider timerVisual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisual.maxValue = timeMax;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time;

        if(time >= timeMax)
        {
         
            time = 0f;
            
        }
        timerVisual.value = time;
    }
}
