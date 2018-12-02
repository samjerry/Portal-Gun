using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCam : MonoBehaviour {

    [SerializeField] private Transform _playerCam;
    [SerializeField] private Transform _portal;
    [SerializeField] private Transform _otherPortal;

    private Vector3 _pos;

    private void Start() {
        _playerCam = GameObject.Find("Main Camera").transform;

        if (this.name == "PortalCam1") {
            _portal = GameObject.Find("Portal 1").transform;
            _otherPortal = GameObject.Find("Portal 2").transform;
        } else {
            _portal = GameObject.Find("Portal 2").transform;
            _otherPortal = GameObject.Find("Portal 1").transform;
        }
    }
    
    void Update() {
        Vector3 _playerPortalOffset = _playerCam.position - _otherPortal.position;
        transform.position = _portal.position + _playerPortalOffset;

        float _angleBetweenPortals = Quaternion.Angle(_portal.rotation, _otherPortal.rotation);

        Quaternion _portalRotation = Quaternion.AngleAxis(_angleBetweenPortals, Vector3.up);
        Vector3 _newCameraDir = _portalRotation * _playerCam.forward;
        transform.rotation = Quaternion.LookRotation(_newCameraDir, Vector3.up);
    }
}