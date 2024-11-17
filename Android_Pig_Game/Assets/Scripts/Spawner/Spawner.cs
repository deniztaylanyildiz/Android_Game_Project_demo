using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _spawnerObjs;
    [SerializeField]
    private bool _isCanSpawn;
    [SerializeField]
    private float _maxSpawnX;
    [SerializeField]
    private float _minSpawnX;




    [SerializeField]
    private float _maxSpawnTimer;
    [SerializeField]
    private float _minSpawnTimer;

    private void Start()
    {

        _isCanSpawn = true;



    }
    private void Update()
    {
        MySpawner();
    }

    public void MySpawner()
    {



        if (_isCanSpawn)
        {
            _isCanSpawn = false;

            int spawn = Random.Range(0, _spawnerObjs.Length);
            float spawnPos = Random.Range(_minSpawnX, _maxSpawnX);
            Vector3 spawnvec = new Vector3(spawnPos, transform.position.y, transform.position.z);
            Instantiate(_spawnerObjs[spawn], spawnvec, Quaternion.identity);
            float myTimer=Random.Range(_minSpawnTimer, _maxSpawnTimer);
            StartCoroutine(SpawnRoutine(myTimer));

        }
    }

    IEnumerator SpawnRoutine(float Timer)
    {
       
        yield return new WaitForSeconds(Timer);
      _isCanSpawn= true;


    }




}
