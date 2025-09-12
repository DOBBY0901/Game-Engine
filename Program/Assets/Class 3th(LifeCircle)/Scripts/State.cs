using Unity.VisualScripting;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        //Awake : ��ü�� ������ �� �� 1�� ȣ��. , ��ü�� ��Ȱ��ȭ�Ǿ� ���� ������ ȣ��
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        //Start : ��ü�� �����Ǿ��� �� ȣ��, �� 1���� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        //FixedUpdate : timestep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        //Update : ��ü�� Ȱ��ȭ �Ǿ��� ��, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        //LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        //OnDisable : ��ü�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy : ��ü�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDestroy");
    }
}
