using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 2)]
public class GameData : ScriptableObject
{
    [SerializeField] private int _diamonds;
    public int Diamonds
    {
        get => _diamonds;
        set => _diamonds = value;
    }
}
