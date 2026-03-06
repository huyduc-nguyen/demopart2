using UnityEngine;
using System; // Bắt buộc phải có để dùng Action

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    protected float currentHealth;

    // Sự kiện sẽ thông báo cho các Script khác khi đối tượng này chết
    public Action onDead;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    protected virtual void Die()
    {
        // Gọi sự kiện onDead nếu có bất kỳ script nào đang lắng nghe
        onDead?.Invoke();

        // Hiệu ứng nổ hoặc biến mất tùy bạn thiết lập ở đây
        // Destroy(gameObject); 
    }
}