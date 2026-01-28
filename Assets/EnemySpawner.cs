using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f); // Lặp lại việc tạo quái
    }
    void SpawnEnemy()
    {
        // Tạo quái ở vị trí ngẫu nhiên trên đỉnh màn hình
        Vector3 spawnPos = new Vector3(Random.Range(-5f, 5f), 6f, 0f);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}