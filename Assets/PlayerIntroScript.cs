using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerIntroScript : MonoBehaviour
{
    public Sprite[] sprites;
    public float strength = 5f;
    public float gravity = 0f;
    public float tilt = 5f;

    private SpriteRenderer spriteRenderer;
    private Vector3 direction;
    private int spriteIndex;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);

        
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
    }

    private void Update()
    {
       
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Flappy Bird");
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }

   
}
