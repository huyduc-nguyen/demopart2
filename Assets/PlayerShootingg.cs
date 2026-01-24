using UnityEngine;

public class PlayerShootingg : MonoBehaviour
{
    public GameObject bulletPrefabs; // Prefab viên đạn
    public float shootingInterval;   // Khoảng cách giữa 2 lần bắn (giây)
    private float lastBulletTime;    // Thời điểm bắn viên cuối cùng

    void Update()
    {
        // Nếu đang giữ chuột trái
        if (Input.GetMouseButton(0))
        {
            // Kiểm tra xem đã đến lúc bắn viên tiếp theo chưa
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time; // Cập nhật lại thời gian vừa bắn
            }
        }
    }

    private void ShootBullet()
    {
        // Tạo ra một bản sao của viên đạn tại vị trí của người chơi
        Instantiate(bulletPrefabs, transform.position, transform.rotation);
    }
}