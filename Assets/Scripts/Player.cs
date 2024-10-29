using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    [SerializeField] Launcher launcher;
    [Header("Trackers")]
    [SerializeField] Transform targetTransform;

    void Start()
    {
        //stamina.SetStamina(currentStamina);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentStamina);
        // AimGun(targetTransform);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Spawn")) {
            //Debug.Log("Spawn");
        }
    }

    public void Shoot() {
        launcher.Launch();
    }
    public void AimGun(Vector3 aimPos) {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, aimPos - transform.position);
    }
    public void AimGun(Transform targetTransform) {
        AimGun(targetTransform.position);
    }

    public Launcher GetLauncher() {
        return launcher;
    }
}
