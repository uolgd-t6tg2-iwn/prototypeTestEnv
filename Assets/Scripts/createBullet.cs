using UnityEngine;

public class createBullet : MonoBehaviour
{   
    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
           Instantiate(bullet, transform.position, transform.rotation); 
        }
    }
}
