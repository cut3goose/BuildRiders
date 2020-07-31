using UnityEngine;
using UnityEngine.UI;

public class ChooseSkin : MonoBehaviour
{
    public RawImage skinPreview;
    public Texture[] skinList = new Texture[8];

    void Start()
    {
        //тут должно быть обращение в память, чтобы понять какой скин у игрока сейчас
        //skinPreview = UserInfo.CurrentSkinNumber;
        skinPreview.texture = skinList[0];
    }

    public void ChooseSkinButton(int skinNumber)
    {
        skinPreview.texture = skinList[skinNumber - 1];
    }
}
