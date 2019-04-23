﻿using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.TestBot
{
    internal static class ActivityHelper
    {
        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        };

        public static string ToJson(IActivity activity) => JsonConvert.SerializeObject(activity, JsonSettings);

        public static Activity Clone(IActivity activity) => JsonConvert.DeserializeObject<Activity>(ToJson(activity));
    }
}