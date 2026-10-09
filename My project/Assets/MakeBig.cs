using UnityEngine;
using UnityEngine.InputSystem;

public class MakeBig : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform originalTransf;
    void Start()
    {
        originalTransf = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            MakeBigger();
        }
    }

    public void MakeBigger()
    {
        transform.localScale *= 1.2f;
    }
}
