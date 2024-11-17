using UnityEngine;

public abstract class TakeDamage : MonoBehaviour,ITakeDamage
{
    [SerializeField]
    private int _maxHp;
    public int CurrentHP;

    public int CurrentScore;




    private void Awake()
    {
        CurrentHP = _maxHp;

    }


    public void TakenDamage(int Damage)
    {
        CurrentHP -= Damage;
    }

    public void TakeScore(int Score)
    {
        CurrentScore += Score;
    }

    public void getHP(int HP)
    {
        if(CurrentHP < _maxHp)
            CurrentHP += HP;
        

    }
}
