using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {


    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    [SerializeField] private RotationAxes axes = RotationAxes.MouseXAndY;

    [SerializeField] private float _sensitivityX = 5f;
    [SerializeField] private float _sensitivityY = 5f;
    [SerializeField] private float _minimumY = -60f;
    [SerializeField] private float _maximumY = 60f;

    private float _rotationY = 0f;

    void Start() {
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }

    void Update() {
        if (axes == RotationAxes.MouseXAndY) {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _sensitivityX;

            _rotationY += Input.GetAxis("Mouse Y") * _sensitivityY;
            _rotationY = Mathf.Clamp(_rotationY, _minimumY, _maximumY);

            transform.localEulerAngles = new Vector3(-_rotationY, rotationX, 0);
        } 
        
        else if (axes == RotationAxes.MouseX) {
            transform.Rotate(0, Input.GetAxis("Mouse X") * _sensitivityX, 0);
        } 
        
        else {
            _rotationY += Input.GetAxis("Mouse Y") * _sensitivityY;
            _rotationY = Mathf.Clamp(_rotationY, _minimumY, _maximumY);

            transform.localEulerAngles = new Vector3(-_rotationY, transform.localEulerAngles.y, 0);
        }
    }
}