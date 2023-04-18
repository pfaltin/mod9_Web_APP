using System;
using DemoWebShop.Services.Cart;
using Newtonsoft.Json;

namespace DemoWebShop.Services
{
    public static class SessionExtensions
    {
        public static void SetCartObjectAsJSON(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static List<CartItem>? GetCartItemFromJson(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(value);
        }
    }
}



