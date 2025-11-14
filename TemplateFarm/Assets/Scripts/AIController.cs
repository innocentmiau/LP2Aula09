using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class AIController : MonoBehaviour
    {

        private IEnumerable<AnimalsAI> _animalsAis;

        private void Awake()
        {
            _animalsAis = new AnimalsAI[]
            {
                new SheepAI(),
                new WolvesAI()
            };
        }

        private void Start()
        {
            StartCoroutine(TakeTurns());
        }

        private IEnumerator TakeTurns()
        {
            YieldInstruction wts = new WaitForSeconds(2);
            while (true)
            {
                foreach (var animal in _animalsAis)
                    animal.TakeTurn();
                yield return wts;
            }
        }
        
    }

}