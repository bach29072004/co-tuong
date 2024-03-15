using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using Script.Module;
using UnityEngine;

public class BanCo : MonoBehaviour
{
    public static BanCo instance;
    public GameObject oCoPf;
    private OCo[][] _oCos;
    public float KhoangCachOCo;
    public GameObject matBanCo, cacQuanCo;
    public OCo[][] OCos
    {
        get
        {
            return _oCos;
        }
    }

    private Vector3 basePosition;

    private void Awake()
    {
        instance = this;
    }
    [ContextMenu("intitBanCo")]
    public void InitBanCo()
    {
        KhoangCachOCo = 900f / 9f;
        
        basePosition = new Vector3(-4f * KhoangCachOCo, -4.5f * KhoangCachOCo, 0);
        _oCos = new OCo[9][];
        for (int i = 0; i < 9; i++)
        {
            _oCos[i] = new OCo[10];
            for (int j = 0; j < 10; j++)
            {
                GameObject OCoClone = GameObject.Instantiate(oCoPf,matBanCo.transform);
                //OCoClone.transform.SetParent(matBanCo.transform);
                OCoClone.transform.localScale = Vector3.one;
                OCoClone.transform.localPosition = TinhToanViTriOCo(i, j);
                _oCos[i][j] = OCoClone.GetComponent<OCo>();
            }
        }
    }
    public Vector3 TinhToanViTriOCo(int i, int j)
    {
        return basePosition + new Vector3(i * KhoangCachOCo, j * KhoangCachOCo, 0);
    }
    private List<QuanCo> listQuanCo;
    [ContextMenu("InitQuanCO")]
    public void InitQuanCo()
    {
        //Khoi tao quan co va rfset vi tri dau cho chung
        listQuanCo = new List<QuanCo>();
        List<QuanCoInfo> listInfo = new List<QuanCoInfo>();
        listInfo.Clear();
        //Tot
        listInfo.Add(new QuanCoInfo("QuanTotDen1",PathResources.PathQuanTotDen,0,3));
        listInfo.Add(new QuanCoInfo("QuanTotDen2",PathResources.PathQuanTotDen,2,3));
        listInfo.Add(new QuanCoInfo("QuanTotDen3",PathResources.PathQuanTotDen,4,3));
        listInfo.Add(new QuanCoInfo("QuanTotDen4",PathResources.PathQuanTotDen,6,3));
        listInfo.Add(new QuanCoInfo("QuanTotDen5",PathResources.PathQuanTotDen,8,3));
        
        listInfo.Add(new QuanCoInfo("QuanTotDo1",PathResources.PathQuanTotDo,0,6));
        listInfo.Add(new QuanCoInfo("QuanTotDo2",PathResources.PathQuanTotDo,2,6));
        listInfo.Add(new QuanCoInfo("QuanTotDo3",PathResources.PathQuanTotDo,4,6));
        listInfo.Add(new QuanCoInfo("QuanTotDo4",PathResources.PathQuanTotDo,6,6));
        listInfo.Add(new QuanCoInfo("QuanTotDo5",PathResources.PathQuanTotDo,8,6));
        
        //Xe
        listInfo.Add(new QuanCoInfo("QuanXeDen1",PathResources.PathQuanXeDen,0,0));
        listInfo.Add(new QuanCoInfo("QuanXeDen2",PathResources.PathQuanXeDen,8,0));
        
        listInfo.Add(new QuanCoInfo("QuanXeDo1",PathResources.PathQuanXeDo,0,9));
        listInfo.Add(new QuanCoInfo("QuanXeDo2",PathResources.PathQuanXeDo,8,9));
        
        //Phao
        listInfo.Add(new QuanCoInfo("QuanPhaoDen1",PathResources.PathQuanPhaoDen,1,2));
        listInfo.Add(new QuanCoInfo("QuanPhaoDen2",PathResources.PathQuanPhaoDen,7,2));
        
        listInfo.Add(new QuanCoInfo("QuanPhaoDo1",PathResources.PathQuanPhaoDo,1,7));
        listInfo.Add(new QuanCoInfo("QuanPhaoDo2",PathResources.PathQuanPhaoDo,7,7));
        
        //Ma
        listInfo.Add(new QuanCoInfo("QuanMaDen1",PathResources.PathQuanMaDen,1,0));
        listInfo.Add(new QuanCoInfo("QuanMaDen2",PathResources.PathQuanMaDen,7,0));
        
        listInfo.Add(new QuanCoInfo("QuanMaDo1",PathResources.PathQuanMaDo,1,9));
        listInfo.Add(new QuanCoInfo("QuanMaDo2",PathResources.PathQuanMaDo,7,9));
        
        //Tuong
        listInfo.Add(new QuanCoInfo("QuanTuongDen1",PathResources.PathQuanTuongDen,2,0));
        listInfo.Add(new QuanCoInfo("QuanTuongDen2",PathResources.PathQuanTuongDen,6,0));
        
        listInfo.Add(new QuanCoInfo("QuanTuongDo1",PathResources.PathQuanTuongDo,2,9));
        listInfo.Add(new QuanCoInfo("QuanTuongDo2",PathResources.PathQuanTuongDo,6,9));
        
        //Si
        listInfo.Add(new QuanCoInfo("QuanSiDen1",PathResources.PathQuanSiDen,3,0));
        listInfo.Add(new QuanCoInfo("QuanSiDen2",PathResources.PathQuanSiDen,5,0));
        
        listInfo.Add(new QuanCoInfo("QuanSiDo1",PathResources.PathQuanSiDo,3,9));
        listInfo.Add(new QuanCoInfo("QuanSiDo2",PathResources.PathQuanSiDo,5,9));
        
        //Vua
        listInfo.Add(new QuanCoInfo("QuanVuaDen",PathResources.PathQuanVuaDen,4,0));
        
        listInfo.Add(new QuanCoInfo("QuanVuaDo",PathResources.PathQuanVuaDo,4,9));
        

        foreach (var tmp in listInfo)
        {
            GameObject Obj = GameObject.Instantiate(ResourceController.Instance.GetGameObject(tmp.Path));
            Obj.transform.SetParent(cacQuanCo.transform);
            QuanCo k = Obj.GetComponent<QuanCo>();
            k.SetViTriDauTien(tmp.X,tmp.Y);
            listQuanCo.Add(k);
            
        }
        
        
    }
    
}
