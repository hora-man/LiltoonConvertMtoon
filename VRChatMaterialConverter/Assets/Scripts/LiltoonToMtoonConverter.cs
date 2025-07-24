using UnityEngine;

public static class LiltoonToMtoonConverter
{
    // avatarClone内の全てのRendererのマテリアルを変換
    public static void ConvertAllMaterials(GameObject avatarClone)
    {
        var renderers = avatarClone.GetComponentsInChildren<Renderer>(true);
        foreach (var renderer in renderers)
        {
            for (int i = 0; i < renderer.sharedMaterials.Length; i++)
            {
                Material mat = renderer.sharedMaterials[i];
                if (mat != null && IsLiltoonMaterial(mat))
                {
                    renderer.sharedMaterials[i] = ConvertLiltoonToMtoon(mat);
                }
            }
        }
    }

    // Liltoonマテリアルか判定（例: Shader名で判定）
    private static bool IsLiltoonMaterial(Material mat)
    {
        return mat.shader != null && mat.shader.name.Contains("lilToon");
    }

    // LiltoonマテリアルをMtoonマテリアルに変換（必要に応じてプロパティをコピー）
    private static Material ConvertLiltoonToMtoon(Material lilMat)
    {
        Shader mtoonShader = Shader.Find("VRM/MToon");
        if (mtoonShader == null)
        {
            Debug.LogError("MToonシェーダーが見つかりません。");
            return lilMat;
        }

        Material mtoonMat = new Material(mtoonShader);
        mtoonMat.name = lilMat.name + "_Mtoon";

        // 例: MainTextureとColorをコピー
        if (lilMat.HasProperty("_MainTex"))
            mtoonMat.SetTexture("_MainTex", lilMat.GetTexture("_MainTex"));
        if (lilMat.HasProperty("_Color"))
            mtoonMat.SetColor("_Color", lilMat.GetColor("_Color"));

        // 代表的なMToonプロパティを可能な限りコピー
        string[] colorProps = {
            "_Color", "_ShadeColor", "_EmissionColor", "_OutlineColor", "_RimColor", "_MatCapColor"
        };
        foreach (var prop in colorProps)
        {
            if (lilMat.HasProperty(prop) && mtoonMat.HasProperty(prop))
                mtoonMat.SetColor(prop, lilMat.GetColor(prop));
        }

        string[] textureProps = {
            "_MainTex", "_ShadeTexture", "_BumpMap", "_EmissionMap", "_RimTexture", "_SphereAdd", "_MatCap", "_MatCapSampler"
        };
        foreach (var prop in textureProps)
        {
            if (lilMat.HasProperty(prop) && mtoonMat.HasProperty(prop))
                mtoonMat.SetTexture(prop, lilMat.GetTexture(prop));
        }

        string[] floatProps = {
            "_BumpScale", "_Cutoff", "_OutlineWidth", "_OutlineWidthMode", "_OutlineColorMode",
            "_ReceiveShadowRate", "_ShadingGradeRate", "_LightColorAttenuation", "_IndirectLightIntensity",
            "_RimLightingMix", "_RimFresnelPower", "_RimLift", "_SphereAddIntensity", "_MatCapBlend", "_MatCapScale"
        };
        foreach (var prop in floatProps)
        {
            if (lilMat.HasProperty(prop) && mtoonMat.HasProperty(prop))
                mtoonMat.SetFloat(prop, lilMat.GetFloat(prop));
        }

        // 必要に応じて他の型（Vector, Intなど）も追加可能

        return mtoonMat;
    }
}