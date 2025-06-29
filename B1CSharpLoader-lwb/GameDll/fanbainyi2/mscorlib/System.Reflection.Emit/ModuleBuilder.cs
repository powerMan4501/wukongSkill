using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_ModuleBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class ModuleBuilder : Module, _ModuleBuilder
{
	private Dictionary<string, Type> m_TypeBuilderDict;

	private ISymbolWriter m_iSymWriter;

	internal ModuleBuilderData m_moduleData;

	private MethodToken m_EntryPoint;

	internal InternalModuleBuilder m_internalModuleBuilder;

	private AssemblyBuilder m_assemblyBuilder;

	internal AssemblyBuilder ContainingAssemblyBuilder => m_assemblyBuilder;

	internal object SyncRoot => ContainingAssemblyBuilder.SyncRoot;

	internal InternalModuleBuilder InternalModule => m_internalModuleBuilder;

	public override string FullyQualifiedName
	{
		[SecuritySafeCritical]
		get
		{
			string text = m_moduleData.m_strFileName;
			if (text == null)
			{
				return null;
			}
			if (ContainingAssemblyBuilder.m_assemblyData.m_strDir != null)
			{
				text = Path.Combine(ContainingAssemblyBuilder.m_assemblyData.m_strDir, text);
				text = Path.UnsafeGetFullPath(text);
			}
			if (ContainingAssemblyBuilder.m_assemblyData.m_strDir != null && text != null)
			{
				new FileIOPermission(FileIOPermissionAccess.PathDiscovery, text).Demand();
			}
			return text;
		}
	}

	public override int MDStreamVersion => InternalModule.MDStreamVersion;

	public override Guid ModuleVersionId => InternalModule.ModuleVersionId;

	public override int MetadataToken => InternalModule.MetadataToken;

	public override string ScopeName => InternalModule.ScopeName;

	public override string Name => InternalModule.Name;

	public override Assembly Assembly => m_assemblyBuilder;

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern IntPtr nCreateISymWriterForDynamicModule(Module module, string filename);

	internal static string UnmangleTypeName(string typeName)
	{
		int startIndex = typeName.Length - 1;
		while (true)
		{
			startIndex = typeName.LastIndexOf('+', startIndex);
			if (startIndex == -1)
			{
				break;
			}
			bool flag = true;
			int num = startIndex;
			while (typeName[--num] == '\\')
			{
				flag = !flag;
			}
			if (flag)
			{
				break;
			}
			startIndex = num;
		}
		return typeName.Substring(startIndex + 1);
	}

	internal ModuleBuilder(AssemblyBuilder assemblyBuilder, InternalModuleBuilder internalModuleBuilder)
	{
		m_internalModuleBuilder = internalModuleBuilder;
		m_assemblyBuilder = assemblyBuilder;
	}

	internal void AddType(string name, Type type)
	{
		m_TypeBuilderDict.Add(name, type);
	}

	internal void CheckTypeNameConflict(string strTypeName, Type enclosingType)
	{
		Type value = null;
		if (m_TypeBuilderDict.TryGetValue(strTypeName, out value) && (object)value.DeclaringType == enclosingType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DuplicateTypeName"));
		}
	}

	private Type GetType(string strFormat, Type baseType)
	{
		if (strFormat == null || strFormat.Equals(string.Empty))
		{
			return baseType;
		}
		char[] bFormat = strFormat.ToCharArray();
		return SymbolType.FormCompoundType(bFormat, baseType, 0);
	}

	internal void CheckContext(params Type[][] typess)
	{
		ContainingAssemblyBuilder.CheckContext(typess);
	}

	internal void CheckContext(params Type[] types)
	{
		ContainingAssemblyBuilder.CheckContext(types);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetTypeRef(RuntimeModule module, string strFullName, RuntimeModule refedModule, string strRefedModuleFileName, int tkResolution);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetMemberRef(RuntimeModule module, RuntimeModule refedModule, int tr, int defToken);

	[SecurityCritical]
	private int GetMemberRef(Module refedModule, int tr, int defToken)
	{
		return GetMemberRef(GetNativeHandle(), GetRuntimeModuleFromModule(refedModule).GetNativeHandle(), tr, defToken);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetMemberRefFromSignature(RuntimeModule module, int tr, string methodName, byte[] signature, int length);

	[SecurityCritical]
	private int GetMemberRefFromSignature(int tr, string methodName, byte[] signature, int length)
	{
		return GetMemberRefFromSignature(GetNativeHandle(), tr, methodName, signature, length);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetMemberRefOfMethodInfo(RuntimeModule module, int tr, IRuntimeMethodInfo method);

	[SecurityCritical]
	private int GetMemberRefOfMethodInfo(int tr, RuntimeMethodInfo method)
	{
		if (ContainingAssemblyBuilder.ProfileAPICheck && (method.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", method.FullName));
		}
		return GetMemberRefOfMethodInfo(GetNativeHandle(), tr, method);
	}

	[SecurityCritical]
	private int GetMemberRefOfMethodInfo(int tr, RuntimeConstructorInfo method)
	{
		if (ContainingAssemblyBuilder.ProfileAPICheck && (method.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", method.FullName));
		}
		return GetMemberRefOfMethodInfo(GetNativeHandle(), tr, method);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetMemberRefOfFieldInfo(RuntimeModule module, int tkType, RuntimeTypeHandle declaringType, int tkField);

	[SecurityCritical]
	private int GetMemberRefOfFieldInfo(int tkType, RuntimeTypeHandle declaringType, RuntimeFieldInfo runtimeField)
	{
		if (ContainingAssemblyBuilder.ProfileAPICheck)
		{
			RtFieldInfo rtFieldInfo = runtimeField as RtFieldInfo;
			if (rtFieldInfo != null && (rtFieldInfo.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", rtFieldInfo.FullName));
			}
		}
		return GetMemberRefOfFieldInfo(GetNativeHandle(), tkType, declaringType, runtimeField.MetadataToken);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetTokenFromTypeSpec(RuntimeModule pModule, byte[] signature, int length);

	[SecurityCritical]
	private int GetTokenFromTypeSpec(byte[] signature, int length)
	{
		return GetTokenFromTypeSpec(GetNativeHandle(), signature, length);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetArrayMethodToken(RuntimeModule module, int tkTypeSpec, string methodName, byte[] signature, int sigLength);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetStringConstant(RuntimeModule module, string str, int length);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void PreSavePEFile(RuntimeModule module, int portableExecutableKind, int imageFileMachine);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SavePEFile(RuntimeModule module, string fileName, int entryPoint, int isExe, bool isManifestFile);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddResource(RuntimeModule module, string strName, byte[] resBytes, int resByteCount, int tkFile, int attribute, int portableExecutableKind, int imageFileMachine);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetModuleName(RuntimeModule module, string strModuleName);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetFieldRVAContent(RuntimeModule module, int fdToken, byte[] data, int length);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DefineNativeResourceFile(RuntimeModule module, string strFilename, int portableExecutableKind, int ImageFileMachine);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DefineNativeResourceBytes(RuntimeModule module, byte[] pbResource, int cbResource, int portableExecutableKind, int imageFileMachine);

	[SecurityCritical]
	internal void DefineNativeResource(PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
	{
		string strResourceFileName = m_moduleData.m_strResourceFileName;
		byte[] resourceBytes = m_moduleData.m_resourceBytes;
		if (strResourceFileName != null)
		{
			DefineNativeResourceFile(GetNativeHandle(), strResourceFileName, (int)portableExecutableKind, (int)imageFileMachine);
		}
		else if (resourceBytes != null)
		{
			DefineNativeResourceBytes(GetNativeHandle(), resourceBytes, resourceBytes.Length, (int)portableExecutableKind, (int)imageFileMachine);
		}
	}

	internal virtual Type FindTypeBuilderWithName(string strTypeName, bool ignoreCase)
	{
		Type value;
		if (ignoreCase)
		{
			foreach (string key in m_TypeBuilderDict.Keys)
			{
				if (string.Compare(key, strTypeName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return m_TypeBuilderDict[key];
				}
			}
		}
		else if (m_TypeBuilderDict.TryGetValue(strTypeName, out value))
		{
			return value;
		}
		return null;
	}

	internal void SetEntryPoint(MethodToken entryPoint)
	{
		m_EntryPoint = entryPoint;
	}

	[SecurityCritical]
	internal void PreSave(string fileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
	{
		if (m_moduleData.m_isSaved)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("InvalidOperation_ModuleHasBeenSaved"), m_moduleData.m_strModuleName));
		}
		if (!m_moduleData.m_fGlobalBeenCreated && m_moduleData.m_fHasGlobal)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GlobalFunctionNotBaked"));
		}
		foreach (Type value in m_TypeBuilderDict.Values)
		{
			TypeBuilder typeBuilder;
			if (value is TypeBuilder)
			{
				typeBuilder = (TypeBuilder)value;
			}
			else
			{
				EnumBuilder enumBuilder = (EnumBuilder)value;
				typeBuilder = enumBuilder.m_typeBuilder;
			}
			if (!typeBuilder.IsCreated())
			{
				throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("NotSupported_NotAllTypesAreBaked"), typeBuilder.FullName));
			}
		}
		PreSavePEFile(GetNativeHandle(), (int)portableExecutableKind, (int)imageFileMachine);
	}

	[SecurityCritical]
	internal void Save(string fileName, bool isAssemblyFile, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
	{
		if (m_moduleData.m_embeddedRes != null)
		{
			for (ResWriterData resWriterData = m_moduleData.m_embeddedRes; resWriterData != null; resWriterData = resWriterData.m_nextResWriter)
			{
				if (resWriterData.m_resWriter != null)
				{
					resWriterData.m_resWriter.Generate();
				}
				byte[] array = new byte[resWriterData.m_memoryStream.Length];
				resWriterData.m_memoryStream.Flush();
				resWriterData.m_memoryStream.Position = 0L;
				resWriterData.m_memoryStream.Read(array, 0, array.Length);
				AddResource(GetNativeHandle(), resWriterData.m_strName, array, array.Length, m_moduleData.FileToken, (int)resWriterData.m_attribute, (int)portableExecutableKind, (int)imageFileMachine);
			}
		}
		DefineNativeResource(portableExecutableKind, imageFileMachine);
		PEFileKinds isExe = ((!isAssemblyFile) ? PEFileKinds.Dll : ContainingAssemblyBuilder.m_assemblyData.m_peFileKind);
		SavePEFile(GetNativeHandle(), fileName, m_EntryPoint.Token, (int)isExe, isAssemblyFile);
		m_moduleData.m_isSaved = true;
	}

	[SecurityCritical]
	private int GetTypeRefNested(Type type, Module refedModule, string strRefedModuleFileName)
	{
		Type declaringType = type.DeclaringType;
		int tkResolution = 0;
		string text = type.FullName;
		if (declaringType != null)
		{
			tkResolution = GetTypeRefNested(declaringType, refedModule, strRefedModuleFileName);
			text = UnmangleTypeName(text);
		}
		if (ContainingAssemblyBuilder.ProfileAPICheck)
		{
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType != null && (runtimeType.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", runtimeType.FullName));
			}
		}
		return GetTypeRef(GetNativeHandle(), text, GetRuntimeModuleFromModule(refedModule).GetNativeHandle(), strRefedModuleFileName, tkResolution);
	}

	[SecurityCritical]
	internal MethodToken InternalGetConstructorToken(ConstructorInfo con, bool usingRef)
	{
		if (con == null)
		{
			throw new ArgumentNullException("con");
		}
		int num = 0;
		ConstructorBuilder constructorBuilder = null;
		ConstructorOnTypeBuilderInstantiation constructorOnTypeBuilderInstantiation = null;
		RuntimeConstructorInfo runtimeConstructorInfo = null;
		if ((constructorBuilder = con as ConstructorBuilder) != null)
		{
			if (!usingRef && constructorBuilder.Module.Equals(this))
			{
				return constructorBuilder.GetToken();
			}
			int token = GetTypeTokenInternal(con.ReflectedType).Token;
			num = GetMemberRef(con.ReflectedType.Module, token, constructorBuilder.GetToken().Token);
		}
		else if ((constructorOnTypeBuilderInstantiation = con as ConstructorOnTypeBuilderInstantiation) != null)
		{
			if (usingRef)
			{
				throw new InvalidOperationException();
			}
			int token = GetTypeTokenInternal(con.DeclaringType).Token;
			num = GetMemberRef(con.DeclaringType.Module, token, constructorOnTypeBuilderInstantiation.MetadataTokenInternal);
		}
		else if ((runtimeConstructorInfo = con as RuntimeConstructorInfo) != null && !con.ReflectedType.IsArray)
		{
			int token = GetTypeTokenInternal(con.ReflectedType).Token;
			num = GetMemberRefOfMethodInfo(token, runtimeConstructorInfo);
		}
		else
		{
			ParameterInfo[] parameters = con.GetParameters();
			if (parameters == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidConstructorInfo"));
			}
			int num2 = parameters.Length;
			Type[] array = new Type[num2];
			Type[][] array2 = new Type[num2][];
			Type[][] array3 = new Type[num2][];
			for (int i = 0; i < num2; i++)
			{
				if (parameters[i] == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidConstructorInfo"));
				}
				array[i] = parameters[i].ParameterType;
				array2[i] = parameters[i].GetRequiredCustomModifiers();
				array3[i] = parameters[i].GetOptionalCustomModifiers();
			}
			int token = GetTypeTokenInternal(con.ReflectedType).Token;
			SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(this, con.CallingConvention, null, null, null, array, array2, array3);
			int length;
			byte[] signature = methodSigHelper.InternalGetSignature(out length);
			num = GetMemberRefFromSignature(token, con.Name, signature, length);
		}
		return new MethodToken(num);
	}

	[SecurityCritical]
	internal void Init(string strModuleName, string strFileName, int tkFile)
	{
		m_moduleData = new ModuleBuilderData(this, strModuleName, strFileName, tkFile);
		m_TypeBuilderDict = new Dictionary<string, Type>();
	}

	[SecurityCritical]
	internal void ModifyModuleName(string name)
	{
		m_moduleData.ModifyModuleName(name);
		SetModuleName(GetNativeHandle(), name);
	}

	internal void SetSymWriter(ISymbolWriter writer)
	{
		m_iSymWriter = writer;
	}

	internal override ModuleHandle GetModuleHandle()
	{
		return new ModuleHandle(GetNativeHandle());
	}

	internal RuntimeModule GetNativeHandle()
	{
		return InternalModule.GetNativeHandle();
	}

	private static RuntimeModule GetRuntimeModuleFromModule(Module m)
	{
		ModuleBuilder moduleBuilder = m as ModuleBuilder;
		if (moduleBuilder != null)
		{
			return moduleBuilder.InternalModule;
		}
		return m as RuntimeModule;
	}

	[SecurityCritical]
	private int GetMemberRefToken(MethodBase method, IEnumerable<Type> optionalParameterTypes)
	{
		int cGenericParameters = 0;
		if (method.IsGenericMethod)
		{
			if (!method.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException();
			}
			cGenericParameters = method.GetGenericArguments().Length;
		}
		if (optionalParameterTypes != null && (method.CallingConvention & CallingConventions.VarArgs) == 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAVarArgCallingConvention"));
		}
		MethodInfo methodInfo = method as MethodInfo;
		Type[] parameterTypes;
		Type methodBaseReturnType;
		if (method.DeclaringType.IsGenericType)
		{
			MethodBase methodBase = null;
			MethodOnTypeBuilderInstantiation methodOnTypeBuilderInstantiation;
			ConstructorOnTypeBuilderInstantiation constructorOnTypeBuilderInstantiation;
			if ((methodOnTypeBuilderInstantiation = method as MethodOnTypeBuilderInstantiation) != null)
			{
				methodBase = methodOnTypeBuilderInstantiation.m_method;
			}
			else if ((constructorOnTypeBuilderInstantiation = method as ConstructorOnTypeBuilderInstantiation) != null)
			{
				methodBase = constructorOnTypeBuilderInstantiation.m_ctor;
			}
			else if (method is MethodBuilder || method is ConstructorBuilder)
			{
				methodBase = method;
			}
			else if (method.IsGenericMethod)
			{
				methodBase = methodInfo.GetGenericMethodDefinition();
				methodBase = methodBase.Module.ResolveMethod(method.MetadataToken, (methodBase.DeclaringType != null) ? methodBase.DeclaringType.GetGenericArguments() : null, methodBase.GetGenericArguments());
			}
			else
			{
				methodBase = method.Module.ResolveMethod(method.MetadataToken, (method.DeclaringType != null) ? method.DeclaringType.GetGenericArguments() : null, null);
			}
			parameterTypes = methodBase.GetParameterTypes();
			methodBaseReturnType = MethodBuilder.GetMethodBaseReturnType(methodBase);
		}
		else
		{
			parameterTypes = method.GetParameterTypes();
			methodBaseReturnType = MethodBuilder.GetMethodBaseReturnType(method);
		}
		int length;
		byte[] signature = GetMemberRefSignature(method.CallingConvention, methodBaseReturnType, parameterTypes, optionalParameterTypes, cGenericParameters).InternalGetSignature(out length);
		int tr;
		if (!method.DeclaringType.IsGenericType)
		{
			tr = ((!method.Module.Equals(this)) ? GetTypeToken(method.DeclaringType).Token : ((!(methodInfo != null)) ? GetConstructorToken(method as ConstructorInfo).Token : GetMethodToken(methodInfo).Token));
		}
		else
		{
			int length2;
			byte[] signature2 = SignatureHelper.GetTypeSigToken(this, method.DeclaringType).InternalGetSignature(out length2);
			tr = GetTokenFromTypeSpec(signature2, length2);
		}
		return GetMemberRefFromSignature(tr, method.Name, signature, length);
	}

	[SecurityCritical]
	internal SignatureHelper GetMemberRefSignature(CallingConventions call, Type returnType, Type[] parameterTypes, IEnumerable<Type> optionalParameterTypes, int cGenericParameters)
	{
		int num = ((parameterTypes != null) ? parameterTypes.Length : 0);
		SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(this, call, returnType, cGenericParameters);
		for (int i = 0; i < num; i++)
		{
			methodSigHelper.AddArgument(parameterTypes[i]);
		}
		if (optionalParameterTypes != null)
		{
			int num2 = 0;
			foreach (Type optionalParameterType in optionalParameterTypes)
			{
				if (num2 == 0)
				{
					methodSigHelper.AddSentinel();
				}
				methodSigHelper.AddArgument(optionalParameterType);
				num2++;
			}
		}
		return methodSigHelper;
	}

	public override bool Equals(object obj)
	{
		return InternalModule.Equals(obj);
	}

	public override int GetHashCode()
	{
		return InternalModule.GetHashCode();
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return InternalModule.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return InternalModule.GetCustomAttributes(attributeType, inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return InternalModule.IsDefined(attributeType, inherit);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return InternalModule.GetCustomAttributesData();
	}

	public override Type[] GetTypes()
	{
		lock (SyncRoot)
		{
			return GetTypesNoLock();
		}
	}

	internal Type[] GetTypesNoLock()
	{
		int count = m_TypeBuilderDict.Count;
		Type[] array = new Type[m_TypeBuilderDict.Count];
		int num = 0;
		foreach (Type value in m_TypeBuilderDict.Values)
		{
			EnumBuilder enumBuilder = value as EnumBuilder;
			TypeBuilder typeBuilder = ((!(enumBuilder != null)) ? ((TypeBuilder)value) : enumBuilder.m_typeBuilder);
			if (typeBuilder.IsCreated())
			{
				array[num++] = typeBuilder.UnderlyingSystemType;
			}
			else
			{
				array[num++] = value;
			}
		}
		return array;
	}

	[ComVisible(true)]
	public override Type GetType(string className)
	{
		return GetType(className, throwOnError: false, ignoreCase: false);
	}

	[ComVisible(true)]
	public override Type GetType(string className, bool ignoreCase)
	{
		return GetType(className, throwOnError: false, ignoreCase);
	}

	[ComVisible(true)]
	public override Type GetType(string className, bool throwOnError, bool ignoreCase)
	{
		lock (SyncRoot)
		{
			return GetTypeNoLock(className, throwOnError, ignoreCase);
		}
	}

	private Type GetTypeNoLock(string className, bool throwOnError, bool ignoreCase)
	{
		Type type = InternalModule.GetType(className, throwOnError, ignoreCase);
		if (type != null)
		{
			return type;
		}
		string text = null;
		string text2 = null;
		int num = 0;
		while (num <= className.Length)
		{
			int num2 = className.IndexOfAny(new char[3] { '[', '*', '&' }, num);
			if (num2 == -1)
			{
				text = className;
				text2 = null;
				break;
			}
			int num3 = 0;
			int num4 = num2 - 1;
			while (num4 >= 0 && className[num4] == '\\')
			{
				num3++;
				num4--;
			}
			if (num3 % 2 == 1)
			{
				num = num2 + 1;
				continue;
			}
			text = className.Substring(0, num2);
			text2 = className.Substring(num2);
			break;
		}
		if (text == null)
		{
			text = className;
			text2 = null;
		}
		text = text.Replace("\\\\", "\\").Replace("\\[", "[").Replace("\\*", "*")
			.Replace("\\&", "&");
		if (text2 != null)
		{
			type = InternalModule.GetType(text, throwOnError: false, ignoreCase);
		}
		if (type == null)
		{
			type = FindTypeBuilderWithName(text, ignoreCase);
			if (type == null && Assembly is AssemblyBuilder)
			{
				List<ModuleBuilder> moduleBuilderList = ContainingAssemblyBuilder.m_assemblyData.m_moduleBuilderList;
				int count = moduleBuilderList.Count;
				for (int i = 0; i < count; i++)
				{
					if (!(type == null))
					{
						break;
					}
					ModuleBuilder moduleBuilder = moduleBuilderList[i];
					type = moduleBuilder.FindTypeBuilderWithName(text, ignoreCase);
				}
			}
			if (type == null)
			{
				return null;
			}
		}
		if (text2 == null)
		{
			return type;
		}
		return GetType(text2, type);
	}

	public override byte[] ResolveSignature(int metadataToken)
	{
		return InternalModule.ResolveSignature(metadataToken);
	}

	public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		return InternalModule.ResolveMethod(metadataToken, genericTypeArguments, genericMethodArguments);
	}

	public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		return InternalModule.ResolveField(metadataToken, genericTypeArguments, genericMethodArguments);
	}

	public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		return InternalModule.ResolveType(metadataToken, genericTypeArguments, genericMethodArguments);
	}

	public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		return InternalModule.ResolveMember(metadataToken, genericTypeArguments, genericMethodArguments);
	}

	public override string ResolveString(int metadataToken)
	{
		return InternalModule.ResolveString(metadataToken);
	}

	public override void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
	{
		InternalModule.GetPEKind(out peKind, out machine);
	}

	public override bool IsResource()
	{
		return InternalModule.IsResource();
	}

	public override FieldInfo[] GetFields(BindingFlags bindingFlags)
	{
		return InternalModule.GetFields(bindingFlags);
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return InternalModule.GetField(name, bindingAttr);
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
	{
		return InternalModule.GetMethods(bindingFlags);
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return InternalModule.GetMethodInternal(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public override X509Certificate GetSignerCertificate()
	{
		return InternalModule.GetSignerCertificate();
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, TypeAttributes.NotPublic, null, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name, TypeAttributes attr)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, attr, null, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent)
	{
		lock (SyncRoot)
		{
			CheckContext(parent);
			return DefineTypeNoLock(name, attr, parent, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, attr, parent, null, PackingSize.Unspecified, typesize);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, attr, parent, null, packingSize, typesize);
		}
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}
	}

	[SecurityCritical]
	private TypeBuilder DefineTypeNoLock(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packingSize, int typesize)
	{
		return new TypeBuilder(name, attr, parent, interfaces, this, packingSize, typesize, null);
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize)
	{
		lock (SyncRoot)
		{
			return DefineTypeNoLock(name, attr, parent, packsize);
		}
	}

	[SecurityCritical]
	private TypeBuilder DefineTypeNoLock(string name, TypeAttributes attr, Type parent, PackingSize packsize)
	{
		return new TypeBuilder(name, attr, parent, null, this, packsize, 0, null);
	}

	[SecuritySafeCritical]
	public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType)
	{
		CheckContext(underlyingType);
		lock (SyncRoot)
		{
			EnumBuilder enumBuilder = DefineEnumNoLock(name, visibility, underlyingType);
			m_TypeBuilderDict[name] = enumBuilder;
			return enumBuilder;
		}
	}

	[SecurityCritical]
	private EnumBuilder DefineEnumNoLock(string name, TypeAttributes visibility, Type underlyingType)
	{
		return new EnumBuilder(name, underlyingType, visibility, this);
	}

	public IResourceWriter DefineResource(string name, string description)
	{
		return DefineResource(name, description, ResourceAttributes.Public);
	}

	public IResourceWriter DefineResource(string name, string description, ResourceAttributes attribute)
	{
		lock (SyncRoot)
		{
			return DefineResourceNoLock(name, description, attribute);
		}
	}

	private IResourceWriter DefineResourceNoLock(string name, string description, ResourceAttributes attribute)
	{
		if (IsTransient())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadResourceContainer"));
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (m_assemblyBuilder.IsPersistable())
		{
			m_assemblyBuilder.m_assemblyData.CheckResNameConflict(name);
			MemoryStream memoryStream = new MemoryStream();
			ResourceWriter resourceWriter = new ResourceWriter(memoryStream);
			ResWriterData resWriterData = new ResWriterData(resourceWriter, memoryStream, name, string.Empty, string.Empty, attribute);
			resWriterData.m_nextResWriter = m_moduleData.m_embeddedRes;
			m_moduleData.m_embeddedRes = resWriterData;
			return resourceWriter;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadResourceContainer"));
	}

	public void DefineManifestResource(string name, Stream stream, ResourceAttributes attribute)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		lock (SyncRoot)
		{
			DefineManifestResourceNoLock(name, stream, attribute);
		}
	}

	private void DefineManifestResourceNoLock(string name, Stream stream, ResourceAttributes attribute)
	{
		if (IsTransient())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadResourceContainer"));
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (m_assemblyBuilder.IsPersistable())
		{
			m_assemblyBuilder.m_assemblyData.CheckResNameConflict(name);
			ResWriterData resWriterData = new ResWriterData(null, stream, name, string.Empty, string.Empty, attribute);
			resWriterData.m_nextResWriter = m_moduleData.m_embeddedRes;
			m_moduleData.m_embeddedRes = resWriterData;
			return;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadResourceContainer"));
	}

	public void DefineUnmanagedResource(byte[] resource)
	{
		lock (SyncRoot)
		{
			DefineUnmanagedResourceInternalNoLock(resource);
		}
	}

	internal void DefineUnmanagedResourceInternalNoLock(byte[] resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		if (m_moduleData.m_strResourceFileName != null || m_moduleData.m_resourceBytes != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		m_moduleData.m_resourceBytes = new byte[resource.Length];
		Array.Copy(resource, m_moduleData.m_resourceBytes, resource.Length);
	}

	[SecuritySafeCritical]
	public void DefineUnmanagedResource(string resourceFileName)
	{
		lock (SyncRoot)
		{
			DefineUnmanagedResourceFileInternalNoLock(resourceFileName);
		}
	}

	[SecurityCritical]
	internal void DefineUnmanagedResourceFileInternalNoLock(string resourceFileName)
	{
		if (resourceFileName == null)
		{
			throw new ArgumentNullException("resourceFileName");
		}
		if (m_moduleData.m_resourceBytes != null || m_moduleData.m_strResourceFileName != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		string text = Path.UnsafeGetFullPath(resourceFileName);
		new FileIOPermission(FileIOPermissionAccess.Read, text).Demand();
		new EnvironmentPermission(PermissionState.Unrestricted).Assert();
		try
		{
			if (!File.UnsafeExists(resourceFileName))
			{
				throw new FileNotFoundException(Environment.GetResourceString("IO.FileNotFound_FileName", resourceFileName), resourceFileName);
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		m_moduleData.m_strResourceFileName = text;
	}

	public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
	{
		return DefineGlobalMethod(name, attributes, CallingConventions.Standard, returnType, parameterTypes);
	}

	public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		return DefineGlobalMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
	}

	public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		lock (SyncRoot)
		{
			return DefineGlobalMethodNoLock(name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
		}
	}

	private MethodBuilder DefineGlobalMethodNoLock(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		if (m_moduleData.m_fGlobalBeenCreated)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_GlobalsHaveBeenCreated"));
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if ((attributes & MethodAttributes.Static) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_GlobalFunctionHasToBeStatic"));
		}
		CheckContext(returnType);
		CheckContext(requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes);
		CheckContext(requiredParameterTypeCustomModifiers);
		CheckContext(optionalParameterTypeCustomModifiers);
		m_moduleData.m_fHasGlobal = true;
		return m_moduleData.m_globalTypeBuilder.DefineMethod(name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
	}

	public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		return DefinePInvokeMethod(name, dllName, name, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
	}

	public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		lock (SyncRoot)
		{
			return DefinePInvokeMethodNoLock(name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
		}
	}

	private MethodBuilder DefinePInvokeMethodNoLock(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		if ((attributes & MethodAttributes.Static) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_GlobalFunctionHasToBeStatic"));
		}
		CheckContext(returnType);
		CheckContext(parameterTypes);
		m_moduleData.m_fHasGlobal = true;
		return m_moduleData.m_globalTypeBuilder.DefinePInvokeMethod(name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
	}

	public void CreateGlobalFunctions()
	{
		lock (SyncRoot)
		{
			CreateGlobalFunctionsNoLock();
		}
	}

	private void CreateGlobalFunctionsNoLock()
	{
		if (m_moduleData.m_fGlobalBeenCreated)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
		m_moduleData.m_globalTypeBuilder.CreateType();
		m_moduleData.m_fGlobalBeenCreated = true;
	}

	public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
	{
		lock (SyncRoot)
		{
			return DefineInitializedDataNoLock(name, data, attributes);
		}
	}

	private FieldBuilder DefineInitializedDataNoLock(string name, byte[] data, FieldAttributes attributes)
	{
		if (m_moduleData.m_fGlobalBeenCreated)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_GlobalsHaveBeenCreated"));
		}
		m_moduleData.m_fHasGlobal = true;
		return m_moduleData.m_globalTypeBuilder.DefineInitializedData(name, data, attributes);
	}

	public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
	{
		lock (SyncRoot)
		{
			return DefineUninitializedDataNoLock(name, size, attributes);
		}
	}

	private FieldBuilder DefineUninitializedDataNoLock(string name, int size, FieldAttributes attributes)
	{
		if (m_moduleData.m_fGlobalBeenCreated)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_GlobalsHaveBeenCreated"));
		}
		m_moduleData.m_fHasGlobal = true;
		return m_moduleData.m_globalTypeBuilder.DefineUninitializedData(name, size, attributes);
	}

	[SecurityCritical]
	internal TypeToken GetTypeTokenInternal(Type type)
	{
		return GetTypeTokenInternal(type, getGenericDefinition: false);
	}

	[SecurityCritical]
	private TypeToken GetTypeTokenInternal(Type type, bool getGenericDefinition)
	{
		lock (SyncRoot)
		{
			return GetTypeTokenWorkerNoLock(type, getGenericDefinition);
		}
	}

	[SecuritySafeCritical]
	public TypeToken GetTypeToken(Type type)
	{
		return GetTypeTokenInternal(type, getGenericDefinition: true);
	}

	[SecurityCritical]
	private TypeToken GetTypeTokenWorkerNoLock(Type type, bool getGenericDefinition)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		CheckContext(type);
		if (type.IsByRef)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_CannotGetTypeTokenForByRef"));
		}
		if ((type.IsGenericType && (!type.IsGenericTypeDefinition || !getGenericDefinition)) || type.IsGenericParameter || type.IsArray || type.IsPointer)
		{
			int length;
			byte[] signature = SignatureHelper.GetTypeSigToken(this, type).InternalGetSignature(out length);
			return new TypeToken(GetTokenFromTypeSpec(signature, length));
		}
		Module module = type.Module;
		if (module.Equals(this))
		{
			TypeBuilder typeBuilder = null;
			GenericTypeParameterBuilder genericTypeParameterBuilder = null;
			EnumBuilder enumBuilder = type as EnumBuilder;
			typeBuilder = ((!(enumBuilder != null)) ? (type as TypeBuilder) : enumBuilder.m_typeBuilder);
			if (typeBuilder != null)
			{
				return typeBuilder.TypeToken;
			}
			if ((genericTypeParameterBuilder = type as GenericTypeParameterBuilder) != null)
			{
				return new TypeToken(genericTypeParameterBuilder.MetadataTokenInternal);
			}
			return new TypeToken(GetTypeRefNested(type, this, string.Empty));
		}
		ModuleBuilder moduleBuilder = module as ModuleBuilder;
		bool flag = ((moduleBuilder != null) ? moduleBuilder.IsTransient() : ((RuntimeModule)module).IsTransientInternal());
		if (!IsTransient() && flag)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadTransientModuleReference"));
		}
		string strRefedModuleFileName = string.Empty;
		if (module.Assembly.Equals(Assembly))
		{
			if (moduleBuilder == null)
			{
				moduleBuilder = ContainingAssemblyBuilder.GetModuleBuilder((InternalModuleBuilder)module);
			}
			strRefedModuleFileName = moduleBuilder.m_moduleData.m_strFileName;
		}
		return new TypeToken(GetTypeRefNested(type, module, strRefedModuleFileName));
	}

	public TypeToken GetTypeToken(string name)
	{
		return GetTypeToken(InternalModule.GetType(name, throwOnError: false, ignoreCase: true));
	}

	[SecuritySafeCritical]
	public MethodToken GetMethodToken(MethodInfo method)
	{
		lock (SyncRoot)
		{
			return GetMethodTokenNoLock(method, getGenericTypeDefinition: true);
		}
	}

	[SecurityCritical]
	internal MethodToken GetMethodTokenInternal(MethodInfo method)
	{
		lock (SyncRoot)
		{
			return GetMethodTokenNoLock(method, getGenericTypeDefinition: false);
		}
	}

	[SecurityCritical]
	private MethodToken GetMethodTokenNoLock(MethodInfo method, bool getGenericTypeDefinition)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		int num = 0;
		SymbolMethod symbolMethod = null;
		MethodBuilder methodBuilder = null;
		if ((methodBuilder = method as MethodBuilder) != null)
		{
			int metadataTokenInternal = methodBuilder.MetadataTokenInternal;
			if (method.Module.Equals(this))
			{
				return new MethodToken(metadataTokenInternal);
			}
			if (method.DeclaringType == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotImportGlobalFromDifferentModule"));
			}
			int tr = (getGenericTypeDefinition ? GetTypeToken(method.DeclaringType).Token : GetTypeTokenInternal(method.DeclaringType).Token);
			num = GetMemberRef(method.DeclaringType.Module, tr, metadataTokenInternal);
		}
		else
		{
			if (method is MethodOnTypeBuilderInstantiation)
			{
				return new MethodToken(GetMemberRefToken(method, null));
			}
			if ((symbolMethod = method as SymbolMethod) != null)
			{
				if (symbolMethod.GetModule() == this)
				{
					return symbolMethod.GetToken();
				}
				return symbolMethod.GetToken(this);
			}
			Type declaringType = method.DeclaringType;
			if (declaringType == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotImportGlobalFromDifferentModule"));
			}
			RuntimeMethodInfo runtimeMethodInfo = null;
			if (declaringType.IsArray)
			{
				ParameterInfo[] parameters = method.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					array[i] = parameters[i].ParameterType;
				}
				return GetArrayMethodToken(declaringType, method.Name, method.CallingConvention, method.ReturnType, array);
			}
			if ((runtimeMethodInfo = method as RuntimeMethodInfo) != null)
			{
				int tr = (getGenericTypeDefinition ? GetTypeToken(method.DeclaringType).Token : GetTypeTokenInternal(method.DeclaringType).Token);
				num = GetMemberRefOfMethodInfo(tr, runtimeMethodInfo);
			}
			else
			{
				ParameterInfo[] parameters2 = method.GetParameters();
				Type[] array2 = new Type[parameters2.Length];
				Type[][] array3 = new Type[array2.Length][];
				Type[][] array4 = new Type[array2.Length][];
				for (int j = 0; j < parameters2.Length; j++)
				{
					array2[j] = parameters2[j].ParameterType;
					array3[j] = parameters2[j].GetRequiredCustomModifiers();
					array4[j] = parameters2[j].GetOptionalCustomModifiers();
				}
				int tr = (getGenericTypeDefinition ? GetTypeToken(method.DeclaringType).Token : GetTypeTokenInternal(method.DeclaringType).Token);
				SignatureHelper methodSigHelper;
				try
				{
					methodSigHelper = SignatureHelper.GetMethodSigHelper(this, method.CallingConvention, method.ReturnType, method.ReturnParameter.GetRequiredCustomModifiers(), method.ReturnParameter.GetOptionalCustomModifiers(), array2, array3, array4);
				}
				catch (NotImplementedException)
				{
					methodSigHelper = SignatureHelper.GetMethodSigHelper(this, method.ReturnType, array2);
				}
				int length;
				byte[] signature = methodSigHelper.InternalGetSignature(out length);
				num = GetMemberRefFromSignature(tr, method.Name, signature, length);
			}
		}
		return new MethodToken(num);
	}

	[SecuritySafeCritical]
	public MethodToken GetConstructorToken(ConstructorInfo constructor, IEnumerable<Type> optionalParameterTypes)
	{
		if (constructor == null)
		{
			throw new ArgumentNullException("constructor");
		}
		lock (SyncRoot)
		{
			return new MethodToken(GetMethodTokenInternal(constructor, optionalParameterTypes, useMethodDef: false));
		}
	}

	[SecuritySafeCritical]
	public MethodToken GetMethodToken(MethodInfo method, IEnumerable<Type> optionalParameterTypes)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		lock (SyncRoot)
		{
			return new MethodToken(GetMethodTokenInternal(method, optionalParameterTypes, useMethodDef: true));
		}
	}

	[SecurityCritical]
	internal int GetMethodTokenInternal(MethodBase method, IEnumerable<Type> optionalParameterTypes, bool useMethodDef)
	{
		int num = 0;
		MethodInfo methodInfo = method as MethodInfo;
		if (method.IsGenericMethod)
		{
			MethodInfo methodInfo2 = methodInfo;
			bool isGenericMethodDefinition = methodInfo.IsGenericMethodDefinition;
			if (!isGenericMethodDefinition)
			{
				methodInfo2 = methodInfo.GetGenericMethodDefinition();
			}
			num = ((Equals(methodInfo2.Module) && (!(methodInfo2.DeclaringType != null) || !methodInfo2.DeclaringType.IsGenericType)) ? GetMethodTokenInternal(methodInfo2).Token : GetMemberRefToken(methodInfo2, null));
			if (isGenericMethodDefinition && useMethodDef)
			{
				return num;
			}
			int length;
			byte[] signature = SignatureHelper.GetMethodSpecSigHelper(this, methodInfo.GetGenericArguments()).InternalGetSignature(out length);
			return TypeBuilder.DefineMethodSpec(GetNativeHandle(), num, signature, length);
		}
		if ((method.CallingConvention & CallingConventions.VarArgs) == 0 && (method.DeclaringType == null || !method.DeclaringType.IsGenericType))
		{
			if (methodInfo != null)
			{
				return GetMethodTokenInternal(methodInfo).Token;
			}
			return GetConstructorToken(method as ConstructorInfo).Token;
		}
		return GetMemberRefToken(method, optionalParameterTypes);
	}

	[SecuritySafeCritical]
	public MethodToken GetArrayMethodToken(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		lock (SyncRoot)
		{
			return GetArrayMethodTokenNoLock(arrayClass, methodName, callingConvention, returnType, parameterTypes);
		}
	}

	[SecurityCritical]
	private MethodToken GetArrayMethodTokenNoLock(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		if (arrayClass == null)
		{
			throw new ArgumentNullException("arrayClass");
		}
		if (methodName == null)
		{
			throw new ArgumentNullException("methodName");
		}
		if (methodName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "methodName");
		}
		if (!arrayClass.IsArray)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_HasToBeArrayClass"));
		}
		CheckContext(returnType, arrayClass);
		CheckContext(parameterTypes);
		SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(this, callingConvention, returnType, null, null, parameterTypes, null, null);
		int length;
		byte[] signature = methodSigHelper.InternalGetSignature(out length);
		TypeToken typeTokenInternal = GetTypeTokenInternal(arrayClass);
		return new MethodToken(GetArrayMethodToken(GetNativeHandle(), typeTokenInternal.Token, methodName, signature, length));
	}

	[SecuritySafeCritical]
	public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		CheckContext(returnType, arrayClass);
		CheckContext(parameterTypes);
		MethodToken arrayMethodToken = GetArrayMethodToken(arrayClass, methodName, callingConvention, returnType, parameterTypes);
		return new SymbolMethod(this, arrayMethodToken, arrayClass, methodName, callingConvention, returnType, parameterTypes);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public MethodToken GetConstructorToken(ConstructorInfo con)
	{
		return InternalGetConstructorToken(con, usingRef: false);
	}

	[SecuritySafeCritical]
	public FieldToken GetFieldToken(FieldInfo field)
	{
		lock (SyncRoot)
		{
			return GetFieldTokenNoLock(field);
		}
	}

	[SecurityCritical]
	private FieldToken GetFieldTokenNoLock(FieldInfo field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("con");
		}
		int num = 0;
		FieldBuilder fieldBuilder = null;
		RuntimeFieldInfo runtimeFieldInfo = null;
		FieldOnTypeBuilderInstantiation fieldOnTypeBuilderInstantiation = null;
		if ((fieldBuilder = field as FieldBuilder) != null)
		{
			if (field.DeclaringType != null && field.DeclaringType.IsGenericType)
			{
				int length;
				byte[] signature = SignatureHelper.GetTypeSigToken(this, field.DeclaringType).InternalGetSignature(out length);
				int tokenFromTypeSpec = GetTokenFromTypeSpec(signature, length);
				num = GetMemberRef(this, tokenFromTypeSpec, fieldBuilder.GetToken().Token);
			}
			else
			{
				if (fieldBuilder.Module.Equals(this))
				{
					return fieldBuilder.GetToken();
				}
				if (field.DeclaringType == null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotImportGlobalFromDifferentModule"));
				}
				int tokenFromTypeSpec = GetTypeTokenInternal(field.DeclaringType).Token;
				num = GetMemberRef(field.ReflectedType.Module, tokenFromTypeSpec, fieldBuilder.GetToken().Token);
			}
		}
		else if ((runtimeFieldInfo = field as RuntimeFieldInfo) != null)
		{
			if (field.DeclaringType == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotImportGlobalFromDifferentModule"));
			}
			if (field.DeclaringType != null && field.DeclaringType.IsGenericType)
			{
				int length2;
				byte[] signature2 = SignatureHelper.GetTypeSigToken(this, field.DeclaringType).InternalGetSignature(out length2);
				int tokenFromTypeSpec = GetTokenFromTypeSpec(signature2, length2);
				num = GetMemberRefOfFieldInfo(tokenFromTypeSpec, field.DeclaringType.GetTypeHandleInternal(), runtimeFieldInfo);
			}
			else
			{
				int tokenFromTypeSpec = GetTypeTokenInternal(field.DeclaringType).Token;
				num = GetMemberRefOfFieldInfo(tokenFromTypeSpec, field.DeclaringType.GetTypeHandleInternal(), runtimeFieldInfo);
			}
		}
		else if ((fieldOnTypeBuilderInstantiation = field as FieldOnTypeBuilderInstantiation) != null)
		{
			FieldInfo fieldInfo = fieldOnTypeBuilderInstantiation.FieldInfo;
			int length3;
			byte[] signature3 = SignatureHelper.GetTypeSigToken(this, field.DeclaringType).InternalGetSignature(out length3);
			int tokenFromTypeSpec = GetTokenFromTypeSpec(signature3, length3);
			num = GetMemberRef(fieldInfo.ReflectedType.Module, tokenFromTypeSpec, fieldOnTypeBuilderInstantiation.MetadataTokenInternal);
		}
		else
		{
			int tokenFromTypeSpec = GetTypeTokenInternal(field.ReflectedType).Token;
			SignatureHelper fieldSigHelper = SignatureHelper.GetFieldSigHelper(this);
			fieldSigHelper.AddArgument(field.FieldType, field.GetRequiredCustomModifiers(), field.GetOptionalCustomModifiers());
			int length4;
			byte[] signature4 = fieldSigHelper.InternalGetSignature(out length4);
			num = GetMemberRefFromSignature(tokenFromTypeSpec, field.Name, signature4, length4);
		}
		return new FieldToken(num, field.GetType());
	}

	[SecuritySafeCritical]
	public StringToken GetStringConstant(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return new StringToken(GetStringConstant(GetNativeHandle(), str, str.Length));
	}

	[SecuritySafeCritical]
	public SignatureToken GetSignatureToken(SignatureHelper sigHelper)
	{
		if (sigHelper == null)
		{
			throw new ArgumentNullException("sigHelper");
		}
		int length;
		byte[] signature = sigHelper.InternalGetSignature(out length);
		return new SignatureToken(TypeBuilder.GetTokenFromSig(GetNativeHandle(), signature, length), this);
	}

	[SecuritySafeCritical]
	public SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength)
	{
		if (sigBytes == null)
		{
			throw new ArgumentNullException("sigBytes");
		}
		byte[] array = new byte[sigBytes.Length];
		Array.Copy(sigBytes, array, sigBytes.Length);
		return new SignatureToken(TypeBuilder.GetTokenFromSig(GetNativeHandle(), array, sigLength), this);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		if (con == null)
		{
			throw new ArgumentNullException("con");
		}
		if (binaryAttribute == null)
		{
			throw new ArgumentNullException("binaryAttribute");
		}
		TypeBuilder.DefineCustomAttribute(this, 1, GetConstructorToken(con).Token, binaryAttribute, toDisk: false, updateCompilerFlags: false);
	}

	[SecuritySafeCritical]
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		if (customBuilder == null)
		{
			throw new ArgumentNullException("customBuilder");
		}
		customBuilder.CreateCustomAttribute(this, 1);
	}

	public ISymbolWriter GetSymWriter()
	{
		return m_iSymWriter;
	}

	public ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		lock (SyncRoot)
		{
			return DefineDocumentNoLock(url, language, languageVendor, documentType);
		}
	}

	private ISymbolDocumentWriter DefineDocumentNoLock(string url, Guid language, Guid languageVendor, Guid documentType)
	{
		if (m_iSymWriter == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
		return m_iSymWriter.DefineDocument(url, language, languageVendor, documentType);
	}

	[SecuritySafeCritical]
	public void SetUserEntryPoint(MethodInfo entryPoint)
	{
		lock (SyncRoot)
		{
			SetUserEntryPointNoLock(entryPoint);
		}
	}

	[SecurityCritical]
	private void SetUserEntryPointNoLock(MethodInfo entryPoint)
	{
		if (entryPoint == null)
		{
			throw new ArgumentNullException("entryPoint");
		}
		if (m_iSymWriter == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
		if (entryPoint.DeclaringType != null)
		{
			if (!entryPoint.Module.Equals(this))
			{
				throw new InvalidOperationException(Environment.GetResourceString("Argument_NotInTheSameModuleBuilder"));
			}
		}
		else
		{
			MethodBuilder methodBuilder = entryPoint as MethodBuilder;
			if (methodBuilder != null && methodBuilder.GetModuleBuilder() != this)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Argument_NotInTheSameModuleBuilder"));
			}
		}
		SymbolToken userEntryPoint = new SymbolToken(GetMethodTokenInternal(entryPoint).Token);
		m_iSymWriter.SetUserEntryPoint(userEntryPoint);
	}

	public void SetSymCustomAttribute(string name, byte[] data)
	{
		lock (SyncRoot)
		{
			SetSymCustomAttributeNoLock(name, data);
		}
	}

	private void SetSymCustomAttributeNoLock(string name, byte[] data)
	{
		if (m_iSymWriter == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
	}

	public bool IsTransient()
	{
		return InternalModule.IsTransientInternal();
	}

	void _ModuleBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _ModuleBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _ModuleBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _ModuleBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
