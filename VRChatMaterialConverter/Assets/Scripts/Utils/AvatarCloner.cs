using UnityEngine;

namespace VRChatMaterialConverter.Utils
{
    public static class AvatarCloner
    {
        public static GameObject CloneAvatar(GameObject originalAvatar)
        {
            // Create a clone of the original avatar
            GameObject clone = Object.Instantiate(originalAvatar);

            // 名前を「元のアバター名(Clone)」に変更
            clone.name = originalAvatar.name + "_MtoonClone";

            // Optionally, you can modify the clone here if needed

            // Return the cloned avatar
            return clone;
        }
    }
}