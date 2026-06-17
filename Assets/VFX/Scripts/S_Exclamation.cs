using UnityEngine;

public class S_Exclamation : MonoBehaviour
{
    public GameObject vfxPrefab;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(vfxPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
