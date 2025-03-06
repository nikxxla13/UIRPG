using UnityEngine;

public class Character : MonoBehaviour
{
    
    public int health;

    public void Shout()

    {
        Debug.Log("I AM " + name.ToUpper());
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
