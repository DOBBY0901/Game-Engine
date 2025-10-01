using UnityEditor.Build;
using UnityEngine;

public class Sensor : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Soar();
        }
       
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Revert();
        }
        
    }
   
}
