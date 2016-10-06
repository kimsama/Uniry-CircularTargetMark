using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CircularTargetMark : MonoBehaviour
{
    public Material radiusMaterial;
    public Color color = Color.white;
    public float radius = 10f;
    public float radiusWidth = 2f;
    public float power = 5f;
    public float speed = 60f;

    void Update()
    {
        radiusMaterial.SetVector("_Center", transform.position);
        radiusMaterial.SetColor("_RadiusColor", color);
        radiusMaterial.SetFloat("_Radius", radius);
        radiusMaterial.SetFloat("_RadiusWidth", radiusWidth);
        radiusMaterial.SetFloat("_RadiusPower", power);
        radiusMaterial.SetFloat("_RadiusSpeed", speed);
    }
}