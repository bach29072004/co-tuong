using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public Button btnSoLuongTym, btnNhiemVu, btnSetting, btnThemTym, btnBanBe, btnCoTuong, btnCoUp, btnXemCo;

    public void Start()
    {
        btnSoLuongTym.onClick.AddListener(() => OnPopUpThemTym());
        btnNhiemVu.onClick.AddListener(() => OnPopUpNhiemVu());
        btnSetting.onClick.AddListener(() => OnPopUpSetting());
        btnThemTym.onClick.AddListener(() => OnPopUpThemTym());
        btnCoTuong.onClick.AddListener(() => OnCanvasCoTuong());
        btnCoUp.onClick.AddListener(() => OnCanvasCoUp());
        btnXemCo.onClick.AddListener(() => OnPopUpXemCo());
    }

    private void OnPopUpXemCo()
    {
        //GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopup));
    }

    private void OnCanvasCoUp()
    {
      //  throw new NotImplementedException();
    }

    private void OnCanvasCoTuong()
    {
      //  throw new NotImplementedException();
    }

    private void OnPopUpSetting()
    {
        GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopUpSetting));
    }

    private void OnPopUpNhiemVu()
    {
        GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopUpNhiemVu));
    }

    private void OnPopUpThemTym()
    {
        GameObject.Instantiate(ResourceController.Instance.GetGameObject(PathResources.PathPopUpThemTym));
    }
    
    
}
