using System.Collections;
using System.Collections.Generic;
using Script;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class PopUpThongTinNguoiChoi : MonoBehaviour
{
    public TMP_Text txtName;

    public Image anhDaiDien;
    // Co tuong
    public TMP_Text txtEloCoTuong, txtWinCoTuong, txtLoseCoTuong, txtHangCoTuong;
    //Co up
    public TMP_Text txtEloCoUp, txtWinCoUp, txtLoseCoUp, txtHangCoUp;
    
    public Button btnAnhDaiDien, btnLienKetTaiKhoan, btnXoaTaiKhoan, btnThayTen;

    public void SetInfo(InfoNguoiChoi info)
    {
        txtName.SetText(info.name);
        txtEloCoTuong.SetText(info.eloCoTuong.ToString());
        txtEloCoUp.SetText(info.eloCoUp.ToString());
        txtWinCoTuong.SetText(info.eloCoUp.ToString());
    }
}
