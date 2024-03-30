using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum State { Run, Jump, Slide, Hit, Die, Skill }
    public float startJumpPower;
    public bool isGround;
    public int JumpCount = 0;
    public int MaxJumpCount = 1;
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
        //점프
        if(Input.GetKeyDown(KeyCode.Space) && (JumpCount < MaxJumpCount)) {
            rigid.velocity = Vector2.zero;
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
            AnimatorChange(State.Jump);
            JumpCount++;
        }
        
        //슬라이드
        if(Input.GetKey(KeyCode.DownArrow) && isGround) {
              AnimatorChange(State.Slide);
              
              if(Input.GetKeyDown(KeyCode.Space) && (JumpCount < MaxJumpCount)) {
                rigid.velocity = Vector2.zero;
                rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
                AnimatorChange(State.Jump);
                JumpCount++;
        }
        }
        else if(Input.GetKeyUp(KeyCode.DownArrow)) {
              AnimatorChange(State.Run);
        }
    }
    //땅에 닿았을 때 다시 달리는 모션
    void OnCollisionStay2D(Collision2D collision) {
        
        if(!isGround) {
        AnimatorChange(State.Run); 
        }
        isGround = true;
        JumpCount = 0;
    }  
    // 점프 모션으로 변환
    void OnCollisionExit2D(Collision2D collision) {
        AnimatorChange(State.Jump);
        isGround = false;
    }

    //애니메이션 변경 함수
    void AnimatorChange(State state) {
       animator.SetInteger("State", (int)state);
    }



}
