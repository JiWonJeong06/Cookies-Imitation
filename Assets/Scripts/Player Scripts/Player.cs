using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public enum State { Run, Jump, Slide, Die }
    public float startJumpPower;
    public bool isGround;
    public int JumpCount = 0;
    public int MaxJumpCount = 2;

    public UnityEvent onHit;
    Rigidbody2D rigid;
    Animator animator;
    Sound sound;

    public string JumpKey;
    public string SlideKey;
    CapsuleCollider2D  CapCollider;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sound = GetComponent<Sound>();
        CapCollider =  GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {   
        
        if (!GameManager.Gamestart) 
            return;
        
 
        if(Input.GetKeyDown(KeyCode.Space)  && (JumpCount < MaxJumpCount)) {
            CapCollider.offset = new Vector2(0f, 0.5f);
            CapCollider.size = new Vector2(0.7f, 1f); 
            JumpCount++;
            rigid.velocity = Vector2.zero;
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
            sound.PlaySound(Sound.Sfx.Jump);
            AnimatorChange(State.Jump);
        }
        
    }

    void OnCollisionStay2D(Collision2D collision) {
        

        if(!isGround) {
        AnimatorChange(State.Run);
        JumpCount = 0;
        }
        isGround = true;
    }  

    void OnCollisionExit2D(Collision2D collision) {
        AnimatorChange(State.Jump);
        isGround = false;
    }

    void AnimatorChange(State state) {
       animator.SetInteger("State", (int)state);
    }

    //game end
    void OnTriggerEnter2D(){
        rigid.simulated = false;
        AnimatorChange(State.Die);
        onHit.Invoke();
    }


}
