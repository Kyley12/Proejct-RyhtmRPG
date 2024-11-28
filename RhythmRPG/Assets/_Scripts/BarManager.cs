using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public Stats stats;
    public string currentStatName;
    private float currentStatMaxValue;
    private Image barImage;


    private void Awake()
    {
        barImage = transform.Find("bar").GetComponent<Image>();
        
        currentStatMaxValue = stats.GetStats(currentStatName).maxValue;

        SetHealth(currentStatMaxValue / currentStatMaxValue);
    }

    private void Update()
    {
        SetHealth(stats.GetStats(currentStatName).value / currentStatMaxValue);
    }

    private void SetHealth(float valueNormalized)
    {
        barImage.fillAmount = valueNormalized;
    }
}
