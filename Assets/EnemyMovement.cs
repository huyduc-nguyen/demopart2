using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Hàm này chạy khi có vật thể khác xuyên vào Collider của Enemy
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra xem vật va chạm có phải là đạn không (dựa vào tên)
        if (other.gameObject.name.Contains("Bullet"))
        {
            // 1. Xóa viên đạn
            Destroy(other.gameObject);

            // 2. Xóa chính kẻ địch này
            Destroy(this.gameObject);

            // In ra thông báo để kiểm tra trong cửa sổ Console
            Debug.Log("Đã tiêu diệt mục tiêu!");
        }
    }
}