using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Enum;
using Script.Module;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public abstract class QuanCo : MonoBehaviour
{
    public Button btnSelect;
    //[SerializeField]
    private Vector3 offsetPosition = new Vector3(-420,-462,0);
    public QuanCoInfo Info;
    
    public CLocation Location;
    public EPlayer player;
    public List<OCo> ListOCoTaget = new List<OCo>();
    public Transform renderer;
    public bool Eat = false;
    public void SetViTriDauTien(QuanCoInfo info)
    {
        Info = info;
        Location = new CLocation(info.X, info.Y);
        renderer.localScale = new Vector3(60f, 60f, 60f);
        transform.localScale = Vector3.one;
        transform.localPosition = offsetPosition + new Vector3(info.X*BanCo.instance.KhoangCachOCo, info.Y*BanCo.instance.KhoangCachOCo, 0);
    }

    public void SetNewLocation(CLocation newLocation)
    {
        Location = newLocation;
        transform.localPosition = offsetPosition + new Vector3(Location.X*BanCo.instance.KhoangCachOCo, Location.Y*BanCo.instance.KhoangCachOCo, 0);
    }

    public abstract void Move(OCo targetOco);
    public abstract void BlackSelected();
    public abstract void RedSelected();
    public void BeSelected()
    {
    
        if (!Eat)
        {
            SelectToMove();
        }
        else
        {
            BeEated();
        }
    
    }
   
    public void UnSelected()
    {
        Debug.Log(this.Info.Name);
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Normal;
        }
        ListOCoTaget.Clear();
    }
    public void SelectToMove()
    {
        if (player != BaseGameController.Instance.currentPlayer) return;
        OCo oCoChonTruocDo = BanCo.instance.OCoDangChon;
        BanCo.instance.SetOCoDangChon(Location.X,Location.Y);
        
        switch (player)
        {
            case EPlayer.Black:
                BlackSelected();
                break;
            case EPlayer.Red:
                RedSelected();
                break;
        }
    }
    public void BeEated()
    {
        BanCo.instance.MakeAMove(BanCo.instance.OCos[Location.X][Location.Y]);
        Destroy(this.gameObject);
    }
}
