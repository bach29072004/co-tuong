using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotifyController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtTextScroll;
    [SerializeField] private GameObject khungNotify;
    public GameObject bg;
    public Transform tranScale;
    public bool isPlay = false;
    
    private void Start()
    {
        if (tranScale != null)
        {
            float scale = (float)Screen.width / 900;
            if ((float)Screen.height / 1952 < scale)
            {
                scale = (float)Screen.height / 1952;
            }
        }
        khungNotify.gameObject.SetActive(false);
        isPlay = false;
    }

    public void SetUpdateNotify()
    {
        if (!isPlay)
        {
            SetPlayNotify();
        }
    }

    public void StopNotify()
    {
        if (_iENotify != null)
        {
            StopCoroutine(_iENotify);
        }
        khungNotify.gameObject.SetActive(false);
        Data.Instance.ListNotifyData.Clear();
    }

    private void OnEnable()
    {
        Data.Instance.ListNotifyData.Add("bachhkjahdk fakljjdfa sh aksjdh akjlsdh  sakdjh");
        SetPlayNotify();
    }

    public void SetPlayNotify()
    {
        if (Data.Instance.ListNotifyData.Count > 0)
        {
            if (_iENotify != null)
            {
                StopCoroutine(_iENotify);
                _iENotify = SetNotify();
                StartCoroutine(_iENotify);
            }
            else
            {
                _iENotify = SetNotify();
                StartCoroutine(_iENotify); 
            }
        }
    }
    
    private IEnumerator _iENotify;
    
    private IEnumerator SetNotify()
    {
        isPlay = true;
        
        //int totalTime = Data.Instance.ListNotifyData[0].totalTime;
        int totalTime = 20;
        //if (UserData.Instance.CurrentStepGuide > 25)
        {
            khungNotify.gameObject.SetActive(true);
            txtTextScroll.text = Data.Instance.ListNotifyData[0];
            float w = LayoutUtility.GetPreferredWidth(txtTextScroll.rectTransform);
            //txtTextScroll.transform.DOKill();
            StartCoroutine(MoveObject(new Vector3(660 + w/2, 0, 0), new Vector3(-w/2 - 660, -1.1f, 0), totalTime));
        }

        yield return new WaitForSeconds(totalTime);
        Data.Instance.ListNotifyData.Remove(Data.Instance.ListNotifyData[0]);
        khungNotify.gameObject.SetActive(false);
        SetPlayNotify();
    }
    
    private IEnumerator MoveObject(Vector3 startPos, Vector3 targetPos, float duration)
    {
        float time = 0;
        float rate = 1 / duration;
        while (time < 1)
        {
            time += rate * Time.deltaTime;
            txtTextScroll.transform.localPosition = Vector3.Lerp(startPos, targetPos, time);
            yield return 0;
        }

        isPlay = false;
    }

    private void OnDisable()
    {
        if (_iENotify != null)
        {
            isPlay = false;
            StopCoroutine(_iENotify);
            if (Data.Instance.ListNotifyData.Count > 0)
            {
                Data.Instance.ListNotifyData.Remove(Data.Instance.ListNotifyData[0]);
            }
            khungNotify.gameObject.SetActive(false);
        }
    }
}
