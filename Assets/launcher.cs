using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject _prefab;
    public Camera view;
    public float cooldownTime = 1.0f; // Adjust the cooldown time in seconds
    private float lastTapTime;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time - lastTapTime > cooldownTime)
        {
            Ray ray = view.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //spawn in front of at the camera
                var thing = Instantiate(_prefab, hit.point, Quaternion.identity);

                //if it has physics fire it!
            }
        }
        
    }
}