using Unity.VisualScripting;
using UnityEngine;

public class Player :CanPlay
{

    public static Player Instance { get; private set; }

    private void Awake()
    {


     
            CurrentHP = _maxHp;
        
       


        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }


   

}
