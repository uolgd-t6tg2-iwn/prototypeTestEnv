using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float rotateSpeed;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxisRaw("Vertical");
        float turn = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(0,0,movement) * movementSpeed * Time.deltaTime);
        
        transform.Rotate(new Vector3(0,turn,0) *  rotateSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector3(0,1f, 0));
        }

    }
}
