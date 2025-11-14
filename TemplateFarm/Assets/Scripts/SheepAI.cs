using UnityEngine;

namespace Scripts
{
    public class SheepAI : AnimalsAI
    {
        
        protected override void Move()
        {
            Debug.Log("Sheep tried to moved.");
        }

        protected override void TryEat()
        {
            Debug.Log("Sheep tried to eat.");
        }

        protected override void TryReproduce()
        {
            Debug.Log("Sheep tried to reproduce.");
        }
    }
}