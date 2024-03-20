using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Enum;
using UnityEngine;

public class QuanTot : QuanCo
{
    public bool Eat;
    private void Start()
    {
        Eat = true;
        btnSelect.onClick.AddListener(() =>
        {
            if (!Eat)
            {
                BeSelected();
            }
            else
            {
                BeEated();
            }
        });
    }

    public override void Move(OCo targetOco)
    {
        SetNewLocation(targetOco.Location);
        UnSelected();
        
    }

    public void BeEated()
    {
        
    }
    public override void BeSelected()
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

    public override void BlackSelected()
    {
        if (Location.Y >= 5)
        {
            if (Location.X > 0)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X + 1][Location.Y]);
            if (Location.X < 7)
            {
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X -1 ][Location.Y]);
            }
        }

        if (Location.Y < 9)
            ListOCoTaget.Add(BanCo.instance.OCos[Location.X][Location.Y + 1]);
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Target;
        }
    }

    public override void RedSelected()
    {
        if (Location.Y < 5)
        {
            if (Location.X > 0)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X - 1][Location.Y]);
            if (Location.X < 7)
            {
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X + 1][Location.Y]);
            }
        }

        if (Location.Y > 0)
            ListOCoTaget.Add(BanCo.instance.OCos[Location.X][Location.Y -1]);
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Target;
        }
    }

    public override void UnSelected()
    {
        Debug.Log(this.Info.Name);
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Normal;
        }
        ListOCoTaget.Clear();
    }
}
