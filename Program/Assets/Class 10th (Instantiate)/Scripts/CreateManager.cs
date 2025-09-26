using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float time;
    [SerializeField] int coroutincount;

    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> list;
   
    void Start()
    {
       
        Create();
       
        StartCoroutine(Coroutine());

    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= 5f )
        {
            Debug.Log("5√ ");

            time = 0f;
        }
    }

    void Create()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, transform);
            
            clone.SetActive(false);
           
            list.Add(clone);
        }
    }

    IEnumerator Coroutine()
    {
        while (coroutincount < list.Count)
        {
            int index = Random.Range(0, list.Count);
            
            yield return new WaitForSeconds(5f);
           
            if (list[index].activeSelf)
            {
              index = (index + 1) % list.Count;
            }

            list[index].SetActive(true);

            coroutincount++;
        }
    }
}
