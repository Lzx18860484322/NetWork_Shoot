using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class AnimationController : NetworkBehaviour
    {

        Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            if (!isLocalPlayer)
                return;
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isLocalPlayer)
                return;
            if (GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_IsWalking)
            {
                anim.SetBool("IsWalking", true);
            }
        }

    }
}