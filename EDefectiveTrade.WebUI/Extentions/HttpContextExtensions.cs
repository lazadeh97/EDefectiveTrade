﻿using System.Text.Json;

namespace EDefectiveTrade.WebUI.Extentions
{
    public static class HttpContextExtensions
    {
        public static T GetObject<T>(this ISession session, string key)
        {
            var data = session.GetString(key);
            return data == null ? default : JsonSerializer.Deserialize<T>(data);
        }

        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
    }
}
