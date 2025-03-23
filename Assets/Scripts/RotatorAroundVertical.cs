using UnityEngine;

public class RotatorAroundVertical : MonoBehaviour
{
    [SerializeField] private float _degreePerSecond = 60f;

    private void Update()
    {
        transform.Rotate(transform.up, _degreePerSecond * Time.deltaTime);
    }
}
