using UnityEngine;

public interface ITakeDamage 
{
    public void TakenDamage(int Damage);
    public void GainScore(int Score);
    public void LoseScore(int Score);
    public void getHP(int HP);



}
