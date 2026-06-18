using UnityEngine;

public class DupeMashine : MonoBehaviour
{
    public PotionSpawner Spawner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>());
        {
            Spawner.Spawn(other.gameObject);

        }

    }

}
