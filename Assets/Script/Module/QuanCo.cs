using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class QuanCo : MonoBehaviour
{
    [SerializeField]
    private Vector3 offsetPosition;
    private Vector2 viTriDauTien;
    public Vector2 viTriTrenBanCo;
    public EPlayer player;
    public abstract void Move();

    public void SetViTriDauTien(int x, int y)
    {
        viTriDauTien = new Vector2(x, y);
        transform.localScale = Vector3.one;
        transform.localPosition = offsetPosition + new Vector3(x*BanCo.instance.KhoangCachOCo, y*BanCo.instance.KhoangCachOCo, 0);
    }
}
