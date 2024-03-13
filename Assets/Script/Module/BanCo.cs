using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanCo : MonoBehaviour
{
    public GameObject oCoPf;
    private OCo[][] _oCos;
    public float SizeOfOCo = 90;
    public OCo[][] OCos
    {
        get
        {
            return _oCos;
        }
    }

    private Vector3 basePosition;
    public void InitBanCo()
    {
        SizeOfOCo = oCoPf.GetComponent<Renderer>().bounds.size.x*1.2f;
        basePosition = new Vector3(-4f * SizeOfOCo, -4.5f * SizeOfOCo, 0);
        _oCos = new OCo[9][];
        for (int i = 0; i < 9; i++)
        {
            _oCos[i] = new OCo[10];
            for (int j = 0; j < 10; j++)
            {
                GameObject OCoClone = GameObject.Instantiate(oCoPf,TinhToanViTriOCo(i,j),Quaternion.identity);
                OCoClone.transform.SetParent(gameObject.transform);
                _oCos[i][j] = OCoClone.GetComponent<OCo>();
            }
        }
    }

    private List<QuanCo> ListQuanCo;
    [ContextMenu("InitQuanCO")]
    public void InitQuanCo()
    {
        //Khoi tao quan co va rfset vi tri dau cho chung
        ListQuanCo = new List<QuanCo>();
        
        //Xe
    }
    public Vector3 TinhToanViTriOCo(int i, int j)
    {
        return basePosition + new Vector3(i * SizeOfOCo, j * SizeOfOCo, 0);
    }

    [ContextMenu("check")]
    public void Check()
    {
        InitBanCo();
    }
}
