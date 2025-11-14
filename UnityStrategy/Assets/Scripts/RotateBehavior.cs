using UnityEngine;

public class RotateBehavior : MonoBehaviour, IAnimateBehaviour
{

    [SerializeField] private float speed = 1f;

    public void Animate()
    {
        transform.Rotate(Vector3.one, speed * Time.deltaTime);
    }
    
    
}