using UnityEditor;
using UnityEngine;

public class MainTower : MonoBehaviour
{
    public int health = 100;

    public void GetDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);

#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
        }
    }

}
