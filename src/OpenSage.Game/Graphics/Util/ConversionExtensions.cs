﻿using System.Numerics;
using OpenSage.Data.W3d;

namespace OpenSage.Graphics.Util
{
    public static class ConversionExtensions
    {
        public static Vector2 ToVector2(this W3dTexCoord value)
        {
            return new Vector2(value.U, value.V);
        }

        public static Vector3 ToVector3(this W3dVector value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }

        public static Vector3 ToVector3(this W3dRgb value)
        {
            return new Vector3(value.R / 255.0f, value.G / 255.0f, value.B / 255.0f);
        }

        public static Quaternion ToQuaternion(this W3dQuaternion value)
        {
            return new Quaternion(value.X, value.Y, value.Z, value.W);
        }
    }
}
