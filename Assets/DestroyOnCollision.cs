using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public bool destroyWithAnyObject = false;
    public string collisionTag = "Laser";

    void OnCollisionEnter(Collision collision)
    {
        if (destroyWithAnyObject)
        {
            Destroy(gameObject);
        }
        else if (!string.IsNullOrEmpty(collisionTag) && collision.gameObject.CompareTag(collisionTag))
        {
            Destroy(gameObject);
        }
    }
}
