using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 10f;

    [Header("Prefabs")]

    [SerializeField] GameObject projectilePrefab;
    [Header("Helpers")]
    [SerializeField] Transform projectileSpawn;

    public int maxAmmo;
    public int currAmmo;

    void Update() {

    }
    void Awake() {
        //Launch();
        currAmmo = 10;
        maxAmmo = 10;
    }
    public void Launch(int direction) {
        if (currAmmo < 1) {
            return;
        }
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawn.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = (direction * transform.right * projectileSpeed);
        Destroy(projectile, 3f);
    }
 
    public int Subtract() {
        return currAmmo--;
    }
    public int GetCurAmmo() {
        return currAmmo;
    }
    public int GetMaxAmmo() {
        return currAmmo;
    }
    public void RefillCurAmmo() {
        currAmmo = maxAmmo;
    }

    public AudioClip GetAudioClip() {
        return GetComponent<AudioSource>().clip;
    }
}
