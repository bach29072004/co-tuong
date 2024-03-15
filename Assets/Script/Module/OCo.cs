using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Script;
using Script.Enum;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class OCo : MonoBehaviour
{
    public Button btnTarget;
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
                    btnTarget.gameObject.SetActive(false);
                    if (CurrentQuanCo != null)
                        CurrentQuanCo.UnSelected();
                    break;
                case EOcoState.Selected:
                    
                    break;
                case EOcoState.Target:
                    btnTarget.gameObject.SetActive(true);
                    break;
                default:
                    break;
                
            }
        }
    }


    public QuanCo CurrentQuanCo;
    public CLocation Location { get; private set; }

    public void SetLocation(CLocation location)
    {
        Location = location;
    }
    public void Start()
    {
        trangThai = EOcoState.Normal;
        btnTarget.onClick.AddListener(() => TargetClick());
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

    public void SetCurrentPeice(QuanCo quanCo)
    {
        CurrentQuanCo = quanCo;
    }

    public void MakeAMove(OCo targetOCo)
    {
        CurrentQuanCo.Move(targetOCo);
        SetCurrentPeice(null);
        trangThai = EOcoState.Normal;
    }
}
