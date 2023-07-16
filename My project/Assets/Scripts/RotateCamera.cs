using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    
    [SerializeField] private Transform target;

    private Camera _camera;
 

    private void Start()
    {
        _camera = Camera.main;
    }

    private void OnEnable()
    {
        if (target == null)
            target = transform;

       
    }

    private void Update()
    {
        if (Time.timeScale == 0) return;

        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - (Vector2)target.transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        target.transform.rotation = Quaternion.Euler(Vector3.forward * (angle));
    }

    /*private void OnDrawGizmos()
    {
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(mousePosition, target.transform.position);
    }*/
}
