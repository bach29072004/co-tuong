using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuanCo : MonoBehaviour
{
    public Vector3 offsetPosition;
    public Vector2 viTriDauTien;
    public Vector2 viTriTrenBanCo;
    public EPlayer player;
    public abstract void Move();
}
