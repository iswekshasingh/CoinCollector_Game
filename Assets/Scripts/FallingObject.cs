using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = 3f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Catcher>() != null)
        {
            if (gameObject.CompareTag("Coin"))
            {
                GameManager.Instance.CollectCoin();
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Bomb"))
            {
                GameManager.Instance.HitBomb();
                Destroy(gameObject);
            }
        }
    }
}