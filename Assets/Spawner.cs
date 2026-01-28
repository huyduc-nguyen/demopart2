using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Kéo file Enemy từ thư mục Prefabs vào đây
    public float spawnInterval = 2f; // Cứ mỗi 2 giây tạo 1 con

    void Start()
    {
        // Gọi hàm "SpawnEnemy" lặp đi lặp lại
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Tạo vị trí ngẫu nhiên theo chiều ngang (X) từ -8 đến 8
        // Vị trí Y cố định ở trên cao (ví dụ: 6)
        Vector3 randomPos = new Vector3(Random.Range(-8f, 8f), 6f, 0f);

        // Tạo ra kẻ địch tại vị trí đó
        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
    }
}