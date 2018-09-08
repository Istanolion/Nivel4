using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour {

    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButton("A")){
            anim.SetBool("Running", true);
        }
        else anim.SetBool("Running", false);
        if (Input.GetAxis("Fire") < 0)
        {
            anim.SetBool("Shooting", true);
        }
        else anim.SetBool("Shooting", false);
        if (Input.GetButtonDown ("Death"))
        {
            anim.SetTrigger("Death");
        }
    }
}
