using UnityEngine;

public class enemyattack : attack
{
    [SerializeField]
    private float shootInterval = 3.0f;

    [SerializeField]
    private float shootDelay = 3.0f;


    private void Start()
    {

            // spawn a bullet
            InvokeRepeating("ShootBullet", shootDelay, shootInterval);
        
    }
}
