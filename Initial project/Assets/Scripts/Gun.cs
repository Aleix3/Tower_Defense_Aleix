using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damage = 25;
    public int range = 100;
    public float fireRate = 0.2f;

    public Transform fpsCamera;

    private float nextTimeToShoot = 0f;

    void Update()
    {
      if(Input.GetMouseButton(0) && Time.time >= nextTimeToShoot)
        {
            nextTimeToShoot = Time.time + fireRate;
            shoot();
        }
    }

    void shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
