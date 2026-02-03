using UnityEngine;
using UnityEngine.UI;

public class ChangeColorWhenPressed : MonoBehaviour
{
    public Image duck;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    public void ChangeColor()
    {
        duck.color = Random.ColorHSV();
    }

    public void Rotate()
    {
        transform.eulerAngles = new Vector3(0, 0, (float)slider.value);
    }
}
