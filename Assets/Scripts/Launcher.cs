using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 10;
    [Header("Prefabs")]
    [SerializeField] GameObject projectilePrefab;
    [Header("Helpers")]
    [SerializeField] Transform spawnTransform;

    public int maxAmmo;
    public int currAmmo;
    void Awake() {
        //Launch();
        currAmmo = 5;
        maxAmmo = 10;
    }
    public void Launch() {
        if (currAmmo < 1) {
            return;
        }
        GameObject projectile = Instantiate(projectilePrefab, spawnTransform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = transform.up * projectileSpeed;
    }

    public int GetCurAmmo() {
        return currAmmo;
    }

    public void RefillCurAmmo() {
        currAmmo = maxAmmo;
    }
}
