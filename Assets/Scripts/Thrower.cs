using UnityEngine;
using UnityEngine.InputSystem;

public class Thrower : MonoBehaviour {
    public Transform diePrefab;

    private void Update() {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) {
            Instantiate(diePrefab);
            
        }
    }
}
