using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Enum;
using UnityEngine;

public class QuanTot : QuanCo
{
   
    private void Start()
    {
        Eat = false;
        btnSelect.onClick.AddListener(BeSelected);
    }

    public override void Move(OCo targetOco)
    {
        SetNewLocation(targetOco.Location);
        UnSelected();
    }
    
    
    public override void BlackSelected()
    {
        if (Location.Y >= 5)
        {
            if (Location.X > 0)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X - 1][Location.Y]);
            if (Location.X < 7)
            {
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X  +1 ][Location.Y]);
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

    
}
