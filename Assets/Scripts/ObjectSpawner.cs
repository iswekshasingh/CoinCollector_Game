using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject bombPrefab;

    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        Camera cam = Camera.main;

        float halfWidth = cam.orthographicSize * cam.aspect;

        float x = Random.Range(
            cam.transform.position.x - halfWidth + 0.5f,
            cam.transform.position.x + halfWidth - 0.5f
        );

        float y = cam.transform.position.y + cam.orthographicSize + 1f;

        GameObject prefab = Random.value < 0.7f
            ? coinPrefab
            : bombPrefab;

        Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}