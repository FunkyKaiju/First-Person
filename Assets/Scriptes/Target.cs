

using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;
    public GameObject coinPrefab;
    public Transform trans;


    void DropCoin()
    {
        Vector3 position = transform.position;
        GameObject coin = Instantiate(coinPrefab, position, Quaternion.identity);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        DropCoin();
    }
}
