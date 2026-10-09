using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position; 

        transform.position += direction.normalized * speed * Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(direction);


    }
}
