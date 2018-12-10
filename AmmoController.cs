using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    public int ammo = 30;
    public Text uitext;

    void Update()
    {
        if (uitext != null)
        {
            uitext.text = ammo.ToString();
        }
    }
}
