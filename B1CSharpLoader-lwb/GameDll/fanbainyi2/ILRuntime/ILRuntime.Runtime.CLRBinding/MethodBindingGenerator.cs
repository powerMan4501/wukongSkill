using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.CLRBinding;

internal static class MethodBindingGenerator
{
	private static string GenerateParameterTypes(MethodInfo i, bool needBracket)
	{
		ParameterInfo[] parameters = i.GetParameters();
		StringBuilder stringBuilder = new StringBuilder();
		if (needBracket)
		{
			stringBuilder.Append("{");
		}
		bool flag = true;
		ParameterInfo[] array = parameters;
		foreach (ParameterInfo obj in array)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append("typeof(");
			obj.ParameterType.GetClassName(out var _, out var realClsName, out var isByRef);
			stringBuilder.Append(realClsName);
			stringBuilder.Append(")");
			if (isByRef)
			{
				stringBuilder.Append(".MakeByRefType()");
			}
		}
		if (needBracket)
		{
			stringBuilder.Append("}");
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateMethodRegisterCode(this Type type, MethodInfo[] methods, HashSet<MethodBase> excludes, out bool needMethods)
	{
		needMethods = false;
		MethodInfo[] methods2 = type.GetMethods();
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		bool flag = false;
		foreach (MethodInfo i2 in methods)
		{
			if ((excludes != null && excludes.Contains(i2)) || type.ShouldSkipMethod(i2))
			{
				continue;
			}
			if (i2.IsGenericMethod)
			{
				if (!flag)
				{
					stringBuilder.AppendLine("            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();\r\n            List<MethodInfo> lst = null;                    \r\n            foreach(var m in type.GetMethods())\r\n            {\r\n                if(m.IsGenericMethodDefinition)\r\n                {\r\n                    if (!genericMethods.TryGetValue(m.Name, out lst))\r\n                    {\r\n                        lst = new List<MethodInfo>();\r\n                        genericMethods[m.Name] = lst;\r\n                    }\r\n                    lst.Add(m);\r\n                }\r\n            }");
					flag = true;
				}
				Type[] genericArguments = i2.GetGenericArguments();
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("{");
				bool flag2 = true;
				Type[] array = genericArguments;
				string clsName;
				string realClsName;
				bool isByRef;
				foreach (Type type2 in array)
				{
					if (flag2)
					{
						flag2 = false;
					}
					else
					{
						stringBuilder2.Append(", ");
					}
					stringBuilder2.Append("typeof(");
					type2.GetClassName(out clsName, out realClsName, out isByRef);
					stringBuilder2.Append(realClsName);
					stringBuilder2.Append(")");
					if (isByRef)
					{
						stringBuilder2.Append(".MakeByRefType()");
					}
				}
				stringBuilder2.Append("}");
				stringBuilder.AppendLine($"            args = new Type[]{stringBuilder2};");
				stringBuilder.AppendLine($"            if (genericMethods.TryGetValue(\"{i2.Name}\", out lst))");
				stringBuilder.Append("            {\r\n                foreach(var m in lst)\r\n                {\r\n                    if(m.MatchGenericParameters(args, ");
				if (i2.ReturnType != typeof(void))
				{
					stringBuilder.Append("typeof(");
					i2.ReturnType.GetClassName(out clsName, out realClsName, out isByRef);
					stringBuilder.Append(realClsName);
					stringBuilder.Append(")");
				}
				else
				{
					stringBuilder.Append("typeof(void)");
				}
				if (i2.GetParameters().Length != 0)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(GenerateParameterTypes(i2, needBracket: false));
				}
				stringBuilder.Append("))\r\n                    {\r\n                        method = m.MakeGenericMethod(args);\r\n                        app.RegisterCLRMethodRedirection(method, ");
				stringBuilder.AppendLine($"{i2.Name}_{num});");
				stringBuilder.AppendLine("\r\n                        break;\r\n                    }\r\n                }\r\n            }");
			}
			else
			{
				ParameterInfo[] param = i2.GetParameters();
				string arg = GenerateParameterTypes(i2, needBracket: true);
				stringBuilder.AppendLine($"            args = new Type[]{arg};");
				i2.ReturnType.GetClassName(out var _, out var realClsName2, out var _);
				if ((i2.Name.Equals("op_Implicit") || i2.Name.Equals("op_Explicit")) && methods2.Count((MethodInfo m) => m.Name.Equals(i2.Name)) > 1)
				{
					needMethods = true;
					stringBuilder.AppendLine($"            method = methods.Where(t => t.Name.Equals(\"{i2.Name}\") && t.ReturnType == typeof({realClsName2}) && t.CheckMethodParams(args)).Single();");
				}
				else if (methods2.Any((MethodInfo m) => m.IsGenericMethod && m.Name.Equals(i2.Name) && m.CheckMethodParams(param)))
				{
					needMethods = true;
					stringBuilder.AppendLine($"            method = methods.Where(t => t.Name.Equals(\"{i2.Name}\") && t.CheckMethodParams(args)).Single();");
				}
				else
				{
					stringBuilder.AppendLine($"            method = type.GetMethod(\"{i2.Name}\", flag, null, args, null);");
				}
				stringBuilder.AppendLine($"            app.RegisterCLRMethodRedirection(method, {i2.Name}_{num});");
			}
			num++;
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateMethodWraperCode(this Type type, MethodInfo[] methods, string typeClsName, HashSet<MethodBase> excludes, List<Type> valueTypeBinders, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = type.IsArray && type.GetArrayRank() > 1;
		int num = 0;
		foreach (MethodInfo methodInfo in methods)
		{
			if ((excludes != null && excludes.Contains(methodInfo)) || type.ShouldSkipMethod(methodInfo))
			{
				continue;
			}
			bool isSpecialName = methodInfo.IsSpecialName;
			ParameterInfo[] parameters = methodInfo.GetParameters();
			int num2 = parameters.Length;
			if (!methodInfo.IsStatic)
			{
				num2++;
			}
			stringBuilder.AppendLine($"        static StackObject* {methodInfo.Name}_{num}(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)");
			stringBuilder.AppendLine("        {");
			stringBuilder.AppendLine("            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;");
			if (parameters.Length != 0 || !methodInfo.IsStatic)
			{
				stringBuilder.AppendLine("            StackObject* ptr_of_this_method;");
			}
			stringBuilder.AppendLine($"            StackObject* __ret = ILIntepreter.Minus(__esp, {num2});");
			stringBuilder.AppendLine();
			bool flag2 = parameters.HasByRefParam();
			for (int num3 = parameters.Length; num3 > 0; num3--)
			{
				ParameterInfo parameterInfo = parameters[num3 - 1];
				stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {parameters.Length - num3 + 1});");
				parameterInfo.ParameterType.AppendArgumentCode(stringBuilder, num3, parameterInfo.Name, valueTypeBinders, flag, flag2, needFree: true);
				stringBuilder.AppendLine();
			}
			bool flag3 = (type.Name.Contains("AsyncTaskMethodBuilder") || type.FullName.StartsWith("System.Runtime.CompilerServices.AsyncVoidMethodBuilder")) && methodInfo.Name == "Start";
			if (!methodInfo.IsStatic)
			{
				stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {num2});");
				if (type.IsPrimitive)
				{
					stringBuilder.AppendLine($"            {typeClsName} instance_of_this_method = GetInstance(__domain, ptr_of_this_method, __mStack);");
				}
				else if (type.IsValueType && !type.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(type))
				{
					type.GetClassName(out var clsName, out var realClsName, out var _);
					stringBuilder.AppendLine(string.Format("            {0} instance_of_this_method = new {0}();", realClsName));
					stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder != null) {{");
					stringBuilder.AppendLine($"                ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder.ParseValue(ref instance_of_this_method, __intp, ptr_of_this_method, __mStack, false);");
					stringBuilder.AppendLine("            } else {");
					if (type.IsValueType)
					{
						stringBuilder.AppendLine("                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);");
					}
					stringBuilder.AppendLine($"                instance_of_this_method = {type.GetRetrieveValueCode(typeClsName)};");
					if (!type.IsValueType && !flag2)
					{
						stringBuilder.AppendLine("                __intp.Free(ptr_of_this_method);");
					}
					stringBuilder.AppendLine("            }");
				}
				else
				{
					if (type.IsValueType && !type.IsPrimitive)
					{
						stringBuilder.AppendLine("            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);");
					}
					if (flag3)
					{
						stringBuilder.AppendLine($"            object instance_of_this_method = {type.GetRetrieveValueCode(typeClsName)};");
					}
					else
					{
						stringBuilder.AppendLine($"            {typeClsName} instance_of_this_method = {type.GetRetrieveValueCode(typeClsName)};");
					}
					if (!type.IsValueType && !flag2)
					{
						stringBuilder.AppendLine("            __intp.Free(ptr_of_this_method);");
					}
				}
			}
			stringBuilder.AppendLine();
			if (methodInfo.ReturnType != typeof(void))
			{
				stringBuilder.Append("            var result_of_this_method = ");
			}
			else
			{
				stringBuilder.Append("            ");
			}
			string text = "";
			if (methodInfo.IsGenericMethod)
			{
				Type[] genericArguments = methodInfo.GetGenericArguments();
				StringBuilder stringBuilder2 = new StringBuilder();
				bool flag4 = true;
				stringBuilder2.Append('<');
				Type[] array = genericArguments;
				foreach (Type type2 in array)
				{
					if (flag4)
					{
						flag4 = false;
					}
					else
					{
						stringBuilder2.Append(", ");
					}
					type2.GetClassName(out var _, out var realClsName2, out var _);
					stringBuilder2.Append(realClsName2);
				}
				stringBuilder2.Append('>');
				text = stringBuilder2.ToString();
			}
			if (methodInfo.IsStatic)
			{
				if (isSpecialName)
				{
					string[] array2 = new string[2];
					int num4 = methodInfo.Name.IndexOf("_");
					array2[0] = methodInfo.Name.Substring(0, num4);
					array2[1] = methodInfo.Name.Substring(num4 + 1);
					switch (array2[0])
					{
					case "get":
						if (parameters.Length != 0)
						{
							stringBuilder.AppendLine(string.Format("{1}[{0}];", parameters[0].Name, typeClsName));
						}
						else
						{
							stringBuilder.AppendLine(string.Format("{1}.{0};", array2[1], typeClsName));
						}
						break;
					case "set":
						if (parameters.Length > 1)
						{
							stringBuilder.AppendLine(string.Format("{2}[{0}] = {1};", parameters[0].Name, parameters[1].Name, typeClsName));
						}
						else
						{
							stringBuilder.AppendLine(string.Format("{2}.{0} = {1};", array2[1], parameters[0].Name, typeClsName));
						}
						break;
					case "op":
						switch (array2[1])
						{
						case "Equality":
							stringBuilder.AppendLine($"{parameters[0].Name} == {parameters[1].Name};");
							break;
						case "Inequality":
							stringBuilder.AppendLine($"{parameters[0].Name} != {parameters[1].Name};");
							break;
						case "Addition":
							stringBuilder.AppendLine($"{parameters[0].Name} + {parameters[1].Name};");
							break;
						case "Subtraction":
							stringBuilder.AppendLine($"{parameters[0].Name} - {parameters[1].Name};");
							break;
						case "Multiply":
							stringBuilder.AppendLine($"{parameters[0].Name} * {parameters[1].Name};");
							break;
						case "Division":
							stringBuilder.AppendLine($"{parameters[0].Name} / {parameters[1].Name};");
							break;
						case "GreaterThan":
							stringBuilder.AppendLine($"{parameters[0].Name} > {parameters[1].Name};");
							break;
						case "GreaterThanOrEqual":
							stringBuilder.AppendLine($"{parameters[0].Name} >= {parameters[1].Name};");
							break;
						case "LessThan":
							stringBuilder.AppendLine($"{parameters[0].Name} < {parameters[1].Name};");
							break;
						case "LessThanOrEqual":
							stringBuilder.AppendLine($"{parameters[0].Name} <= {parameters[1].Name};");
							break;
						case "UnaryNegation":
							stringBuilder.AppendLine($"-{parameters[0].Name};");
							break;
						case "LogicalNot":
							stringBuilder.AppendLine($"!{parameters[0].Name};");
							break;
						case "Modulus":
							stringBuilder.AppendLine($"{parameters[0].Name} % {parameters[1].Name};");
							break;
						case "Explicit":
						case "Implicit":
						{
							methodInfo.ReturnType.GetClassName(out var _, out var realClsName5, out var _);
							stringBuilder.AppendLine(string.Format("({1}){0};", parameters[0].Name, realClsName5));
							break;
						}
						case "Increment":
							stringBuilder.AppendLine($"++{parameters[0].Name};");
							break;
						case "Decrement":
							stringBuilder.AppendLine($"--{parameters[0].Name};");
							break;
						default:
							throw new NotImplementedException(methodInfo.Name);
						}
						break;
					case "add":
					{
						methodInfo.DeclaringType.GetClassName(out var _, out var realClsName4, out var _);
						stringBuilder.AppendLine($"{realClsName4}.{methodInfo.Name.Substring(4)} += {parameters[0].Name};");
						break;
					}
					case "remove":
					{
						methodInfo.DeclaringType.GetClassName(out var _, out var realClsName3, out var _);
						stringBuilder.AppendLine($"{realClsName3}.{methodInfo.Name.Substring(7)} -= {parameters[0].Name};");
						break;
					}
					default:
						throw new NotImplementedException();
					}
				}
				else
				{
					stringBuilder.Append($"{typeClsName}.{methodInfo.Name}{text}(");
					parameters.AppendParameters(stringBuilder);
					stringBuilder.AppendLine(");");
				}
			}
			else if (isSpecialName)
			{
				string[] array3 = new string[2];
				int num5 = methodInfo.Name.IndexOf("_");
				array3[0] = methodInfo.Name.Substring(0, num5);
				array3[1] = methodInfo.Name.Substring(num5 + 1);
				string text2 = array3[0];
				if (flag3)
				{
					switch (text2)
					{
					case "get":
						if (parameters.Length != 0)
						{
							stringBuilder.AppendLine(string.Format("(({1})instance_of_this_method)[{0}];", parameters[0].Name, typeClsName));
						}
						else
						{
							stringBuilder.AppendLine(string.Format("(({1})instance_of_this_method).{0};", array3[1], typeClsName));
						}
						break;
					case "set":
						if (parameters.Length > 1)
						{
							stringBuilder.AppendLine(string.Format("(({2})instance_of_this_method)[{0}] = {1};", parameters[0].Name, parameters[1].Name, typeClsName));
							break;
						}
						stringBuilder.AppendLine(string.Format("(({2})instance_of_this_method).{0} = {1};", array3[1], parameters[0].Name, typeClsName, typeClsName));
						break;
					case "add":
						stringBuilder.AppendLine(string.Format("(({2})instance_of_this_method).{0} += {1};", methodInfo.Name.Substring(4), parameters[0].Name, typeClsName));
						break;
					case "remove":
						stringBuilder.AppendLine(string.Format("(({2})instance_of_this_method).{0} -= {1};", methodInfo.Name.Substring(7), parameters[0].Name, typeClsName));
						break;
					default:
						throw new NotImplementedException();
					}
				}
				else
				{
					switch (text2)
					{
					case "get":
						if (parameters.Length != 0)
						{
							stringBuilder.AppendLine($"instance_of_this_method[{parameters[0].Name}];");
						}
						else
						{
							stringBuilder.AppendLine($"instance_of_this_method.{array3[1]};");
						}
						break;
					case "set":
						if (parameters.Length > 1)
						{
							stringBuilder.AppendLine($"instance_of_this_method[{parameters[0].Name}] = {parameters[1].Name};");
						}
						else
						{
							stringBuilder.AppendLine($"instance_of_this_method.{array3[1]} = {parameters[0].Name};");
						}
						break;
					case "add":
						stringBuilder.AppendLine($"instance_of_this_method.{methodInfo.Name.Substring(4)} += {parameters[0].Name};");
						break;
					case "remove":
						stringBuilder.AppendLine($"instance_of_this_method.{methodInfo.Name.Substring(7)} -= {parameters[0].Name};");
						break;
					default:
						throw new NotImplementedException();
					}
				}
			}
			else if (flag)
			{
				if (methodInfo.Name == "Get")
				{
					stringBuilder.Append("instance_of_this_method[");
					parameters.AppendParameters(stringBuilder, isMultiArr: true);
					stringBuilder.AppendLine("];");
				}
				else
				{
					stringBuilder.Append("instance_of_this_method[");
					parameters.AppendParameters(stringBuilder, isMultiArr: true, 1);
					stringBuilder.Append("]");
					stringBuilder.Append(" = a");
					stringBuilder.Append(parameters.Length);
					stringBuilder.AppendLine(";");
				}
			}
			else
			{
				if (flag3)
				{
					stringBuilder.Append(string.Format("(({2})instance_of_this_method).{0}{1}(", methodInfo.Name, text, typeClsName));
				}
				else
				{
					stringBuilder.Append($"instance_of_this_method.{methodInfo.Name}{text}(");
				}
				parameters.AppendParameters(stringBuilder);
				stringBuilder.AppendLine(");");
			}
			stringBuilder.AppendLine();
			for (int num6 = parameters.Length; num6 > 0; num6--)
			{
				ParameterInfo parameterInfo2 = parameters[num6 - 1];
				if (parameterInfo2.ParameterType.IsByRef || flag2)
				{
					Type type3 = (parameterInfo2.ParameterType.IsByRef ? parameterInfo2.ParameterType.GetElementType() : parameterInfo2.ParameterType);
					type3.GetClassName(out var clsName6, out var realClsName6, out var _);
					stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {parameters.Length - num6 + 1});");
					if (parameterInfo2.ParameterType.IsByRef)
					{
						stringBuilder.AppendLine("            switch(ptr_of_this_method->ObjectType)\r\n            {\r\n                case ObjectTypes.StackObjectReference:\r\n                    {\r\n                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);");
						if (type3.IsValueType && !type3.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(type3))
						{
							stringBuilder.AppendLine($"                if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName6}_Binder != null) {{");
							stringBuilder.AppendLine($"                        ILRuntime.Runtime.Generated.CLRBindings.s_{clsName6}_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref {parameterInfo2.Name});");
							stringBuilder.AppendLine("                } else {");
							type3.GetRefWriteBackValueCode(stringBuilder, parameterInfo2.Name);
							stringBuilder.AppendLine("                }");
						}
						else
						{
							type3.GetRefWriteBackValueCode(stringBuilder, parameterInfo2.Name);
						}
						stringBuilder.Append("                    }\r\n                    break;\r\n                case ObjectTypes.FieldReference:\r\n                    {\r\n                        var ___obj = __mStack[ptr_of_this_method->Value];\r\n                        if(___obj is ILTypeInstance)\r\n                        {\r\n                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;\r\n                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                case ObjectTypes.StaticFieldReference:\r\n                    {\r\n                        var ___type = __domain.GetType(ptr_of_this_method->Value);\r\n                        if(___type is ILType)\r\n                        {\r\n                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                 case ObjectTypes.ArrayReference:\r\n                    {\r\n                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as ");
						stringBuilder.Append(realClsName6);
						stringBuilder.Append("[];\r\n                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.AppendLine(";\r\n                    }\r\n                    break;\r\n            }");
						stringBuilder.AppendLine();
					}
					else if (type3.IsValueType && !type3.IsPrimitive)
					{
						stringBuilder.AppendLine("            __intp.FreeStackValueType(ptr_of_this_method);");
					}
					stringBuilder.AppendLine("            __intp.Free(ptr_of_this_method);");
				}
			}
			if (!methodInfo.IsStatic && ((type.IsValueType && !type.IsPrimitive) || flag2))
			{
				stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {num2});");
				bool flag5 = flag3;
				if (type.IsValueType && !type.IsPrimitive && !flag5)
				{
					if (valueTypeBinders != null && valueTypeBinders.Contains(type))
					{
						type.GetClassName(out var clsName7, out var _, out var _);
						stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName7}_Binder != null) {{");
						stringBuilder.AppendLine($"                ILRuntime.Runtime.Generated.CLRBindings.s_{clsName7}_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);");
						stringBuilder.AppendLine("            } else {");
						stringBuilder.AppendLine("                WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);");
						stringBuilder.AppendLine("            }");
					}
					else
					{
						stringBuilder.AppendLine("            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);");
					}
					stringBuilder.AppendLine();
				}
				stringBuilder.AppendLine("            __intp.Free(ptr_of_this_method);");
			}
			if (methodInfo.ReturnType != typeof(void))
			{
				if (methodInfo.ReturnType.IsValueType && !methodInfo.ReturnType.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(methodInfo.ReturnType))
				{
					methodInfo.ReturnType.GetClassName(out var clsName8, out var _, out var _);
					stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName8}_Binder != null) {{");
					stringBuilder.AppendLine($"                ILRuntime.Runtime.Generated.CLRBindings.s_{clsName8}_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);");
					stringBuilder.AppendLine("                return __ret + 1;");
					stringBuilder.AppendLine("            } else {");
					methodInfo.ReturnType.GetReturnValueCode(stringBuilder, domain);
					stringBuilder.AppendLine("            }");
				}
				else
				{
					methodInfo.ReturnType.GetReturnValueCode(stringBuilder, domain);
				}
			}
			else
			{
				stringBuilder.AppendLine("            return __ret;");
			}
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			num++;
		}
		return stringBuilder.ToString();
	}
}
