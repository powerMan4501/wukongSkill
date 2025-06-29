using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ILRuntime.Runtime.Enviorment;

public class CrossBindingCodeGenerator
{
	private class PropertyGenerateInfo
	{
		public string Name;

		public Type ReturnType;

		public string GetterBody;

		public string SettingBody;

		public string Modifier;

		public string OverrideString;
	}

	public static string GenerateCrossBindingAdapterCode(Type baseType, string nameSpace)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<MethodInfo> list = new List<MethodInfo>();
		GetMethods(baseType, list);
		baseType.GetClassName(out var clsName, out var realClsName, out var _, simpleClassName: true);
		stringBuilder.Append("using System;\r\nusing ILRuntime.CLR.Method;\r\nusing ILRuntime.Runtime.Enviorment;\r\nusing ILRuntime.Runtime.Intepreter;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\n\r\nnamespace ");
		stringBuilder.AppendLine(nameSpace);
		stringBuilder.Append("{   \r\n    public class ");
		stringBuilder.Append(clsName);
		stringBuilder.AppendLine("Adapter : CrossBindingAdaptor\r\n    {");
		stringBuilder.Append("        public override Type BaseCLRType\r\n        {\r\n            get\r\n            {\r\n                return typeof(");
		stringBuilder.Append(realClsName);
		stringBuilder.AppendLine(");\r\n            }\r\n        }\r\n\r\n        public override Type AdaptorType\r\n        {\r\n            get\r\n            {\r\n                return typeof(Adapter);\r\n            }\r\n        }\r\n\r\n        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)\r\n        {\r\n            return new Adapter(appdomain, instance);\r\n        }\r\n");
		stringBuilder.AppendLine($"        public class Adapter : {realClsName}, CrossBindingAdaptorType");
		stringBuilder.AppendLine("        {");
		GenerateCrossBindingMethodInfo(stringBuilder, list);
		stringBuilder.AppendLine("\r\n            bool isInvokingToString;\r\n            ILTypeInstance instance;\r\n            ILRuntime.Runtime.Enviorment.AppDomain appdomain;\r\n\r\n            public Adapter()\r\n            {\r\n\r\n            }\r\n\r\n            public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)\r\n            {\r\n                this.appdomain = appdomain;\r\n                this.instance = instance;\r\n            }\r\n\r\n            public ILTypeInstance ILInstance { get { return instance; } }\r\n");
		GenerateCrossBindingMethodBody(stringBuilder, list);
		stringBuilder.Append("            public override string ToString()\r\n            {\r\n                IMethod m = appdomain.ObjectType.GetMethod(");
		stringBuilder.AppendLine("\"ToString\", 0);");
		stringBuilder.AppendLine("                m = instance.Type.GetVirtualMethod(m);\r\n                if (m == null || m is ILMethod)\r\n                {\r\n                    if (!isInvokingToString)\r\n                    {\r\n                        isInvokingToString = true;\r\n                        string res = instance.ToString();\r\n                        isInvokingToString = false;\r\n                        return res;\r\n                    }\r\n                    else\r\n                        return instance.Type.FullName;\r\n                }\r\n                else\r\n                    return instance.Type.FullName;");
		stringBuilder.AppendLine("            }");
		stringBuilder.AppendLine("        }");
		stringBuilder.AppendLine("    }");
		stringBuilder.AppendLine("}");
		return stringBuilder.ToString();
	}

	private static void GenerateCrossBindingMethodBody(StringBuilder sb, List<MethodInfo> virtMethods)
	{
		int num = 0;
		Dictionary<string, PropertyGenerateInfo> dictionary = new Dictionary<string, PropertyGenerateInfo>();
		foreach (MethodInfo virtMethod in virtMethods)
		{
			if (ShouldSkip(virtMethod))
			{
				continue;
			}
			bool flag = virtMethod.IsSpecialName && (virtMethod.Name.StartsWith("get_") || virtMethod.Name.StartsWith("set_"));
			PropertyGenerateInfo value = null;
			bool flag2 = false;
			bool flag3 = false;
			StringBuilder stringBuilder = null;
			string clsName;
			string realClsName;
			bool isByRef;
			if (flag)
			{
				string text = virtMethod.Name.Substring(4);
				if (virtMethod.Name == "get_Item" || virtMethod.Name == "set_Item")
				{
					new StringBuilder();
					ParameterInfo parameterInfo = virtMethod.GetParameters()[0];
					parameterInfo.ParameterType.GetClassName(out clsName, out realClsName, out isByRef, simpleClassName: true);
					text = string.Format("this [{0}]", realClsName + " " + parameterInfo.Name);
					flag3 = true;
				}
				flag2 = virtMethod.Name.StartsWith("get_");
				stringBuilder = sb;
				sb = new StringBuilder();
				if (!dictionary.TryGetValue(text, out value))
				{
					value = new PropertyGenerateInfo();
					value.Name = text;
					dictionary[text] = value;
				}
				if (value.ReturnType == null)
				{
					if (flag2)
					{
						value.ReturnType = virtMethod.ReturnType;
					}
					else
					{
						value.ReturnType = virtMethod.GetParameters()[0].ParameterType;
					}
				}
			}
			ParameterInfo[] parameters = virtMethod.GetParameters();
			string text2 = (virtMethod.IsFamily ? "protected" : "public");
			string text3 = (virtMethod.DeclaringType.IsInterface ? "" : (virtMethod.IsFinal ? "new " : "override "));
			string text4 = "";
			if (virtMethod.ReturnType != typeof(void))
			{
				virtMethod.ReturnType.GetClassName(out clsName, out realClsName, out isByRef, simpleClassName: true);
				text4 = "return ";
			}
			else
			{
				realClsName = "void";
			}
			if (!flag)
			{
				sb.Append(string.Format("            {0} {3}{1} {2}(", text2, realClsName, virtMethod.Name, text3));
				GetParameterDefinition(sb, parameters, first: true);
				sb.AppendLine(")\r\n            {");
			}
			else
			{
				value.Modifier = text2;
				value.OverrideString = text3;
			}
			if (!virtMethod.IsAbstract)
			{
				sb.AppendLine($"                if (m{virtMethod.Name}_{num}.CheckShouldInvokeBase(this.instance))");
				if (flag)
				{
					string arg = (flag3 ? $"base[{virtMethod.GetParameters()[0].Name}]" : $"base.{virtMethod.Name.Substring(4)}");
					if (flag2)
					{
						sb.AppendLine($"                    return {arg};");
					}
					else
					{
						sb.AppendLine($"                    {arg} = value;");
					}
				}
				else
				{
					sb.AppendLine(string.Format("                    {2}base.{0}({1});", virtMethod.Name, GetParameterName(parameters, first: true), text4));
				}
				sb.AppendLine("                else");
				sb.AppendLine(string.Format("                    {3}m{0}_{1}.Invoke(this.instance{2});", virtMethod.Name, num, GetParameterName(parameters, first: false), text4));
			}
			else
			{
				sb.AppendLine(string.Format("                {3}m{0}_{1}.Invoke(this.instance{2});", virtMethod.Name, num, GetParameterName(parameters, first: false), text4));
			}
			if (flag)
			{
				if (flag2)
				{
					value.GetterBody = sb.ToString();
				}
				else
				{
					value.SettingBody = sb.ToString();
				}
				sb = stringBuilder;
			}
			else
			{
				sb.AppendLine("            }");
				sb.AppendLine();
			}
			num++;
		}
		foreach (KeyValuePair<string, PropertyGenerateInfo> item in dictionary)
		{
			PropertyGenerateInfo value2 = item.Value;
			value2.ReturnType.GetClassName(out var _, out var realClsName2, out var _, simpleClassName: true);
			sb.AppendLine(string.Format("            {0} {3}{1} {2}", value2.Modifier, realClsName2, value2.Name, value2.OverrideString));
			sb.AppendLine("            {");
			if (!string.IsNullOrEmpty(value2.GetterBody))
			{
				sb.AppendLine("            get");
				sb.AppendLine("            {");
				sb.AppendLine(value2.GetterBody);
				sb.AppendLine("            }");
			}
			if (!string.IsNullOrEmpty(value2.SettingBody))
			{
				sb.AppendLine("            set");
				sb.AppendLine("            {");
				sb.AppendLine(value2.SettingBody);
				sb.AppendLine("            }");
			}
			sb.AppendLine("            }");
			sb.AppendLine();
		}
	}

	private static void GenerateCrossBindingMethodInfo(StringBuilder sb, List<MethodInfo> virtMethods)
	{
		int num = 0;
		foreach (MethodInfo virtMethod in virtMethods)
		{
			if (!ShouldSkip(virtMethod))
			{
				ParameterInfo[] parameters = virtMethod.GetParameters();
				if (NeedGenerateCrossBindingMethodClass(parameters))
				{
					GenerateCrossBindingMethodClass(sb, virtMethod.Name, num, parameters, virtMethod.ReturnType);
					sb.AppendLine(string.Format("            {0}_{1}Info m{0}_{1} = new {0}_{1}Info();", virtMethod.Name, num));
				}
				else if (virtMethod.ReturnType != typeof(void))
				{
					sb.AppendLine(string.Format("            CrossBindingFunctionInfo<{0}> m{1}_{2} = new CrossBindingFunctionInfo<{0}>(\"{1}\");", GetParametersString(parameters, virtMethod.ReturnType), virtMethod.Name, num));
				}
				else if (parameters.Length != 0)
				{
					sb.AppendLine(string.Format("            CrossBindingMethodInfo<{0}> m{1}_{2} = new CrossBindingMethodInfo<{0}>(\"{1}\");", GetParametersString(parameters, virtMethod.ReturnType), virtMethod.Name, num));
				}
				else
				{
					sb.AppendLine(string.Format("            CrossBindingMethodInfo m{0}_{1} = new CrossBindingMethodInfo(\"{0}\");", virtMethod.Name, num));
				}
				num++;
			}
		}
	}

	private static bool ShouldSkip(MethodInfo info)
	{
		ParameterInfo[] parameters = info.GetParameters();
		if (info.Name == "ToString" || info.Name == "GetHashCode" || info.Name == "Finalize")
		{
			return parameters.Length == 0;
		}
		if (info.Name == "Equals" && parameters.Length == 1 && parameters[0].ParameterType == typeof(object))
		{
			return true;
		}
		if (info.IsAssembly || info.IsFamilyOrAssembly || info.IsPrivate || info.IsFinal)
		{
			return true;
		}
		if (info.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
		{
			return true;
		}
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type.IsPointer || type.IsNotPublic || (type.IsNested && !type.IsNestedPublic))
			{
				return true;
			}
		}
		Type type2 = info.ReturnType;
		if (type2.IsByRef)
		{
			type2 = type2.GetElementType();
		}
		if (type2.IsNotPublic || (type2.IsNested && !type2.IsNestedPublic))
		{
			return true;
		}
		return false;
	}

	private static string GetParametersString(ParameterInfo[] param, Type returnType)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (ParameterInfo obj in param)
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			else
			{
				flag = false;
			}
			obj.ParameterType.GetClassName(out var _, out var realClsName, out var _, simpleClassName: true);
			stringBuilder.Append(realClsName);
		}
		if (returnType != typeof(void))
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			returnType.GetClassName(out var _, out var realClsName2, out var _, simpleClassName: true);
			stringBuilder.Append(realClsName2);
		}
		return stringBuilder.ToString();
	}

	private static string GetParametersTypeString(ParameterInfo[] param, Type returnType)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (ParameterInfo obj in param)
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			else
			{
				flag = false;
			}
			stringBuilder.Append("typeof(");
			obj.ParameterType.GetClassName(out var _, out var realClsName, out var isByRef, simpleClassName: true);
			stringBuilder.Append(realClsName);
			stringBuilder.Append(")");
			if (isByRef)
			{
				stringBuilder.Append(".MakeByRefType()");
			}
		}
		if (returnType != typeof(void))
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			returnType.GetClassName(out var _, out var realClsName2, out var _, simpleClassName: true);
			stringBuilder.Append(realClsName2);
		}
		return stringBuilder.ToString();
	}

	private static bool NeedGenerateCrossBindingMethodClass(ParameterInfo[] param)
	{
		if (param.Length > 5)
		{
			return true;
		}
		foreach (ParameterInfo parameterInfo in param)
		{
			if (parameterInfo.IsOut || parameterInfo.ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	private static string GetParameterName(ParameterInfo[] param, bool first)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (ParameterInfo parameterInfo in param)
		{
			if (!first)
			{
				stringBuilder.Append(", ");
			}
			else
			{
				first = false;
			}
			if (parameterInfo.IsOut)
			{
				stringBuilder.Append("out ");
			}
			else if (parameterInfo.ParameterType.IsByRef)
			{
				stringBuilder.Append("ref ");
			}
			stringBuilder.Append(parameterInfo.Name);
		}
		return stringBuilder.ToString();
	}

	private static void GetParameterDefinition(StringBuilder sb, ParameterInfo[] param, bool first)
	{
		foreach (ParameterInfo parameterInfo in param)
		{
			if (!first)
			{
				sb.Append(", ");
			}
			else
			{
				first = false;
			}
			parameterInfo.ParameterType.GetClassName(out var _, out var realClsName, out var isByRef, simpleClassName: true);
			if (parameterInfo.IsOut)
			{
				sb.Append("out ");
			}
			else if (isByRef)
			{
				sb.Append("ref ");
			}
			sb.Append(realClsName);
			sb.Append(" ");
			sb.Append(parameterInfo.Name);
		}
	}

	private static void GenerateCrossBindingMethodClass(StringBuilder sb, string funcName, int index, ParameterInfo[] param, Type returnType)
	{
		sb.AppendLine($"            class {funcName}_{index}Info : CrossBindingMethodInfo");
		sb.Append("            {\r\n                static Type[] pTypes = new Type[] {");
		sb.Append(GetParametersTypeString(param, returnType));
		sb.AppendLine("};");
		sb.AppendLine();
		sb.AppendLine($"                public {funcName}_{index}Info()");
		sb.AppendLine($"                    : base(\"{funcName}\")");
		sb.Append("                {\r\n\r\n                }\r\n\r\n                protected override Type ReturnType { get { return ");
		returnType.GetClassName(out var clsName, out var realClsName, out var isByRef, simpleClassName: true);
		string text = realClsName;
		bool flag = returnType != typeof(void);
		if (!flag)
		{
			sb.Append("null");
		}
		else
		{
			sb.AppendFormat("typeof({0})", realClsName);
		}
		sb.AppendLine("; } }\r\n\r\n                protected override Type[] Parameters { get { return pTypes; } }");
		sb.AppendFormat("                public {0} Invoke(ILTypeInstance instance", (!flag) ? "void" : realClsName);
		GetParameterDefinition(sb, param, first: false);
		sb.AppendLine(")\r\n                {\r\n                    EnsureMethod(instance);");
		GenInitParams(sb, param);
		sb.AppendLine("\r\n                    if (method != null)\r\n                    {\r\n                        invoking = true;");
		if (flag)
		{
			sb.AppendLine(string.Format("                        {0} __res = default({0});", text));
		}
		sb.AppendLine("                        try\r\n                        {\r\n                            using (var ctx = domain.BeginInvoke(method))\r\n                            {");
		Dictionary<ParameterInfo, int> dictionary = new Dictionary<ParameterInfo, int>();
		int num = 0;
		ParameterInfo[] array = param;
		foreach (ParameterInfo parameterInfo in array)
		{
			if (parameterInfo.ParameterType.IsByRef)
			{
				sb.AppendLine(GetPushString(parameterInfo.ParameterType.GetElementType(), parameterInfo.Name));
				dictionary[parameterInfo] = num++;
			}
		}
		sb.AppendLine("                                ctx.PushObject(instance);");
		array = param;
		foreach (ParameterInfo parameterInfo2 in array)
		{
			if (parameterInfo2.ParameterType.IsByRef)
			{
				sb.AppendLine($"                                ctx.PushReference({dictionary[parameterInfo2]});");
			}
			else
			{
				sb.AppendLine(GetPushString(parameterInfo2.ParameterType, parameterInfo2.Name));
			}
		}
		sb.AppendLine("                                ctx.Invoke();");
		if (flag)
		{
			sb.AppendLine(GetReadString(returnType, text, "", "__res"));
		}
		array = param;
		foreach (ParameterInfo parameterInfo3 in array)
		{
			if (parameterInfo3.ParameterType.IsByRef)
			{
				parameterInfo3.ParameterType.GetClassName(out clsName, out realClsName, out isByRef, simpleClassName: true);
				sb.AppendLine(GetReadString(parameterInfo3.ParameterType.GetElementType(), realClsName, dictionary[parameterInfo3].ToString(), parameterInfo3.Name));
			}
		}
		sb.AppendLine("                            }");
		sb.AppendLine("                        }\r\n                        finally\r\n                        {\r\n                            invoking = false;\r\n                        }");
		if (flag)
		{
			sb.AppendLine("                       return __res;");
		}
		sb.AppendLine("                    }");
		if (flag)
		{
			sb.AppendLine("                    else\r\n                        return default(TResult);");
		}
		sb.AppendLine("                }\r\n\r\n                public override void Invoke(ILTypeInstance instance)\r\n                {\r\n                    throw new NotSupportedException();\r\n                }\r\n            }");
	}

	private static void GetMethods(Type type, List<MethodInfo> list)
	{
		if (type == null)
		{
			return;
		}
		MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (MethodInfo i2 in methods)
		{
			if ((i2.IsVirtual || i2.IsAbstract || type.IsInterface) && !i2.ContainsGenericParameters && !list.Any((MethodInfo m) => IsMethodEqual(m, i2)))
			{
				list.Add(i2);
			}
		}
		Type[] interfaces = type.GetInterfaces();
		if (interfaces != null)
		{
			for (int num = 0; num < interfaces.Length; num++)
			{
				GetMethods(interfaces[num], list);
			}
		}
	}

	private static bool IsMethodEqual(MethodInfo left, MethodInfo right)
	{
		ParameterInfo[] parameters = left.GetParameters();
		ParameterInfo[] parameters2 = right.GetParameters();
		if (parameters.Length != parameters2.Length)
		{
			return false;
		}
		string text = left.Name.Replace(left.DeclaringType.FullName, "");
		string text2 = right.Name.Replace(right.DeclaringType.FullName, "");
		if (text != text2)
		{
			return false;
		}
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType != parameters2[i].ParameterType)
			{
				return false;
			}
		}
		return true;
	}

	private static void GenInitParams(StringBuilder sb, ParameterInfo[] param)
	{
		foreach (ParameterInfo parameterInfo in param)
		{
			if (parameterInfo.IsOut)
			{
				sb.AppendLine($"                    {parameterInfo.Name} = default({parameterInfo.ParameterType.GetElementType().FullName});");
			}
		}
	}

	private static string GetPushString(Type type, string argName)
	{
		if (type.IsPrimitive)
		{
			if (type == typeof(int))
			{
				return $"                            ctx.PushInteger({argName});";
			}
			if (type == typeof(long))
			{
				return $"                            ctx.PushLong({argName});";
			}
			if (type == typeof(short))
			{
				return $"                            ctx.PushInteger({argName});";
			}
			if (type == typeof(bool))
			{
				return $"                            ctx.PushBool({argName});";
			}
			if (type == typeof(ushort))
			{
				return $"                            ctx.PushInteger({argName});";
			}
			if (type == typeof(float))
			{
				return $"                            ctx.PushFloat({argName});";
			}
			if (type == typeof(double))
			{
				return $"                            ctx.PushDouble({argName});";
			}
			if (type == typeof(byte))
			{
				return $"                            ctx.PushInteger({argName});";
			}
			if (type == typeof(sbyte))
			{
				return $"                            ctx.PushInteger({argName});";
			}
			if (type == typeof(uint))
			{
				return $"                            ctx.PushInteger((int){argName});";
			}
			if (type == typeof(char))
			{
				return $"                            ctx.PushInteger((int){argName});";
			}
			if (type == typeof(ulong))
			{
				return $"                            ctx.PushLong((long){argName});";
			}
			throw new NotImplementedException();
		}
		return $"                            ctx.PushObject({argName});";
	}

	private static string GetReadString(Type type, string realClsName, string argName, string valName)
	{
		if (type.IsPrimitive)
		{
			if (type == typeof(int))
			{
				return string.Format("                             {1} = ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(long))
			{
				return string.Format("                            {1} = ctx.ReadLong({0});", argName, valName);
			}
			if (type == typeof(short))
			{
				return string.Format("                            {1} = (short)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(bool))
			{
				return string.Format("                            {1} = ctx.ReadBool({0});", argName, valName);
			}
			if (type == typeof(ushort))
			{
				return string.Format("                            {1} = (ushort)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(float))
			{
				return string.Format("                            {1} = ctx.ReadFloat({0});", argName, valName);
			}
			if (type == typeof(double))
			{
				return string.Format("                            {1} = ctx.ReadDouble({0});", argName, valName);
			}
			if (type == typeof(byte))
			{
				return string.Format("                            {1} = (byte)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(sbyte))
			{
				return string.Format("                            {1} = (sbyte)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(uint))
			{
				return string.Format("                            {1} = (uint)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(char))
			{
				return string.Format("                            {1} = (char)ctx.ReadInteger({0});", argName, valName);
			}
			if (type == typeof(ulong))
			{
				return string.Format("                            {1} = (ulong)ctx.ReadLong({0});", argName, valName);
			}
			throw new NotImplementedException();
		}
		return string.Format("                            {2} = ctx.ReadObject<{1}>({0});", argName, realClsName, valName);
	}
}
