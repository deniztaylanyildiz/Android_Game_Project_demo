using UnityEngine;

public interface ICanPlay
{
    public void TakenDamage(int Damage);
    public void GainScore(int Score);
    public void LoseScore(int Score);
    public void getHP(int HP);
    public void ResetScore();


}
