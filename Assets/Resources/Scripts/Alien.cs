using UnityEngine;

public class Alien : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float movementUpperBoundsY;
    [SerializeField] private float movementLowerBoundsY;
    [SerializeField] private float movementUpperBoundsX;
    [SerializeField] private float movementLowerBoundsX;
    [SerializeField] private Vector3 currentTargetPos;
    [SerializeField] private string _name;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spriteMove;
    [SerializeField] private Sprite spriteAttack;

    private InputManager inputManager;
    private CameraManager cameraManager;

    private void Awake()
    {
        transform.localScale = transform.localScale * Random.Range(.7f, 1.3f);
        SetNewTargetPos();
        inputManager = FindAnyObjectByType<InputManager>();
        cameraManager = FindAnyObjectByType<CameraManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        if (inputManager.oxygenCount > 0)
        {
            if (transform.position != currentTargetPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentTargetPos, speed * Time.deltaTime);
                if (Vector3.Distance(transform.position, currentTargetPos) < 1 * (speed / 3))
                {
                    spriteRenderer.sprite = spriteAttack;
                }
                else
                {
                    spriteRenderer.sprite = spriteMove;
                }
            }
            else
            {
                FireZeSlime();
                SetNewTargetPos();
            }
        }
        else
        {
            if (!inputManager.gameActive) return;
            StartCoroutine(cameraManager.ShakeCorouine(0.05f, .1f));
        }
    }

    private void SetNewTargetPos()
    {
        currentTargetPos = new Vector3(Random.Range(movementLowerBoundsX, movementUpperBoundsX), Random.Range(movementLowerBoundsY, movementUpperBoundsY), 0);
    }
    private void FireZeSlime()
    {
        if (_name == "SLIME")
        {
            StartCoroutine(cameraManager.ShakeCorouine(0.15f, .2f));
            inputManager.RandomlySlimeGlass();
            inputManager.RandomlySlimeGlass();
            inputManager.RandomlySlimeGlass();
            inputManager.RandomlySlimeGlass();
            inputManager.RandomlySlimeGlass();
            inputManager.RandomlySlimeGlass();
        }
        else
        {
            StartCoroutine(cameraManager.ShakeCorouine(0.15f, .05f));
            inputManager.SlimeBasedOnPosition(currentTargetPos);
        }
    }

    private void Reset()
    {
        Destroy(gameObject);
    }

}