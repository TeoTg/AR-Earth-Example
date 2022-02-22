using System.Collections;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyRocket());
    }

    private IEnumerator DestroyRocket()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
