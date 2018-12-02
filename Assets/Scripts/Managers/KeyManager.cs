using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {

    private KeyCode[] _walkKeys = new KeyCode[] {
         KeyCode.W,
         KeyCode.A,
         KeyCode.S,
         KeyCode.D
     };

    private GameObject _player;

    private void Start() {
        _player = GameObject.Find("P_Body");
    }

    void Update () {
        foreach (KeyCode _keyInput in System.Enum.GetValues(typeof(KeyCode))) {
            if (Input.GetKey(_keyInput)) {
         // check if a button is pressed from the Walk Keys 
                for (int i = 0; i < _walkKeys.Length; i++) {
                    if (_keyInput == _walkKeys[i]) {
                        if (Input.GetKey(KeyCode.LeftShift)) {
                            _player.GetComponent<PlayerMovement>().Run();
                        } else {
                            _player.GetComponent<PlayerMovement>().Walk();
                        }
                    }
                }
            }
        }
        // (GameObject of choice).GetComponent<(Script of choice)>().(Function of choice)();
    }
}
