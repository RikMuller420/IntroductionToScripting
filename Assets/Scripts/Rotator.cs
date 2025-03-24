using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _angularSpeed = 60f;

    private void Update()
    {
        transform.Rotate(transform.up, _angularSpeed * Time.deltaTime);
    }
}
