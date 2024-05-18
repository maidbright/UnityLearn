using UnityEngine;

public class tenBullets : BulletScript
{

    protected override void Fire()
    {
        body.AddForce(-transform.up * speed);
    }
}
