using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Enum;
using UnityEngine;

public class QuanTot : QuanCo
{
    private bool _isQuaSong;

    private void Start()
    {
        _isQuaSong = false;
        btnSelect.onClick.AddListener(BeSelected);
    }

    public override void Move(OCo targetOco)
    {
        if (Location.Y > 5) _isQuaSong = true;
        SetNewLocation(targetOco.Location);
    }

    public override void BeSelected()
    {
        BanCo.instance.BoChonOcoTruocDo();
        BanCo.instance.SetOCoChonTruocDo(Location.X,Location.Y);
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
        if (_isQuaSong)
        {
            if (Location.X > 0)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X - 1][Location.Y]);
            if (Location.X < 8)
            {
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X + 1][Location.Y]);
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
        throw new System.NotImplementedException();
    }

    public override void UnSelected()
    {
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Normal;
        }
        ListOCoTaget.Clear();
        
    }
}
