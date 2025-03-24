using UnityEngine;

public class SizeIncreaser : MonoBehaviour
{
    [SerializeField] private float _growSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += transform.localScale * _growSpeed * Time.deltaTime;
    }
}
