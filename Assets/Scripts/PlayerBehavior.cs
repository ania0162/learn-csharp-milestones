using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //1.1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    //2.1
    private float _vInput;
    private float _hInput;

    //1.2
    private Rigidbody _rb;

   
    // Start is called before the first frame update
    void Start()
    {
        //2.2
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //3.1
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;

        //4.1
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        //4.2
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);

        //5.2
        _rb.MoveRotation(_rb.rotation * angleRot);

    /*
        //5.1
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);

        //6.1
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
    */
    }
}
