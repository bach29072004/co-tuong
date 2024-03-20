using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public Button btnSoLuongTym, btnNhiemVu, btnSetting, btnThemTym, btnBanBe, btnCoTuong, btnCoUp, btnXemCo,btnThongTin;
    public Canvas canvasCoTuong;
    public void Start()
    {
        /*btnSoLuongTym.onClick.AddListener(() => OnPopUpThemTym());
        btnNhiemVu.onClick.AddListener(() => OnPopUpNhiemVu());
        btnSetting.onClick.AddListener(() => OnPopUpSetting());
        btnThemTym.onClick.AddListener(() => OnPopUpThemTym());
        btnCoTuong.onClick.AddListener(() => OnCanvasCoTuong());
        btnCoUp.onClick.AddListener(() => OnCanvasCoUp());
        btnXemCo.onClick.AddListener(() => OnPopUpXemCo());*/
        btnThongTin.onClick.AddListener(() => OnOffDialog.Instance.OnPopUpThongTin());
        btnNhiemVu.onClick.AddListener(() => OnOffDialog.Instance.OnPopUpNhiemVu());
        btnSoLuongTym.onClick.AddListener(() => OnOffDialog.Instance.OnPopUpThemTym());
        btnSetting.onClick.AddListener(() => OnOffDialog.Instance.OnPopUpSetting());
        btnThemTym.onClick.AddListener(() => OnOffDialog.Instance.OnPopUpThemTym());
        btnCoTuong.onClick.AddListener(() => OnCanvasCoTuong());
    }

    private void OnCanvasCoTuong()
    {
        canvasCoTuong.gameObject.SetActive(true);
    }
    
    
}
