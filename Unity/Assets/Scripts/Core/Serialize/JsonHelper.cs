using System;
using System.IO;

namespace ET
{
    public static class JsonHelper
    {
        public static string ToJson(object obj)
        {
            return MongoHelper.ToJson(obj);
        }

        public static T FromJson<T>(string str)
        {
            return MongoHelper.FromJson<T>(str);
        }

        public static object FromJson(Type type, string str)
        {
            return MongoHelper.FromJson(type, str);
        }

        public static byte[] Serialize(object obj)
        {
            return MongoHelper.Serialize(obj);
        }

        public static void Serialize(object message, MemoryStream stream)
        {
            MongoHelper.Serialize(message, stream);
        }

        public static object Deserialize(Type type, byte[] bytes)
        {
            return MongoHelper.Deserialize(type, bytes);
        }

        public static object Deserialize(Type type, byte[] bytes, int index, int count)
        {
            return MongoHelper.Deserialize(type, bytes, index, count);
        }

        public static object Deserialize(Type type, MemoryStream stream)
        {
            return MongoHelper.Deserialize(type, stream);
        }

        public static T Deserialize<T>(byte[] bytes)
        {
            return MongoHelper.Deserialize<T>(bytes);
        }

        public static T Deserialize<T>(byte[] bytes, int index, int count)
        {
            return MongoHelper.Deserialize<T>(bytes, index, count);
        }
    }
}