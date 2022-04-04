using UnityEngine.Events;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _score = 0;

    public event UnityAction<int> ScoreAdded;

    public void AddScore()
    {
        _score++;
        ScoreAdded?.Invoke(_score);
    }
}