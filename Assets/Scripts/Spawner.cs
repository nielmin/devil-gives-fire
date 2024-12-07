using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] GameObject monsterPrefab;

    [Header("Helpers")]
    [SerializeField] Transform monsterSpawnTransform;

    void Start() {
        Spawn();
    }
    public void Spawn() {
        GameObject projectile = Instantiate(monsterPrefab, monsterSpawnTransform.position, Quaternion.identity);
    }

}
