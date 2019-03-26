using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    public Animator animator;
    public float StartAnimation;
    public AudioSource _audio;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        animator.SetFloat("myfloat", StartAnimation);
        if(animator.GetBool("ON"))
        {

        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            animator.SetBool("ON", true);
            _audio.Play();
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("ON", false);
        }   
    }
}
