using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [Range(0.1f, 2f)]
    public float speed = 0.5f;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Tính toán Offset của Texture dựa trên thời gian
        // Trục Y thường được dùng cho game bắn súng dọc
        Vector2 offset = new Vector2(0, Time.time * speed);

        // Áp dụng vào Material của Quad
        meshRenderer.material.mainTextureOffset = offset;
    }
}