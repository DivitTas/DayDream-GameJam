using JetBrains.Annotations;
using UnityEditor.Rendering;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public Rigidbody rb;
    int jumpCounter = 0;
    bool enableSuperJump;
    bool enableDash;
   

    bool jumpQueued;

    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { 
    
        rb = GetComponent<Rigidbody>();
        enableSuperJump = true;


    }
    public bool IsDashing()=> enableDash;
    public bool IsSuperJumping()=> enableSuperJump;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && time > 1f)
        {
            jumpQueued = true;
        }
    }
    private void FixedUpdate()
    {
        
        if (jumpQueued && IsSuperJumping())
        {
            rb.AddForce(Vector3.up * 10f, ForceMode.VelocityChange);
            time = 0f;
            jumpQueued = false;
        }

        time += Time.fixedDeltaTime;

    }
}
