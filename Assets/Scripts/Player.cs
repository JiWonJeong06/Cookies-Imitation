using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public float startJumpPower;
    public float JumpPower;
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
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            rigid.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
        }
    }




}
