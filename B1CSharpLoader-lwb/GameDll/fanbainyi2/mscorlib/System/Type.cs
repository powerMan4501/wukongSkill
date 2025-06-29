using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Type))]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class Type : MemberInfo, _Type, IReflect
{
	public static readonly MemberFilter FilterAttribute = __Filters.Instance.FilterAttribute;

	public static readonly MemberFilter FilterName = __Filters.Instance.FilterName;

	public static readonly MemberFilter FilterNameIgnoreCase = __Filters.Instance.FilterIgnoreCase;

	[__DynamicallyInvokable]
	public static readonly object Missing = System.Reflection.Missing.Value;

	public static readonly char Delimiter = '.';

	[__DynamicallyInvokable]
	public static readonly Type[] EmptyTypes = EmptyArray<Type>.Value;

	private static Binder defaultBinder;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	internal const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	public override MemberTypes MemberType => MemberTypes.TypeInfo;

	[__DynamicallyInvokable]
	public override Type DeclaringType
	{
		[__DynamicallyInvokable]
		get
		{
			return null;
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodBase DeclaringMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return null;
		}
	}

	[__DynamicallyInvokable]
	public override Type ReflectedType
	{
		[__DynamicallyInvokable]
		get
		{
			return null;
		}
	}

	public virtual StructLayoutAttribute StructLayoutAttribute
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public abstract Guid GUID { get; }

	public static Binder DefaultBinder
	{
		get
		{
			if (defaultBinder == null)
			{
				CreateBinder();
			}
			return defaultBinder;
		}
	}

	public new abstract Module Module { get; }

	[__DynamicallyInvokable]
	public abstract Assembly Assembly
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException();
		}
	}

	[__DynamicallyInvokable]
	public abstract string FullName
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract string Namespace
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract string AssemblyQualifiedName
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract Type BaseType
	{
		[__DynamicallyInvokable]
		get;
	}

	[ComVisible(true)]
	public ConstructorInfo TypeInitializer => GetConstructorImpl(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, EmptyTypes, null);

	[__DynamicallyInvokable]
	public bool IsNested
	{
		[__DynamicallyInvokable]
		get
		{
			return DeclaringType != null;
		}
	}

	[__DynamicallyInvokable]
	public TypeAttributes Attributes
	{
		[__DynamicallyInvokable]
		get
		{
			return GetAttributeFlagsImpl();
		}
	}

	[__DynamicallyInvokable]
	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException();
		}
	}

	[__DynamicallyInvokable]
	public bool IsVisible
	{
		[__DynamicallyInvokable]
		get
		{
			RuntimeType runtimeType = this as RuntimeType;
			if (runtimeType != null)
			{
				return RuntimeTypeHandle.IsVisible(runtimeType);
			}
			if (IsGenericParameter)
			{
				return true;
			}
			if (HasElementType)
			{
				return GetElementType().IsVisible;
			}
			Type type = this;
			while (type.IsNested)
			{
				if (!type.IsNestedPublic)
				{
					return false;
				}
				type = type.DeclaringType;
			}
			if (!type.IsPublic)
			{
				return false;
			}
			if (IsGenericType && !IsGenericTypeDefinition)
			{
				Type[] genericArguments = GetGenericArguments();
				foreach (Type type2 in genericArguments)
				{
					if (!type2.IsVisible)
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNotPublic
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsPublic
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.Public;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedPublic
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedPrivate
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPrivate;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedFamily
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamily;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedAssembly;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedFamANDAssem
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamANDAssem;
		}
	}

	[__DynamicallyInvokable]
	public bool IsNestedFamORAssem
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.VisibilityMask;
		}
	}

	public bool IsAutoLayout => (GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == 0;

	public bool IsLayoutSequential => (GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.SequentialLayout;

	public bool IsExplicitLayout => (GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.ExplicitLayout;

	[__DynamicallyInvokable]
	public bool IsClass
	{
		[__DynamicallyInvokable]
		get
		{
			if ((GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == 0)
			{
				return !IsValueType;
			}
			return false;
		}
	}

	[__DynamicallyInvokable]
	public bool IsInterface
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			RuntimeType runtimeType = this as RuntimeType;
			if (runtimeType != null)
			{
				return RuntimeTypeHandle.IsInterface(runtimeType);
			}
			return (GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
		}
	}

	[__DynamicallyInvokable]
	public bool IsValueType
	{
		[__DynamicallyInvokable]
		get
		{
			return IsValueTypeImpl();
		}
	}

	[__DynamicallyInvokable]
	public bool IsAbstract
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.Abstract) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsSealed
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.Sealed) != 0;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsEnum
	{
		[__DynamicallyInvokable]
		get
		{
			return IsSubclassOf(RuntimeType.EnumType);
		}
	}

	[__DynamicallyInvokable]
	public bool IsSpecialName
	{
		[__DynamicallyInvokable]
		get
		{
			return (GetAttributeFlagsImpl() & TypeAttributes.SpecialName) != 0;
		}
	}

	public bool IsImport => (GetAttributeFlagsImpl() & TypeAttributes.Import) != 0;

	public virtual bool IsSerializable
	{
		[__DynamicallyInvokable]
		get
		{
			if ((GetAttributeFlagsImpl() & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				return true;
			}
			RuntimeType runtimeType = UnderlyingSystemType as RuntimeType;
			if (runtimeType != null)
			{
				return runtimeType.IsSpecialSerializableType();
			}
			return false;
		}
	}

	public bool IsAnsiClass => (GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == 0;

	public bool IsUnicodeClass => (GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.UnicodeClass;

	public bool IsAutoClass => (GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.AutoClass;

	[__DynamicallyInvokable]
	public bool IsArray
	{
		[__DynamicallyInvokable]
		get
		{
			return IsArrayImpl();
		}
	}

	internal virtual bool IsSzArray => false;

	[__DynamicallyInvokable]
	public virtual bool IsGenericType
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsGenericTypeDefinition
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsConstructedGenericType
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsGenericParameter
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public virtual int GenericParameterPosition
	{
		[__DynamicallyInvokable]
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
		}
	}

	[__DynamicallyInvokable]
	public virtual bool ContainsGenericParameters
	{
		[__DynamicallyInvokable]
		get
		{
			if (HasElementType)
			{
				return GetRootElementType().ContainsGenericParameters;
			}
			if (IsGenericParameter)
			{
				return true;
			}
			if (!IsGenericType)
			{
				return false;
			}
			Type[] genericArguments = GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (genericArguments[i].ContainsGenericParameters)
				{
					return true;
				}
			}
			return false;
		}
	}

	[__DynamicallyInvokable]
	public bool IsByRef
	{
		[__DynamicallyInvokable]
		get
		{
			return IsByRefImpl();
		}
	}

	[__DynamicallyInvokable]
	public bool IsPointer
	{
		[__DynamicallyInvokable]
		get
		{
			return IsPointerImpl();
		}
	}

	[__DynamicallyInvokable]
	public bool IsPrimitive
	{
		[__DynamicallyInvokable]
		get
		{
			return IsPrimitiveImpl();
		}
	}

	public bool IsCOMObject => IsCOMObjectImpl();

	internal bool IsWindowsRuntimeObject => IsWindowsRuntimeObjectImpl();

	internal bool IsExportedToWindowsRuntime => IsExportedToWindowsRuntimeImpl();

	[__DynamicallyInvokable]
	public bool HasElementType
	{
		[__DynamicallyInvokable]
		get
		{
			return HasElementTypeImpl();
		}
	}

	public bool IsContextful => IsContextfulImpl();

	public bool IsMarshalByRef => IsMarshalByRefImpl();

	internal bool HasProxyAttribute => HasProxyAttributeImpl();

	[__DynamicallyInvokable]
	public virtual Type[] GenericTypeArguments
	{
		[__DynamicallyInvokable]
		get
		{
			if (IsGenericType && !IsGenericTypeDefinition)
			{
				return GetGenericArguments();
			}
			return EmptyTypes;
		}
	}

	public virtual bool IsSecurityCritical
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool IsSecuritySafeCritical
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool IsSecurityTransparent
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	internal bool NeedsReflectionSecurityCheck
	{
		get
		{
			if (!IsVisible)
			{
				return true;
			}
			if (IsSecurityCritical && !IsSecuritySafeCritical)
			{
				return true;
			}
			if (IsGenericType)
			{
				Type[] genericArguments = GetGenericArguments();
				foreach (Type type in genericArguments)
				{
					if (type.NeedsReflectionSecurityCheck)
					{
						return true;
					}
				}
			}
			else if (IsArray || IsPointer)
			{
				return GetElementType().NeedsReflectionSecurityCheck;
			}
			return false;
		}
	}

	[__DynamicallyInvokable]
	public abstract Type UnderlyingSystemType
	{
		[__DynamicallyInvokable]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeType.GetType(typeName, throwOnError, ignoreCase, reflectionOnly: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public static Type GetType(string typeName, bool throwOnError)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeType.GetType(typeName, throwOnError, ignoreCase: false, reflectionOnly: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public static Type GetType(string typeName)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeType.GetType(typeName, throwOnError: false, ignoreCase: false, reflectionOnly: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError: false, ignoreCase: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeType.GetType(typeName, throwIfNotFound, ignoreCase, reflectionOnly: true, ref stackMark);
	}

	[__DynamicallyInvokable]
	public virtual Type MakePointerType()
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	public virtual Type MakeByRefType()
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	public virtual Type MakeArrayType()
	{
		throw new NotSupportedException();
	}

	[__DynamicallyInvokable]
	public virtual Type MakeArrayType(int rank)
	{
		throw new NotSupportedException();
	}

	[SecurityCritical]
	public static Type GetTypeFromProgID(string progID)
	{
		return RuntimeType.GetTypeFromProgIDImpl(progID, null, throwOnError: false);
	}

	[SecurityCritical]
	public static Type GetTypeFromProgID(string progID, bool throwOnError)
	{
		return RuntimeType.GetTypeFromProgIDImpl(progID, null, throwOnError);
	}

	[SecurityCritical]
	public static Type GetTypeFromProgID(string progID, string server)
	{
		return RuntimeType.GetTypeFromProgIDImpl(progID, server, throwOnError: false);
	}

	[SecurityCritical]
	public static Type GetTypeFromProgID(string progID, string server, bool throwOnError)
	{
		return RuntimeType.GetTypeFromProgIDImpl(progID, server, throwOnError);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Type GetTypeFromCLSID(Guid clsid)
	{
		return RuntimeType.GetTypeFromCLSIDImpl(clsid, null, throwOnError: false);
	}

	[SecuritySafeCritical]
	public static Type GetTypeFromCLSID(Guid clsid, bool throwOnError)
	{
		return RuntimeType.GetTypeFromCLSIDImpl(clsid, null, throwOnError);
	}

	[SecuritySafeCritical]
	public static Type GetTypeFromCLSID(Guid clsid, string server)
	{
		return RuntimeType.GetTypeFromCLSIDImpl(clsid, server, throwOnError: false);
	}

	[SecuritySafeCritical]
	public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError)
	{
		return RuntimeType.GetTypeFromCLSIDImpl(clsid, server, throwOnError);
	}

	[__DynamicallyInvokable]
	public static TypeCode GetTypeCode(Type type)
	{
		if (type == null)
		{
			return TypeCode.Empty;
		}
		return type.GetTypeCodeImpl();
	}

	protected virtual TypeCode GetTypeCodeImpl()
	{
		if (this != UnderlyingSystemType && UnderlyingSystemType != null)
		{
			return GetTypeCode(UnderlyingSystemType);
		}
		return TypeCode.Object;
	}

	private static void CreateBinder()
	{
		if (defaultBinder == null)
		{
			DefaultBinder value = new DefaultBinder();
			Interlocked.CompareExchange(ref defaultBinder, value, null);
		}
	}

	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	[DebuggerStepThrough]
	[DebuggerHidden]
	public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture)
	{
		return InvokeMember(name, invokeAttr, binder, target, args, null, culture, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args)
	{
		return InvokeMember(name, invokeAttr, binder, target, args, null, null, null);
	}

	internal virtual RuntimeTypeHandle GetTypeHandleInternal()
	{
		return TypeHandle;
	}

	[__DynamicallyInvokable]
	public static RuntimeTypeHandle GetTypeHandle(object o)
	{
		if (o == null)
		{
			throw new ArgumentNullException(null, Environment.GetResourceString("Arg_InvalidHandle"));
		}
		return new RuntimeTypeHandle((RuntimeType)o.GetType());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeType GetTypeFromHandleUnsafe(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern Type GetTypeFromHandle(RuntimeTypeHandle handle);

	[__DynamicallyInvokable]
	public virtual int GetArrayRank()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetConstructorImpl(bindingAttr, binder, callConvention, types, modifiers);
	}

	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetConstructorImpl(bindingAttr, binder, CallingConventions.Any, types, modifiers);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public ConstructorInfo GetConstructor(Type[] types)
	{
		return GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, types, null);
	}

	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public ConstructorInfo[] GetConstructors()
	{
		return GetConstructors(BindingFlags.Instance | BindingFlags.Public);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, bindingAttr, binder, CallingConventions.Any, types, modifiers);
	}

	public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, types, modifiers);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetMethod(string name, Type[] types)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, types, null);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return GetMethodImpl(name, bindingAttr, null, CallingConventions.Any, null, null);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetMethod(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, null, null);
	}

	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[__DynamicallyInvokable]
	public MethodInfo[] GetMethods()
	{
		return GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public FieldInfo GetField(string name)
	{
		return GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public FieldInfo[] GetFields()
	{
		return GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	public Type GetInterface(string name)
	{
		return GetInterface(name, ignoreCase: false);
	}

	public abstract Type GetInterface(string name, bool ignoreCase);

	[__DynamicallyInvokable]
	public abstract Type[] GetInterfaces();

	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		Type[] interfaces = GetInterfaces();
		int num = 0;
		for (int i = 0; i < interfaces.Length; i++)
		{
			if (!filter(interfaces[i], filterCriteria))
			{
				interfaces[i] = null;
			}
			else
			{
				num++;
			}
		}
		if (num == interfaces.Length)
		{
			return interfaces;
		}
		Type[] array = new Type[num];
		num = 0;
		for (int j = 0; j < interfaces.Length; j++)
		{
			if (interfaces[j] != null)
			{
				array[num++] = interfaces[j];
			}
		}
		return array;
	}

	[__DynamicallyInvokable]
	public EventInfo GetEvent(string name)
	{
		return GetEvent(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public virtual EventInfo[] GetEvents()
	{
		return GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		return GetPropertyImpl(name, bindingAttr, binder, returnType, types, modifiers);
	}

	public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		return GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, types, modifiers);
	}

	[__DynamicallyInvokable]
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return GetPropertyImpl(name, bindingAttr, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		return GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, types, null);
	}

	public PropertyInfo GetProperty(string name, Type[] types)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		return GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, null, types, null);
	}

	[__DynamicallyInvokable]
	public PropertyInfo GetProperty(string name, Type returnType)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (returnType == null)
		{
			throw new ArgumentNullException("returnType");
		}
		return GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, null, null);
	}

	internal PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Type returnType)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (returnType == null)
		{
			throw new ArgumentNullException("returnType");
		}
		return GetPropertyImpl(name, bindingAttr, null, returnType, null, null);
	}

	[__DynamicallyInvokable]
	public PropertyInfo GetProperty(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, null, null, null);
	}

	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	[__DynamicallyInvokable]
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public PropertyInfo[] GetProperties()
	{
		return GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public Type[] GetNestedTypes()
	{
		return GetNestedTypes(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract Type[] GetNestedTypes(BindingFlags bindingAttr);

	public Type GetNestedType(string name)
	{
		return GetNestedType(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public MemberInfo[] GetMember(string name)
	{
		return GetMember(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
	{
		return GetMember(name, MemberTypes.All, bindingAttr);
	}

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public MemberInfo[] GetMembers()
	{
		return GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	[__DynamicallyInvokable]
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

	[__DynamicallyInvokable]
	public virtual MemberInfo[] GetDefaultMembers()
	{
		throw new NotImplementedException();
	}

	public virtual MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria)
	{
		MethodInfo[] array = null;
		ConstructorInfo[] array2 = null;
		FieldInfo[] array3 = null;
		PropertyInfo[] array4 = null;
		EventInfo[] array5 = null;
		Type[] array6 = null;
		int num = 0;
		int num2 = 0;
		if ((memberType & MemberTypes.Method) != 0)
		{
			array = GetMethods(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array.Length; num++)
				{
					if (!filter(array[num], filterCriteria))
					{
						array[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array.Length;
			}
		}
		if ((memberType & MemberTypes.Constructor) != 0)
		{
			array2 = GetConstructors(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array2.Length; num++)
				{
					if (!filter(array2[num], filterCriteria))
					{
						array2[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array2.Length;
			}
		}
		if ((memberType & MemberTypes.Field) != 0)
		{
			array3 = GetFields(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array3.Length; num++)
				{
					if (!filter(array3[num], filterCriteria))
					{
						array3[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array3.Length;
			}
		}
		if ((memberType & MemberTypes.Property) != 0)
		{
			array4 = GetProperties(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array4.Length; num++)
				{
					if (!filter(array4[num], filterCriteria))
					{
						array4[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array4.Length;
			}
		}
		if ((memberType & MemberTypes.Event) != 0)
		{
			array5 = GetEvents(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array5.Length; num++)
				{
					if (!filter(array5[num], filterCriteria))
					{
						array5[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array5.Length;
			}
		}
		if ((memberType & MemberTypes.NestedType) != 0)
		{
			array6 = GetNestedTypes(bindingAttr);
			if (filter != null)
			{
				for (num = 0; num < array6.Length; num++)
				{
					if (!filter(array6[num], filterCriteria))
					{
						array6[num] = null;
					}
					else
					{
						num2++;
					}
				}
			}
			else
			{
				num2 += array6.Length;
			}
		}
		MemberInfo[] array7 = new MemberInfo[num2];
		num2 = 0;
		if (array != null)
		{
			for (num = 0; num < array.Length; num++)
			{
				if (array[num] != null)
				{
					array7[num2++] = array[num];
				}
			}
		}
		if (array2 != null)
		{
			for (num = 0; num < array2.Length; num++)
			{
				if (array2[num] != null)
				{
					array7[num2++] = array2[num];
				}
			}
		}
		if (array3 != null)
		{
			for (num = 0; num < array3.Length; num++)
			{
				if (array3[num] != null)
				{
					array7[num2++] = array3[num];
				}
			}
		}
		if (array4 != null)
		{
			for (num = 0; num < array4.Length; num++)
			{
				if (array4[num] != null)
				{
					array7[num2++] = array4[num];
				}
			}
		}
		if (array5 != null)
		{
			for (num = 0; num < array5.Length; num++)
			{
				if (array5[num] != null)
				{
					array7[num2++] = array5[num];
				}
			}
		}
		if (array6 != null)
		{
			for (num = 0; num < array6.Length; num++)
			{
				if (array6[num] != null)
				{
					array7[num2++] = array6[num];
				}
			}
		}
		return array7;
	}

	[__DynamicallyInvokable]
	public virtual Type[] GetGenericParameterConstraints()
	{
		if (!IsGenericParameter)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
		}
		throw new InvalidOperationException();
	}

	[__DynamicallyInvokable]
	protected virtual bool IsValueTypeImpl()
	{
		return IsSubclassOf(RuntimeType.ValueType);
	}

	protected abstract TypeAttributes GetAttributeFlagsImpl();

	[__DynamicallyInvokable]
	protected abstract bool IsArrayImpl();

	[__DynamicallyInvokable]
	protected abstract bool IsByRefImpl();

	[__DynamicallyInvokable]
	protected abstract bool IsPointerImpl();

	[__DynamicallyInvokable]
	protected abstract bool IsPrimitiveImpl();

	protected abstract bool IsCOMObjectImpl();

	internal virtual bool IsWindowsRuntimeObjectImpl()
	{
		throw new NotImplementedException();
	}

	internal virtual bool IsExportedToWindowsRuntimeImpl()
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual Type MakeGenericType(params Type[] typeArguments)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	protected virtual bool IsContextfulImpl()
	{
		return typeof(ContextBoundObject).IsAssignableFrom(this);
	}

	protected virtual bool IsMarshalByRefImpl()
	{
		return typeof(MarshalByRefObject).IsAssignableFrom(this);
	}

	internal virtual bool HasProxyAttributeImpl()
	{
		return false;
	}

	[__DynamicallyInvokable]
	public abstract Type GetElementType();

	[__DynamicallyInvokable]
	public virtual Type[] GetGenericArguments()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public virtual Type GetGenericTypeDefinition()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	protected abstract bool HasElementTypeImpl();

	internal Type GetRootElementType()
	{
		Type type = this;
		while (type.HasElementType)
		{
			type = type.GetElementType();
		}
		return type;
	}

	public virtual string[] GetEnumNames()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		GetEnumData(out var enumNames, out var _);
		return enumNames;
	}

	public virtual Array GetEnumValues()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		throw new NotImplementedException();
	}

	private Array GetEnumRawConstantValues()
	{
		GetEnumData(out var _, out var enumValues);
		return enumValues;
	}

	private void GetEnumData(out string[] enumNames, out Array enumValues)
	{
		FieldInfo[] fields = GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		object[] array = new object[fields.Length];
		string[] array2 = new string[fields.Length];
		for (int i = 0; i < fields.Length; i++)
		{
			array2[i] = fields[i].Name;
			array[i] = fields[i].GetRawConstantValue();
		}
		IComparer comparer = Comparer.Default;
		for (int j = 1; j < array.Length; j++)
		{
			int num = j;
			string text = array2[j];
			object obj = array[j];
			bool flag = false;
			while (comparer.Compare(array[num - 1], obj) > 0)
			{
				array2[num] = array2[num - 1];
				array[num] = array[num - 1];
				num--;
				flag = true;
				if (num == 0)
				{
					break;
				}
			}
			if (flag)
			{
				array2[num] = text;
				array[num] = obj;
			}
		}
		enumNames = array2;
		enumValues = array;
	}

	public virtual Type GetEnumUnderlyingType()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		FieldInfo[] fields = GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (fields == null || fields.Length != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidEnum"), "enumType");
		}
		return fields[0].FieldType;
	}

	public virtual bool IsEnumDefined(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		Type type = value.GetType();
		if (type.IsEnum)
		{
			if (!type.IsEquivalentTo(this))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumAndObjectMustBeSameType", type.ToString(), ToString()));
			}
			type = type.GetEnumUnderlyingType();
		}
		if (type == typeof(string))
		{
			string[] enumNames = GetEnumNames();
			object[] array = enumNames;
			if (Array.IndexOf(array, value) >= 0)
			{
				return true;
			}
			return false;
		}
		if (IsIntegerType(type))
		{
			Type enumUnderlyingType = GetEnumUnderlyingType();
			if (enumUnderlyingType.GetTypeCodeImpl() != type.GetTypeCodeImpl())
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType", type.ToString(), enumUnderlyingType.ToString()));
			}
			Array enumRawConstantValues = GetEnumRawConstantValues();
			return BinarySearch(enumRawConstantValues, value) >= 0;
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType", type.ToString(), GetEnumUnderlyingType()));
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType"));
	}

	public virtual string GetEnumName(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		Type type = value.GetType();
		if (!type.IsEnum && !IsIntegerType(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnumBaseTypeOrEnum"), "value");
		}
		Array enumRawConstantValues = GetEnumRawConstantValues();
		int num = BinarySearch(enumRawConstantValues, value);
		if (num >= 0)
		{
			string[] enumNames = GetEnumNames();
			return enumNames[num];
		}
		return null;
	}

	private static int BinarySearch(Array array, object value)
	{
		ulong[] array2 = new ulong[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = Enum.ToUInt64(array.GetValue(i));
		}
		ulong value2 = Enum.ToUInt64(value);
		return Array.BinarySearch(array2, value2);
	}

	internal static bool IsIntegerType(Type t)
	{
		if (!(t == typeof(int)) && !(t == typeof(short)) && !(t == typeof(ushort)) && !(t == typeof(byte)) && !(t == typeof(sbyte)) && !(t == typeof(uint)) && !(t == typeof(long)) && !(t == typeof(ulong)) && !(t == typeof(char)))
		{
			return t == typeof(bool);
		}
		return true;
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public virtual bool IsSubclassOf(Type c)
	{
		Type type = this;
		if (type == c)
		{
			return false;
		}
		while (type != null)
		{
			if (type == c)
			{
				return true;
			}
			type = type.BaseType;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public virtual bool IsInstanceOfType(object o)
	{
		if (o == null)
		{
			return false;
		}
		return IsAssignableFrom(o.GetType());
	}

	[__DynamicallyInvokable]
	public virtual bool IsAssignableFrom(Type c)
	{
		if (c == null)
		{
			return false;
		}
		if (this == c)
		{
			return true;
		}
		RuntimeType runtimeType = UnderlyingSystemType as RuntimeType;
		if (runtimeType != null)
		{
			return runtimeType.IsAssignableFrom(c);
		}
		if (c.IsSubclassOf(this))
		{
			return true;
		}
		if (IsInterface)
		{
			return c.ImplementInterface(this);
		}
		if (IsGenericParameter)
		{
			Type[] genericParameterConstraints = GetGenericParameterConstraints();
			for (int i = 0; i < genericParameterConstraints.Length; i++)
			{
				if (!genericParameterConstraints[i].IsAssignableFrom(c))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	public virtual bool IsEquivalentTo(Type other)
	{
		return this == other;
	}

	internal bool ImplementInterface(Type ifaceType)
	{
		Type type = this;
		while (type != null)
		{
			Type[] interfaces = type.GetInterfaces();
			if (interfaces != null)
			{
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (interfaces[i] == ifaceType || (interfaces[i] != null && interfaces[i].ImplementInterface(ifaceType)))
					{
						return true;
					}
				}
			}
			type = type.BaseType;
		}
		return false;
	}

	internal string FormatTypeName()
	{
		return FormatTypeName(serialization: false);
	}

	internal virtual string FormatTypeName(bool serialization)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return "Type: " + Name;
	}

	public static Type[] GetTypeArray(object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		Type[] array = new Type[args.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (args[i] == null)
			{
				throw new ArgumentNullException();
			}
			array[i] = args[i].GetType();
		}
		return array;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object o)
	{
		if (o == null)
		{
			return false;
		}
		return Equals(o as Type);
	}

	[__DynamicallyInvokable]
	public virtual bool Equals(Type o)
	{
		if ((object)o == null)
		{
			return false;
		}
		return (object)UnderlyingSystemType == o.UnderlyingSystemType;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern bool operator ==(Type left, Type right);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern bool operator !=(Type left, Type right);

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		Type underlyingSystemType = UnderlyingSystemType;
		if ((object)underlyingSystemType != this)
		{
			return underlyingSystemType.GetHashCode();
		}
		return base.GetHashCode();
	}

	[ComVisible(true)]
	public virtual InterfaceMapping GetInterfaceMap(Type interfaceType)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public new Type GetType()
	{
		return base.GetType();
	}

	void _Type.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _Type.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _Type.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _Type.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
