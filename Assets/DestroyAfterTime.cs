using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private float timeAlive = 0f;
    public float maxTimeAlive = 5f;

    void Update()
    {
        timeAlive += Time.deltaTime;

        if (timeAlive >= maxTimeAlive)
        {
            Debug.Log(gameObject.name + " destroyed!");
            Destroy(gameObject);
        }
    }
}
