using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RonaldoController : MonoBehaviour
{
    Animator anim;
    public float speed = 2.0f;
    public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) ||
            Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Caminar", false);
            anim.SetBool("CaminarAtras", false);
        }
            

        if (Input.GetKey(KeyCode.UpArrow) )
        {
            anim.SetBool("Caminar", true);
            transform.Translate(0, 0, translation);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("CaminarAtras", true);
            transform.Translate(0, 0, translation);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Caminar", true);
            transform.Rotate(0, rotation, 0);
        }
    }
}
