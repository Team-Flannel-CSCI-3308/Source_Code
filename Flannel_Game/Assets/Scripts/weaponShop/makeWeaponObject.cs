using System.Collections;
using UnityEditor;
using UnityEngine;

public class makeWeaponObject
{
    
    [MenuItem("Assets/Create/Weapon Object")]
	public static void Create()
    {
        weaponObject asset = ScriptableObject.CreateInstance<weaponObject> ();
        AssetDatabase.CreateAsset(asset, "Assets/NewWeaponObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
