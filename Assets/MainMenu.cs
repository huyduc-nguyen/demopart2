using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Bạn phải có chữ 'public' thì Unity mới tìm thấy hàm này
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("trangchu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}