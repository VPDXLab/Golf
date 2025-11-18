using UnityEngine;

namespace Golf
{
    public class ScoreManager : MonoBehaviour
    {
        public int score { get; private set; }
        
        public void Increase()
        {
            score++;   
            Debug.Log($"Score: {score}");
        }
    }
}