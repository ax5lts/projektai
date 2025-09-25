using System.Collections;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnRate = 2f;
    public float spawnX = 2.5f;
    public float minY = -2f, maxY = 2f;

    void Start()
    {
        StartCoroutine(SpawnPlatforms());
    }

    IEnumerator SpawnPlatforms()
    {
        yield return new WaitForSeconds(1f);

        while (true)
        {
            SpawnPlatform();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnPlatform()
    {
        float randomY = GetValidRandomY();
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);
        Quaternion rotation = Quaternion.identity;

        GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, rotation);
        newPlatform.AddComponent<PlatformMover>();
        float GetValidRandomY()
        {
            float randomY;
            do
            {
                randomY = Random.Range(minY, maxY);
            }
            while (randomY >= -2.56f && randomY <= 0.2f);

            return randomY;
        }
    }
}