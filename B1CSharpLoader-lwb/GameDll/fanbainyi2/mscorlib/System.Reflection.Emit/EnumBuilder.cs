using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_EnumBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EnumBuilder : TypeInfo, _EnumBuilder
{
	internal TypeBuilder m_typeBuilder;

	private FieldBuilder m_underlyingField;

	public TypeToken TypeToken => m_typeBuilder.TypeToken;

	public FieldBuilder UnderlyingField => m_underlyingField;

	public override string Name => m_typeBuilder.Name;

	public override Guid GUID => m_typeBuilder.GUID;

	public override Module Module => m_typeBuilder.Module;

	public override Assembly Assembly => m_typeBuilder.Assembly;

	public override RuntimeTypeHandle TypeHandle => m_typeBuilder.TypeHandle;

	public override string FullName => m_typeBuilder.FullName;

	public override string AssemblyQualifiedName => m_typeBuilder.AssemblyQualifiedName;

	public override string Namespace => m_typeBuilder.Namespace;

	public override Type BaseType => m_typeBuilder.BaseType;

	public override bool IsConstructedGenericType => false;

	public override Type UnderlyingSystemType => GetEnumUnderlyingType();

	public override Type DeclaringType => m_typeBuilder.DeclaringType;

	public override Type ReflectedType => m_typeBuilder.ReflectedType;

	internal int MetadataTokenInternal => m_typeBuilder.MetadataTokenInternal;

	public override bool IsAssignableFrom(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			return false;
		}
		return IsAssignableFrom(typeInfo.AsType());
	}

	public FieldBuilder DefineLiteral(string literalName, object literalValue)
	{
		FieldBuilder fieldBuilder = m_typeBuilder.DefineField(literalName, this, FieldAttributes.Public | FieldAttributes.Static | FieldAttributes.Literal);
		fieldBuilder.SetConstant(literalValue);
		return fieldBuilder;
	}

	public TypeInfo CreateTypeInfo()
	{
		return m_typeBuilder.CreateTypeInfo();
	}

	public Type CreateType()
	{
		return m_typeBuilder.CreateType();
	}

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return m_typeBuilder.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return m_typeBuilder.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetConstructors(bindingAttr);
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (types == null)
		{
			return m_typeBuilder.GetMethod(name, bindingAttr);
		}
		return m_typeBuilder.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetMethods(bindingAttr);
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetField(name, bindingAttr);
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetFields(bindingAttr);
	}

	public override Type GetInterface(string name, bool ignoreCase)
	{
		return m_typeBuilder.GetInterface(name, ignoreCase);
	}

	public override Type[] GetInterfaces()
	{
		return m_typeBuilder.GetInterfaces();
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetEvent(name, bindingAttr);
	}

	public override EventInfo[] GetEvents()
	{
		return m_typeBuilder.GetEvents();
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetProperties(bindingAttr);
	}

	public override Type[] GetNestedTypes(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetNestedTypes(bindingAttr);
	}

	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetNestedType(name, bindingAttr);
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetMember(name, type, bindingAttr);
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetMembers(bindingAttr);
	}

	[ComVisible(true)]
	public override InterfaceMapping GetInterfaceMap(Type interfaceType)
	{
		return m_typeBuilder.GetInterfaceMap(interfaceType);
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return m_typeBuilder.GetEvents(bindingAttr);
	}

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return m_typeBuilder.Attributes;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}

	protected override bool IsValueTypeImpl()
	{
		return true;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	public override Type GetElementType()
	{
		return m_typeBuilder.GetElementType();
	}

	protected override bool HasElementTypeImpl()
	{
		return m_typeBuilder.HasElementType;
	}

	public override Type GetEnumUnderlyingType()
	{
		return m_underlyingField.FieldType;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return m_typeBuilder.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return m_typeBuilder.GetCustomAttributes(attributeType, inherit);
	}

	[ComVisible(true)]
	public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		m_typeBuilder.SetCustomAttribute(con, binaryAttribute);
	}

	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		m_typeBuilder.SetCustomAttribute(customBuilder);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return m_typeBuilder.IsDefined(attributeType, inherit);
	}

	private EnumBuilder()
	{
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

	[SecurityCritical]
	internal EnumBuilder(string name, Type underlyingType, TypeAttributes visibility, ModuleBuilder module)
	{
		if ((visibility & ~TypeAttributes.VisibilityMask) != TypeAttributes.NotPublic)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ShouldOnlySetVisibilityFlags"), "name");
		}
		m_typeBuilder = new TypeBuilder(name, visibility | TypeAttributes.Sealed, typeof(Enum), null, module, PackingSize.Unspecified, 0, null);
		m_underlyingField = m_typeBuilder.DefineField("value__", underlyingType, FieldAttributes.Public | FieldAttributes.SpecialName | FieldAttributes.RTSpecialName);
	}

	void _EnumBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _EnumBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _EnumBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _EnumBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
