using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBeahviour
{
    public void Animate()
    {
        transform.Rotate(Time.deltaTime * Vector3.one * 20f);
    }
}
