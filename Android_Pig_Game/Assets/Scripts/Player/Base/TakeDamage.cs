using UnityEngine;

public abstract class TakeDamage : MonoBehaviour,ITakeDamage
{
    public int CurrentHP;
    public int _maxHp { get; private set; } = 3;

    
    public int CurrentScore { get; private set; }=0;



  

    public void TakenDamage(int Damage)
    {
        CurrentHP -= Damage;
    }

    public void GainScore(int Score)
    {
        CurrentScore += Score;
    }

    public void getHP(int HP)
    {
        if(CurrentHP < _maxHp)
            CurrentHP += HP;
        

    }

    public void LoseScore(int Score)
    {
        if(CurrentScore>0)
            CurrentScore -= Score;
    }
}
