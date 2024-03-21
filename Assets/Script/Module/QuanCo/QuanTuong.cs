using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEngine;

public class QuanTuong : QuanCo
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


    private List<OCoDiChuyenVaBiChan> _list = new List<OCoDiChuyenVaBiChan>()
    {
        new OCoDiChuyenVaBiChan(2,2,1,1),
        new OCoDiChuyenVaBiChan(-2,2,-1,1),
        new OCoDiChuyenVaBiChan(2,-2,1,-1),
        new OCoDiChuyenVaBiChan(-2,-2,-1,-1)
    };
    public override void BlackSelected()
    {
        foreach (var vec in _list)
        {
            if (Location.X + vec.X >= 0 && Location.X + vec.X < 9 && Location.Y + vec.Y >= 0 && Location.Y + vec.Y < 5)
            {
                
                if (Location.X + vec.OChanX >= 0 && Location.X + vec.OChanX < 9 && Location.Y + vec.OChanY >= 0 && Location.Y + vec.OChanY < 5)
                    if (BanCo.Instance.OCos[Location.X + vec.OChanX][Location.Y + vec.OChanY].CurrentQuanCo == null)
                        ListOCoTaget.Add(BanCo.Instance.OCos[Location.X + vec.X][Location.Y + vec.Y]);
            }
        }

        ChuyenListTargetSangTarget();
    }

    public override void RedSelected()
    {
        foreach (var vec in _list)
        {
            if (Location.X + vec.X >= 0 && Location.X + vec.X < 9 && Location.Y + vec.Y >= 5 && Location.Y + vec.Y < 10)
            {
                if (Location.X + vec.OChanX >= 0 && Location.X + vec.OChanX < 9 && Location.Y + vec.OChanY >= 5 && Location.Y + vec.OChanY < 10)
                    if (BanCo.Instance.OCos[Location.X + vec.OChanX][Location.Y + vec.OChanY].CurrentQuanCo == null)
                        ListOCoTaget.Add(BanCo.Instance.OCos[Location.X + vec.X][Location.Y + vec.Y]);
            }
        }

        ChuyenListTargetSangTarget();
    }

   
    
}
