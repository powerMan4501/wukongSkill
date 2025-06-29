using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.CLRBinding;

internal static class BindingGeneratorExtensions
{
	internal static bool ShouldSkipField(this Type type, FieldInfo i)
	{
		if (i.IsPrivate)
		{
			return true;
		}
		if (i.IsSpecialName)
		{
			return true;
		}
		if (i.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
		{
			return true;
		}
		return false;
	}

	internal static bool ShouldSkipMethod(this Type type, MethodBase i)
	{
		if (i.IsPrivate)
		{
			return true;
		}
		if (i.IsGenericMethodDefinition)
		{
			return true;
		}
		if (i.IsConstructor && type.IsAbstract)
		{
			return true;
		}
		if (i is MethodInfo && ((MethodInfo)i).ReturnType.IsByRef)
		{
			return true;
		}
		ParameterInfo[] parameters = i.GetParameters();
		if (i.IsSpecialName)
		{
			string[] array = i.Name.Split(new char[1] { '_' });
			if (array[0] == "add" || array[0] == "remove")
			{
				return false;
			}
			if (array[0] == "get" || array[0] == "set")
			{
				int num = ((array[0] == "set") ? (parameters.Length - 1) : parameters.Length);
				Type[] array2;
				if (num > 0)
				{
					array2 = new Type[num];
					for (int j = 0; j < num; j++)
					{
						array2[j] = parameters[j].ParameterType;
					}
				}
				else
				{
					array2 = new Type[0];
				}
				PropertyInfo property = type.GetProperty(array[1], array2);
				if (property == null)
				{
					return true;
				}
				if (property.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
				{
					return true;
				}
			}
		}
		if (i.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
		{
			return true;
		}
		ParameterInfo[] array3 = parameters;
		for (int k = 0; k < array3.Length; k++)
		{
			if (array3[k].ParameterType.IsPointer)
			{
				return true;
			}
		}
		return false;
	}

	internal static void AppendParameters(this ParameterInfo[] param, StringBuilder sb, bool isMultiArr = false, int skipLast = 0)
	{
		bool flag = true;
		for (int i = 0; i < param.Length - skipLast; i++)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				sb.Append(", ");
			}
			ParameterInfo parameterInfo = param[i];
			if (parameterInfo.IsOut && parameterInfo.ParameterType.IsByRef)
			{
				sb.Append("out ");
			}
			else if (parameterInfo.IsIn && parameterInfo.ParameterType.IsByRef)
			{
				sb.Append("in ");
			}
			else if (parameterInfo.ParameterType.IsByRef)
			{
				sb.Append("ref ");
			}
			if (isMultiArr)
			{
				sb.Append("a");
				sb.Append(i + 1);
			}
			else
			{
				sb.Append("@");
				sb.Append(parameterInfo.Name);
			}
		}
	}

	internal static void AppendArgumentCode(this Type p, StringBuilder sb, int idx, string name, List<Type> valueTypeBinders, bool isMultiArr, bool hasByRef, bool needFree)
	{
		p.GetClassName(out var clsName, out var realClsName, out var isByRef);
		Type type = (p.IsByRef ? p.GetElementType() : p);
		string arg = (hasByRef ? "false" : "true");
		if (type.IsValueType && !type.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(type))
		{
			if (isMultiArr)
			{
				sb.AppendLine(string.Format("            {0} a{1} = new {0}();", realClsName, idx));
			}
			else
			{
				sb.AppendLine(string.Format("            {0} @{1} = new {0}();", realClsName, name));
			}
			sb.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder != null) {{");
			if (isMultiArr)
			{
				sb.AppendLine(string.Format("                ILRuntime.Runtime.Generated.CLRBindings.s_{1}_Binder.ParseValue(ref a{0}, __intp, ptr_of_this_method, __mStack, {2});", idx, clsName, arg));
			}
			else
			{
				sb.AppendLine(string.Format("                ILRuntime.Runtime.Generated.CLRBindings.s_{1}_Binder.ParseValue(ref @{0}, __intp, ptr_of_this_method, __mStack, {2});", name, clsName, arg));
			}
			sb.AppendLine("            } else {");
			if (isByRef)
			{
				sb.AppendLine("                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);");
			}
			if (isMultiArr)
			{
				sb.AppendLine($"                a{idx} = {p.GetRetrieveValueCode(realClsName)};");
			}
			else
			{
				sb.AppendLine($"                @{name} = {p.GetRetrieveValueCode(realClsName)};");
			}
			if (!hasByRef && needFree)
			{
				sb.AppendLine("                __intp.Free(ptr_of_this_method);");
			}
			sb.AppendLine("            }");
		}
		else if (isByRef)
		{
			if (p.GetElementType().IsPrimitive)
			{
				if (type == typeof(int) || type == typeof(uint) || type == typeof(short) || type == typeof(ushort) || type == typeof(byte) || type == typeof(sbyte) || type == typeof(char))
				{
					if (type == typeof(int))
					{
						sb.AppendLine($"            {realClsName} @{name} = __intp.RetriveInt32(ptr_of_this_method, __mStack);");
					}
					else
					{
						sb.AppendLine(string.Format("            {0} @{1} = ({0})__intp.RetriveInt32(ptr_of_this_method, __mStack);", realClsName, name));
					}
					return;
				}
				if (type == typeof(long) || type == typeof(ulong))
				{
					if (type == typeof(long))
					{
						sb.AppendLine($"            {realClsName} @{name} = __intp.RetriveInt64(ptr_of_this_method, __mStack);");
					}
					else
					{
						sb.AppendLine(string.Format("            {0} @{1} = ({0})__intp.RetriveInt64(ptr_of_this_method, __mStack);", realClsName, name));
					}
					return;
				}
				if (type == typeof(float))
				{
					sb.AppendLine($"            {realClsName} @{name} = __intp.RetriveFloat(ptr_of_this_method, __mStack);");
					return;
				}
				if (type == typeof(double))
				{
					sb.AppendLine($"            {realClsName} @{name} = __intp.RetriveDouble(ptr_of_this_method, __mStack);");
					return;
				}
				if (!(type == typeof(bool)))
				{
					throw new NotSupportedException();
				}
				sb.AppendLine($"            {realClsName} @{name} = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;");
			}
			else if (p.GetElementType().IsEnum)
			{
				sb.AppendLine(string.Format("            {0} @{1} = ({0})__intp.RetriveInt32(ptr_of_this_method, __mStack);", realClsName, name));
			}
			else
			{
				sb.AppendLine(string.Format("            {0} @{1} = ({0})typeof({0}).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags){2});", realClsName, name, (int)p.GetTypeFlagsRecursive()));
			}
		}
		else
		{
			if (isMultiArr)
			{
				sb.AppendLine($"            {realClsName} a{idx} = {p.GetRetrieveValueCode(realClsName)};");
			}
			else
			{
				sb.AppendLine($"            {realClsName} @{name} = {p.GetRetrieveValueCode(realClsName)};");
			}
			if (!hasByRef && !p.IsPrimitive && needFree)
			{
				sb.AppendLine("            __intp.Free(ptr_of_this_method);");
			}
		}
	}

	internal static string GetRetrieveValueCode(this Type type, string realClsName)
	{
		if (type.IsByRef)
		{
			type = type.GetElementType();
		}
		if (type.IsPrimitive)
		{
			if (type == typeof(int))
			{
				return "ptr_of_this_method->Value";
			}
			if (type == typeof(long))
			{
				return "*(long*)&ptr_of_this_method->Value";
			}
			if (type == typeof(short))
			{
				return "(short)ptr_of_this_method->Value";
			}
			if (type == typeof(bool))
			{
				return "ptr_of_this_method->Value == 1";
			}
			if (type == typeof(ushort))
			{
				return "(ushort)ptr_of_this_method->Value";
			}
			if (type == typeof(float))
			{
				return "*(float*)&ptr_of_this_method->Value";
			}
			if (type == typeof(double))
			{
				return "*(double*)&ptr_of_this_method->Value";
			}
			if (type == typeof(byte))
			{
				return "(byte)ptr_of_this_method->Value";
			}
			if (type == typeof(sbyte))
			{
				return "(sbyte)ptr_of_this_method->Value";
			}
			if (type == typeof(uint))
			{
				return "(uint)ptr_of_this_method->Value";
			}
			if (type == typeof(char))
			{
				return "(char)ptr_of_this_method->Value";
			}
			if (type == typeof(ulong))
			{
				return "*(ulong*)&ptr_of_this_method->Value";
			}
			throw new NotImplementedException();
		}
		return string.Format("({0})typeof({0}).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags){1})", realClsName, (int)type.GetTypeFlagsRecursive());
	}

	internal static void GetRefWriteBackValueCode(this Type type, StringBuilder sb, string paramName)
	{
		if (type.IsPrimitive)
		{
			if (type == typeof(int))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(long))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Long;");
				sb.Append("                        *(long*)&___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(short))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(bool))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName + " ? 1 : 0;");
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(ushort))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(float))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Float;");
				sb.Append("                        *(float*)&___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(double))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Double;");
				sb.Append("                        *(double*)&___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(byte))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(sbyte))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = @" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(uint))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = (int)@" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (type == typeof(char))
			{
				sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
				sb.Append("                        ___dst->Value = (int)@" + paramName);
				sb.AppendLine(";");
				return;
			}
			if (!(type == typeof(ulong)))
			{
				throw new NotImplementedException();
			}
			sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Long;");
			sb.Append("                        *(ulong*)&___dst->Value = @" + paramName);
			sb.AppendLine(";");
		}
		else if (type.IsEnum)
		{
			sb.AppendLine("                        ___dst->ObjectType = ObjectTypes.Integer;");
			sb.Append("                        ___dst->Value = (int)@" + paramName);
			sb.AppendLine(";");
		}
		else
		{
			sb.Append("                        object ___obj = @");
			sb.Append(paramName);
			sb.AppendLine(";");
			sb.AppendLine("                        if (___dst->ObjectType >= ObjectTypes.Object)\r\n                        {\r\n                            if (___obj is CrossBindingAdaptorType)\r\n                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;\r\n                            __mStack[___dst->Value] = ___obj;\r\n                        }\r\n                        else\r\n                        {\r\n                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);\r\n                        }");
		}
	}

