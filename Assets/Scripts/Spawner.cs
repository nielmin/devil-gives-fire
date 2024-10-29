using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1;
    [Header("Prefabs")]
    [SerializeField] GameObject monsterPrefab;
    [Header("Helpers")]
    [SerializeField] Transform monsterSpawnTransform;

    void Start() {
        Spawn();
    }
    public void Spawn() {
        GameObject projectile = Instantiate(monsterPrefab, monsterSpawnTransform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector3(projectileSpeed, 0, 0);
    }

}
