using UnityEngine;

public class regBullets : BulletScript
{
    protected override void Fire()
    {
        body.AddForce(transform.forward * speed, ForceMode.Force);
    }
}
