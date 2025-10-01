using UnityEngine;

public class Perceive : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Debug.Log("OnCollisionEnter");
    }
    void OnCollisionStay()
    {
        Debug.Log("OnCollisionStay");
    }
    void OnCollisionExit()
    {
        Debug.Log("OnCollisionExit");
    }
}
