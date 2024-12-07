using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateChanger : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator monster;

    [SerializeField] string currentState = "Player_Idle";

    public void MonsterChangeAnimations(string newState) {
        if (currentState  == newState) {
            return;
        }

        currentState = newState;
            monster.Play(currentState);
    }

    public void ChangeAnimations(string newState, bool hasAttacked) {
        if (currentState  == newState) {
            return;
        }

        currentState = newState;
        if (hasAttacked) {
            animator.Play("Player_Fire");
        } else {
            animator.Play(currentState);
        }
    }
    void Start() {
        ChangeAnimations("Player_Idle", false);
        MonsterChangeAnimations("Monster_Walk");
    }
}
