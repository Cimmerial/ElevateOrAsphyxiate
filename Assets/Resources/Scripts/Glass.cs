using UnityEngine;

public class Glass : MonoBehaviour
{
    [SerializeField] public bool isIntact;
    [SerializeField] public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        isIntact = false;
    }
    private void OnEnable()
    {
        InputManager.ResetGameEvent += Reset;
    }
    private void OnDisable()
    {
        InputManager.ResetGameEvent -= Reset;
    }

    private void Update()
    {
        if (!isIntact)
        {
            spriteRenderer.enabled = false;
        }
        else
        {
            spriteRenderer.enabled = true;
        }
    }
    private void Reset()
    {
        isIntact = false;
    }
}