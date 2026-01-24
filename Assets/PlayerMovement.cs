using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // 1. Lấy vị trí của chuột trên màn hình (Pixel)
        Vector3 mousePosition = Input.mousePosition;

        // 2. Chuyển đổi vị trí chuột sang vị trí trong không gian Game (World Point)
        // Lưu ý: Chúng ta lấy vị trí Z của Camera để tính toán chính xác
        mousePosition.z = Camera.main.nearClipPlane + 10f;
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 3. Giữ nguyên trục Z của tàu (để tàu không bị bay ra xa hoặc quá gần camera)
        targetPosition.z = transform.position.z;

        // 4. Cập nhật vị trí của tàu theo vị trí chuột
        transform.position = targetPosition;
    }
}