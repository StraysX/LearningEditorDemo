using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using Sirenix.Utilities;

public class PictureImportSettingWindow : OdinMenuEditorWindow
{
    public bool OpenAutoSetting;
    [MenuItem("Tools/图片导入数据配置窗口")]
    private static void OpenWindow()
    {
        var window = GetWindow<PictureImportSettingWindow>();
        window.position = GUIHelper.GetEditorWindowRect().AlignCenter(400, 600);
    }

	protected override OdinMenuTree BuildMenuTree()
	{
		return new OdinMenuTree(supportsMultiSelect: true);
	}

	//[MenuItem("Tools/图片导入数据配置窗口")]
	//private static void OpenWindow()
	//{
	//    var window = GetWindow<PictureImportSettingWindow>();
	//    window.position = GUIHelper.GetEditorWindowRect().AlignCenter(400, 600);
	//}



}
