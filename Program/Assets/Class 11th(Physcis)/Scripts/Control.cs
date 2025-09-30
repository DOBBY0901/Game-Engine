using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Control : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] float Bounce;
    [SerializeField] Rigidbody rb;
    
    Vector3 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
      
        float ad = Input.GetAxisRaw("Horizontal");
        float ws = Input.GetAxisRaw("Vertical");

        direction = new Vector3(ad,0, ws);

    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * movespeed, ForceMode.Force);
    }
}
