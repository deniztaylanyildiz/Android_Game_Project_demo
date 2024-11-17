using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public  class PlayerMobileMove:MonoBehaviour
{
    [SerializeField]
    private float _speed = 2;
    [SerializeField]
    private Vector3 _mousePos;


    private void Update()
    {
        Move();
    }



    public void Move()
    {

        if (Input.GetMouseButton(0))
        {
            _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (_mousePos.x < 0)
            {
                transform.Translate(Vector3.left.x * _speed * Time.deltaTime, 0, 0);


            }
            else if (_mousePos.x > 0)
            {

                transform.Translate(Vector3.right.x * _speed * Time.deltaTime, 0, 0);

            }
            else
                return;

        }

    }
}
