using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

#if UNITY_EDITOR

public class PolygonalMind_Overlay : MonoBehaviour
{
    //storing  paths so they can be easily modified and accessed
    private const string PolygonalMenuPath = "Polygonal Mind/";
    private const string PublisherPath = PolygonalMenuPath + "Publisher Page";
    private const string GithubPath = PolygonalMenuPath + "Github";
    private const string WebPath = PolygonalMenuPath + "About Polygonal Mind";

    /*
    MenuItem(path, priority) 
    the smaller the prio number, the higher it goes at the menu bar. If empty, random. A bar is included if prio difference >10
    */
    [MenuItem(PublisherPath, priority = 1)]
    private static void AssetStoreAccess() 
    {
	    Application.OpenURL("https://assetstore.unity.com/publishers/36722");
    }

    [MenuItem(GithubPath, priority = 2)]
    private static void GithubAccess() 
    {
	    Application.OpenURL("https://github.com/PolygonalMind");
    }

    [MenuItem(WebPath, priority = 13)]
    private static void WebAccess() 
    {
	    Application.OpenURL("https://www.polygonalmind.com/");
    }

}

#endif