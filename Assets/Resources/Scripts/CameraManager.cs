using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class CameraManager : MonoBehaviour
{

    private void OnEnable()
    {
        InputManager.ResetGameEvent += Reset;
    }
    private void OnDisable()
    {
        InputManager.ResetGameEvent -= Reset;
    }

    public IEnumerator ShakeCorouine(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1.2f, 1.2f) * magnitude;
            float y = Random.Range(-0.8f, 0.8f) * magnitude;
            transform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;
    }
    private void Reset()
    {
        StartCoroutine(TransformBackCoroutine());
    }
    private IEnumerator TransformBackCoroutine()
    {
        yield return new WaitForSeconds(.4f);
        transform.position = new Vector3(0, 0, transform.position.z);
    }
} 