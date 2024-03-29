using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public float startJumpPower;
    public float JumpPower;
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
        if(Input.GetKeyDown(KeyCode.Space)) {
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)) {
              Debug.Log("슬라이드 하는 중");
        }
    }




}
