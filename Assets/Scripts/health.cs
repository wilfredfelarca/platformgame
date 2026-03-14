using UnityEngine;

public class health : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if(collision.gameObject.TryGetComponent<bullet>(out bullet bulletComponent))
        {
            Destroy(bulletComponent.gameObject);
            Destroy(this.gameObject);
        }
    }

}
