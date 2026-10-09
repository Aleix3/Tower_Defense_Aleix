using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 100;

    private Renderer renderer;
    private Color originalColor;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        renderer.material = new Material(renderer.material);

        originalColor = renderer.material.color;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        StartCoroutine(FlashRed());

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator FlashRed()
    {
        renderer.material.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        renderer.material.color = originalColor;
    }
}
