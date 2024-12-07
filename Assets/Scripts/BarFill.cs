using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarFill : MonoBehaviour
{
    public int maxValue;
    public Image fill;

    private int currentValue;
    // Start is called before the first frame update
    void Awake()
    {
        currentValue = maxValue;
        fill.fillAmount = 1;
    }

    public void Add(int i) {

        currentValue += i;

        if (currentValue > maxValue) {
            currentValue = maxValue;
        }

        fill.fillAmount = (float) currentValue/maxValue;
    }

    public void Subtract(int i) {
        currentValue -= i;

        if (currentValue < 0) {
            currentValue = 0;
        }
        fill.fillAmount = (float) currentValue/maxValue;

    }

    public void Reset() {
        currentValue = 0;
    }
    public void SetCurrent(int i) {
        currentValue = i;
        fill.fillAmount = (float) currentValue/maxValue;

    }
}
