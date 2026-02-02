using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image sImage; //the image component reference
    public int howManyClicks = 0;
    public TextMeshProUGUI score; //the text component reference
    public Slider slider;
    public TextMeshProUGUI sliderValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        slider.wholeNumbers = true;
        slider.minValue = -3f;
        slider.maxValue = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue.text = slider.value.ToString();

        if (Keyboard.current.anyKey.wasPressedThisFrame == true){

            ChangeColour();
        }

    }

    public void ChangeColour()
    {
        sr.color = Random.ColorHSV();
        sImage.color = sr.color;
    }

    public void ScaleBig(float scaleAmount)
    {
        transform.localScale = Vector3.one * scaleAmount;
    }

    public void CountClicks()
    {
        howManyClicks++;
        score.text = howManyClicks.ToString();
        Debug.Log("Button clicked " + howManyClicks + " times.");
    }
}
