using UnityEditor;
using System.IO;
using UnityEngine;

public class CreateAssetBundles
{
    [MenuItem("Tools/Asset Bundles/Build Android")]
    static void BuildAndroidAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles/Android";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.Android);
    }
    [MenuItem("Tools/Asset Bundles/Build iOS")]
    static void BuildIosAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles/iOS";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.iOS);
    }
    [MenuItem("Tools/Asset Bundles/Build Window")]
    static void BuildWindowAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles/Window";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
