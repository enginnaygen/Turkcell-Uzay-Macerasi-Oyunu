using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }


    public void SliderValue(int maxValue, int currentValue)
    {
        int sliderFill = maxValue - currentValue;
        slider.maxValue = maxValue;
        slider.value = sliderFill;

    }
}
