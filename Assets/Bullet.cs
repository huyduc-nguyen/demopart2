using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed; // Tốc độ bay của đạn

    void Update()
    {
        // Lấy vị trí hiện tại
        var newPosition = transform.position;
        // Tăng vị trí Y theo thời gian và tốc độ
        newPosition.y += Time.deltaTime * flySpeed;
        // Cập nhật lại vị trí mới
        transform.position = newPosition;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Destroy(other.gameObject); // Xóa kẻ địch
            Destroy(gameObject);       // Xóa chính viên đạn
        }
    }
}