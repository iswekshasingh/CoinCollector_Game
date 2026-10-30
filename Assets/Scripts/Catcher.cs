
using UnityEngine;
using UnityEngine.InputSystem;

[ExecuteAlways]
public class Catcher : MonoBehaviour
{
    public float speed = 10f;
    public float characterHeight = 1.6f;

    public Sprite rightSprite;
    public Sprite leftSprite;

    private SpriteRenderer sr;

    void OnEnable()
    {
        SetupCharacter();
    }

    void OnValidate()
    {
        SetupCharacter();
    }

    void SetupCharacter()
    {
        sr = GetComponent<SpriteRenderer>();

        if (sr == null || rightSprite == null)
            return;

        // Show character even when game is stopped
        sr.sprite = rightSprite;

        // Maintain original image proportions
        float scale = characterHeight / rightSprite.bounds.size.y;

        transform.localScale = new Vector3(scale, scale, 1f);
    }

    void Update()
    {
        if (!Application.isPlaying)
            return;

        if (sr == null || Keyboard.current == null)
            return;

        float input = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            input = -1f;
            sr.sprite = leftSprite;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            input = 1f;
            sr.sprite = rightSprite;
        }

        Vector3 pos = transform.position;

        pos.x += input * speed * Time.deltaTime;

        Camera cam = Camera.main;

        if (cam == null)
            return;

        // Calculate screen boundaries
        float halfWidth = cam.orthographicSize * cam.aspect;

        float leftEdge = cam.transform.position.x - halfWidth;
        float rightEdge = cam.transform.position.x + halfWidth;

        float width = sr.bounds.extents.x;

        pos.x = Mathf.Clamp(
            pos.x,
            leftEdge + width,
            rightEdge - width
        );

        // Keep character's feet on the bottom edge
        float bottomEdge = cam.transform.position.y - cam.orthographicSize;

        pos.y = bottomEdge + sr.bounds.extents.y;

        transform.position = pos;
    }
}
