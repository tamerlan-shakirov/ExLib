/* ================================================================
   ----------------------------------------------------------------
   Project   :   ExLib
   Publisher :   Renowned Games
   Developer :   Zinnur Davleev
   ----------------------------------------------------------------
   Copyright 2022-2023 Renowned Games All rights reserved.
   ================================================================ */

using UnityEditor;
using UnityEngine;

namespace RenownedGames.ExLibEditor
{
    public static class HandlesUtility
    {
        #region [Extension Methods]
        public static void DrawSegmentCap(Vector3 from, Vector3 to, float thickness = 1)
        {
            Vector3 d = Vector3.Cross(Camera.current.transform.forward, to - from).normalized * .1f;
            Handles.DrawLine(to - d, to + d, thickness);
        }

        public static void DrawArrowCap(Vector3 from, Vector3 to, float thickness = 1)
        {
            Vector3 r = Vector3.Cross(Camera.current.transform.forward, to - from).normalized * .1f;
            Vector3 d = (from - to) * .1f;

            Handles.DrawLine(to, to + d - r, thickness);
            Handles.DrawLine(to, to + d + r, thickness);
        }

        public static void DrawSphere(Vector3 position, float radius)
        {
            Handles.SphereHandleCap(0, position, Quaternion.identity, radius * 2f, EventType.Repaint);
        }
        #endregion
    }
}