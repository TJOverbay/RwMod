using RwMod.Model;

namespace RwMod.Console.Renderers
{
    public static class Rendering_Extensions
    {
        public static string ToStringOrDefault(this string value, string defaultValue = "[null]")
        {
            if (string.IsNullOrWhiteSpace(value))
                return defaultValue;
            else
                return value;
        }

        public static string ToRenderString(this FloatRange range)
        {
            if (range != null)
            {
                return $"{range.Min} - {range.Max}";
            }
            else
            {
                return "0 to 0";
            }
        }

        public static string ToRenderString(this KeyedValue kv)
        {
            if (kv != null)
            {
                return $"{kv.Key.ToStringOrDefault()} :: {kv.Value}";
            }
            else
            {
                return "[null]";
            }
        }
    }
}
