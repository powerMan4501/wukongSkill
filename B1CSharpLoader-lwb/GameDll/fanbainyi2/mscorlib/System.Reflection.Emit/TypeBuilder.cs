using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_TypeBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class TypeBuilder : TypeInfo, _TypeBuilder
{
	private class CustAttr
	{
		private ConstructorInfo m_con;

		private byte[] m_binaryAttribute;

		private CustomAttributeBuilder m_customBuilder;

		public CustAttr(ConstructorInfo con, byte[] binaryAttribute)
		{
			if (con == null)
			{
				throw new ArgumentNullException("con");
			}
			if (binaryAttribute == null)
			{
				throw new ArgumentNullException("binaryAttribute");
			}
			m_con = con;
			m_binaryAttribute = binaryAttribute;
		}

		public CustAttr(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			m_customBuilder = customBuilder;
		}

		[SecurityCritical]
		public void Bake(ModuleBuilder module, int token)
		{
			if (m_customBuilder == null)
			{
				DefineCustomAttribute(module, token, module.GetConstructorToken(m_con).Token, m_binaryAttribute, toDisk: false, updateCompilerFlags: false);
			}
			else
			{
				m_customBuilder.CreateCustomAttribute(module, token);
			}
		}
	}

	public const int UnspecifiedTypeSize = 0;

	private List<CustAttr> m_ca;

	private TypeToken m_tdType;

	private ModuleBuilder m_module;

	private string m_strName;

	private string m_strNameSpace;

	private string m_strFullQualName;

	private Type m_typeParent;

	private List<Type> m_typeInterfaces;

	private TypeAttributes m_iAttr;

	private GenericParameterAttributes m_genParamAttributes;

	internal List<MethodBuilder> m_listMethods;

	internal int m_lastTokenizedMethod;

	private int m_constructorCount;

	private int m_iTypeSize;

	private PackingSize m_iPackingSize;

	private TypeBuilder m_DeclaringType;

	private Type m_enumUnderlyingType;

	internal bool m_isHiddenGlobalType;

	private bool m_hasBeenCreated;

	private RuntimeType m_bakedRuntimeType;

	private int m_genParamPos;

	private GenericTypeParameterBuilder[] m_inst;

	private bool m_bIsGenParam;

	private MethodBuilder m_declMeth;

	private TypeBuilder m_genTypeDef;

	internal object SyncRoot => m_module.SyncRoot;

	internal RuntimeType BakedRuntimeType => m_bakedRuntimeType;

	public override Type DeclaringType => m_DeclaringType;

	public override Type ReflectedType => m_DeclaringType;

	public override string Name => m_strName;

	public override Module Module => GetModuleBuilder();

	internal int MetadataTokenInternal => m_tdType.Token;

	public override Guid GUID
	{
		get
		{
			if (!IsCreated())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
			}
			return m_bakedRuntimeType.GUID;
		}
	}

	public override Assembly Assembly => m_module.Assembly;

	public override RuntimeTypeHandle TypeHandle
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override string FullName
	{
		get
		{
			if (m_strFullQualName == null)
			{
				m_strFullQualName = TypeNameBuilder.ToString(this, TypeNameBuilder.Format.FullName);
			}
			return m_strFullQualName;
		}
	}

	public override string Namespace => m_strNameSpace;

	public override string AssemblyQualifiedName => TypeNameBuilder.ToString(this, TypeNameBuilder.Format.AssemblyQualifiedName);

	public override Type BaseType => m_typeParent;

	public override bool IsSecurityCritical
	{
		get
		{
			if (!IsCreated())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
			}
			return m_bakedRuntimeType.IsSecurityCritical;
		}
	}

	public override bool IsSecuritySafeCritical
	{
		get
		{
			if (!IsCreated())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
			}
			return m_bakedRuntimeType.IsSecuritySafeCritical;
		}
	}

	public override bool IsSecurityTransparent
	{
		get
		{
			if (!IsCreated())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
			}
			return m_bakedRuntimeType.IsSecurityTransparent;
		}
	}

	public override Type UnderlyingSystemType
	{
		get
		{
			if (m_bakedRuntimeType != null)
			{
				return m_bakedRuntimeType;
			}
			if (IsEnum)
			{
				if (m_enumUnderlyingType == null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoUnderlyingTypeOnEnum"));
				}
				return m_enumUnderlyingType;
			}
			return this;
		}
	}

	public override GenericParameterAttributes GenericParameterAttributes => m_genParamAttributes;

	public override bool IsGenericTypeDefinition => IsGenericType;

	public override bool IsGenericType => m_inst != null;

	public override bool IsGenericParameter => m_bIsGenParam;

	public override bool IsConstructedGenericType => false;

	public override int GenericParameterPosition => m_genParamPos;

	public override MethodBase DeclaringMethod => m_declMeth;

	public int Size => m_iTypeSize;

	public PackingSize PackingSize => m_iPackingSize;

	public TypeToken TypeToken
	{
		get
		{
			if (IsGenericParameter)
			{
				ThrowIfCreated();
			}
			return m_tdType;
		}
	}

	public override bool IsAssignableFrom(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			return false;
		}
		return IsAssignableFrom(typeInfo.AsType());
	}

	public static MethodInfo GetMethod(Type type, MethodInfo method)
	{
		if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeTypeBuilder"));
		}
		if (method.IsGenericMethod && !method.IsGenericMethodDefinition)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedGenericMethodDefinition"), "method");
		}
		if (method.DeclaringType == null || !method.DeclaringType.IsGenericTypeDefinition)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MethodNeedGenericDeclaringType"), "method");
		}
		if (type.GetGenericTypeDefinition() != method.DeclaringType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidMethodDeclaringType"), "type");
		}
		if (type.IsGenericTypeDefinition)
		{
			type = type.MakeGenericType(type.GetGenericArguments());
		}
		if (!(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "type");
		}
		return MethodOnTypeBuilderInstantiation.GetMethod(method, type as TypeBuilderInstantiation);
	}

	public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor)
	{
		if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeTypeBuilder"));
		}
		if (!constructor.DeclaringType.IsGenericTypeDefinition)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ConstructorNeedGenericDeclaringType"), "constructor");
		}
		if (!(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "type");
		}
		if (type is TypeBuilder && type.IsGenericTypeDefinition)
		{
			type = type.MakeGenericType(type.GetGenericArguments());
		}
		if (type.GetGenericTypeDefinition() != constructor.DeclaringType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidConstructorDeclaringType"), "type");
		}
		return ConstructorOnTypeBuilderInstantiation.GetConstructor(constructor, type as TypeBuilderInstantiation);
	}

	public static FieldInfo GetField(Type type, FieldInfo field)
	{
		if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeTypeBuilder"));
		}
		if (!field.DeclaringType.IsGenericTypeDefinition)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_FieldNeedGenericDeclaringType"), "field");
		}
		if (!(type is TypeBuilderInstantiation))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "type");
		}
		if (type is TypeBuilder && type.IsGenericTypeDefinition)
		{
			type = type.MakeGenericType(type.GetGenericArguments());
		}
		if (type.GetGenericTypeDefinition() != field.DeclaringType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFieldDeclaringType"), "type");
		}
		return FieldOnTypeBuilderInstantiation.GetField(field, type as TypeBuilderInstantiation);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetParentType(RuntimeModule module, int tdTypeDef, int tkParent);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddInterfaceImpl(RuntimeModule module, int tdTypeDef, int tkInterface);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int DefineMethod(RuntimeModule module, int tkParent, string name, byte[] signature, int sigLength, MethodAttributes attributes);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int DefineMethodSpec(RuntimeModule module, int tkParent, byte[] signature, int sigLength);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int DefineField(RuntimeModule module, int tkParent, string name, byte[] signature, int sigLength, FieldAttributes attributes);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetMethodIL(RuntimeModule module, int tk, bool isInitLocals, byte[] body, int bodyLength, byte[] LocalSig, int sigLength, int maxStackSize, ExceptionHandler[] exceptions, int numExceptions, int[] tokenFixups, int numTokenFixups);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DefineCustomAttribute(RuntimeModule module, int tkAssociate, int tkConstructor, byte[] attr, int attrLength, bool toDisk, bool updateCompilerFlags);

	[SecurityCritical]
	internal static void DefineCustomAttribute(ModuleBuilder module, int tkAssociate, int tkConstructor, byte[] attr, bool toDisk, bool updateCompilerFlags)
	{
		byte[] array = null;
		if (attr != null)
		{
			array = new byte[attr.Length];
			Array.Copy(attr, array, attr.Length);
		}
		DefineCustomAttribute(module.GetNativeHandle(), tkAssociate, tkConstructor, array, (array != null) ? array.Length : 0, toDisk, updateCompilerFlags);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetPInvokeData(RuntimeModule module, string DllName, string name, int token, int linkFlags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int DefineProperty(RuntimeModule module, int tkParent, string name, PropertyAttributes attributes, byte[] signature, int sigLength);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int DefineEvent(RuntimeModule module, int tkParent, string name, EventAttributes attributes, int tkEventType);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void DefineMethodSemantics(RuntimeModule module, int tkAssociation, MethodSemanticsAttributes semantics, int tkMethod);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void DefineMethodImpl(RuntimeModule module, int tkType, int tkBody, int tkDecl);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetMethodImpl(RuntimeModule module, int tkMethod, MethodImplAttributes MethodImplAttributes);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int SetParamInfo(RuntimeModule module, int tkMethod, int iSequence, ParameterAttributes iParamAttributes, string strParamName);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int GetTokenFromSig(RuntimeModule module, byte[] signature, int sigLength);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetFieldLayoutOffset(RuntimeModule module, int fdToken, int iOffset);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetClassLayout(RuntimeModule module, int tk, PackingSize iPackingSize, int iTypeSize);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetFieldMarshal(RuntimeModule module, int tk, byte[] ubMarshal, int ubSize);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void SetConstantValue(RuntimeModule module, int tk, int corType, void* pValue);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void AddDeclarativeSecurity(RuntimeModule module, int parent, SecurityAction action, byte[] blob, int cb);

	private static bool IsPublicComType(Type type)
	{
		Type declaringType = type.DeclaringType;
		if (declaringType != null)
		{
			if (IsPublicComType(declaringType) && (type.Attributes & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
			{
				return true;
			}
		}
		else if ((type.Attributes & TypeAttributes.VisibilityMask) == TypeAttributes.Public)
		{
			return true;
		}
		return false;
	}

	internal static bool IsTypeEqual(Type t1, Type t2)
	{
		if (t1 == t2)
		{
			return true;
		}
		TypeBuilder typeBuilder = null;
		TypeBuilder typeBuilder2 = null;
		Type type = null;
		Type type2 = null;
		if (t1 is TypeBuilder)
		{
			typeBuilder = (TypeBuilder)t1;
			type = typeBuilder.m_bakedRuntimeType;
		}
		else
		{
			type = t1;
		}
		if (t2 is TypeBuilder)
		{
			typeBuilder2 = (TypeBuilder)t2;
			type2 = typeBuilder2.m_bakedRuntimeType;
		}
		else
		{
			type2 = t2;
		}
		if (typeBuilder != null && typeBuilder2 != null && (object)typeBuilder == typeBuilder2)
		{
			return true;
		}
		if (type != null && type2 != null && type == type2)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal unsafe static void SetConstantValue(ModuleBuilder module, int tk, Type destType, object value)
	{
		if (value != null)
		{
			Type type = value.GetType();
			if (destType.IsByRef)
			{
				destType = destType.GetElementType();
			}
			if (destType.IsEnum)
			{
				EnumBuilder enumBuilder;
				Type type2;
				TypeBuilder typeBuilder;
				if ((enumBuilder = destType as EnumBuilder) != null)
				{
					type2 = enumBuilder.GetEnumUnderlyingType();
					if (type != enumBuilder.m_typeBuilder.m_bakedRuntimeType && type != type2)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_ConstantDoesntMatch"));
					}
				}
				else if ((typeBuilder = destType as TypeBuilder) != null)
				{
					type2 = typeBuilder.m_enumUnderlyingType;
					if (type2 == null || (type != typeBuilder.UnderlyingSystemType && type != type2))
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_ConstantDoesntMatch"));
					}
				}
				else
				{
					type2 = Enum.GetUnderlyingType(destType);
					if (type != destType && type != type2)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_ConstantDoesntMatch"));
					}
				}
				type = type2;
			}
			else if (!destType.IsAssignableFrom(type))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ConstantDoesntMatch"));
			}
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType((RuntimeType)type);
			if (corElementType - 2 <= CorElementType.U8)
			{
				fixed (byte* data = &JitHelpers.GetPinningHelper(value).m_data)
				{
					SetConstantValue(module.GetNativeHandle(), tk, (int)corElementType, data);
				}
				return;
			}
			if (type == typeof(string))
			{
				fixed (char* pValue = (string)value)
				{
					SetConstantValue(module.GetNativeHandle(), tk, 14, pValue);
				}
				return;
			}
			if (!(type == typeof(DateTime)))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ConstantNotSupported", type.ToString()));
			}
			long ticks = ((DateTime)value).Ticks;
			SetConstantValue(module.GetNativeHandle(), tk, 10, &ticks);
		}
		else
		{
			if (destType.IsValueType && (!destType.IsGenericType || !(destType.GetGenericTypeDefinition() == typeof(Nullable<>))))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ConstantNull"));
			}
			SetConstantValue(module.GetNativeHandle(), tk, 18, null);
		}
	}

	internal TypeBuilder(ModuleBuilder module)
	{
		m_tdType = new TypeToken(33554432);
		m_isHiddenGlobalType = true;
		m_module = module;
		m_listMethods = new List<MethodBuilder>();
		m_lastTokenizedMethod = -1;
	}

	internal TypeBuilder(string szName, int genParamPos, MethodBuilder declMeth)
	{
		m_declMeth = declMeth;
		m_DeclaringType = m_declMeth.GetTypeBuilder();
		m_module = declMeth.GetModuleBuilder();
		InitAsGenericParam(szName, genParamPos);
	}

	private TypeBuilder(string szName, int genParamPos, TypeBuilder declType)
	{
		m_DeclaringType = declType;
		m_module = declType.GetModuleBuilder();
		InitAsGenericParam(szName, genParamPos);
	}

	private void InitAsGenericParam(string szName, int genParamPos)
	{
		m_strName = szName;
		m_genParamPos = genParamPos;
		m_bIsGenParam = true;
		m_typeInterfaces = new List<Type>();
	}

	[SecurityCritical]
	internal TypeBuilder(string name, TypeAttributes attr, Type parent, Type[] interfaces, ModuleBuilder module, PackingSize iPackingSize, int iTypeSize, TypeBuilder enclosingType)
	{
		Init(name, attr, parent, interfaces, module, iPackingSize, iTypeSize, enclosingType);
	}

	[SecurityCritical]
	private void Init(string fullname, TypeAttributes attr, Type parent, Type[] interfaces, ModuleBuilder module, PackingSize iPackingSize, int iTypeSize, TypeBuilder enclosingType)
	{
		if (fullname == null)
		{
			throw new ArgumentNullException("fullname");
		}
		if (fullname.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "fullname");
		}
		if (fullname[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalName"), "fullname");
		}
		if (fullname.Length > 1023)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeNameTooLong"), "fullname");
		}
		m_module = module;
		m_DeclaringType = enclosingType;
		AssemblyBuilder containingAssemblyBuilder = m_module.ContainingAssemblyBuilder;
		containingAssemblyBuilder.m_assemblyData.CheckTypeNameConflict(fullname, enclosingType);
		if (enclosingType != null && ((attr & TypeAttributes.VisibilityMask) == TypeAttributes.Public || (attr & TypeAttributes.VisibilityMask) == 0))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadNestedTypeFlags"), "attr");
		}
		int[] array = null;
		if (interfaces != null)
		{
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (interfaces[i] == null)
				{
					throw new ArgumentNullException("interfaces");
				}
			}
			array = new int[interfaces.Length + 1];
			for (int i = 0; i < interfaces.Length; i++)
			{
				array[i] = m_module.GetTypeTokenInternal(interfaces[i]).Token;
			}
		}
		int num = fullname.LastIndexOf('.');
		if (num == -1 || num == 0)
		{
			m_strNameSpace = string.Empty;
			m_strName = fullname;
		}
		else
		{
			m_strNameSpace = fullname.Substring(0, num);
			m_strName = fullname.Substring(num + 1);
		}
		VerifyTypeAttributes(attr);
		m_iAttr = attr;
		SetParent(parent);
		m_listMethods = new List<MethodBuilder>();
		m_lastTokenizedMethod = -1;
		SetInterfaces(interfaces);
		int tkParent = 0;
		if (m_typeParent != null)
		{
			tkParent = m_module.GetTypeTokenInternal(m_typeParent).Token;
		}
		int tkEnclosingType = 0;
		if (enclosingType != null)
		{
			tkEnclosingType = enclosingType.m_tdType.Token;
		}
		m_tdType = new TypeToken(DefineType(m_module.GetNativeHandle(), fullname, tkParent, m_iAttr, tkEnclosingType, array));
		m_iPackingSize = iPackingSize;
		m_iTypeSize = iTypeSize;
		if (m_iPackingSize != PackingSize.Unspecified || m_iTypeSize != 0)
		{
			SetClassLayout(GetModuleBuilder().GetNativeHandle(), m_tdType.Token, m_iPackingSize, m_iTypeSize);
		}
		if (IsPublicComType(this))
		{
			if (containingAssemblyBuilder.IsPersistable() && !m_module.IsTransient())
			{
				containingAssemblyBuilder.m_assemblyData.AddPublicComType(this);
			}
			if (!m_module.Equals(containingAssemblyBuilder.ManifestModule))
			{
				containingAssemblyBuilder.DefineExportedTypeInMemory(this, m_module.m_moduleData.FileToken, m_tdType.Token);
			}
		}
		m_module.AddType(FullName, this);
	}

	[SecurityCritical]
	private MethodBuilder DefinePInvokeMethodHelper(string name, string dllName, string importName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		CheckContext(returnType);
		CheckContext(returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes);
		CheckContext(parameterTypeRequiredCustomModifiers);
		CheckContext(parameterTypeOptionalCustomModifiers);
		AppDomain.CheckDefinePInvokeSupported();
		lock (SyncRoot)
		{
			return DefinePInvokeMethodHelperNoLock(name, dllName, importName, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, nativeCallConv, nativeCharSet);
		}
	}

	[SecurityCritical]
	private MethodBuilder DefinePInvokeMethodHelperNoLock(string name, string dllName, string importName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (dllName == null)
		{
			throw new ArgumentNullException("dllName");
		}
		if (dllName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "dllName");
		}
		if (importName == null)
		{
			throw new ArgumentNullException("importName");
		}
		if (importName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "importName");
		}
		if ((attributes & MethodAttributes.Abstract) != MethodAttributes.PrivateScope)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadPInvokeMethod"));
		}
		if ((m_iAttr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadPInvokeOnInterface"));
		}
		ThrowIfCreated();
		attributes |= MethodAttributes.PinvokeImpl;
		MethodBuilder methodBuilder = new MethodBuilder(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, m_module, this, bIsGlobalMethod: false);
		int length;
		byte[] array = methodBuilder.GetMethodSignature().InternalGetSignature(out length);
		if (m_listMethods.Contains(methodBuilder))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MethodRedefined"));
		}
		m_listMethods.Add(methodBuilder);
		MethodToken token = methodBuilder.GetToken();
		int num = 0;
		switch (nativeCallConv)
		{
		case CallingConvention.Winapi:
			num = 256;
			break;
		case CallingConvention.Cdecl:
			num = 512;
			break;
		case CallingConvention.StdCall:
			num = 768;
			break;
		case CallingConvention.ThisCall:
			num = 1024;
			break;
		case CallingConvention.FastCall:
			num = 1280;
			break;
		}
		switch (nativeCharSet)
		{
		case CharSet.None:
			num |= 0;
			break;
		case CharSet.Ansi:
			num |= 2;
			break;
		case CharSet.Unicode:
			num |= 4;
			break;
		case CharSet.Auto:
			num |= 6;
			break;
		}
		SetPInvokeData(m_module.GetNativeHandle(), dllName, importName, token.Token, num);
		methodBuilder.SetToken(token);
		return methodBuilder;
	}

	[SecurityCritical]
	private FieldBuilder DefineDataHelper(string name, byte[] data, int size, FieldAttributes attributes)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (size <= 0 || size >= 4128768)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadSizeForData"));
		}
		ThrowIfCreated();
		string text = "$ArrayType$" + size;
		Type type = m_module.FindTypeBuilderWithName(text, ignoreCase: false);
		TypeBuilder typeBuilder = type as TypeBuilder;
		if (typeBuilder == null)
		{
			TypeAttributes attr = TypeAttributes.Public | TypeAttributes.ExplicitLayout | TypeAttributes.Sealed;
			typeBuilder = m_module.DefineType(text, attr, typeof(ValueType), PackingSize.Size1, size);
			typeBuilder.CreateType();
		}
		FieldBuilder fieldBuilder = DefineField(name, typeBuilder, attributes | FieldAttributes.Static);
		fieldBuilder.SetData(data, size);
		return fieldBuilder;
	}

	private void VerifyTypeAttributes(TypeAttributes attr)
	{
		if (DeclaringType == null)
		{
			if ((attr & TypeAttributes.VisibilityMask) != TypeAttributes.NotPublic && (attr & TypeAttributes.VisibilityMask) != TypeAttributes.Public)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_BadTypeAttrNestedVisibilityOnNonNestedType"));
			}
		}
		else if ((attr & TypeAttributes.VisibilityMask) == 0 || (attr & TypeAttributes.VisibilityMask) == TypeAttributes.Public)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadTypeAttrNonNestedVisibilityNestedType"));
		}
		if ((attr & TypeAttributes.LayoutMask) != TypeAttributes.NotPublic && (attr & TypeAttributes.LayoutMask) != TypeAttributes.SequentialLayout && (attr & TypeAttributes.LayoutMask) != TypeAttributes.ExplicitLayout)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadTypeAttrInvalidLayout"));
		}
		if ((attr & TypeAttributes.ReservedMask) != TypeAttributes.NotPublic)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadTypeAttrReservedBitsSet"));
		}
	}

	public bool IsCreated()
	{
		return m_hasBeenCreated;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int DefineType(RuntimeModule module, string fullname, int tkParent, TypeAttributes attributes, int tkEnclosingType, int[] interfaceTokens);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int DefineGenericParam(RuntimeModule module, string name, int tkParent, GenericParameterAttributes attributes, int position, int[] constraints);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void TermCreateClass(RuntimeModule module, int tk, ObjectHandleOnStack type);

	internal void ThrowIfCreated()
	{
		if (IsCreated())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TypeHasBeenCreated"));
		}
	}

	internal ModuleBuilder GetModuleBuilder()
	{
		return m_module;
	}

	internal void SetGenParamAttributes(GenericParameterAttributes genericParameterAttributes)
	{
		m_genParamAttributes = genericParameterAttributes;
	}

	internal void SetGenParamCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		CustAttr genParamCustomAttributeNoLock = new CustAttr(con, binaryAttribute);
		lock (SyncRoot)
		{
			SetGenParamCustomAttributeNoLock(genParamCustomAttributeNoLock);
		}
	}

	internal void SetGenParamCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		CustAttr genParamCustomAttributeNoLock = new CustAttr(customBuilder);
		lock (SyncRoot)
		{
			SetGenParamCustomAttributeNoLock(genParamCustomAttributeNoLock);
		}
	}

	private void SetGenParamCustomAttributeNoLock(CustAttr ca)
	{
		if (m_ca == null)
		{
			m_ca = new List<CustAttr>();
		}
		m_ca.Add(ca);
	}

	public override string ToString()
	{
		return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.ToString);
	}

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetConstructors(bindingAttr);
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		if (types == null)
		{
			return m_bakedRuntimeType.GetMethod(name, bindingAttr);
		}
		return m_bakedRuntimeType.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetMethods(bindingAttr);
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetField(name, bindingAttr);
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetFields(bindingAttr);
	}

	public override Type GetInterface(string name, bool ignoreCase)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetInterface(name, ignoreCase);
	}

	public override Type[] GetInterfaces()
	{
		if (m_bakedRuntimeType != null)
		{
			return m_bakedRuntimeType.GetInterfaces();
		}
		if (m_typeInterfaces == null)
		{
			return EmptyArray<Type>.Value;
		}
		return m_typeInterfaces.ToArray();
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetEvent(name, bindingAttr);
	}

	public override EventInfo[] GetEvents()
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetEvents();
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetProperties(bindingAttr);
	}

	public override Type[] GetNestedTypes(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetNestedTypes(bindingAttr);
	}

	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetNestedType(name, bindingAttr);
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetMember(name, type, bindingAttr);
	}

	[ComVisible(true)]
	public override InterfaceMapping GetInterfaceMap(Type interfaceType)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetInterfaceMap(interfaceType);
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetEvents(bindingAttr);
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return m_bakedRuntimeType.GetMembers(bindingAttr);
	}

	public override bool IsAssignableFrom(Type c)
	{
		if (IsTypeEqual(c, this))
		{
			return true;
		}
		Type type = null;
		TypeBuilder typeBuilder = c as TypeBuilder;
		type = ((!(typeBuilder != null)) ? c : typeBuilder.m_bakedRuntimeType);
		if (type != null && type is RuntimeType)
		{
			if (m_bakedRuntimeType == null)
			{
				return false;
			}
			return m_bakedRuntimeType.IsAssignableFrom(type);
		}
		if (typeBuilder == null)
		{
			return false;
		}
		if (typeBuilder.IsSubclassOf(this))
		{
			return true;
		}
		if (!base.IsInterface)
		{
			return false;
		}
		Type[] interfaces = typeBuilder.GetInterfaces();
		for (int i = 0; i < interfaces.Length; i++)
		{
			if (IsTypeEqual(interfaces[i], this))
			{
				return true;
			}
			if (interfaces[i].IsSubclassOf(this))
			{
				return true;
			}
		}
		return false;
	}

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return m_iAttr;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		if ((GetAttributeFlagsImpl() & TypeAttributes.Import) == 0)
		{
			return false;
		}
		return true;
	}

	public override Type GetElementType()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	[ComVisible(true)]
	public override bool IsSubclassOf(Type c)
	{
		Type type = this;
		if (IsTypeEqual(type, c))
		{
			return false;
		}
		type = type.BaseType;
		while (type != null)
		{
			if (IsTypeEqual(type, c))
			{
				return true;
			}
			type = type.BaseType;
		}
		return false;
	}

	public override Type MakePointerType()
	{
		return SymbolType.FormCompoundType("*".ToCharArray(), this, 0);
	}

	public override Type MakeByRefType()
	{
		return SymbolType.FormCompoundType("&".ToCharArray(), this, 0);
	}

	public override Type MakeArrayType()
	{
		return SymbolType.FormCompoundType("[]".ToCharArray(), this, 0);
	}

	public override Type MakeArrayType(int rank)
	{
		if (rank <= 0)
		{
			throw new IndexOutOfRangeException();
		}
		string text = "";
		if (rank == 1)
		{
			text = "*";
		}
		else
		{
			for (int i = 1; i < rank; i++)
			{
				text += ",";
			}
		}
		string text2 = string.Format(CultureInfo.InvariantCulture, "[{0}]", text);
		return SymbolType.FormCompoundType(text2.ToCharArray(), this, 0);
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(bool inherit)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		return CustomAttribute.GetCustomAttributes(m_bakedRuntimeType, typeof(object) as RuntimeType, inherit);
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(m_bakedRuntimeType, runtimeType, inherit);
	}

	[SecuritySafeCritical]
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (!IsCreated())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_TypeNotYetCreated"));
		}
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "caType");
		}
		return CustomAttribute.IsDefined(m_bakedRuntimeType, runtimeType, inherit);
	}

	internal void SetInterfaces(params Type[] interfaces)
	{
		ThrowIfCreated();
		m_typeInterfaces = new List<Type>();
		if (interfaces != null)
		{
			m_typeInterfaces.AddRange(interfaces);
		}
	}

	public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		if (names.Length == 0)
		{
			throw new ArgumentException();
		}
		for (int i = 0; i < names.Length; i++)
		{
			if (names[i] == null)
			{
				throw new ArgumentNullException("names");
			}
		}
		if (m_inst != null)
		{
			throw new InvalidOperationException();
		}
		m_inst = new GenericTypeParameterBuilder[names.Length];
		for (int j = 0; j < names.Length; j++)
		{
			m_inst[j] = new GenericTypeParameterBuilder(new TypeBuilder(names[j], j, this));
		}
		return m_inst;
	}

	public override Type MakeGenericType(params Type[] typeArguments)
	{
		CheckContext(typeArguments);
		return TypeBuilderInstantiation.MakeGenericType(this, typeArguments);
	}

	public override Type[] GetGenericArguments()
	{
		return m_inst;
	}

	public override Type GetGenericTypeDefinition()
	{
		if (IsGenericTypeDefinition)
		{
			return this;
		}
		if (m_genTypeDef == null)
		{
			throw new InvalidOperationException();
		}
		return m_genTypeDef;
	}

	[SecuritySafeCritical]
	public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
	{
		lock (SyncRoot)
		{
			DefineMethodOverrideNoLock(methodInfoBody, methodInfoDeclaration);
		}
	}

	[SecurityCritical]
	private void DefineMethodOverrideNoLock(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
	{
		if (methodInfoBody == null)
		{
			throw new ArgumentNullException("methodInfoBody");
		}
		if (methodInfoDeclaration == null)
		{
			throw new ArgumentNullException("methodInfoDeclaration");
		}
		ThrowIfCreated();
		if ((object)methodInfoBody.DeclaringType != this)
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentException_BadMethodImplBody"));
		}
		MethodToken methodTokenInternal = m_module.GetMethodTokenInternal(methodInfoBody);
		MethodToken methodTokenInternal2 = m_module.GetMethodTokenInternal(methodInfoDeclaration);
		DefineMethodImpl(m_module.GetNativeHandle(), m_tdType.Token, methodTokenInternal.Token, methodTokenInternal2.Token);
	}

	public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
	{
		return DefineMethod(name, attributes, CallingConventions.Standard, returnType, parameterTypes);
	}

	public MethodBuilder DefineMethod(string name, MethodAttributes attributes)
	{
		return DefineMethod(name, attributes, CallingConventions.Standard, null, null);
	}

	public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention)
	{
		return DefineMethod(name, attributes, callingConvention, null, null);
	}

	public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		return DefineMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
	}

	public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		lock (SyncRoot)
		{
			return DefineMethodNoLock(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}
	}

	private MethodBuilder DefineMethodNoLock(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		CheckContext(returnType);
		CheckContext(returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes);
		CheckContext(parameterTypeRequiredCustomModifiers);
		CheckContext(parameterTypeOptionalCustomModifiers);
		if (parameterTypes != null)
		{
			if (parameterTypeOptionalCustomModifiers != null && parameterTypeOptionalCustomModifiers.Length != parameterTypes.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MismatchedArrays", "parameterTypeOptionalCustomModifiers", "parameterTypes"));
			}
			if (parameterTypeRequiredCustomModifiers != null && parameterTypeRequiredCustomModifiers.Length != parameterTypes.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MismatchedArrays", "parameterTypeRequiredCustomModifiers", "parameterTypes"));
			}
		}
		ThrowIfCreated();
		if (!m_isHiddenGlobalType && (m_iAttr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask && (attributes & MethodAttributes.Abstract) == 0 && (attributes & MethodAttributes.Static) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadAttributeOnInterfaceMethod"));
		}
		MethodBuilder methodBuilder = new MethodBuilder(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, m_module, this, bIsGlobalMethod: false);
		if (!m_isHiddenGlobalType && (methodBuilder.Attributes & MethodAttributes.SpecialName) != MethodAttributes.PrivateScope && methodBuilder.Name.Equals(ConstructorInfo.ConstructorName))
		{
			m_constructorCount++;
		}
		m_listMethods.Add(methodBuilder);
		return methodBuilder;
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public ConstructorBuilder DefineTypeInitializer()
	{
		lock (SyncRoot)
		{
			return DefineTypeInitializerNoLock();
		}
	}

	[SecurityCritical]
	private ConstructorBuilder DefineTypeInitializerNoLock()
	{
		ThrowIfCreated();
		MethodAttributes attributes = MethodAttributes.Private | MethodAttributes.Static | MethodAttributes.SpecialName;
		return new ConstructorBuilder(ConstructorInfo.TypeConstructorName, attributes, CallingConventions.Standard, null, m_module, this);
	}

	[ComVisible(true)]
	public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes)
	{
		if ((m_iAttr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ConstructorNotAllowedOnInterface"));
		}
		lock (SyncRoot)
		{
			return DefineDefaultConstructorNoLock(attributes);
		}
	}

	private ConstructorBuilder DefineDefaultConstructorNoLock(MethodAttributes attributes)
	{
		ConstructorInfo constructorInfo = null;
		if (m_typeParent is TypeBuilderInstantiation)
		{
			Type type = m_typeParent.GetGenericTypeDefinition();
			if (type is TypeBuilder)
			{
				type = ((TypeBuilder)type).m_bakedRuntimeType;
			}
			if (type == null)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
			}
			Type type2 = type.MakeGenericType(m_typeParent.GetGenericArguments());
			constructorInfo = ((!(type2 is TypeBuilderInstantiation)) ? type2.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) : GetConstructor(type2, type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null)));
		}
		if (constructorInfo == null)
		{
			constructorInfo = m_typeParent.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
		}
		if (constructorInfo == null)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NoParentDefaultConstructor"));
		}
		ConstructorBuilder constructorBuilder = DefineConstructor(attributes, CallingConventions.Standard, null);
		m_constructorCount++;
		ILGenerator iLGenerator = constructorBuilder.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Call, constructorInfo);
		iLGenerator.Emit(OpCodes.Ret);
		constructorBuilder.m_isDefaultConstructor = true;
		return constructorBuilder;
	}

	[ComVisible(true)]
	public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes)
	{
		return DefineConstructor(attributes, callingConvention, parameterTypes, null, null);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
	{
		if ((m_iAttr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask && (attributes & MethodAttributes.Static) != MethodAttributes.Static)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ConstructorNotAllowedOnInterface"));
		}
		lock (SyncRoot)
		{
			return DefineConstructorNoLock(attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers);
		}
	}

	[SecurityCritical]
	private ConstructorBuilder DefineConstructorNoLock(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
	{
		CheckContext(parameterTypes);
		CheckContext(requiredCustomModifiers);
		CheckContext(optionalCustomModifiers);
		ThrowIfCreated();
		string name = (((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope) ? ConstructorInfo.TypeConstructorName : ConstructorInfo.ConstructorName);
		attributes |= MethodAttributes.SpecialName;
		ConstructorBuilder result = new ConstructorBuilder(name, attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers, m_module, this);
		m_constructorCount++;
		return result;
	}

	[SecuritySafeCritical]
	public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		return DefinePInvokeMethodHelper(name, dllName, name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, nativeCallConv, nativeCharSet);
	}

	[SecuritySafeCritical]
	public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		return DefinePInvokeMethodHelper(name, dllName, entryName, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, nativeCallConv, nativeCharSet);
	}

	[SecuritySafeCritical]
	public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
	{
		return DefinePInvokeMethodHelper(name, dllName, entryName, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, nativeCallConv, nativeCharSet);
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, TypeAttributes.NestedPrivate, null, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
	{
		lock (SyncRoot)
		{
			CheckContext(parent);
			CheckContext(interfaces);
			return DefineNestedTypeNoLock(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, attr, parent, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, attr, null, null, PackingSize.Unspecified, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, attr, parent, null, PackingSize.Unspecified, typeSize);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, attr, parent, null, packSize, 0);
		}
	}

	[SecuritySafeCritical]
	public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize)
	{
		lock (SyncRoot)
		{
			return DefineNestedTypeNoLock(name, attr, parent, null, packSize, typeSize);
		}
	}

	[SecurityCritical]
	private TypeBuilder DefineNestedTypeNoLock(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packSize, int typeSize)
	{
		return new TypeBuilder(name, attr, parent, interfaces, m_module, packSize, typeSize, this);
	}

	public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes)
	{
		return DefineField(fieldName, type, null, null, attributes);
	}

	[SecuritySafeCritical]
	public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
	{
		lock (SyncRoot)
		{
			return DefineFieldNoLock(fieldName, type, requiredCustomModifiers, optionalCustomModifiers, attributes);
		}
	}

	[SecurityCritical]
	private FieldBuilder DefineFieldNoLock(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
	{
		ThrowIfCreated();
		CheckContext(type);
		CheckContext(requiredCustomModifiers);
		if (m_enumUnderlyingType == null && IsEnum && (attributes & FieldAttributes.Static) == 0)
		{
			m_enumUnderlyingType = type;
		}
		return new FieldBuilder(this, fieldName, type, requiredCustomModifiers, optionalCustomModifiers, attributes);
	}

	[SecuritySafeCritical]
	public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
	{
		lock (SyncRoot)
		{
			return DefineInitializedDataNoLock(name, data, attributes);
		}
	}

	[SecurityCritical]
	private FieldBuilder DefineInitializedDataNoLock(string name, byte[] data, FieldAttributes attributes)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return DefineDataHelper(name, data, data.Length, attributes);
	}

	[SecuritySafeCritical]
	public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
	{
		lock (SyncRoot)
		{
			return DefineUninitializedDataNoLock(name, size, attributes);
		}
	}

	[SecurityCritical]
	private FieldBuilder DefineUninitializedDataNoLock(string name, int size, FieldAttributes attributes)
	{
		return DefineDataHelper(name, null, size, attributes);
	}

	public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes)
	{
		return DefineProperty(name, attributes, returnType, null, null, parameterTypes, null, null);
	}

	public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
	{
		return DefineProperty(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
	}

	public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		return DefineProperty(name, attributes, (CallingConventions)0, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
	}

	[SecuritySafeCritical]
	public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		lock (SyncRoot)
		{
			return DefinePropertyNoLock(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}
	}

	[SecurityCritical]
	private PropertyBuilder DefinePropertyNoLock(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		CheckContext(returnType);
		CheckContext(returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes);
		CheckContext(parameterTypeRequiredCustomModifiers);
		CheckContext(parameterTypeOptionalCustomModifiers);
		ThrowIfCreated();
		SignatureHelper propertySigHelper = SignatureHelper.GetPropertySigHelper(m_module, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		int length;
		byte[] signature = propertySigHelper.InternalGetSignature(out length);
		return new PropertyBuilder(prToken: new PropertyToken(DefineProperty(m_module.GetNativeHandle(), m_tdType.Token, name, attributes, signature, length)), mod: m_module, name: name, sig: propertySigHelper, attr: attributes, returnType: returnType, containingType: this);
	}

	[SecuritySafeCritical]
	public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype)
	{
		lock (SyncRoot)
		{
			return DefineEventNoLock(name, attributes, eventtype);
		}
	}

	[SecurityCritical]
	private EventBuilder DefineEventNoLock(string name, EventAttributes attributes, Type eventtype)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (name[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalName"), "name");
		}
		CheckContext(eventtype);
		ThrowIfCreated();
		int token = m_module.GetTypeTokenInternal(eventtype).Token;
		return new EventBuilder(evToken: new EventToken(DefineEvent(m_module.GetNativeHandle(), m_tdType.Token, name, attributes, token)), mod: m_module, name: name, attr: attributes, type: this);
	}

	[SecuritySafeCritical]
	public TypeInfo CreateTypeInfo()
	{
		lock (SyncRoot)
		{
			return CreateTypeNoLock();
		}
	}

	[SecuritySafeCritical]
	public Type CreateType()
	{
		lock (SyncRoot)
		{
			return CreateTypeNoLock();
		}
	}

	internal void CheckContext(params Type[][] typess)
	{
		m_module.CheckContext(typess);
	}

	internal void CheckContext(params Type[] types)
	{
		m_module.CheckContext(types);
	}

	[SecurityCritical]
	private TypeInfo CreateTypeNoLock()
	{
		if (IsCreated())
		{
			return m_bakedRuntimeType;
		}
		ThrowIfCreated();
		if (m_typeInterfaces == null)
		{
			m_typeInterfaces = new List<Type>();
		}
		int[] array = new int[m_typeInterfaces.Count];
		for (int i = 0; i < m_typeInterfaces.Count; i++)
		{
			array[i] = m_module.GetTypeTokenInternal(m_typeInterfaces[i]).Token;
		}
		int num = 0;
		if (m_typeParent != null)
		{
			num = m_module.GetTypeTokenInternal(m_typeParent).Token;
		}
		if (IsGenericParameter)
		{
			int[] array2;
			if (m_typeParent != null)
			{
				array2 = new int[m_typeInterfaces.Count + 2];
				array2[array2.Length - 2] = num;
			}
			else
			{
				array2 = new int[m_typeInterfaces.Count + 1];
			}
			for (int j = 0; j < m_typeInterfaces.Count; j++)
			{
				array2[j] = m_module.GetTypeTokenInternal(m_typeInterfaces[j]).Token;
			}
			int tkParent = ((m_declMeth == null) ? m_DeclaringType.m_tdType.Token : m_declMeth.GetToken().Token);
			m_tdType = new TypeToken(DefineGenericParam(m_module.GetNativeHandle(), m_strName, tkParent, m_genParamAttributes, m_genParamPos, array2));
			if (m_ca != null)
			{
				foreach (CustAttr item in m_ca)
				{
					item.Bake(m_module, MetadataTokenInternal);
				}
			}
			m_hasBeenCreated = true;
			return this;
		}
		if ((m_tdType.Token & 0xFFFFFF) != 0 && (num & 0xFFFFFF) != 0)
		{
			SetParentType(m_module.GetNativeHandle(), m_tdType.Token, num);
		}
		if (m_inst != null)
		{
			GenericTypeParameterBuilder[] inst = m_inst;
			foreach (Type type in inst)
			{
				if (type is GenericTypeParameterBuilder)
				{
					((GenericTypeParameterBuilder)type).m_type.CreateType();
				}
			}
		}
		if (!m_isHiddenGlobalType && m_constructorCount == 0 && (m_iAttr & TypeAttributes.ClassSemanticsMask) == 0 && !base.IsValueType && (m_iAttr & (TypeAttributes.Abstract | TypeAttributes.Sealed)) != (TypeAttributes.Abstract | TypeAttributes.Sealed))
		{
			DefineDefaultConstructor(MethodAttributes.Public);
		}
		int count = m_listMethods.Count;
		for (int l = 0; l < count; l++)
		{
			MethodBuilder methodBuilder = m_listMethods[l];
			if (methodBuilder.IsGenericMethodDefinition)
			{
				methodBuilder.GetToken();
			}
			MethodAttributes attributes = methodBuilder.Attributes;
			if ((methodBuilder.GetMethodImplementationFlags() & (MethodImplAttributes)135) != MethodImplAttributes.IL || (attributes & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				continue;
			}
			int signatureLength;
			byte[] localSignature = methodBuilder.GetLocalSignature(out signatureLength);
			if ((attributes & MethodAttributes.Abstract) != MethodAttributes.PrivateScope && (m_iAttr & TypeAttributes.Abstract) == 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadTypeAttributesNotAbstract"));
			}
			byte[] body = methodBuilder.GetBody();
			if ((attributes & MethodAttributes.Abstract) != MethodAttributes.PrivateScope)
			{
				if (body != null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadMethodBody"));
				}
			}
			else if (body == null || body.Length == 0)
			{
				if (methodBuilder.m_ilGenerator != null)
				{
					methodBuilder.CreateMethodBodyHelper(methodBuilder.GetILGenerator());
				}
				body = methodBuilder.GetBody();
				if ((body == null || body.Length == 0) && !methodBuilder.m_canBeRuntimeImpl)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadEmptyMethodBody", methodBuilder.Name));
				}
			}
			int maxStack = methodBuilder.GetMaxStack();
			ExceptionHandler[] exceptionHandlers = methodBuilder.GetExceptionHandlers();
			int[] tokenFixups = methodBuilder.GetTokenFixups();
			SetMethodIL(m_module.GetNativeHandle(), methodBuilder.GetToken().Token, methodBuilder.InitLocals, body, (body != null) ? body.Length : 0, localSignature, signatureLength, maxStack, exceptionHandlers, (exceptionHandlers != null) ? exceptionHandlers.Length : 0, tokenFixups, (tokenFixups != null) ? tokenFixups.Length : 0);
			if (m_module.ContainingAssemblyBuilder.m_assemblyData.m_access == AssemblyBuilderAccess.Run)
			{
				methodBuilder.ReleaseBakedStructures();
			}
		}
		m_hasBeenCreated = true;
		RuntimeType o = null;
		TermCreateClass(m_module.GetNativeHandle(), m_tdType.Token, JitHelpers.GetObjectHandleOnStack(ref o));
		if (!m_isHiddenGlobalType)
		{
			m_bakedRuntimeType = o;
			if (m_DeclaringType != null && m_DeclaringType.m_bakedRuntimeType != null)
			{
				m_DeclaringType.m_bakedRuntimeType.InvalidateCachedNestedType();
			}
			return o;
		}
		return null;
	}

	public void SetParent(Type parent)
	{
		ThrowIfCreated();
		if (parent != null)
		{
			CheckContext(parent);
			if (parent.IsInterface)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_CannotSetParentToInterface"));
			}
			m_typeParent = parent;
		}
		else if ((m_iAttr & TypeAttributes.ClassSemanticsMask) != TypeAttributes.ClassSemanticsMask)
		{
			m_typeParent = typeof(object);
		}
		else
		{
			if ((m_iAttr & TypeAttributes.Abstract) == 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadInterfaceNotAbstract"));
			}
			m_typeParent = null;
		}
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public void AddInterfaceImplementation(Type interfaceType)
	{
		if (interfaceType == null)
		{
			throw new ArgumentNullException("interfaceType");
		}
		CheckContext(interfaceType);
		ThrowIfCreated();
		TypeToken typeTokenInternal = m_module.GetTypeTokenInternal(interfaceType);
		AddInterfaceImpl(m_module.GetNativeHandle(), m_tdType.Token, typeTokenInternal.Token);
		m_typeInterfaces.Add(interfaceType);
	}

	[SecuritySafeCritical]
	public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
	{
		lock (SyncRoot)
		{
			AddDeclarativeSecurityNoLock(action, pset);
		}
	}

	[SecurityCritical]
	private void AddDeclarativeSecurityNoLock(SecurityAction action, PermissionSet pset)
	{
		if (pset == null)
		{
			throw new ArgumentNullException("pset");
		}
		if (!Enum.IsDefined(typeof(SecurityAction), action) || action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
		{
			throw new ArgumentOutOfRangeException("action");
		}
		ThrowIfCreated();
		byte[] array = null;
		int cb = 0;
		if (!pset.IsEmpty())
		{
			array = pset.EncodeXml();
			cb = array.Length;
		}
		AddDeclarativeSecurity(m_module.GetNativeHandle(), m_tdType.Token, action, array, cb);
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
		DefineCustomAttribute(m_module, m_tdType.Token, m_module.GetConstructorToken(con).Token, binaryAttribute, toDisk: false, updateCompilerFlags: false);
	}

	[SecuritySafeCritical]
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		if (customBuilder == null)
		{
			throw new ArgumentNullException("customBuilder");
		}
		customBuilder.CreateCustomAttribute(m_module, m_tdType.Token);
	}

	void _TypeBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _TypeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _TypeBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _TypeBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
