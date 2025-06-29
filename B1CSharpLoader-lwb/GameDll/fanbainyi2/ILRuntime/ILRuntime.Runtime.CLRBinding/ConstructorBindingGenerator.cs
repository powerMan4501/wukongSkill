using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ILRuntime.Runtime.CLRBinding;

internal static class ConstructorBindingGenerator
{
	internal static string GenerateConstructorRegisterCode(this Type type, ConstructorInfo[] methods, HashSet<MethodBase> excludes)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (ConstructorInfo constructorInfo in methods)
		{
			if ((excludes != null && excludes.Contains(constructorInfo)) || type.ShouldSkipMethod(constructorInfo))
			{
				continue;
			}
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{");
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
					stringBuilder2.Append(", ");
				}
				stringBuilder2.Append("typeof(");
				obj.ParameterType.GetClassName(out var _, out var realClsName, out var isByRef);
				stringBuilder2.Append(realClsName);
				stringBuilder2.Append(")");
				if (isByRef)
				{
					stringBuilder2.Append(".MakeByRefType()");
				}
			}
			stringBuilder2.Append("}");
			stringBuilder.AppendLine($"            args = new Type[]{stringBuilder2};");
			stringBuilder.AppendLine("            method = type.GetConstructor(flag, null, args, null);");
			stringBuilder.AppendLine($"            app.RegisterCLRMethodRedirection(method, Ctor_{num});");
			num++;
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateConstructorWraperCode(this Type type, ConstructorInfo[] methods, string typeClsName, HashSet<MethodBase> excludes, List<Type> valueTypeBinders)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		bool flag = type.IsArray && type.GetArrayRank() > 1;
		foreach (ConstructorInfo constructorInfo in methods)
		{
			if ((excludes != null && excludes.Contains(constructorInfo)) || type.ShouldSkipMethod(constructorInfo) || constructorInfo.IsStatic)
			{
				continue;
			}
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			int num2 = parameters.Length;
			stringBuilder.AppendLine($"        static StackObject* Ctor_{num}(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)");
			stringBuilder.AppendLine("        {");
			stringBuilder.AppendLine("            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;");
			if (parameters.Length != 0)
			{
				stringBuilder.AppendLine("            StackObject* ptr_of_this_method;");
			}
			stringBuilder.AppendLine($"            StackObject* __ret = ILIntepreter.Minus(__esp, {num2});");
			bool flag2 = parameters.HasByRefParam();
			string arg = (flag2 ? "false" : "true");
			for (int num3 = parameters.Length; num3 > 0; num3--)
			{
				ParameterInfo parameterInfo = parameters[num3 - 1];
				stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {parameters.Length - num3 + 1});");
				parameterInfo.ParameterType.GetClassName(out var clsName, out var realClsName, out var isByRef);
				Type type2 = (parameterInfo.ParameterType.IsByRef ? parameterInfo.ParameterType.GetElementType() : parameterInfo.ParameterType);
				if (type2.IsValueType && !type2.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(type2))
				{
					if (flag)
					{
						stringBuilder.AppendLine(string.Format("            {0} a{1} = new {0}();", realClsName, num3));
					}
					else
					{
						stringBuilder.AppendLine(string.Format("            {0} @{1} = new {0}();", realClsName, parameterInfo.Name));
					}
					stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName}_Binder != null) {{");
					if (flag)
					{
						stringBuilder.AppendLine(string.Format("                ILRuntime.Runtime.Generated.CLRBindings.s_{1}_Binder.ParseValue(ref a{0}, __intp, ptr_of_this_method, __mStack, {2});", num3, clsName, arg));
					}
					else
					{
						stringBuilder.AppendLine(string.Format("                ILRuntime.Runtime.Generated.CLRBindings.s_{1}_Binder.ParseValue(ref @{0}, __intp, ptr_of_this_method, __mStack, {2});", parameterInfo.Name, clsName, arg));
					}
					stringBuilder.AppendLine("            } else {");
					if (isByRef)
					{
						stringBuilder.AppendLine("                ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);");
					}
					if (flag)
					{
						stringBuilder.AppendLine($"                a{num3} = {parameterInfo.ParameterType.GetRetrieveValueCode(realClsName)};");
					}
					else
					{
						stringBuilder.AppendLine($"                @{parameterInfo.Name} = {parameterInfo.ParameterType.GetRetrieveValueCode(realClsName)};");
					}
					if (!flag2)
					{
						stringBuilder.AppendLine("                __intp.Free(ptr_of_this_method);");
					}
					stringBuilder.AppendLine("            }");
				}
				else if (isByRef)
				{
					if (parameterInfo.ParameterType.GetElementType().IsPrimitive)
					{
						if (type2 == typeof(int) || type2 == typeof(uint) || type2 == typeof(short) || type2 == typeof(ushort) || type2 == typeof(byte) || type2 == typeof(sbyte) || type2 == typeof(char))
						{
							if (type2 == typeof(int))
							{
								stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = __intp.RetriveInt32(ptr_of_this_method, __mStack);");
							}
							else
							{
								stringBuilder.AppendLine(string.Format("            {0} @{1} = ({0})__intp.RetriveInt32(ptr_of_this_method, __mStack);", realClsName, parameterInfo.Name));
							}
						}
						else if (type2 == typeof(long) || type2 == typeof(ulong))
						{
							if (type2 == typeof(long))
							{
								stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = __intp.RetriveInt64(ptr_of_this_method, __mStack);");
							}
							else
							{
								stringBuilder.AppendLine(string.Format("            {0} @{1} = ({0})__intp.RetriveInt64(ptr_of_this_method, __mStack);", realClsName, parameterInfo.Name));
							}
						}
						else if (type2 == typeof(float))
						{
							stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = __intp.RetriveFloat(ptr_of_this_method, __mStack);");
						}
						else if (type2 == typeof(double))
						{
							stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = __intp.RetriveDouble(ptr_of_this_method, __mStack);");
						}
						else
						{
							if (!(type2 == typeof(bool)))
							{
								throw new NotSupportedException();
							}
							stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;");
						}
					}
					else
					{
						stringBuilder.AppendLine(string.Format("            {0} @{1} = ({0})typeof({0}).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack));", realClsName, parameterInfo.Name));
					}
				}
				else
				{
					if (flag)
					{
						stringBuilder.AppendLine($"            {realClsName} a{num3} = {parameterInfo.ParameterType.GetRetrieveValueCode(realClsName)};");
					}
					else
					{
						stringBuilder.AppendLine($"            {realClsName} @{parameterInfo.Name} = {parameterInfo.ParameterType.GetRetrieveValueCode(realClsName)};");
					}
					if (!flag2 && !parameterInfo.ParameterType.IsPrimitive)
					{
						stringBuilder.AppendLine("            __intp.Free(ptr_of_this_method);");
					}
				}
				stringBuilder.AppendLine();
			}
			stringBuilder.AppendLine();
			stringBuilder.Append("            var result_of_this_method = ");
			string clsName2;
			string realClsName2;
			bool isByRef2;
			if (flag)
			{
				type.GetElementType().GetClassName(out clsName2, out realClsName2, out isByRef2);
				stringBuilder.Append($"new {realClsName2}[");
				parameters.AppendParameters(stringBuilder, flag);
				stringBuilder.AppendLine("];");
			}
			else
			{
				type.GetClassName(out clsName2, out realClsName2, out isByRef2);
				stringBuilder.Append($"new {realClsName2}(");
				parameters.AppendParameters(stringBuilder, flag);
				stringBuilder.AppendLine(");");
			}
			stringBuilder.AppendLine();
			for (int num4 = parameters.Length; num4 > 0; num4--)
			{
				ParameterInfo parameterInfo2 = parameters[num4 - 1];
				if (parameterInfo2.ParameterType.IsByRef || flag2)
				{
					Type type3 = (parameterInfo2.ParameterType.IsByRef ? parameterInfo2.ParameterType.GetElementType() : parameterInfo2.ParameterType);
					type3.GetClassName(out var clsName3, out var realClsName3, out var _);
					stringBuilder.AppendLine($"            ptr_of_this_method = ILIntepreter.Minus(__esp, {parameters.Length - num4 + 1});");
					if (parameterInfo2.ParameterType.IsByRef)
					{
						stringBuilder.AppendLine("            switch(ptr_of_this_method->ObjectType)\r\n            {\r\n                case ObjectTypes.StackObjectReference:\r\n                    {\r\n                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);");
						if (parameterInfo2.ParameterType.IsValueType && !parameterInfo2.ParameterType.IsPrimitive && valueTypeBinders != null && valueTypeBinders.Contains(parameterInfo2.ParameterType))
						{
							stringBuilder.AppendLine($"                if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName3}_Binder != null) {{");
							stringBuilder.AppendLine($"                        ILRuntime.Runtime.Generated.CLRBindings.s_{realClsName3}_Binder.WriteBackValue(__domain, ptr_of_this_method, __mStack, ref {parameterInfo2.Name});");
							stringBuilder.AppendLine("                } else {");
							parameterInfo2.ParameterType.GetElementType().GetRefWriteBackValueCode(stringBuilder, parameterInfo2.Name);
							stringBuilder.AppendLine("                }");
						}
						else
						{
							parameterInfo2.ParameterType.GetElementType().GetRefWriteBackValueCode(stringBuilder, parameterInfo2.Name);
						}
						stringBuilder.Append("                    }\r\n                    break;\r\n                case ObjectTypes.FieldReference:\r\n                    {\r\n                        var ___obj = __mStack[ptr_of_this_method->Value];\r\n                        if(___obj is ILTypeInstance)\r\n                        {\r\n                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = ");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            var t = __domain.GetType(___obj.GetType()) as CLRType;\r\n                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, ");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                case ObjectTypes.StaticFieldReference:\r\n                    {\r\n                        var t = __domain.GetType(ptr_of_this_method->Value);\r\n                        if(t is ILType)\r\n                        {\r\n                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = ");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, ");
						stringBuilder.Append(parameterInfo2.Name);
						stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                 case ObjectTypes.ArrayReference:\r\n                    {\r\n                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as ");
						stringBuilder.Append(realClsName3);
						stringBuilder.Append("[];\r\n                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = ");
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
			if (type.IsValueType)
			{
				if (valueTypeBinders != null && valueTypeBinders.Contains(type))
				{
					type.GetClassName(out var clsName4, out var _, out var _);
					stringBuilder.AppendLine("            if(!isNewObj)\r\n            {\r\n                __ret--;");
					stringBuilder.AppendLine($"                if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName4}_Binder != null) {{");
					stringBuilder.AppendLine($"                    ILRuntime.Runtime.Generated.CLRBindings.s_{clsName4}_Binder.WriteBackValue(__domain, __ret, __mStack, ref result_of_this_method);");
					stringBuilder.AppendLine("                } else {");
					stringBuilder.AppendLine("                    WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);");
					stringBuilder.AppendLine("                }");
					stringBuilder.AppendLine("                return __ret;\r\n            }");
				}
				else
				{
					stringBuilder.AppendLine("            if(!isNewObj)\r\n            {\r\n                __ret--;\r\n                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);\r\n                return __ret;\r\n            }");
				}
				stringBuilder.AppendLine();
			}
			if (type.IsValueType && valueTypeBinders != null && valueTypeBinders.Contains(type))
			{
				type.GetClassName(out var clsName5, out var _, out var _);
				stringBuilder.AppendLine($"            if (ILRuntime.Runtime.Generated.CLRBindings.s_{clsName5}_Binder != null) {{");
				stringBuilder.AppendLine($"                ILRuntime.Runtime.Generated.CLRBindings.s_{clsName5}_Binder.PushValue(ref result_of_this_method, __intp, __ret, __mStack);");
				stringBuilder.AppendLine("                return __ret + 1;");
				stringBuilder.AppendLine("            } else {");
				stringBuilder.AppendLine("                return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);");
				stringBuilder.AppendLine("            }");
			}
			else
			{
				stringBuilder.AppendLine("            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);");
			}
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			num++;
		}
		return stringBuilder.ToString();
	}
}
