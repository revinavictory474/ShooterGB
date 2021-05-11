using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        //animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Animation();
    }

    private void Animation()
    {
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {         
            animator.SetBool("Walk_F", true);
        }

        else
        {
            animator.SetBool("Walk_F", false);
        }
        
    }
}
