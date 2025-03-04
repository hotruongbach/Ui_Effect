﻿using UnityEngine;

/// <summary>
/// From https://forum.unity.com/threads/how-to-assign-matrix4x4-to-transform.121966/
/// </summary>
public static class TransformExtensions
{
    public static void FromMatrix(this Transform transform, Matrix4x4 matrix)
    {
        transform.localScale = matrix.ExtractScale();
        transform.localRotation = matrix.ExtractRotation();
        transform.localPosition = matrix.ExtractPosition();
    }
}
