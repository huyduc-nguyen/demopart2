using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        // Ẩn con trỏ chuột khi chơi để không bị vướng mắt
        Cursor.visible = false;
    }

    void Update()
    {
        // 1. Lấy vị trí của chuột trên màn hình (Pixel)
        Vector3 mousePosition = Input.mousePosition;

        // 2. Thiết lập khoảng cách từ Camera đến vật thể (Z)
        // 10f thường là khoảng cách mặc định từ Main Camera đến trục tọa độ 0
        mousePosition.z = 10f;

        // 3. Chuyển đổi vị trí chuột sang vị trí trong không gian Game (World Point)
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 4. Giữ nguyên trục Z của tàu để tránh lỗi hiển thị 2D
        targetPosition.z = transform.position.z;

        // 5. Cập nhật vị trí của tàu
        transform.position = targetPosition;
    }

    // Hiện lại con trỏ chuột khi thoát hoặc ngừng game
    void OnDisable()
    {
        Cursor.visible = true;
    }
}