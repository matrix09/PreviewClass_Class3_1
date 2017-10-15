using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    Animator am;

    void Start()
    {
        am = GetComponent<Animator>();
    }

    float speed = 0f;
    public void Update()
    {
        Move();
    }

    void Move()
    {
        float he = Input.GetAxis("Horizontal");

        float ve = Input.GetAxis("Vertical");

        Quaternion dir = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);

        Vector3 right = dir * Vector3.right;

        Vector3 forward = dir * Vector3.forward;

        Vector3 mov = ve * forward + he * right;

        speed = 0f;

        if (mov != Vector3.zero)
        {
            transform.forward = mov;
            transform.forward = Vector3.Lerp(transform.forward, mov, 5 * Time.deltaTime);
            transform.Translate(Vector3.forward * 5f * Time.deltaTime);
            //transform.Translate(transform.forward * 5f * Time.deltaTime, Space.World);
            speed = 1f;
        }

        am.SetFloat("Speed", speed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            Destroy(other.gameObject);
        }
    }


}
