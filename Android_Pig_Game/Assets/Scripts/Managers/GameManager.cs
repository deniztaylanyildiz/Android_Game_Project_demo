using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        Isdead();
    }




    public void Isdead()
    {
        if(Player.Instance.CurrentHP<=0)
        { //gameOver

            Destroy(_player, 0.2F);
                
                
                }    


    }

}
