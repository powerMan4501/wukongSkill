using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter.OpCodes;

namespace ILRuntime.Runtime.CLRBinding;

public class BindingCodeGenerator
{
	internal class CLRBindingGenerateInfo
	{
		public Type Type { get; set; }

		public HashSet<MethodInfo> Methods { get; set; }

		public HashSet<FieldInfo> Fields { get; set; }

		public HashSet<ConstructorInfo> Constructors { get; set; }

		public bool ArrayNeeded { get; set; }

		public bool DefaultInstanceNeeded { get; set; }

		public bool ValueTypeNeeded { get; set; }

		public bool NeedGenerate
		{
			get
			{
				if (Methods.Count == 0 && Constructors.Count == 0 && Fields.Count == 0 && !ArrayNeeded && !DefaultInstanceNeeded && !ValueTypeNeeded)
				{
					return false;
				}
				if (Type == typeof(Delegate) || Type == typeof(RuntimeHelpers))
				{
					return false;
				}
				return true;
			}
		}
	}

	internal class FileNameEqualityComparer : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			if (x == null)
			{
				return y == null;
			}
			if (y == null)
			{
				return false;
			}
			return x.Equals(y, StringComparison.OrdinalIgnoreCase);
		}

		public int GetHashCode(string obj)
		{
			int result = 0;
			if (obj != null)
			{
				result = obj.GetHashCode();
			}
			return result;
		}
	}

	private static string SmartBindText = "\r\n//will auto register in unity\r\n#if UNITY_5_3_OR_NEWER\r\n        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]\r\n#endif\r\n        static private void RegisterBindingAction()\r\n        {\r\n            ILRuntime.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);\r\n        }\r\n";

	public static void GenerateBindingCode(List<Type> types, string outputPath, HashSet<MethodBase> excludeMethods = null, HashSet<FieldInfo> excludeFields = null, List<Type> valueTypeBinders = null, List<Type> delegateTypes = null)
	{
		if (!Directory.Exists(outputPath))
		{
			Directory.CreateDirectory(outputPath);
		}
		string[] files = Directory.GetFiles(outputPath, "*.cs");
		for (int i = 0; i < files.Length; i++)
		{
			File.Delete(files[i]);
		}
		List<string> list = new List<string>();
		foreach (Type type in types)
		{
			if (type.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
			{
				continue;
			}
			type.GetClassName(out var clsName, out var realClsName, out var _);
			list.Add(clsName);
			using StreamWriter streamWriter = new StreamWriter(outputPath + "/" + clsName + ".cs", append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("using System;\r\nusing System.Collections.Generic;\r\nusing System.Reflection;\r\nusing System.Runtime.InteropServices;\r\n\r\nusing ILRuntime.CLR.TypeSystem;\r\nusing ILRuntime.CLR.Method;\r\nusing ILRuntime.Runtime.Enviorment;\r\nusing ILRuntime.Runtime.Intepreter;\r\nusing ILRuntime.Runtime.Stack;\r\nusing ILRuntime.Reflection;\r\nusing ILRuntime.CLR.Utils;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\n\r\nnamespace ILRuntime.Runtime.Generated\r\n{\r\n    unsafe class ");
			stringBuilder.AppendLine(clsName);
			stringBuilder.Append("    {\r\n        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {\r\n");
			string value = "            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;";
			string value2 = "            MethodBase method;";
			string value3 = "            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();";
			string value4 = "            FieldInfo field;";
			string value5 = "            Type[] args;";
			string value6 = $"            Type type = typeof({realClsName});";
			MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
			FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
			bool needMethods;
			string value7 = type.GenerateMethodRegisterCode(methods, excludeMethods, out needMethods);
			string value8 = type.GenerateFieldRegisterCode(fields, excludeFields);
			string value9 = type.GenerateValueTypeRegisterCode(realClsName);
			string value10 = type.GenerateMiscRegisterCode(realClsName, defaultCtor: true, newArr: true);
			string value11 = type.GenerateCommonCode(realClsName);
			ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
			string value12 = type.GenerateConstructorRegisterCode(constructors, excludeMethods);
			string value13 = type.GenerateMethodWraperCode(methods, realClsName, excludeMethods, valueTypeBinders, null);
			string value14 = type.GenerateFieldWraperCode(fields, realClsName, excludeFields, valueTypeBinders, null);
			string value15 = type.GenerateCloneWraperCode(fields, realClsName);
			string value16 = type.GenerateConstructorWraperCode(constructors, realClsName, excludeMethods, valueTypeBinders);
			bool num = !string.IsNullOrEmpty(value7);
			bool flag = !string.IsNullOrEmpty(value8);
			bool flag2 = !string.IsNullOrEmpty(value9);
			bool flag3 = !string.IsNullOrEmpty(value10);
			bool flag4 = !string.IsNullOrEmpty(value12);
			bool flag5 = methods.Where((MethodInfo x) => !x.IsGenericMethod).Count() != 0;
			if ((num && flag5) || flag || flag4)
			{
				stringBuilder.AppendLine(value);
			}
			if (num || flag4)
			{
				stringBuilder.AppendLine(value2);
			}
			if (flag)
			{
				stringBuilder.AppendLine(value4);
			}
			if (num || flag || flag4)
			{
				stringBuilder.AppendLine(value5);
			}
			if (num || flag || flag2 || flag3 || flag4)
			{
				stringBuilder.AppendLine(value6);
			}
			if (needMethods)
			{
				stringBuilder.AppendLine(value3);
			}
			stringBuilder.AppendLine(value7);
			stringBuilder.AppendLine(value8);
			stringBuilder.AppendLine(value9);
			stringBuilder.AppendLine(value10);
			stringBuilder.AppendLine(value12);
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(value11);
			stringBuilder.AppendLine(value13);
			stringBuilder.AppendLine(value14);
			stringBuilder.AppendLine(value15);
			stringBuilder.AppendLine(value16);
			stringBuilder.AppendLine("    }");
			stringBuilder.AppendLine("}");
			streamWriter.Write(Regex.Replace(stringBuilder.ToString(), "(?<!\r)\n", "\r\n"));
			streamWriter.Flush();
		}
		List<string> collection = GenerateDelegateBinding(delegateTypes, outputPath);
		list.AddRange(collection);
		GenerateBindingInitializeScript(list, valueTypeBinders, outputPath);
	}

	public static bool IsClassInExclude(string ClassName, List<string> excludeClass)
	{
		for (int i = 0; i < excludeClass.Count; i++)
		{
			if (ClassName.Contains(excludeClass[i]))
			{
				return true;
			}
		}
		return false;
	}

	public static void GenerateBindingCode(ILRuntime.Runtime.Enviorment.AppDomain domain, string outputPath, List<Type> valueTypeBinders = null, List<Type> delegateTypes = null, int maxGenericDepth = 10, List<string> excludeClass = null, params string[] excludeFiles)
	{
		if (domain == null)
		{
			return;
		}
		if (!Directory.Exists(outputPath))
		{
			Directory.CreateDirectory(outputPath);
		}
		Dictionary<Type, CLRBindingGenerateInfo> dictionary = new Dictionary<Type, CLRBindingGenerateInfo>(new ByReferenceKeyComparer<Type>());
		CrawlAppdomain(domain, dictionary, maxGenericDepth);
		string[] files = Directory.GetFiles(outputPath, "*.cs");
		for (int i = 0; i < files.Length; i++)
		{
			File.Delete(files[i]);
		}
		if (valueTypeBinders == null)
		{
			valueTypeBinders = new List<Type>(domain.ValueTypeBinders.Keys);
		}
		HashSet<MethodBase> excludes = null;
		HashSet<FieldInfo> excludes2 = null;
		HashSet<string> hashSet = new HashSet<string>();
		List<string> list = new List<string>();
		FileNameEqualityComparer comparer = new FileNameEqualityComparer();
		foreach (KeyValuePair<Type, CLRBindingGenerateInfo> item in dictionary)
		{
			if (!item.Value.NeedGenerate)
			{
				continue;
			}
			Type type = item.Value.Type;
			if (type.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length != 0)
			{
				continue;
			}
			type.GetClassName(out var clsName, out var realClsName, out var _);
			if (IsClassInExclude(clsName, excludeClass) || excludeFiles.Contains(clsName))
			{
				continue;
			}
			int num = 0;
			string text = clsName;
			while (list.Contains(text))
			{
				num++;
				text = clsName + "_t" + num;
			}
			list.Add(text);
			clsName = text;
			string text2 = outputPath + "/" + clsName;
			int num2 = Math.Min(text2.Length, 200);
			if (num2 < text2.Length)
			{
				text2 = text2.Substring(0, num2);
			}
			int num3 = 0;
			string text3 = text2;
			while (hashSet.Contains(text3, comparer))
			{
				num3++;
				text3 = text2 + "_t" + num3;
			}
			hashSet.Add(text3);
			text3 += ".cs";
			using StreamWriter streamWriter = new StreamWriter(text3, append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("#if !WITH_EDITOR\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Reflection;\r\nusing System.Runtime.InteropServices;\r\n\r\nusing ILRuntime.CLR.TypeSystem;\r\nusing ILRuntime.CLR.Method;\r\nusing ILRuntime.Runtime.Enviorment;\r\nusing ILRuntime.Runtime.Intepreter;\r\nusing ILRuntime.Runtime.Stack;\r\nusing ILRuntime.Reflection;\r\nusing ILRuntime.CLR.Utils;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\nnamespace ILRuntime.Runtime.Generated\r\n{\r\n    unsafe class ");
			stringBuilder.AppendLine(clsName);
			stringBuilder.Append("    {\r\n        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {\r\n");
			string value = "            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;";
			string value2 = "            MethodBase method;";
			string value3 = "            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();";
			string value4 = "            FieldInfo field;";
			string value5 = "            Type[] args;";
			string value6 = $"            Type type = typeof({realClsName});";
			MethodInfo[] array = item.Value.Methods.ToArray();
			FieldInfo[] array2 = item.Value.Fields.ToArray();
			bool needMethods;
			string value7 = type.GenerateMethodRegisterCode(array, excludes, out needMethods);
			string value8 = ((array2.Length != 0) ? type.GenerateFieldRegisterCode(array2, excludes2) : null);
			string value9 = (item.Value.ValueTypeNeeded ? type.GenerateValueTypeRegisterCode(realClsName) : null);
			string value10 = type.GenerateMiscRegisterCode(realClsName, item.Value.DefaultInstanceNeeded, item.Value.ArrayNeeded);
			string value11 = type.GenerateCommonCode(realClsName);
			ConstructorInfo[] methods = item.Value.Constructors.ToArray();
			string value12 = type.GenerateConstructorRegisterCode(methods, excludes);
			string value13 = type.GenerateMethodWraperCode(array, realClsName, excludes, valueTypeBinders, domain);
			string value14 = ((array2.Length != 0) ? type.GenerateFieldWraperCode(array2, realClsName, excludes2, valueTypeBinders, domain) : null);
			string value15 = null;
			if (item.Value.ValueTypeNeeded)
			{
				FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
				value15 = type.GenerateCloneWraperCode(fields, realClsName);
			}
			bool num4 = !string.IsNullOrEmpty(value7);
			bool flag = !string.IsNullOrEmpty(value8);
			bool flag2 = !string.IsNullOrEmpty(value9);
			bool flag3 = !string.IsNullOrEmpty(value10);
			bool flag4 = !string.IsNullOrEmpty(value12);
			bool flag5 = array.Where((MethodInfo x) => !x.IsGenericMethod).Count() != 0;
			if ((num4 && flag5) || flag || flag4)
			{
				stringBuilder.AppendLine(value);
			}
			if (num4 || flag4)
			{
				stringBuilder.AppendLine(value2);
			}
			if (flag)
			{
				stringBuilder.AppendLine(value4);
			}
			if (num4 || flag || flag4)
			{
				stringBuilder.AppendLine(value5);
			}
			if (num4 || flag || flag2 || flag3 || flag4)
			{
				stringBuilder.AppendLine(value6);
			}
			if (needMethods)
			{
				stringBuilder.AppendLine(value3);
			}
			stringBuilder.AppendLine(value7);
			if (array2.Length != 0)
			{
				stringBuilder.AppendLine(value8);
			}
			if (item.Value.ValueTypeNeeded)
			{
				stringBuilder.AppendLine(value9);
			}
			if (!string.IsNullOrEmpty(value10))
			{
				stringBuilder.AppendLine(value10);
			}
			stringBuilder.AppendLine(value12);
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(value11);
			stringBuilder.AppendLine(value13);
			if (array2.Length != 0)
			{
				stringBuilder.AppendLine(value14);
			}
			if (item.Value.ValueTypeNeeded)
			{
				stringBuilder.AppendLine(value15);
			}
			string value16 = type.GenerateConstructorWraperCode(methods, realClsName, excludes, valueTypeBinders);
			stringBuilder.AppendLine(value16);
			stringBuilder.AppendLine("    }");
			stringBuilder.AppendLine("}");
			stringBuilder.AppendLine("#endif");
			streamWriter.Write(Regex.Replace(stringBuilder.ToString(), "(?<!\r)\n", "\r\n"));
			streamWriter.Flush();
		}
		using (StreamWriter streamWriter2 = new StreamWriter(outputPath + "/CLRBindings.cs", append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendLine("#if !WITH_EDITOR\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Reflection;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\nnamespace ILRuntime.Runtime.Generated\r\n{\r\n    class CLRBindings\r\n    {");
			stringBuilder2.Append(SmartBindText);
			stringBuilder2.Append("\r\n        /// <summary>\r\n        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration\r\n        /// </summary>\r\n                public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {");
			foreach (string item2 in list)
			{
				stringBuilder2.Append("            ");
				stringBuilder2.Append(item2);
				stringBuilder2.AppendLine(".Register(app);");
			}
			stringBuilder2.AppendLine("        }\r\n    }\r\n}\r\n#endif");
			streamWriter2.Write(Regex.Replace(stringBuilder2.ToString(), "(?<!\r)\n", "\r\n"));
		}
		List<string> collection = GenerateDelegateBinding(delegateTypes, outputPath);
		list.AddRange(collection);
		GenerateBindingInitializeScript(list, valueTypeBinders, outputPath);
	}

	private static void PrewarmDomain(ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		IType[] array = domain.LoadedTypes.Values.ToArray();
		foreach (IType type in array)
		{
			if (!(type is ILType))
			{
				continue;
			}
			if (type.HasGenericParameter)
			{
				ILType iLType = (ILType)type;
				if (iLType.GenericInstances == null)
				{
					continue;
				}
				foreach (ILType genericInstance in iLType.GenericInstances)
				{
					PrewarmType(genericInstance);
				}
			}
			else
			{
				PrewarmType((ILType)type);
			}
		}
	}

	private static void PrewarmType(ILType type)
	{
		List<IMethod> list = type.GetMethods().ToList();
		foreach (ILMethod constructor in type.GetConstructors())
		{
			list.Add(constructor);
		}
		if (type.GetStaticConstroctor() != null)
		{
			list.Add(type.GetStaticConstroctor());
		}
		foreach (IMethod item in list)
		{
			if (item is ILMethod iLMethod && (iLMethod.GenericParameterCount <= 0 || iLMethod.IsGenericInstance))
			{
				_ = iLMethod.Body;
			}
		}
	}

	internal static void CrawlAppdomain(ILRuntime.Runtime.Enviorment.AppDomain domain, Dictionary<Type, CLRBindingGenerateInfo> infos, int maxGenericDepth)
	{
		domain.SuppressStaticConstructor = true;
		for (int i = 0; i < maxGenericDepth; i++)
		{
			PrewarmDomain(domain);
		}
		IType[] array = domain.LoadedTypes.Values.ToArray();
		foreach (IType type in array)
		{
			if (!(type is ILType) || type.TypeForCLR.IsByRef)
			{
				continue;
			}
			if (type.HasGenericParameter)
			{
				ILType iLType = (ILType)type;
				if (iLType.GenericInstances == null)
				{
					continue;
				}
				foreach (ILType genericInstance in iLType.GenericInstances)
				{
					CrawlType(domain, genericInstance, infos);
				}
			}
			else
			{
				CrawlType(domain, (ILType)type, infos);
			}
		}
	}

	private static void CrawlType(ILRuntime.Runtime.Enviorment.AppDomain domain, ILType type, Dictionary<Type, CLRBindingGenerateInfo> infos)
	{
		List<IMethod> list = type.GetMethods().ToList();
		foreach (ILMethod constructor in type.GetConstructors())
		{
			list.Add(constructor);
		}
		if (type.GetStaticConstroctor() != null)
		{
			list.Add(type.GetStaticConstroctor());
		}
		foreach (IMethod item in list)
		{
			if (!(item is ILMethod iLMethod) || (iLMethod.GenericParameterCount > 0 && !iLMethod.IsGenericInstance))
			{
				continue;
			}
			OpCode[] body = iLMethod.Body;
			for (int i = 0; i < body.Length; i++)
			{
				OpCode opCode = body[i];
				switch (opCode.Code)
				{
				case OpCodeEnum.Newobj:
					if (domain.GetMethod(opCode.TokenInteger) is CLRMethod cLRMethod2 && !cLRMethod2.DeclearingType.IsDelegate)
					{
						Type typeForCLR3 = cLRMethod2.DeclearingType.TypeForCLR;
						if (!infos.TryGetValue(typeForCLR3, out var value4))
						{
							value4 = (infos[typeForCLR3] = CreateNewBindingInfo(typeForCLR3));
						}
						if (cLRMethod2.IsConstructor)
						{
							value4.Constructors.Add(cLRMethod2.ConstructorInfo);
						}
						else
						{
							value4.Methods.Add(cLRMethod2.MethodInfo);
						}
					}
					break;
				case OpCodeEnum.Ldfld:
				case OpCodeEnum.Ldflda:
				case OpCodeEnum.Stfld:
				case OpCodeEnum.Ldsfld:
				case OpCodeEnum.Ldsflda:
				case OpCodeEnum.Stsfld:
				{
					if (!(domain.GetType((int)(opCode.TokenLong >> 32)) is CLRType cLRType))
					{
						break;
					}
					FieldInfo field = cLRType.GetField((int)opCode.TokenLong);
					if (field != null && field.IsPublic)
					{
						if (!infos.TryGetValue(cLRType.TypeForCLR, out var value3))
						{
							value3 = CreateNewBindingInfo(cLRType.TypeForCLR);
							infos[cLRType.TypeForCLR] = value3;
						}
						if ((opCode.Code == OpCodeEnum.Stfld || opCode.Code == OpCodeEnum.Stsfld) && cLRType.IsValueType)
						{
							value3.ValueTypeNeeded = true;
							value3.DefaultInstanceNeeded = true;
						}
						value3.Fields.Add(field);
					}
					break;
				}
				case OpCodeEnum.Ldtoken:
				{
					if (opCode.TokenInteger != 0 || !(domain.GetType((int)(opCode.TokenLong >> 32)) is CLRType cLRType3))
					{
						break;
					}
					FieldInfo field2 = cLRType3.GetField((int)opCode.TokenLong);
					if (field2 != null)
					{
						if (!infos.TryGetValue(cLRType3.TypeForCLR, out var value6))
						{
							value6 = CreateNewBindingInfo(cLRType3.TypeForCLR);
							infos[cLRType3.TypeForCLR] = value6;
						}
						value6.Fields.Add(field2);
					}
					break;
				}
				case OpCodeEnum.Newarr:
					if (domain.GetType(opCode.TokenInteger) is CLRType cLRType2)
					{
						if (!infos.TryGetValue(cLRType2.TypeForCLR, out var value5))
						{
							value5 = CreateNewBindingInfo(cLRType2.TypeForCLR);
							infos[cLRType2.TypeForCLR] = value5;
						}
						value5.ArrayNeeded = true;
					}
					break;
				case OpCodeEnum.Call:
				case OpCodeEnum.Callvirt:
					if (!(domain.GetMethod(opCode.TokenInteger) is CLRMethod cLRMethod) || (cLRMethod.IsConstructor && cLRMethod.DeclearingType.CanAssignTo(type.FirstCLRBaseType)))
					{
						break;
					}
					if (cLRMethod.IsConstructor)
					{
						if (cLRMethod.ConstructorInfo.IsPublic)
						{
							Type typeForCLR = cLRMethod.DeclearingType.TypeForCLR;
							if (!infos.TryGetValue(typeForCLR, out var value))
							{
								value = (infos[typeForCLR] = CreateNewBindingInfo(typeForCLR));
							}
							value.Constructors.Add(cLRMethod.ConstructorInfo);
						}
					}
					else if (cLRMethod.MethodInfo.IsPublic)
					{
						Type typeForCLR2 = cLRMethod.DeclearingType.TypeForCLR;
						if (!infos.TryGetValue(typeForCLR2, out var value2))
						{
							value2 = (infos[typeForCLR2] = CreateNewBindingInfo(typeForCLR2));
						}
						value2.Methods.Add(cLRMethod.MethodInfo);
					}
					break;
				}
			}
		}
	}

	internal static CLRBindingGenerateInfo CreateNewBindingInfo(Type t)
	{
		CLRBindingGenerateInfo cLRBindingGenerateInfo = new CLRBindingGenerateInfo();
		cLRBindingGenerateInfo.Type = t;
		cLRBindingGenerateInfo.Methods = new HashSet<MethodInfo>();
		cLRBindingGenerateInfo.Fields = new HashSet<FieldInfo>();
		cLRBindingGenerateInfo.Constructors = new HashSet<ConstructorInfo>();
		if (t.IsValueType)
		{
			cLRBindingGenerateInfo.DefaultInstanceNeeded = true;
		}
		return cLRBindingGenerateInfo;
	}

	internal static List<string> GenerateDelegateBinding(List<Type> types, string outputPath)
	{
		if (types == null)
		{
			types = new List<Type>(0);
		}
		List<string> list = new List<string>();
		foreach (Type type in types)
		{
			MethodInfo method = type.GetMethod("Invoke");
			ParameterInfo[] parameters = method.GetParameters();
			type.GetClassName(out var clsName, out var realClsName, out var _);
			list.Add(clsName);
			using StreamWriter streamWriter = new StreamWriter(outputPath + "/" + clsName + ".cs", append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("using System;\r\nusing System.Collections.Generic;\r\nusing System.Reflection;\r\nusing System.Runtime.InteropServices;\r\n\r\nusing ILRuntime.CLR.TypeSystem;\r\nusing ILRuntime.CLR.Method;\r\nusing ILRuntime.Runtime.Enviorment;\r\nusing ILRuntime.Runtime.Intepreter;\r\nusing ILRuntime.Runtime.Stack;\r\nusing ILRuntime.Reflection;\r\nusing ILRuntime.CLR.Utils;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\nnamespace ILRuntime.Runtime.Generated\r\n{\r\n    unsafe class ");
			stringBuilder.AppendLine(clsName);
			stringBuilder.AppendLine("    {\r\n        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {");
			bool flag = true;
			string clsName2;
			string realClsName2;
			bool isByRef2;
			ParameterInfo[] array;
			if (method.ReturnType != typeof(void))
			{
				stringBuilder.Append("            app.DelegateManager.RegisterFunctionDelegate<");
				flag = true;
				array = parameters;
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
					obj.ParameterType.GetClassName(out clsName2, out realClsName2, out isByRef2);
					stringBuilder.Append(realClsName2);
				}
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				method.ReturnType.GetClassName(out clsName2, out realClsName2, out isByRef2);
				stringBuilder.Append(realClsName2);
				stringBuilder.AppendLine("> ();");
				stringBuilder.AppendLine();
			}
			else if (parameters.Length != 0)
			{
				stringBuilder.Append("            app.DelegateManager.RegisterMethodDelegate<");
				flag = true;
				array = parameters;
				foreach (ParameterInfo obj2 in array)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					obj2.ParameterType.GetClassName(out clsName2, out realClsName2, out isByRef2);
					stringBuilder.Append(realClsName2);
				}
				stringBuilder.AppendLine("> ();");
				stringBuilder.AppendLine();
			}
			stringBuilder.Append("            app.DelegateManager.RegisterDelegateConvertor<");
			stringBuilder.Append(realClsName);
			stringBuilder.AppendLine(">((act) =>");
			stringBuilder.AppendLine("            {");
			stringBuilder.Append("                return new ");
			stringBuilder.Append(realClsName);
			stringBuilder.Append("((");
			flag = true;
			array = parameters;
			foreach (ParameterInfo parameterInfo in array)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(parameterInfo.Name);
			}
			stringBuilder.AppendLine(") =>");
			stringBuilder.AppendLine("                {");
			if (method.ReturnType != typeof(void))
			{
				stringBuilder.Append("                    return ((Func<");
				flag = true;
				array = parameters;
				foreach (ParameterInfo obj3 in array)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					obj3.ParameterType.GetClassName(out clsName2, out realClsName2, out isByRef2);
					stringBuilder.Append(realClsName2);
				}
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				method.ReturnType.GetClassName(out clsName2, out realClsName2, out isByRef2);
				stringBuilder.Append(realClsName2);
				stringBuilder.Append(">)act)(");
			}
			else
			{
				if (parameters.Length != 0)
				{
					stringBuilder.Append("                    ((Action<");
				}
				else
				{
					stringBuilder.Append("                    ((Action");
				}
				flag = true;
				array = parameters;
				foreach (ParameterInfo obj4 in array)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					obj4.ParameterType.GetClassName(out clsName2, out realClsName2, out isByRef2);
					stringBuilder.Append(realClsName2);
				}
				if (parameters.Length != 0)
				{
					stringBuilder.Append(">)act)(");
				}
				else
				{
					stringBuilder.Append(")act)(");
				}
			}
			flag = true;
			array = parameters;
			foreach (ParameterInfo parameterInfo2 in array)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(parameterInfo2.Name);
			}
			stringBuilder.AppendLine(");");
			stringBuilder.AppendLine("                });");
			stringBuilder.AppendLine("            });");
			stringBuilder.AppendLine("        }");
			stringBuilder.AppendLine("    }");
			stringBuilder.AppendLine("}");
			streamWriter.Write(Regex.Replace(stringBuilder.ToString(), "(?<!\r)\n", "\r\n"));
			streamWriter.Flush();
		}
		return list;
	}

	internal static void GenerateBindingInitializeScript(List<string> clsNames, List<Type> valueTypeBinders, string outputPath)
	{
		if (!Directory.Exists(outputPath))
		{
			Directory.CreateDirectory(outputPath);
		}
		using StreamWriter streamWriter = new StreamWriter(outputPath + "/CLRBindings.cs", append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("using System;\r\nusing System.Collections.Generic;\r\nusing System.Reflection;\r\n#if DEBUG && !DISABLE_ILRUNTIME_DEBUG\r\nusing AutoList = System.Collections.Generic.List<object>;\r\n#else\r\nusing AutoList = ILRuntime.Other.UncheckedList<object>;\r\n#endif\r\nnamespace ILRuntime.Runtime.Generated\r\n{\r\n    class CLRBindings\r\n    {\r\n");
		stringBuilder.Append(SmartBindText);
		if (valueTypeBinders != null)
		{
			stringBuilder.AppendLine();
			foreach (Type valueTypeBinder in valueTypeBinders)
			{
				valueTypeBinder.GetClassName(out var clsName, out var realClsName, out var _);
				stringBuilder.AppendLine($"        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<{realClsName}> s_{clsName}_Binder = null;");
			}
			stringBuilder.AppendLine();
		}
		stringBuilder.AppendLine("        /// <summary>\r\n        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration\r\n        /// </summary>\r\n        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {\r\n#if !WITH_EDITOR");
		if (clsNames != null)
		{
			foreach (string clsName4 in clsNames)
			{
				stringBuilder.Append("            ");
				stringBuilder.Append(clsName4);
				stringBuilder.AppendLine(".Register(app);");
			}
		}
		if (valueTypeBinders != null && valueTypeBinders.Count > 0)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;");
			foreach (Type valueTypeBinder2 in valueTypeBinders)
			{
				valueTypeBinder2.GetClassName(out var clsName2, out var realClsName2, out var _);
				stringBuilder.AppendLine($"            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof({realClsName2}));");
				stringBuilder.AppendLine($"            s_{clsName2}_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<{realClsName2}>;");
			}
		}
		stringBuilder.AppendLine("#endif");
		stringBuilder.AppendLine("        }");
		stringBuilder.AppendLine("\r\n        /// <summary>\r\n        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy\r\n        /// </summary>\r\n        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)\r\n        {");
		if (valueTypeBinders != null)
		{
			foreach (Type valueTypeBinder3 in valueTypeBinders)
			{
				valueTypeBinder3.GetClassName(out var clsName3, out var _, out var _);
				stringBuilder.AppendLine($"            s_{clsName3}_Binder = null;");
			}
		}
		stringBuilder.AppendLine("        }");
		stringBuilder.AppendLine("    }\r\n}");
		streamWriter.Write(Regex.Replace(stringBuilder.ToString(), "(?<!\r)\n", "\r\n"));
	}
}
