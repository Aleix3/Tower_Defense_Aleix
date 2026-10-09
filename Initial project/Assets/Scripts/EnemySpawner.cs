using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;
    private float timeCounter = 0;
    public Transform target;

    void Update()
    {
        if (timeCounter > spawnRate)
        {
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.transform.position = this.transform.position;
            newEnemy.GetComponent<EnemyMovement>().target = target;
            timeCounter = 0;
        }
        else
        {
            timeCounter += Time.deltaTime;
        }


    }
}
