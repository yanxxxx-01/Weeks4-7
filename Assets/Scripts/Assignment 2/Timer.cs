using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0f;
    public float timeMax = 50f;
    public Slider timerVisual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisual.maxValue = timeMax;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time < 0)
        {
            time = timeMax;
            Debug.Log("Time's up!");
        }
        timerVisual.value = time;
    }
}
