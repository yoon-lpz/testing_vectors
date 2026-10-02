using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour, InputSystem_Actions.IVectorsClassActions
{
    private InputSystem_Actions inputActions;
    public void Awake() { 
        inputActions = new InputSystem_Actions();
        inputActions.VectorsClass.SetCallbacks(this);
    }

    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();

    public void OnJump(InputAction.CallbackContext context) {
        if (context.performed) Debug.Log("SALTO");
    }
}