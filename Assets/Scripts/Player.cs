using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public enum State { Run, Jump, Slide, Hit, Die, Skill }
    public float startJumpPower;
    public bool isGround;
    public int JumpCount = 0;
    public int MaxJumpCount = 2;

    public UnityEvent onHit;
    Rigidbody2D rigid;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {   
    
        if(Input.GetKeyDown(KeyCode.Space) && (JumpCount < MaxJumpCount)) {
            JumpCount++;
            rigid.velocity = Vector2.zero;
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
            AnimatorChange(State.Jump);
            
        }
        
  
        if(Input.GetKey(KeyCode.DownArrow) && isGround) {
              AnimatorChange(State.Slide);
              
  
        }
        else if(Input.GetKeyUp(KeyCode.DownArrow)) {
              AnimatorChange(State.Run);
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
        GameManager.GameOver();
    }


}
