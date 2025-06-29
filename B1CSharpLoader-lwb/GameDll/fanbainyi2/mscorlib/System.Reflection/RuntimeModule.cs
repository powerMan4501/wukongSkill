using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
internal class RuntimeModule : Module
{
	private RuntimeType m_runtimeType;

	private RuntimeAssembly m_runtimeAssembly;

	private IntPtr m_pRefClass;

	private IntPtr m_pData;

	private IntPtr m_pGlobals;

	private IntPtr m_pFields;

	public override int MDStreamVersion
	{
		[SecuritySafeCritical]
		get
		{
			return ModuleHandle.GetMDStreamVersion(GetNativeHandle());
		}
	}

	internal RuntimeType RuntimeType
	{
		get
		{
			if (m_runtimeType == null)
			{
				m_runtimeType = ModuleHandle.GetModuleType(GetNativeHandle());
			}
			return m_runtimeType;
		}
	}

	internal MetadataImport MetadataImport
	{
		[SecurityCritical]
		get
		{
			return ModuleHandle.GetMetadataImport(GetNativeHandle());
		}
	}

	public override string FullyQualifiedName
	{
		[SecuritySafeCritical]
		get
		{
			string fullyQualifiedName = GetFullyQualifiedName();
			if (fullyQualifiedName != null)
			{
				bool flag = true;
				try
				{
					Path.GetFullPathInternal(fullyQualifiedName);
				}
				catch (ArgumentException)
				{
					flag = false;
				}
				if (flag)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, fullyQualifiedName).Demand();
				}
			}
			return fullyQualifiedName;
		}
	}

	public override Guid ModuleVersionId
	{
		[SecuritySafeCritical]
		get
		{
			MetadataImport.GetScopeProps(out var mvid);
			return mvid;
		}
	}

	public override int MetadataToken
	{
		[SecuritySafeCritical]
		get
		{
			return ModuleHandle.GetToken(GetNativeHandle());
		}
	}

	public override string ScopeName
	{
		[SecuritySafeCritical]
		get
		{
			string s = null;
			GetScopeName(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
			return s;
		}
	}

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			string fullyQualifiedName = GetFullyQualifiedName();
			int num = fullyQualifiedName.LastIndexOf('\\');
			if (num == -1)
			{
				return fullyQualifiedName;
			}
			return new string(fullyQualifiedName.ToCharArray(), num + 1, fullyQualifiedName.Length - num - 1);
		}
	}

	public override Assembly Assembly => GetRuntimeAssembly();

	internal RuntimeModule()
	{
		throw new NotSupportedException();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetType(RuntimeModule module, string className, bool ignoreCase, bool throwOnError, ObjectHandleOnStack type);

	[DllImport("QCall")]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool nIsTransientInternal(RuntimeModule module);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetScopeName(RuntimeModule module, StringHandleOnStack retString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetFullyQualifiedName(RuntimeModule module, StringHandleOnStack retString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern RuntimeType[] GetTypes(RuntimeModule module);

	[SecuritySafeCritical]
	internal RuntimeType[] GetDefinedTypes()
	{
		return GetTypes(GetNativeHandle());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern bool IsResource(RuntimeModule module);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetSignerCertificate(RuntimeModule module, ObjectHandleOnStack retData);

	private static RuntimeTypeHandle[] ConvertToTypeHandleArray(Type[] genericArguments)
	{
		if (genericArguments == null)
		{
			return null;
		}
		int num = genericArguments.Length;
		RuntimeTypeHandle[] array = new RuntimeTypeHandle[num];
		for (int i = 0; i < num; i++)
		{
			Type type = genericArguments[i];
			if (type == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidGenericInstArray"));
			}
			type = type.UnderlyingSystemType;
			if (type == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidGenericInstArray"));
			}
			if (!(type is RuntimeType))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidGenericInstArray"));
			}
			array[i] = type.GetTypeHandleInternal();
		}
		return array;
	}

	[SecuritySafeCritical]
	public override byte[] ResolveSignature(int metadataToken)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (!MetadataImport.IsValidToken(metadataToken2))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this));
		}
		if (!metadataToken2.IsMemberRef && !metadataToken2.IsMethodDef && !metadataToken2.IsTypeSpec && !metadataToken2.IsSignature && !metadataToken2.IsFieldDef)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this), "metadataToken");
		}
		ConstArray constArray = ((!metadataToken2.IsMemberRef) ? MetadataImport.GetSignatureFromToken(metadataToken) : MetadataImport.GetMemberRefProps(metadataToken));
		byte[] array = new byte[constArray.Length];
		for (int i = 0; i < constArray.Length; i++)
		{
			array[i] = constArray[i];
		}
		return array;
	}

	[SecuritySafeCritical]
	public unsafe override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (!MetadataImport.IsValidToken(metadataToken2))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this));
		}
		RuntimeTypeHandle[] typeInstantiationContext = ConvertToTypeHandleArray(genericTypeArguments);
		RuntimeTypeHandle[] methodInstantiationContext = ConvertToTypeHandleArray(genericMethodArguments);
		try
		{
			if (!metadataToken2.IsMethodDef && !metadataToken2.IsMethodSpec)
			{
				if (!metadataToken2.IsMemberRef)
				{
					throw new ArgumentException("metadataToken", Environment.GetResourceString("Argument_ResolveMethod", metadataToken2, this));
				}
				if (*(byte*)MetadataImport.GetMemberRefProps(metadataToken2).Signature.ToPointer() == 6)
				{
					throw new ArgumentException("metadataToken", Environment.GetResourceString("Argument_ResolveMethod", metadataToken2, this));
				}
			}
			IRuntimeMethodInfo runtimeMethodInfo = ModuleHandle.ResolveMethodHandleInternal(GetNativeHandle(), metadataToken2, typeInstantiationContext, methodInstantiationContext);
			Type type = RuntimeMethodHandle.GetDeclaringType(runtimeMethodInfo);
			if (type.IsGenericType || type.IsArray)
			{
				MetadataToken metadataToken3 = new MetadataToken(MetadataImport.GetParentToken(metadataToken2));
				if (metadataToken2.IsMethodSpec)
				{
					metadataToken3 = new MetadataToken(MetadataImport.GetParentToken(metadataToken3));
				}
				type = ResolveType(metadataToken3, genericTypeArguments, genericMethodArguments);
			}
			return RuntimeType.GetMethodBase(type as RuntimeType, runtimeMethodInfo);
		}
		catch (BadImageFormatException innerException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadImageFormatExceptionResolve"), innerException);
		}
	}

	[SecurityCritical]
	private FieldInfo ResolveLiteralField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (!MetadataImport.IsValidToken(metadataToken2) || !metadataToken2.IsFieldDef)
		{
			throw new ArgumentOutOfRangeException("metadataToken", string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this)));
		}
		string name = MetadataImport.GetName(metadataToken2).ToString();
		int parentToken = MetadataImport.GetParentToken(metadataToken2);
		Type type = ResolveType(parentToken, genericTypeArguments, genericMethodArguments);
		type.GetFields();
		try
		{
			return type.GetField(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
		catch
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ResolveField", metadataToken2, this), "metadataToken");
		}
	}

	[SecuritySafeCritical]
	public unsafe override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (!MetadataImport.IsValidToken(metadataToken2))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this));
		}
		RuntimeTypeHandle[] typeInstantiationContext = ConvertToTypeHandleArray(genericTypeArguments);
		RuntimeTypeHandle[] methodInstantiationContext = ConvertToTypeHandleArray(genericMethodArguments);
		try
		{
			IRuntimeFieldInfo runtimeFieldInfo = null;
			if (!metadataToken2.IsFieldDef)
			{
				if (!metadataToken2.IsMemberRef)
				{
					throw new ArgumentException("metadataToken", Environment.GetResourceString("Argument_ResolveField", metadataToken2, this));
				}
				if (*(byte*)MetadataImport.GetMemberRefProps(metadataToken2).Signature.ToPointer() != 6)
				{
					throw new ArgumentException("metadataToken", Environment.GetResourceString("Argument_ResolveField", metadataToken2, this));
				}
				runtimeFieldInfo = ModuleHandle.ResolveFieldHandleInternal(GetNativeHandle(), metadataToken2, typeInstantiationContext, methodInstantiationContext);
			}
			runtimeFieldInfo = ModuleHandle.ResolveFieldHandleInternal(GetNativeHandle(), metadataToken, typeInstantiationContext, methodInstantiationContext);
			RuntimeType runtimeType = RuntimeFieldHandle.GetApproxDeclaringType(runtimeFieldInfo.Value);
			if (runtimeType.IsGenericType || runtimeType.IsArray)
			{
				int parentToken = ModuleHandle.GetMetadataImport(GetNativeHandle()).GetParentToken(metadataToken);
				runtimeType = (RuntimeType)ResolveType(parentToken, genericTypeArguments, genericMethodArguments);
			}
			return RuntimeType.GetFieldInfo(runtimeType, runtimeFieldInfo);
		}
		catch (MissingFieldException)
		{
			return ResolveLiteralField(metadataToken2, genericTypeArguments, genericMethodArguments);
		}
		catch (BadImageFormatException innerException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadImageFormatExceptionResolve"), innerException);
		}
	}

	[SecuritySafeCritical]
	public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (metadataToken2.IsGlobalTypeDefToken)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ResolveModuleType", metadataToken2), "metadataToken");
		}
		if (!MetadataImport.IsValidToken(metadataToken2))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this));
		}
		if (!metadataToken2.IsTypeDef && !metadataToken2.IsTypeSpec && !metadataToken2.IsTypeRef)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ResolveType", metadataToken2, this), "metadataToken");
		}
		RuntimeTypeHandle[] typeInstantiationContext = ConvertToTypeHandleArray(genericTypeArguments);
		RuntimeTypeHandle[] methodInstantiationContext = ConvertToTypeHandleArray(genericMethodArguments);
		try
		{
			Type runtimeType = GetModuleHandle().ResolveTypeHandle(metadataToken, typeInstantiationContext, methodInstantiationContext).GetRuntimeType();
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ResolveType", metadataToken2, this), "metadataToken");
			}
			return runtimeType;
		}
		catch (BadImageFormatException innerException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadImageFormatExceptionResolve"), innerException);
		}
	}

	[SecuritySafeCritical]
	public unsafe override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (metadataToken2.IsProperty)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_PropertyInfoNotAvailable"));
		}
		if (metadataToken2.IsEvent)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_EventInfoNotAvailable"));
		}
		if (metadataToken2.IsMethodSpec || metadataToken2.IsMethodDef)
		{
			return ResolveMethod(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		if (metadataToken2.IsFieldDef)
		{
			return ResolveField(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		if (metadataToken2.IsTypeRef || metadataToken2.IsTypeDef || metadataToken2.IsTypeSpec)
		{
			return ResolveType(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		if (metadataToken2.IsMemberRef)
		{
			if (!MetadataImport.IsValidToken(metadataToken2))
			{
				throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this));
			}
			if (*(byte*)MetadataImport.GetMemberRefProps(metadataToken2).Signature.ToPointer() == 6)
			{
				return ResolveField(metadataToken2, genericTypeArguments, genericMethodArguments);
			}
			return ResolveMethod(metadataToken2, genericTypeArguments, genericMethodArguments);
		}
		throw new ArgumentException("metadataToken", Environment.GetResourceString("Argument_ResolveMember", metadataToken2, this));
	}

	[SecuritySafeCritical]
	public override string ResolveString(int metadataToken)
	{
		MetadataToken metadataToken2 = new MetadataToken(metadataToken);
		if (!metadataToken2.IsString)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Argument_ResolveString"), metadataToken, ToString()));
		}
		if (!MetadataImport.IsValidToken(metadataToken2))
		{
			throw new ArgumentOutOfRangeException("metadataToken", string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Argument_InvalidToken", metadataToken2, this)));
		}
		string userString = MetadataImport.GetUserString(metadataToken);
		if (userString == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Argument_ResolveString"), metadataToken, ToString()));
		}
		return userString;
	}

	public override void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
	{
		ModuleHandle.GetPEKind(GetNativeHandle(), out peKind, out machine);
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return GetMethodInternal(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	internal MethodInfo GetMethodInternal(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (RuntimeType == null)
		{
			return null;
		}
		if (types == null)
		{
			return RuntimeType.GetMethod(name, bindingAttr);
		}
		return RuntimeType.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	[SecuritySafeCritical]
	internal bool IsTransientInternal()
	{
		return nIsTransientInternal(GetNativeHandle());
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(this, runtimeType);
	}

	[SecuritySafeCritical]
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.IsDefined(this, runtimeType);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return CustomAttributeData.GetCustomAttributesInternal(this);
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		UnitySerializationHolder.GetUnitySerializationInfo(info, 5, ScopeName, GetRuntimeAssembly());
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public override Type GetType(string className, bool throwOnError, bool ignoreCase)
	{
		if (className == null)
		{
			throw new ArgumentNullException("className");
		}
		RuntimeType o = null;
		GetType(GetNativeHandle(), className, throwOnError, ignoreCase, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[SecurityCritical]
	internal string GetFullyQualifiedName()
	{
		string s = null;
		GetFullyQualifiedName(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[SecuritySafeCritical]
	public override Type[] GetTypes()
	{
		return GetTypes(GetNativeHandle());
	}

	public override bool IsResource()
	{
		return IsResource(GetNativeHandle());
	}

	public override FieldInfo[] GetFields(BindingFlags bindingFlags)
	{
		if (RuntimeType == null)
		{
			return new FieldInfo[0];
		}
		return RuntimeType.GetFields(bindingFlags);
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (RuntimeType == null)
		{
			return null;
		}
		return RuntimeType.GetField(name, bindingAttr);
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
	{
		if (RuntimeType == null)
		{
			return new MethodInfo[0];
		}
		return RuntimeType.GetMethods(bindingFlags);
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return m_runtimeAssembly;
	}

	internal override ModuleHandle GetModuleHandle()
	{
		return new ModuleHandle(this);
	}

	internal RuntimeModule GetNativeHandle()
	{
		return this;
	}

	[SecuritySafeCritical]
	public override X509Certificate GetSignerCertificate()
	{
		byte[] o = null;
		GetSignerCertificate(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		if (o == null)
		{
			return null;
		}
		return new X509Certificate(o);
	}
}
