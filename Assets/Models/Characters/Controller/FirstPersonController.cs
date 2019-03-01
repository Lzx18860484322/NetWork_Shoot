using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class FirstPersonController : NetworkBehaviour
{

    Animator anim;

    private Rigidbody rig;   //刚体

    private float jumpForce;  //跳跃的力

    public float move_spend = 10f;

    private float move; //水平移动速度（左 或 右）

    private float horizontal;  //水平偏移量

    public GameObject playerCamera;

    // private void Awake()
    // {
    //     playerCamera.SetActive(true);
    // }
    public FirstPersonController(Animator anim)
    {
        this.anim = anim;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * move_spend;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * move_spend;
        // transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
    }

    private void FixedUpdate()
    {



    }

    //
    //PlayerController Class
    //




    /// <summary>
    /// 这个方法只会在本地角色那里调用，当角色被创建的时候就被调用
    /// </summary>
    public override void OnStartLocalPlayer()
    {
        playerCamera.SetActive(true);       //激活自己的相机
        transform.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // void startAn(float x,float y)
    // {
    //     anim.SetFloat("a", true));
    // }

}
