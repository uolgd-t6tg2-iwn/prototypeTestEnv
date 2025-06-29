using UnityEngine;

public class bulletCollision : MonoBehaviour
{

[SerializeField]
 private GameObject plswork;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            ContactPoint contact = collision.contacts[0];

            Destroy(collision.gameObject);

            GameObject wallbreak = Instantiate(plswork, transform.position, transform.rotation);

            Rigidbody rb = wallbreak.GetComponent<Rigidbody>();
            
            rb.AddExplosionForce(100f, contact.point, 5f);
           
        }
    }
}
