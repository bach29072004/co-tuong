using System;
using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEngine;

public class BaseGameController : MonoBehaviour
{
    public static BaseGameController Instance;
    
    private EGameState _gameState;

    public EGameState GameState
    {
        get { return _gameState;}
        set
        {
            _gameState = value;
            switch (_gameState)
            {
                case EGameState.Win:
                    break;
                case EGameState.Lose:
                    break;
                case EGameState.Draw:
                    break;
            }
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
        GameState = EGameState.Win;
    }

    public EPlayer currentPlayer = EPlayer.Black;

    public void SwitchPlayer()
    {
        if (currentPlayer == EPlayer.Black)
            currentPlayer = EPlayer.Red;
        else
        {
            currentPlayer = EPlayer.Black;
        }
    }
}
