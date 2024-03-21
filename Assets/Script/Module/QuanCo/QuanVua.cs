using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Enum;
using UnityEngine;

public class QuanVua : QuanCo
{
    private void Start()
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
        List<CLocation> list = new List<CLocation>()
        {
            new CLocation(1, 0),
            new CLocation(0, -1),
            new CLocation(0, 1),
            new CLocation(-1, 0)
        };
        
        foreach (var vec in list)
        {
            if (Location.X + vec.X >= 3 && Location.X + vec.X <= 5 && Location.Y + vec.Y >= 0 && Location.Y + vec.Y <= 2)
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X + vec.X][Location.Y + vec.Y]);
        }

        ChuyenListTargetSangTarget();
    }

    public override void RedSelected()
    {
        List<CLocation> list = new List<CLocation>()
        {
            new CLocation(1, 0),
            new CLocation(0, -1),
            new CLocation(0, 1),
            new CLocation(-1, 0)
        };
        
        foreach (var vec in list)
        {
            if (Location.X + vec.X >= 3 && Location.X + vec.X <= 5 && Location.Y + vec.Y >= 7 && Location.Y + vec.Y <= 9)
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X + vec.X][Location.Y + vec.Y]);
        }

        ChuyenListTargetSangTarget();
    }

   
    
}
