using System;
using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEditor;
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

        for (int Y = Location.Y - 1; Y >= 0; Y--)
        {
            if (Y != Location.Y)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null) break;
            }
        }
        for (int Y = Location.Y + 1; Y <= 9; Y++)
        {
            if (Y != Location.Y)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null) break;
            }
        }
        
        for (int X = Location.X - 1; X >= 0; X--)
        {
            if (X != Location.X)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null) break;
            }
        }
        for (int X = Location.X + 1; X <= 8; X++)
        {
            if (X != Location.X)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null) break;
            }
        }
        ChuyenListTargetSangTarget();
    }

    public override void RedSelected()
    {
        for (int Y = Location.Y - 1; Y >= 0; Y--)
        {
            if (Y != Location.Y)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null) break;
            }
        }
        for (int Y = Location.Y + 1; Y <= 9; Y++)
        {
            if (Y != Location.Y)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null) break;
            }
        }
        
        for (int X = Location.X - 1; X >= 0; X--)
        {
            if (X != Location.X)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null) break;
            }
        }
        for (int X = Location.X + 1; X <= 8; X++)
        {
            if (X != Location.X)
            {
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null) break;
            }
        }
        ChuyenListTargetSangTarget();
    }

   
}
