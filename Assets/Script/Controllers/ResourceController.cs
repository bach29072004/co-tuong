using System.Collections;
using System.Collections.Generic;
using Script.Module;
using UnityEngine;

public class ResourceController
{
    private static ResourceController _instance = null;

    public static ResourceController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ResourceController();
            }
            return _instance;
        }
    }

    private ResourceController()
    {
        
    }

    #region thuộc tính

    private Material _blackOcoMaterial = null;

    public Material blackOCoMaterial
    {
        get
        {
            if (_blackOcoMaterial == null)
            {
                Material tmp = Resources.Load<Material>("Materials/BlackMaterial");
                if (tmp != null)
                {
                    _blackOcoMaterial = tmp;
                }
            }

            return _blackOcoMaterial;
        }
    }
    
    private Material _whileOcoMaterial = null;
    public Material whileOCoMaterial
    {
        get
        {
            if (_whileOcoMaterial == null)
            {
                Material tmp = Resources.Load<Material>("Materials/WhileMaterial");
                if (tmp != null)
                {
                    _whileOcoMaterial = tmp;
                }
            }

            return _whileOcoMaterial;
        }
    }

    
    #endregion
    // lay gameObject tu resourse
    private Dictionary<string, GameObject> _dictObj = new Dictionary<string, GameObject>();

    public GameObject GetGameObject(string path)
    {
        if (_dictObj.ContainsKey(path) == false)
        {
            _dictObj.Add(path,Resources.Load<GameObject>(path));
        }

        return _dictObj[path];
    }

    public GameObject Initiate(string path,Transform parent)
    {
        GameObject tmp = GameObject.Instantiate(GetGameObject(path));
        tmp.transform.SetParent(parent);
        tmp.transform.localPosition = Vector3.zero;
        tmp.transform.localScale = Vector3.one;
        return tmp;
    }
}
