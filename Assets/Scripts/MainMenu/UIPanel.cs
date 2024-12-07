using UnityEngine;
using UnityEngine.UI;
public class UIPanel : MonoBehaviour
{

    [SerializeField] bool closeByDefault = true;

    void Awake() {
        if(closeByDefault) {
            CloseMenu();
        }
    }
    public void OpenMenu() {
        GetComponent<Canvas>().enabled = true;
    }

    public void CloseMenu() {
        GetComponent<Canvas>().enabled = false;

    }
}
