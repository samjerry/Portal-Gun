using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPortalTex : MonoBehaviour {

    [SerializeField] private Camera _cameraA;
    [SerializeField] private Camera _cameraB;

    [SerializeField] private Material _cameraMatA;
    [SerializeField] private Material _cameraMatB;

    // Use this for initialization
    void Start() {
        if (_cameraA.targetTexture != null) {
            _cameraA.targetTexture.Release();
        }
        _cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        _cameraMatA.mainTexture = _cameraA.targetTexture;

        if (_cameraB.targetTexture != null) {
            _cameraB.targetTexture.Release();
        }
        _cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        _cameraMatB.mainTexture = _cameraB.targetTexture;
    }

}