using UnityEngine;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int lives = 3;
    public int targetScore = 20;

    public TMP_Text scoreText;
    public TMP_Text livesText;

    public GameObject winImage;
    public GameObject loseImage;
    public GameObject darkOverlay;

    private bool gameEnded = false;

    void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
        UpdateUI();

        winImage.SetActive(false);
        loseImage.SetActive(false);
        darkOverlay.SetActive(false);
    }

    void UpdateUI()
    {
        scoreText.text = "SCORE: " + score;
        livesText.text = "LIVES: " + lives;
    }

    public void CollectCoin()
    {
        if (gameEnded) return;

        score++;
        UpdateUI();

        if (score >= targetScore)
        {
            StartCoroutine(EndGame(true));
        }
    }

    public void HitBomb()
    {
        if (gameEnded) return;

        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            StartCoroutine(EndGame(false));
        }
    }

    IEnumerator EndGame(bool won)
    {
        gameEnded = true;

        scoreText.gameObject.SetActive(false);
        livesText.gameObject.SetActive(false);

        darkOverlay.SetActive(true);

        GameObject endingImage = won ? winImage : loseImage;
        endingImage.SetActive(true);

        CanvasGroup group = endingImage.GetComponent<CanvasGroup>();

        if (group == null)
            group = endingImage.AddComponent<CanvasGroup>();

        group.alpha = 0f;
        endingImage.transform.localScale = Vector3.one * 0.8f;

        float duration = 1f;
        float timer = 0f;

        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;

            float t = timer / duration;

            group.alpha = Mathf.Lerp(0f, 1f, t);
            endingImage.transform.localScale =
                Vector3.Lerp(Vector3.one * 0.8f, Vector3.one, t);

            yield return null;
        }

        group.alpha = 1f;
        endingImage.transform.localScale = Vector3.one;

        Time.timeScale = 0f;
    }
}