using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    private void Update()
    {
        // Debug.Log(Input.mousePosition); // 픽셀
        // Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // 비율

        // Ray struct 사용 코드 개선

        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 mousPos = Camera.main.ScreenToWorldPoint(
            //new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            //Vector3 dir = mousPos - Camera.main.transform.position;
            //dir = dir.normalized;

            //Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

            //RaycastHit hit;
            //if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
            //{
            //    Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
            //}
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
            }

            
        }
        
    }
}
