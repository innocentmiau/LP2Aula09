using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{

    [SerializeField] private float speed = 1f;
    
    public void Animate()
    {
        transform.localScale = Mathf.Abs(Mathf.Sin(Time.time * speed)) * Vector3.one;
    }
}