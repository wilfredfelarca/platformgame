using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");

        //Debug.Log($"xMovement is {xMovement}, yMovement is {yMovement}");
        Vector3 movementVector = new Vector3(xMovement, yMovement, 0);
        transform.position += movementVector * movementSpeed * Time.deltaTime;
    }
}
