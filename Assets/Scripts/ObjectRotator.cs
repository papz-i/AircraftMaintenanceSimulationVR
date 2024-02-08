using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float speed = 50.0f;

    private bool canRotate = false;

    public void StartRotating()
    {
        canRotate = true;
    }
    public void StopRotating()
    {
        canRotate = false;
    }

    private void Update()
    {
        if(canRotate) 
            Rotate();
    }

    private void Rotate()
    {
        transform.Rotate((Vector3.forward * speed) * Time.deltaTime);
    }
}
