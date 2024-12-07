using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] DiscreteMovement controls;
    [SerializeField] Player p;
    [SerializeField] SpriteRenderer pSprite;
    [SerializeField] AnimationStateChanger changer;

    [SerializeField] Launcher wand;

    [SerializeField] BarFill mp;
    [SerializeField] AudioSource audioSource;


    public int direction = 0;

    void Start()
    {
        mp.SetCurrent(wand.GetMaxAmmo());
    }


    void Update() {
        if (p.PlayerHasBeenHit()) {
            changer.ChangeAnimations("Player_Dies", false);
            Debug.Log("Game Over");
        }
    }
    void FixedUpdate() {
        Vector3 movement = Vector3.zero;

        mp.SetCurrent(wand.GetCurAmmo());
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) 
        || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            changer.ChangeAnimations("Player_Walk", false);

        } else if (Input.GetKey(KeyCode.Z)) {
            changer.ChangeAnimations("Player_Fire", true);
            wand.Launch(direction);
            audioSource.PlayOneShot(audioSource.clip);

            if (wand.GetCurAmmo() > 0) {
                mp.Subtract(1);
                wand.Subtract();
            }

        } else if (!p.PlayerHasBeenHit()) {
            changer.ChangeAnimations("Player_Idle", false);
        }
 
        if (Input.GetKey(KeyCode.UpArrow)) {
            movement += Vector3.up;

        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            movement += Vector3.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            movement += Vector3.left; 
            direction = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            movement += Vector3.right;
            direction = 1;
   
        }    
        pSprite.flipX = direction == -1;
        if (movement != Vector3.zero) {
            movement.Normalize();
        }

        controls.Movement(movement);
        mp.SetCurrent(wand.currAmmo);
    }

    public Player GetPlayer() {
        return p;
    }

}
