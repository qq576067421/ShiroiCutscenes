﻿using System;

namespace Shiroi.Cutscenes.Serialization {
    public abstract class Serializer {
        public abstract bool Supports(Type type);
        public abstract void Serialize(object value, string name, ISerializedObject destination);
        public abstract object Deserialize(string key, ISerializedObject obj);
    }

    public abstract class Serializer<T> : Serializer {
        private readonly Type supportedType;
        public override bool Supports(Type type) {
            return supportedType.IsAssignableFrom(type);
        }

        protected Serializer() {
            this.supportedType = typeof(T);
        }

        public override void Serialize(object value, string name, ISerializedObject destination) {
            Serialize((T) value, name, destination);
        }


        public abstract void Serialize(T value, string name, ISerializedObject destination);
    }
}