using UnityEngine;

public class CreateBad : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    [SerializeField]
    private int _scorePoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player") { 

            Player.Instance.TakenDamage(_damage);

            Destroy(gameObject);
            Player.Instance.LoseScore(_scorePoint);

        }

        if (collision.tag == "Pointer")
        {

            Player.Instance.GainScore(_scorePoint);

            Destroy(gameObject);

        }

    }






}



