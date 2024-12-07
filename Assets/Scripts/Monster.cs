using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] AnimationStateChanger changer;
    [SerializeField] SpriteRenderer monster;
    [SerializeField] GameObject potionPrefab;


    public int facing;
    public float distance;

    public float distBetween = 4;
    public float speed = 2;

    public bool hasDead;
    void Awake()
    {
        hasDead = false;
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if (player.transform.position.x > transform.position.x) {
            facing = -1;
        } else {
            facing = 1;
        }
        if (distance < distBetween) {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            changer.MonsterChangeAnimations("Monster_Walk");

        } else if (hasDead) {
            changer.MonsterChangeAnimations("Monster_Dies");

        } else {
            changer.MonsterChangeAnimations("Monster_Idle");

        }
        monster.flipX = facing == -1;


    }
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Flame")) {
            hasDead = true;
            Destroy(other.gameObject);
            GameObject potion = Instantiate(potionPrefab, transform.position, Quaternion.identity);

            transform.position = new Vector3(1000,1000,transform.position.z);
            Destroy(this.gameObject, 5f);
        }

    }
}
