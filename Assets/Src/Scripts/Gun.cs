using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera _cam;
    public Animator _animator;
    public AudioSource _shootingSound;

    void Start()
    {
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _animator.SetBool("shooting", true);
                    _shootingSound.Play();

/*
                    Vector3 posFar = new Vector3(touch.position.x, touch.position.y, Camera.main.farClipPlane);
                    Vector3 posNear = new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane);
                    Vector3 posF = _cam.ScreenToWorldPoint(posFar);
                    Vector3 posN = _cam.ScreenToWorldPoint(posNear);
  */                Ray ray;
                    RaycastHit hit;
                    ray = _cam.ScreenPointToRay(touch.position);
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                    {
                        Debug.Log("touching " + hit.transform.gameObject.name);
                        if (hit.transform.gameObject.tag == ("Target"))
                        {
                            Destroy(hit.transform.gameObject);
                        }
                        else
                        {
                            Debug.Log("This object is not the target");
                        }
                    } else
                    {
                        Debug.Log("touching the void");
                    }
                    
                    
                    break;
                case TouchPhase.Ended:
                    _animator.SetBool("shooting", false);
                    break;
            }


        }
    }
}
