using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PercentageSlider : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI percentage;

    public void setPercentage() {
        percentage.text = (slider.value * 100).ToString("0") + "%";
    }
}
