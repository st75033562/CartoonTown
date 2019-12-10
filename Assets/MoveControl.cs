using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour {

    public Transform rotaeTransform;
    public Animator animator;
    private CharacterController cc;

    private float speed = 3;
    private float rotateSpeed = 50;

    void Start()
    {
        cc = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (ETCInput.GetAxis("Vertical") != 0)
        {
            animator.ResetTrigger("idle");
            animator.SetTrigger("walk");
        }

        if (ETCInput.GetAxis("Vertical") == 0 && ETCInput.GetAxis("Horizontal") == 0)
        {
            animator.ResetTrigger("walk");
            animator.SetTrigger("idle");
        }

        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    character.Move(-transform.forward * speed * Time.deltaTime);
        //    animator.ResetTrigger("idle");
        //    animator.SetTrigger("walk");
        //}
        //else
        //{
        //    animator.ResetTrigger("walk");
        //    animator.SetTrigger("idle");
        //}

        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        //    animator.ResetTrigger("walk");
        //    animator.SetTrigger("idle");
        //}
        //else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        //    animator.ResetTrigger("walk");
        //    animator.SetTrigger("idle");
        //}
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "box")
        {
            Destroy(collision.gameObject);
        }
    }
}
