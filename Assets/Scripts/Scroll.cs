using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//화면 스크롤
public class Scroll : MonoBehaviour
{
    public int Count;
    public float Scrollspeed;
    // Start is called before the first frame update
    void Start()
    {
        Count = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Scrollspeed * Time.deltaTime * -1f, 0, 0);
    }
}
