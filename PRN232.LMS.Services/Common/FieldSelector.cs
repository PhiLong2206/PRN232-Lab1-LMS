using System.Reflection;

namespace PRN232.LMS.Services.Common;

public static class FieldSelector
{
    public static object SelectFields<T>(T source, string? fields)
    {
        if (source == null)
        {
            return new { };
        }

        if (string.IsNullOrWhiteSpace(fields))
        {
            return source;
        }

        var selectedFields = fields
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        var result = new Dictionary<string, object?>();

        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var field in selectedFields)
        {
            var property = properties.FirstOrDefault(p =>
                string.Equals(p.Name, field, StringComparison.OrdinalIgnoreCase));

            if (property != null)
            {
                result[ToCamelCase(property.Name)] = property.GetValue(source);
            }
        }

        return result;
    }

    public static IEnumerable<object> SelectFields<T>(
     IEnumerable<T> sources,
     string? fields)
    {
        if (string.IsNullOrWhiteSpace(fields))
        {
            return sources.Cast<object>().ToList();
        }

        return sources
            .Select(x => (object)SelectFields(x, fields))
            .ToList();
    }

    private static string ToCamelCase(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        return char.ToLowerInvariant(value[0]) + value[1..];
    }
}