using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float height;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float parallaxSpeed;
    [SerializeField] private Light2D sceneLight;
    private InputManager inputManager;

    private void Awake()
    {
        startPosition = transform.position;
        inputManager = FindAnyObjectByType<InputManager>();
    }
    private void OnEnable()
    {
        InputManager.ResetGameEvent += Reset;
    }
    private void OnDisable()
    {
        InputManager.ResetGameEvent -= Reset;
    }

    void Update()
    {
        float newY = Mathf.Repeat(Time.time * parallaxSpeed, height);
        transform.position = startPosition + Vector3.down * newY;
        if (inputManager.oxygenCount == 0 && parallaxSpeed < 25 && !inputManager.incutscenes)
        {
            parallaxSpeed += .004f;
            sceneLight.intensity += .004f;
        }
        else
        {
            if (parallaxSpeed < inputManager.currentLevel + 1)
            {
                parallaxSpeed += .0001f;
            }

        }
    }
    private void Reset()
    {
        parallaxSpeed = 1;
        sceneLight.intensity = 1;
    }

}
