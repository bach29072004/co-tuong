using System;
using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEngine;

public class QuanXe : QuanCo
{
    public void Start()
    {
        btnSelect.onClick.AddListener(BeSelected);
    }

    public override void Move(OCo targetOco)
    {
        SetNewLocation(targetOco.Location);
        UnSelected();
    }
    
    public override void BlackSelected()
    {

        for (int Y = 0; Y < 10; Y++)
        {
            if (Y != Location.Y)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X][Y]);
        }
        for (int X = 0; X < 9; X++)
        {
            if (X != Location.X)
                ListOCoTaget.Add(BanCo.instance.OCos[X][Location.Y]);
        }
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Target;
        }
    }

    public override void RedSelected()
    {
        for (int Y = 0; Y < 10; Y++)
        {
            if (Y != Location.Y)
                ListOCoTaget.Add(BanCo.instance.OCos[Location.X][Y]);
        }
        for (int X = 0; X < 9; X++)
        {
            if (X != Location.X)
                ListOCoTaget.Add(BanCo.instance.OCos[X][Location.Y]);
        }
        foreach (var tar in ListOCoTaget)
        {
            tar.trangThai = EOcoState.Target;
        }
    }

   
}
