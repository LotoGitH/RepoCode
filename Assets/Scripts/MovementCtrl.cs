using UnityEngine;
using UnityEngine.InputSystem;

public class MovementCtrl : MonoBehaviour
{
    public InputActionAsset inputActionAsset;
    private InputActionMap _inputActionMap;
    private InputAction _move;
    public float speed = 10f;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputActionMap = inputActionAsset.FindActionMap("Player");
        _move = _inputActionMap.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        if (_move.IsPressed())
        {
            Vector2 joystickmove= _move.ReadValue<Vector2>();
            Vector3 realmovement = new Vector3(
                joystickmove.x * speed, 
                0, 
                joystickmove.y * speed);
            
            gameObject.transform.Translate(realmovement * Time.deltaTime);
        }
        
    }
}
