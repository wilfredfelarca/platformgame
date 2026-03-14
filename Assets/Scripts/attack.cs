using UnityEngine;

public class attack : MonoBehaviour
{

    [SerializeField]
    private GameObject bulletPrefab;


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    protected void ShootBullet()
    {
        // spawn a bullet
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
