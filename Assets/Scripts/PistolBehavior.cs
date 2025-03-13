using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;     
    public float shootForce = 20f;

    public void ShootLaser()
    {
        if (laserTemplate != null && spawnPoint != null)
        {
            GameObject laser = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);

            Rigidbody rb = laser.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(spawnPoint.forward * shootForce, ForceMode.Impulse);
            }

            Destroy(laser, 5f);
        }
    }
}
