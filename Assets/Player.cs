using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public InputSystem_Actions action;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb  = GetComponent<Rigidbody>();
        action = new InputSystem_Actions();
        action.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        action.Disable();
    }
    private void OnEnable()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 movDir = Move();
        rb.AddForce(movDir*10, ForceMode.VelocityChange);
        if(rb.linearVelocity.magnitude > 5f)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * 5f;
        }
    }
    public Vector3 Move()
    {
        Vector2 inutVector = action.Player.Move.ReadValue<Vector2>(); 
        Vector3 movDir = new Vector3(inutVector.x, 0, inutVector.y);
        return movDir;


    }
}
