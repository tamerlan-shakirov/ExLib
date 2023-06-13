/* ================================================================
   ----------------------------------------------------------------
   Project   :   ExLib
   Company   :   Renowned Games
   Developer :   Tamerlan Shakirov
   ----------------------------------------------------------------
   Copyright 2022-2023 Renowned Games All rights reserved.
   ================================================================ */

using UnityEngine;
using UnityEditor;
using System.IO;

namespace RenownedGames.ExLibEditor
{
    public static class ScriptableObjectUtility
    {
        /// <summary>
        /// Create scriptable object as asset file in project. 
        /// </summary>
        /// <param name="path">Path relative 'Assets' folder.</param>
        public static void CreateAsset(this ScriptableObject scriptableObject, string path)
        {
            string directory = Path.GetDirectoryName($"{Application.dataPath}/{path}");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            path = "Assets/" + path;
            path = AssetDatabase.GenerateUniqueAssetPath(path);
            AssetDatabase.CreateAsset(scriptableObject, path);
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// Create scriptable object as asset file in project. 
        /// </summary>
        /// <param name="path">Path relative '/Assets' folder.</param>
        public static void CreateAsset(this ScriptableObject scriptableObject)
        {
            scriptableObject.CreateAsset($"{scriptableObject.GetType().Name}.asset");
        }
    }
}
