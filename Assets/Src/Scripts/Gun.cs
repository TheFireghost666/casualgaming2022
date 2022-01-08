using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Animator _animator;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
       //     Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _animator.SetBool("shooting", true);
                    break;
                case TouchPhase.Ended:
                    _animator.SetBool("shooting", false);
                    break;
            }


        }
    }
}
