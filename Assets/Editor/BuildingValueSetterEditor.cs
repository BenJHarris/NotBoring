using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BuildingValueSetter))]
public class BuildingValueSetterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        serializedObject.Update();

        BuildingValueSetter buildingValueSetter = (BuildingValueSetter)target;

        BoxCollider2D collider = buildingValueSetter.GetComponent<BoxCollider2D>();

        if (GUILayout.Button("Set values"))
        {
            BuildingData data = buildingValueSetter.buildingData;

            if (buildingValueSetter.buildingRenderer != null)
            {
                SerializedObject serializedBuildingRenderer = new SerializedObject(buildingValueSetter.buildingRenderer);
                serializedBuildingRenderer.FindProperty("m_Sprite").objectReferenceValue = data.Sprite;

                serializedBuildingRenderer.ApplyModifiedProperties();

                SerializedObject serializedBuildingRendererTransform = new SerializedObject(buildingValueSetter.buildingRenderer.transform);

                serializedBuildingRendererTransform.FindProperty("m_LocalPosition").vector3Value = data.SpriteOffset;

                serializedBuildingRendererTransform.ApplyModifiedProperties();
            }

            if (buildingValueSetter.backgroundRenderer != null)
            {
                SerializedObject serializedBackgroundRenderer = new SerializedObject(buildingValueSetter.backgroundRenderer);
                serializedBackgroundRenderer.FindProperty("m_Size").vector2Value = data.FloorSize;

                serializedBackgroundRenderer.ApplyModifiedProperties();
            }

            if (collider != null)
            {
                SerializedObject serializedCollider = new SerializedObject(collider);
                serializedCollider.FindProperty("m_Size").vector2Value = data.FloorSize;

                serializedCollider.ApplyModifiedProperties();
            }
        }
    }
}
