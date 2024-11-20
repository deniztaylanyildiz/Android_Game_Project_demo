using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverCanvas;
    public static UIManager Instance { get; private set; }

    private void Awake()
    {



      

      


        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

    }
    private void Start()
    {
        _scoreText.text = "Score: " + Player.Instance.CurrentScore+"";
    }

    public void UpdateScore()
    {

        _scoreText.text = "Score: " + Player.Instance.CurrentScore+"";


    }


    public void GameManagerHelper()
    {
        _gameOverCanvas.SetActive(true);
    }

    public void ButtonExit()
    {
        Application.Quit();
    }

    public void ButtonTryAgain()
    {

        GameManager.Instance.CanvasHelper();
        _gameOverCanvas.SetActive(false);
    }





}
