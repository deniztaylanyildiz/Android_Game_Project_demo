using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameObject _player;
    private GameObject _spawner;






    public enum PlayerLiveAction
    {

        Alive,
        Dead

    }


    public PlayerLiveAction _playerAlive;



    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _spawner = GameObject.FindGameObjectWithTag("Spawner");

        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

    }




    private void Update()
    {
        EnumVoidIsplayerLive();

        if (Player.Instance.CurrentHP <= 0)
        {
            _playerAlive = PlayerLiveAction.Dead;
            Player.Instance.ResetScore();
            UIManager.Instance.UpdateScore();
        }

        
    }

    private void EnumVoidIsplayerLive()
    {
        switch (_playerAlive)
        {

            case PlayerLiveAction.Alive:
              
                _player.SetActive(true);
                _spawner.SetActive(true);
                

                break;

            case PlayerLiveAction.Dead:
                _player.SetActive(false);
                _spawner.SetActive(false);
                Spawner _mySpawner = _spawner.GetComponent<Spawner>();
                _mySpawner.SpawnDeadCheck();
                UIManager.Instance.GameManagerHelper();
                break;

        }


      


    }
    public void CanvasHelper()
    {

    
        _playerAlive = PlayerLiveAction.Alive;
        Player.Instance.CurrentHP = 3;


    }
}
