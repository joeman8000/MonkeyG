using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public static event Action<GameState> OnGameStateChanged;

    void Awake(){
        Instance = this;
    }
    public void UpdateGameState(GameState newstate){
        State = newstate;

        switch (newstate){
            case GameState.Jumping:
                break;
            case GameState.Grounded:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newstate), newstate, null);

        }
    }
}

public enum GameState {
    Jumping,
    Grounded,
    Lose
}*/