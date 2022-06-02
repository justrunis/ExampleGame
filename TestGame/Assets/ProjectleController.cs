using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProjectleController : MonoBehaviour
{
    [SerializeField]
    private Transform barrel;

    [SerializeField]
    private GameObject projetlePrefab;

    [SerializeField]
    private GameObject muzzlePrefab;

    private void Update()
    {
        if (IsFire())
        {
            Fire();
        }
    }

    private bool IsFire()
    {
        return Input.GetButtonDown("Fire1");
    }

    private void Fire()
    {
        CreateProjetle();
        CreateMuzzleEffect();
    }

    private void CreateProjetle()
    {
        Instantiate(projetlePrefab, barrel.position, barrel.rotation);
    }

    private void CreateMuzzleEffect()
    {
        Instantiate(muzzlePrefab, barrel.position, barrel.rotation);
    }
}
