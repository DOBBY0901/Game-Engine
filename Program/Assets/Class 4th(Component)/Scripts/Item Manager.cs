using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class ItemManager : MonoBehaviour
{
    
    [SerializeField] Item [ ] items;
    private int currentIndex = -1;
    void Start()
    {
        Initilize();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            SwitchItem();
       
        }

    }

    void Initilize()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(false);
        }
    }

    void SwitchItem()
    {
        if (currentIndex >= 0 && currentIndex < items.Length)
        {
            items[currentIndex].gameObject.SetActive(false);
        }

        currentIndex = (currentIndex + 1) % items.Length;   
           
        if (items[currentIndex] != null )
        {
            items[currentIndex].gameObject.SetActive(true);
            
        }
    }
}
