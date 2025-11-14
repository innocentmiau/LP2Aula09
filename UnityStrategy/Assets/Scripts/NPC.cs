using UnityEngine;

public class NPC : MonoBehaviour
{
    private IAnimateBehaviour[] behaviours;

    private void Awake()
    {
        behaviours = GetComponents<IAnimateBehaviour>();
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (var behaviour in behaviours)
            behaviour?.Animate();
    }
}
