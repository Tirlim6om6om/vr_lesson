using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Run", false);
        }
    }
}
