using System;
using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEngine;

public class QuanPhao : QuanCo
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
        for (int Y = Location.Y - 1; Y >= 0; Y--)
        {
            if (Y != Location.Y)
            {
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = Y - 1; i >= 0; i--)
                    {
                        if (BanCo.Instance.OCos[Location.X][i].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][i]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
            }
        }
        for (int Y = Location.Y + 1; Y <= 9; Y++)
        {
            if (Y != Location.Y)
            {
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = Y + 1; i <= 9; i++)
                    {
                        if (BanCo.Instance.OCos[Location.X][i].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][i]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
            }
        }
        
        for (int X = Location.X - 1; X >= 0; X--)
        {
            if (X != Location.X)
            {
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = X - 1; i >= 0; i--)
                    {
                        if (BanCo.Instance.OCos[i][Location.Y].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[i][Location.Y]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                
            }
        }
        for (int X = Location.X + 1; X <= 8; X++)
        {
            if (X != Location.X)
            {
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = X + 1; i <= 8; i++)
                    {
                        if (BanCo.Instance.OCos[i][Location.Y].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[i][Location.Y]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
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
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = Y - 1; i >= 0; i--)
                    {
                        if (BanCo.Instance.OCos[Location.X][i].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][i]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
            }
        }
        for (int Y = Location.Y + 1; Y <= 9; Y++)
        {
            if (Y != Location.Y)
            {
                if (BanCo.Instance.OCos[Location.X][Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = Y + 1; i <= 9; i++)
                    {
                        if (BanCo.Instance.OCos[Location.X][i].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][i]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[Location.X][Y]);
            }
        }
        
        for (int X = Location.X - 1; X >= 0; X--)
        {
            if (X != Location.X)
            {
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = X - 1; i >= 0; i--)
                    {
                        if (BanCo.Instance.OCos[i][Location.Y].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[i][Location.Y]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
                
            }
        }
        for (int X = Location.X + 1; X <= 8; X++)
        {
            if (X != Location.X)
            {
                if (BanCo.Instance.OCos[X][Location.Y].CurrentQuanCo != null)
                {
                    // quan co co the an
                    for (int i = X + 1; i <= 8; i++)
                    {
                        if (BanCo.Instance.OCos[i][Location.Y].CurrentQuanCo != null)
                        {
                            ListOCoTaget.Add(BanCo.Instance.OCos[i][Location.Y]);
                            break;
                        }
                    }
                    break;
                }
                ListOCoTaget.Add(BanCo.Instance.OCos[X][Location.Y]);
            }
        }
        
        
        
        ChuyenListTargetSangTarget();
    }

    

    
}
