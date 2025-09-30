using UnityEditor.Build;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌 시작!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌 끝!");
    }
}
