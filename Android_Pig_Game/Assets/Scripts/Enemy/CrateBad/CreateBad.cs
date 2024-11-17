using UnityEngine;

public class CreateBad : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    [SerializeField] 
    private int _scoreChange;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player") { 

            Player.Instance.TakenDamage(_damage);
            Player.Instance.LoseScore(_scoreChange);
            UIManager.Instance.UpdateScore();

            Destroy(gameObject);
            


        }

        if (collision.tag == "Pointer")
        {

            Player.Instance.GainScore(_scoreChange);
            UIManager.Instance.UpdateScore();
            Destroy(gameObject,0.4F);
         
        }

    }






}