	internal static void GetReturnValueCode(this Type type, StringBuilder sb, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		if (type.IsPrimitive)
		{
			if (type == typeof(int))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method;");
			}
			else if (type == typeof(long))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Long;");
				sb.AppendLine("            *(long*)&__ret->Value = result_of_this_method;");
			}
			else if (type == typeof(short))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method;");
			}
			else if (type == typeof(bool))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method ? 1 : 0;");
			}
			else if (type == typeof(ushort))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method;");
			}
			else if (type == typeof(float))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Float;");
				sb.AppendLine("            *(float*)&__ret->Value = result_of_this_method;");
			}
			else if (type == typeof(double))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Double;");
				sb.AppendLine("            *(double*)&__ret->Value = result_of_this_method;");
			}
			else if (type == typeof(byte))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method;");
			}
			else if (type == typeof(sbyte))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = result_of_this_method;");
			}
			else if (type == typeof(uint))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = (int)result_of_this_method;");
			}
			else if (type == typeof(char))
			{
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Integer;");
				sb.AppendLine("            __ret->Value = (int)result_of_this_method;");
			}
			else
			{
				if (!(type == typeof(ulong)))
				{
					throw new NotImplementedException();
				}
				sb.AppendLine("            __ret->ObjectType = ObjectTypes.Long;");
				sb.AppendLine("            *(ulong*)&__ret->Value = result_of_this_method;");
			}
			sb.AppendLine("            return __ret + 1;");
			return;
		}
		string text = ((!(type == typeof(object))) ? "" : ", true");
		if (!type.IsSealed && type != typeof(ILTypeInstance))
		{
			if (domain == null || CheckAssignableToCrossBindingAdapters(domain, type))
			{
				sb.Append("            object obj_result_of_this_method = result_of_this_method;\r\n            if(obj_result_of_this_method is CrossBindingAdaptorType)\r\n            {    \r\n                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance");
				sb.Append(text);
				sb.AppendLine(");\r\n            }");
			}
			else if (typeof(CrossBindingAdaptorType).IsAssignableFrom(type))
			{
				sb.AppendLine($"            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method.ILInstance{text});");
				return;
			}
		}
		sb.AppendLine($"            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method{text});");
	}

	private static bool CheckAssignableToCrossBindingAdapters(ILRuntime.Runtime.Enviorment.AppDomain domain, Type type)
	{
		if (type == typeof(object))
		{
			return true;
		}
		bool flag = domain.CrossBindingAdaptors.ContainsKey(type);
		if (!flag)
		{
			Type baseType = type.BaseType;
			if (baseType != null && baseType != typeof(object))
			{
				flag = CheckAssignableToCrossBindingAdapters(domain, baseType);
			}
		}
		if (!flag)
		{
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				flag = CheckAssignableToCrossBindingAdapters(domain, type2);
				if (flag)
				{
					break;
				}
			}
		}
		return flag;
	}

	internal static bool HasByRefParam(this ParameterInfo[] param)
	{
		for (int num = param.Length; num > 0; num--)
		{
			if (param[num - 1].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}
}
