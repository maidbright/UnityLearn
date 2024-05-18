using UnityEngine;

public class grebBullets : BulletScript
{
    // Start is called before the first frame update
    protected override void Fire()
    {
        body.AddExplosionForce(50.0f, gameObject.transform.position, 15.0f);
    }
}
