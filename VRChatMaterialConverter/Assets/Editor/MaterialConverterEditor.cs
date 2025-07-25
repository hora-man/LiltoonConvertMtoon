using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MaterialConverter))]
public class MaterialConverterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MaterialConverter converter = (MaterialConverter)target;

        if (GUILayout.Button("Convert Liltoon to Mtoon"))
        {
            converter.ConvertMaterials();
        }
    }
}

// --- 追加: Toolsメニューから起動できるウィンドウ ---
public class MaterialConverterWindow : EditorWindow
{
    private MaterialConverter converter;

    [MenuItem("Tools/Material Converter")]
    public static void ShowWindow()
    {
        GetWindow<MaterialConverterWindow>("Material Converter");
    }

    private void OnGUI()
    {
        GUILayout.Label("Material Converter", EditorStyles.boldLabel);

        converter = (MaterialConverter)EditorGUILayout.ObjectField(
            "Material Converter",
            converter,
            typeof(MaterialConverter),
            true);

        if (converter != null)
        {
            if (GUILayout.Button("Convert Liltoon to Mtoon"))
            {
                converter.ConvertMaterials();
            }
        }
        else
        {
            EditorGUILayout.HelpBox("MaterialConverterをシーン内から選択してください。", MessageType.Info);
        }
    }
}
