using Unity.VisualScripting;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    void Start()
    {
       
    }

   
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        //Time.deltatime
        //���� ������ �Ϸ�������� ���� �������� ���۵Ǳ���� ���� �ð��� ��ȯ
        
        transform.position = transform.position + direction * speed * Time.deltaTime;
        

    }
}
