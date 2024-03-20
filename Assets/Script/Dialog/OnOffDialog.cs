using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class OnOffDialog : MonoBehaviour
{
    public bool popUpThongTin = false;
    public bool popUpNhiemVu = false;
    public bool popUpThemTym;
    public bool popUpSetting;
    
    public static OnOffDialog Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void OnPopUpThongTin()
    {
        if (!popUpThongTin)
        {
            GameObject k =ResourceController.Instance.Initiate(PathResources.PathPopUpThongTinNguoiChoi, transform);
            popUpThongTin = true;
            k.GetComponent<PopUpThongTinNguoiChoi>().SetInfo(new InfoNguoiChoi("bach", 1000,1000,200,100));
        }
    }

    public void OnPopUpXemCo()
    {
        //GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopup));
    }

    public void OnCanvasCoUp()
    {
        //  throw new NotImplementedException();
    }

    public void OnCanvasCoTuong()
    {
        //  throw new NotImplementedException();
    }

    public void OnPopUpSetting()
    {
        GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopUpSetting));
    }

    public void OnPopUpNhiemVu()
    {
        if (!popUpNhiemVu)
        {
            GameObject k =ResourceController.Instance.Initiate(PathResources.PathPopUpNhiemVu, transform);
            popUpNhiemVu = true;
        }
    }

    public void OnPopUpThemTym()
    {
        if (!popUpThemTym)
        {
            GameObject k = ResourceController.Instance.Initiate(PathResources.PathPopUpThemTym, this.transform);
            popUpThemTym = true;
        }

    }

}
