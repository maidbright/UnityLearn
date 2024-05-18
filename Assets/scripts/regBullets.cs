using UnityEngine;

public class regBullets : BulletScript
{
    protected override void Fire()
    {
        Vector3 direction = (gameObject.transform.position - transform.position).normalized;
        body.AddForce(direction * speed, ForceMode.Impulse);
    }
}
