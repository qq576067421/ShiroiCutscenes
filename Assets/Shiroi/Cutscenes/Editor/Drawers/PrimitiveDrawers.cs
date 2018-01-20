﻿using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Shiroi.Cutscenes.Editor.Drawers {
    public class EnumDrawer : TypeDrawer {
        public override bool Supports(Type type) {
            return type.IsEnum;
        }

        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, object value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.EnumPopup(rect, name, (Enum) value));
        }
    }

    public class BooleanDrawer : TypeDrawer<bool> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, bool value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.Toggle(rect, name, value));
        }
    }

    public class ByteDrawer : TypeDrawer<byte> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, byte value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((byte) EditorGUI.IntField(rect, name, value));
        }
    }

    public class CharDrawer : TypeDrawer<char> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, char value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((char) EditorGUI.IntField(rect, name, value));
        }
    }

    public class DecimalDrawer : TypeDrawer<decimal> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, decimal value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((decimal) EditorGUI.DoubleField(rect, name, (double) value));
        }
    }

    public class DoubleDrawer : TypeDrawer<double> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, double value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.DoubleField(rect, name, value));
        }
    }

    public class Int16Drawer : TypeDrawer<short> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, short value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((short) EditorGUI.IntField(rect, name, value));
        }
    }

    public class Int32Drawer : TypeDrawer<int> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, int value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.IntField(rect, name, value));
        }
    }

    public class Int64Drawer : TypeDrawer<long> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, long value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.LongField(rect, name, value));
        }
    }

    public class SByteDrawer : TypeDrawer<sbyte> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, sbyte value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((sbyte) EditorGUI.IntField(rect, name, value));
        }
    }

    public class FloatDrawer : TypeDrawer<float> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, float value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.FloatField(rect, name, value));
        }
    }

    public class StringDrawer : TypeDrawer<string> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, string value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter(EditorGUI.TextField(rect, name, value));
        }
    }

    public class UInt16Drawer : TypeDrawer<ushort> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, ushort value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((ushort) EditorGUI.IntField(rect, name, value));
        }
    }

    public class UInt32Drawer : TypeDrawer<uint> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, uint value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((uint) EditorGUI.LongField(rect, name, value));
        }
    }

    public class UInt64Drawer : TypeDrawer<ulong> {
        public override void Draw(CutscenePlayer player, Cutscene cutscene, Rect rect, int tokenIndex, string name, ulong value, Type valueType, FieldInfo fieldInfo, Setter setter) {
            setter((ulong) EditorGUI.LongField(rect, name, (long) value));
        }
    }
}