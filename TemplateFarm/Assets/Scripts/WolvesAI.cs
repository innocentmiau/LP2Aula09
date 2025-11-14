using UnityEngine;

namespace Scripts
{
    public class WolvesAI : AnimalsAI
    {
        
        protected override void SelectTarget()
        {
            Debug.Log("Wolves tried to selected target.");
        }

        protected override void Move()
        {
            Debug.Log("Wolves tried to moved.");
        }

        protected override void TryEat()
        {
            Debug.Log("Wolves tried to eat.");
        }

        protected override void TryReproduce()
        {
            Debug.Log("Wolves tried to reproduce.");
        }
    }
}