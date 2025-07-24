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