using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves and rotates player
/// </summary>

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private int _speed = 5;
    [SerializeField] private int _jumpHeight = 7;

    [SerializeField] private bool _isGrounded = true;

    private Vector3 _velocity;

    private Rigidbody _rb;

    void Start() {
        _rb = GetComponent<Rigidbody>();
    }
        
    public void Walk() {

        if (Input.GetKey(KeyCode.W)) {
            _rb.MovePosition (transform.position + Camera.main.transform.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
            _rb.MovePosition (transform.position + -Camera.main.transform.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            _rb.MovePosition (transform.position + -Camera.main.transform.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            _rb.MovePosition (transform.position + Camera.main.transform.right * _speed * Time.deltaTime);
        }

       // Vector3 dirVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
       // _rb.MovePosition(transform.position + dirVector * _speed * Time.deltaTime);
    }

    public void Run() {

        if (Input.GetKey(KeyCode.W)) {
            _rb.MovePosition(transform.position + Camera.main.transform.forward * _speed * 1.5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
            _rb.MovePosition(transform.position + -Camera.main.transform.right * _speed * 1.5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            _rb.MovePosition(transform.position + -Camera.main.transform.forward * _speed * 1.5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            _rb.MovePosition(transform.position + Camera.main.transform.right * _speed * 1.5f * Time.deltaTime);
        }
        
        //Vector3 dirVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //_rb.MovePosition(transform.position + dirVector * _speed * 1.5f * Time.deltaTime);
    }
}