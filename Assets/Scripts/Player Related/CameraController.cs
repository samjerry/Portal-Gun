using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    [SerializeField] private GameObject _target;

    private Vector3 offset;

    void Start() {
        offset = transform.position - _target.transform.position;
    }

    void LateUpdate() {
        transform.position = _target.transform.position + offset;
    }
}