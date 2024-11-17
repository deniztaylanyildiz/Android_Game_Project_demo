using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

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


   



    


}
