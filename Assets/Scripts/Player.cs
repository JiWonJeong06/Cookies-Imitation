using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum State { Run, Jump, Slide, Hit, Die, Skill }
    public float startJumpPower;
    public float SlidePower;
    public bool isGround;

    Rigidbody2D rigid;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        //점프
        if(Input.GetKeyDown(KeyCode.Space) && isGround) {
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
            AnimatorChange(State.Jump);
        }
        
        //슬라이드
        if(Input.GetKeyDown(KeyCode.DownArrow)) {
              AnimatorChange(State.Slide);
        }
        
    }
    
    void OnCollisionStay2D(Collision2D collision) {
        
        if(!isGround) {
        AnimatorChange(State.Run); 
        }
       
        isGround = true;
    }   
    void OnCollisionExit2D(Collision2D collision) {
        AnimatorChange(State.Jump);
        isGround = false;
    }
    //애니메이션 변경
    void AnimatorChange(State state) {
       animator.SetInteger("State", (int)state);
    }



}
