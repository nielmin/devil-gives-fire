using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{

    [SerializeField] PlayerInput playerInput;
    [SerializeField] TextMeshProUGUI ammoCnt;
    void Start()
    {
        // Debug.Log(playerInput.GetPlayer().GetCurAmmo());
    }

    // Update is called once per frame
    void Update()
    {
        int ammo = playerInput.GetPlayer().GetLauncher().GetCurAmmo();
        ammoCnt.text = ammo.ToString();
    }
}
