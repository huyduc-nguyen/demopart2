using UnityEngine;

public class EnemyHealth : Health
{
    // Biến tĩnh dùng chung cho tất cả kẻ địch để đếm số lượng
    public static int LivingEnemyCount = 0;

    void Awake()
    {
        // Khi một kẻ địch sinh ra (Spawn), tăng biến đếm lên 1
        LivingEnemyCount++;
    }

    protected override void Die()
    {
        // Khi kẻ địch chết, giảm biến đếm đi 1
        LivingEnemyCount--;
        base.Die();
        Destroy(gameObject); // Xóa kẻ địch khỏi Scene
    }
}