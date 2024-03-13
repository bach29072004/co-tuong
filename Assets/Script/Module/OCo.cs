using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Script.Enum;
using UnityEngine;

public class OCo : MonoBehaviour
{
    private EQuanCoColor _color;

    public EQuanCoColor Color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
            switch (_color)
            {
                case EQuanCoColor.Black:
                    GetComponent<Renderer>().material = ResourceController.Instance.blackOCoMaterial;
                    break;
                case EQuanCoColor.While:
                    GetComponent<Renderer>().material = ResourceController.Instance.whileOCoMaterial;
                    break;
                default:
                    break;
            }
        }
    }
    public EOcoState TrangThai;


    private QuanCo _currentQuanCo;
    
    public void ThayDoiTrangThai(EOcoState trangThai)
    {
        
    }

    [ContextMenu("changcolor")]
    public void ChangeColor()
    {
        if (Color == EQuanCoColor.Black)
        {
            Color = EQuanCoColor.While;
        }
        else
        {
            Color = EQuanCoColor.Black;
        }
    }
    
    protected void OnMouseEnter()
    {
        Debug.Log("mouseDown");
    }
}
