using System;
using System.Reflection;
using System.Text;

namespace ILRuntime.Runtime.CLRBinding;

internal static class ValueTypeBindingGenerator
{
	internal static string GenerateValueTypeRegisterCode(this Type type, string typeClsName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (type.IsValueType && !type.IsPrimitive && !type.IsEnum)
		{
			stringBuilder.AppendLine("            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);");
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateCloneWraperCode(this Type type, FieldInfo[] fields, string typeClsName)
	{
		if (!type.IsValueType || type.IsPrimitive)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("        static object PerformMemberwiseClone(ref object o)");
		stringBuilder.AppendLine("        {");
		stringBuilder.AppendLine($"            var ins = new {typeClsName}();");
		stringBuilder.AppendLine($"            ins = ({typeClsName})o;");
		stringBuilder.AppendLine("            return ins;");
		stringBuilder.AppendLine("        }");
		return stringBuilder.ToString();
	}
}
