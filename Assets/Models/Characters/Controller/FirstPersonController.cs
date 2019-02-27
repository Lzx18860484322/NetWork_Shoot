using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{

    Animator anim;

    private Rigidbody rig;   //刚体

    private float jumpForce;  //跳跃的力

    public float move_spend = 10f;

    private float move; //水平移动速度（左 或 右）

    private float horizontal;  //水平偏移量
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * move_spend;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * move_spend;
        // transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
    }

    private void FixedUpdate()
    {
      
    }
    // void startAn(float x,float y)
    // {
    //     anim.SetFloat("a", true));
    // }

}
