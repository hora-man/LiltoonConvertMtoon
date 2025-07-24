using UnityEngine;
using VRChatMaterialConverter.Utils;

public class MaterialConverter : MonoBehaviour
{
    [Header("変換対象アバターのルート")]
    public GameObject avatarRoot;

    public void ConvertMaterials()
    {
        if (avatarRoot == null)
        {
            Debug.LogError("avatarRootが設定されていません。");
            return;
        }

        GameObject avatarClone = AvatarCloner.CloneAvatar(avatarRoot);
        avatarClone.name = avatarRoot.name + "_MtoonClone";

        // マテリアル変換処理
        LiltoonToMtoonConverter.ConvertAllMaterials(avatarClone);

        Debug.Log("変換完了: " + avatarClone.name);
    }
}