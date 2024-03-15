using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Script.Enum;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class OCo : MonoBehaviour
{
    public Button btnTargetn;
    public Button btnSelect;
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

    private EOcoState _trangThai;

    public EOcoState trangThai
    {
        get
        {
            return _trangThai;
        }
        set
        {
            _trangThai = value;
            switch (_trangThai)
            {
                case EOcoState.Normal:
                    break;
                case EOcoState.Selected:
                    break;
                case EOcoState.Target:
                    break;
                default:
                    break;
                
            }
        }
    }


    private QuanCo _currentQuanCo;

    public void Start()
    {
        trangThai = EOcoState.Normal;
        btnSelect.onClick.AddListener(() => SelectedClick());
        btnTargetn.onClick.AddListener(() => TargetClick());
    }

    public void SelectedClick()
    {
        
    }

    public void TargetClick()
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
    
    
}
