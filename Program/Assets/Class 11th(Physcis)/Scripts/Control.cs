using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Control : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] Rigidbody rb;
    
    [SerializeField] ForceMode forceMode;
    [SerializeField] Vector3 direction;

    private void Awake()
    {
        forceMode = ForceMode.Force;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
      
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * movespeed,forceMode);
    }

    public void Soar()
    {
        movespeed= 0.5f;
        
        direction = Vector3.up;

        forceMode = ForceMode.Impulse;
    }
    
    public void Revert()
    {
        movespeed = 5.0f;
    
        direction = Vector3.zero;
       
        forceMode = ForceMode.Force;
    }
}
