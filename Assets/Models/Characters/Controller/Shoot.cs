using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //申请GameObject变量用来承载预制体（拖动预制体赋值）
    public GameObject bullet;

    //申请float变量设置推动力大小
    public float thrust = 2000.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        CheckShoot();
    }


    //检测开火函数
    void CheckShoot()
    {
        //是否输入了“Fire1”（默认鼠标左键和左Ctrl键）
        if (Input.GetButtonDown("Fire1"))
        {
            //实例化一个bullet的克隆体。
            GameObject clone = Instantiate(bullet, transform.position, transform.rotation)as GameObject;

            //获取克隆体的刚体组件。
            Rigidbody rb = clone.GetComponent<Rigidbody>();

            //给克隆体的刚体组件一个推动力。
            rb.AddForce(clone.transform.forward * thrust);
        }

    }
}