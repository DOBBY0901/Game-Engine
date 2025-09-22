using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float progress;
    [SerializeField] int Count;
    public void Sucess()
    {
        Debug.Log("Creat...");
    }
    
    public void Process(float progress)
    {

        this.progress += progress;

        Debug.Log("Progress : " + this.progress + "%");

        this.progress = this.progress % 100;
    }

    public void Enhance(int count)
    {
        this.Count += count;

        Debug.Log("Enhance Count : " + this.Count);
    }

}
