using UnityEngine;

public class enemybullet : MonoBehaviour
{
    [SerializeField]
    private float speed = -3.0f;
    [SerializeField]
    private float lifetime = 5.0f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0, speed);

        //destroy after lifetime

        Destroy(this.gameObject, lifetime);
    }
}
