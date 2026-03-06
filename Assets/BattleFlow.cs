using UnityEngine;
using UnityEngine.SceneManagement; // Để chuyển cảnh

public class BattleFlow : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject gameOverUI;
    public GameObject gameWinUI;

    [Header("Settings")]
    public AudioSource bgMusic;

    private bool isGameEnded = false;

    void Start()
    {
        // Tìm Player bằng Tag và đăng ký sự kiện chết
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            Health playerHealth = player.GetComponent<Health>();
            playerHealth.onDead += OnGameOver;
        }

        // Reset số lượng kẻ địch khi bắt đầu màn chơi mới (đề phòng lỗi cộng dồn)
        // EnemyHealth.LivingEnemyCount = 0; 
    }

    void Update()
    {
        if (isGameEnded) return;

        // Kiểm tra điều kiện thắng: Nếu không còn kẻ địch nào
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    void OnGameOver()
    {
        if (isGameEnded) return;
        isGameEnded = true;

        gameOverUI.SetActive(true);
        if (bgMusic) bgMusic.Stop();
        Debug.Log("Game Over!");
    }

    void OnGameWin()
    {
        if (isGameEnded) return;
        isGameEnded = true;

        gameWinUI.SetActive(true);
        if (bgMusic) bgMusic.Stop();
        Debug.Log("You Win!");
    }

    // Hàm dùng cho các nút bấm trên UI (Restart/Menu)
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}