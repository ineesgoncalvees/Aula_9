using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBeahviour
{
    private float angle;
    public void Animate()
    {
        transform.localScale = Mathf.Abs(Mathf.Cos(angle)) * Vector3.one;

        angle += 2f * Time.deltaTime;
    }
}
