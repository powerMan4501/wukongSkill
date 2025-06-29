using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.CLRBinding;

internal static class FieldBindingGenerator
{
	internal static string GenerateFieldRegisterCode(this Type type, FieldInfo[] fields, HashSet<FieldInfo> excludes)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (FieldInfo fieldInfo in fields)
		{
			if ((excludes == null || !excludes.Contains(fieldInfo)) && !type.ShouldSkipField(fieldInfo) && !fieldInfo.IsSpecialName)
			{
				stringBuilder.AppendLine($"            field = type.GetField(\"{fieldInfo.Name}\", flag);");
				stringBuilder.AppendLine($"            app.RegisterCLRFieldGetter(field, get_{fieldInfo.Name}_{num});");
				if (!fieldInfo.IsInitOnly && !fieldInfo.IsLiteral)
				{
					stringBuilder.AppendLine($"            app.RegisterCLRFieldSetter(field, set_{fieldInfo.Name}_{num});");
					stringBuilder.AppendLine(string.Format("            app.RegisterCLRFieldBinding(field, CopyToStack_{0}_{1}, AssignFromStack_{0}_{1});", fieldInfo.Name, num));
				}
				else
				{
					stringBuilder.AppendLine($"            app.RegisterCLRFieldBinding(field, CopyToStack_{fieldInfo.Name}_{num}, null);");
				}
				num++;
			}
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateFieldWraperCode(this Type type, FieldInfo[] fields, string typeClsName, HashSet<FieldInfo> excludes, List<Type> valueTypeBinders, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (FieldInfo fieldInfo in fields)
		{
			if ((excludes != null && excludes.Contains(fieldInfo)) || type.ShouldSkipField(fieldInfo))
			{
				continue;
			}
			stringBuilder.AppendLine($"        static object get_{fieldInfo.Name}_{num}(ref object o)");
			stringBuilder.AppendLine("        {");
			if (fieldInfo.IsStatic)
			{
				stringBuilder.AppendLine($"            return {typeClsName}.{fieldInfo.Name};");
			}
			else
			{
				stringBuilder.AppendLine($"            return (({typeClsName})o).{fieldInfo.Name};");
			}
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine($"        static StackObject* CopyToStack_{fieldInfo.Name}_{num}(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)");
			stringBuilder.AppendLine("        {");
			if (fieldInfo.IsStatic)
			{
				stringBuilder.AppendLine($"            var result_of_this_method = {typeClsName}.{fieldInfo.Name};");
			}
			else
			{
				stringBuilder.AppendLine($"            var result_of_this_method = (({typeClsName})o).{fieldInfo.Name};");
			}
			fieldInfo.FieldType.GetClassName(out var clsName, out var realClsName, out var _);
			if (fieldInfo.FieldType.IsValueType && !fieldInfo.FieldType.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(fieldInfo.FieldType))
			{
				stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder != null) {{");
				stringBuilder.AppendLine($"                ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);");
				stringBuilder.AppendLine("                return __ret + 1;");
				stringBuilder.AppendLine("            } else {");
				fieldInfo.FieldType.GetReturnValueCode(stringBuilder, domain);
				stringBuilder.AppendLine("            }");
			}
			else
			{
				fieldInfo.FieldType.GetReturnValueCode(stringBuilder, domain);
			}
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			if (!fieldInfo.IsInitOnly && !fieldInfo.IsLiteral)
			{
				stringBuilder.AppendLine($"        static void set_{fieldInfo.Name}_{num}(ref object o, object v)");
				stringBuilder.AppendLine("        {");
				if (fieldInfo.IsStatic)
				{
					stringBuilder.AppendLine($"            {typeClsName}.{fieldInfo.Name} = ({realClsName})v;");
				}
				else if (type.IsValueType)
				{
					stringBuilder.AppendLine(string.Format("            {0} ins =({0})o;", typeClsName));
					stringBuilder.AppendLine($"            ins.{fieldInfo.Name} = ({realClsName})v;");
					stringBuilder.AppendLine("            o = ins;");
				}
				else
				{
					stringBuilder.AppendLine($"            (({typeClsName})o).{fieldInfo.Name} = ({realClsName})v;");
				}
				stringBuilder.AppendLine("        }");
				stringBuilder.AppendLine();
				stringBuilder.AppendLine($"        static StackObject* AssignFromStack_{fieldInfo.Name}_{num}(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)");
				stringBuilder.AppendLine("        {");
				stringBuilder.AppendLine("            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;");
				fieldInfo.FieldType.AppendArgumentCode(stringBuilder, 0, fieldInfo.Name, valueTypeBinders, isMultiArr: false, hasByRef: false, needFree: false);
				if (fieldInfo.IsStatic)
				{
					stringBuilder.AppendLine(string.Format("            {0}.{1} = @{1};", typeClsName, fieldInfo.Name));
				}
				else if (type.IsValueType)
				{
					stringBuilder.AppendLine(string.Format("            {0} ins =({0})o;", typeClsName));
					stringBuilder.AppendLine(string.Format("            ins.{0} = @{0};", fieldInfo.Name));
					stringBuilder.AppendLine("            o = ins;");
				}
				else
				{
					stringBuilder.AppendLine(string.Format("            (({0})o).{1} = @{1};", typeClsName, fieldInfo.Name));
				}
				stringBuilder.AppendLine("            return ptr_of_this_method;");
				stringBuilder.AppendLine("        }");
				stringBuilder.AppendLine();
			}
			num++;
		}
		return stringBuilder.ToString();
	}

	internal static bool CheckCanPinn(this Type type)
	{
		if (type.IsValueType)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			bool result = true;
			FieldInfo[] array = fields;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].FieldType.IsPrimitive)
				{
					result = false;
					break;
				}
			}
			return result;
		}
		return false;
	}
}
