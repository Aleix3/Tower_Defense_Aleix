using UnityEngine;

public class BasicTurret : MonoBehaviour
{
    public int damage = 10;
    public float range = 20;
    public float fireRate = 1f;
    private float counter = 0f;
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter <= 0f)
        {
            GameObject target = null;

            float minDistance = range;

            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    target = enemy;
                }
            }

            if (target == null)
            {
                return;
            }

            Vector3 direction = (target.transform.position - transform.position).normalized;

            if (Physics.Raycast(transform.position, direction, out RaycastHit hit, range))
            {
                if (hit.transform == target.transform)
                {
                    target.GetComponent<Target>().TakeDamage(damage);
                    counter = fireRate;
                }
            }

        }

        
    }
}
