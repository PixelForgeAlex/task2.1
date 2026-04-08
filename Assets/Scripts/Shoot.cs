using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private GameObject _progectile;

    [SerializeField] private float _force;



    private void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {

            var mousePos = Input.mousePosition;

            var ray = Camera.main.ScreenPointToRay(mousePos);



            var worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            var projectileInstance = Instantiate(_progectile, worldPos, Quaternion.identity);

            var projectileRB = projectileInstance.GetComponent<Rigidbody>();



            if (projectileRB != null)

            {

                projectileRB.AddForce(ray.direction * _force);

            }

        }

    }

}