using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

internal sealed class SymbolType : TypeInfo
{
	internal TypeKind m_typeKind;

	internal Type m_baseType;

	internal int m_cRank;

	internal int[] m_iaLowerBound;

	internal int[] m_iaUpperBound;

	private char[] m_bFormat;

	private bool m_isSzArray = true;

	internal override bool IsSzArray
	{
		get
		{
			if (m_cRank > 1)
			{
				return false;
			}
			return m_isSzArray;
		}
	}

	public override Guid GUID
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
		}
	}

	public override Module Module
	{
		get
		{
			Type baseType = m_baseType;
			while (baseType is SymbolType)
			{
				baseType = ((SymbolType)baseType).m_baseType;
			}
			return baseType.Module;
		}
	}

	public override Assembly Assembly
	{
		get
		{
			Type baseType = m_baseType;
			while (baseType is SymbolType)
			{
				baseType = ((SymbolType)baseType).m_baseType;
			}
			return baseType.Assembly;
		}
	}

	public override RuntimeTypeHandle TypeHandle
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
		}
	}

	public override string Name
	{
		get
		{
			string text = new string(m_bFormat);
			Type baseType = m_baseType;
			while (baseType is SymbolType)
			{
				text = new string(((SymbolType)baseType).m_bFormat) + text;
				baseType = ((SymbolType)baseType).m_baseType;
			}
			return baseType.Name + text;
		}
	}

	public override string FullName => TypeNameBuilder.ToString(this, TypeNameBuilder.Format.FullName);

	public override string AssemblyQualifiedName => TypeNameBuilder.ToString(this, TypeNameBuilder.Format.AssemblyQualifiedName);

	public override string Namespace => m_baseType.Namespace;

	public override Type BaseType => typeof(Array);

	public override bool IsConstructedGenericType => false;

	public override Type UnderlyingSystemType => this;

	public override bool IsAssignableFrom(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			return false;
		}
		return IsAssignableFrom(typeInfo.AsType());
	}

	internal static Type FormCompoundType(char[] bFormat, Type baseType, int curIndex)
	{
		if (bFormat == null || curIndex == bFormat.Length)
		{
			return baseType;
		}
		if (bFormat[curIndex] == '&')
		{
			SymbolType symbolType = new SymbolType(TypeKind.IsByRef);
			symbolType.SetFormat(bFormat, curIndex, 1);
			curIndex++;
			if (curIndex != bFormat.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_BadSigFormat"));
			}
			symbolType.SetElementType(baseType);
			return symbolType;
		}
		if (bFormat[curIndex] == '[')
		{
			SymbolType symbolType = new SymbolType(TypeKind.IsArray);
			int num = curIndex;
			curIndex++;
			int num2 = 0;
			int num3 = -1;
			while (bFormat[curIndex] != ']')
			{
				if (bFormat[curIndex] == '*')
				{
					symbolType.m_isSzArray = false;
					curIndex++;
				}
				if ((bFormat[curIndex] >= '0' && bFormat[curIndex] <= '9') || bFormat[curIndex] == '-')
				{
					bool flag = false;
					if (bFormat[curIndex] == '-')
					{
						flag = true;
						curIndex++;
					}
					while (bFormat[curIndex] >= '0' && bFormat[curIndex] <= '9')
					{
						num2 *= 10;
						num2 += bFormat[curIndex] - 48;
						curIndex++;
					}
					if (flag)
					{
						num2 = -num2;
					}
					num3 = num2 - 1;
				}
				if (bFormat[curIndex] == '.')
				{
					curIndex++;
					if (bFormat[curIndex] != '.')
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_BadSigFormat"));
					}
					curIndex++;
					if ((bFormat[curIndex] >= '0' && bFormat[curIndex] <= '9') || bFormat[curIndex] == '-')
					{
						bool flag2 = false;
						num3 = 0;
						if (bFormat[curIndex] == '-')
						{
							flag2 = true;
							curIndex++;
						}
						while (bFormat[curIndex] >= '0' && bFormat[curIndex] <= '9')
						{
							num3 *= 10;
							num3 += bFormat[curIndex] - 48;
							curIndex++;
						}
						if (flag2)
						{
							num3 = -num3;
						}
						if (num3 < num2)
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_BadSigFormat"));
						}
					}
				}
				if (bFormat[curIndex] == ',')
				{
					curIndex++;
					symbolType.SetBounds(num2, num3);
					num2 = 0;
					num3 = -1;
				}
				else if (bFormat[curIndex] != ']')
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_BadSigFormat"));
				}
			}
			symbolType.SetBounds(num2, num3);
			curIndex++;
			symbolType.SetFormat(bFormat, num, curIndex - num);
			symbolType.SetElementType(baseType);
			return FormCompoundType(bFormat, symbolType, curIndex);
		}
		if (bFormat[curIndex] == '*')
		{
			SymbolType symbolType = new SymbolType(TypeKind.IsPointer);
			symbolType.SetFormat(bFormat, curIndex, 1);
			curIndex++;
			symbolType.SetElementType(baseType);
			return FormCompoundType(bFormat, symbolType, curIndex);
		}
		return null;
	}

	internal SymbolType(TypeKind typeKind)
	{
		m_typeKind = typeKind;
		m_iaLowerBound = new int[4];
		m_iaUpperBound = new int[4];
	}

	internal void SetElementType(Type baseType)
	{
		if (baseType == null)
		{
			throw new ArgumentNullException("baseType");
		}
		m_baseType = baseType;
	}

	private void SetBounds(int lower, int upper)
	{
		if (lower != 0 || upper != -1)
		{
			m_isSzArray = false;
		}
		if (m_iaLowerBound.Length <= m_cRank)
		{
			int[] array = new int[m_cRank * 2];
			Array.Copy(m_iaLowerBound, array, m_cRank);
			m_iaLowerBound = array;
			Array.Copy(m_iaUpperBound, array, m_cRank);
			m_iaUpperBound = array;
		}
		m_iaLowerBound[m_cRank] = lower;
		m_iaUpperBound[m_cRank] = upper;
		m_cRank++;
	}

	internal void SetFormat(char[] bFormat, int curIndex, int length)
	{
		char[] array = new char[length];
		Array.Copy(bFormat, curIndex, array, 0, length);
		m_bFormat = array;
	}

	public override Type MakePointerType()
	{
		return FormCompoundType((new string(m_bFormat) + "*").ToCharArray(), m_baseType, 0);
	}

	public override Type MakeByRefType()
	{
		return FormCompoundType((new string(m_bFormat) + "&").ToCharArray(), m_baseType, 0);
	}

	public override Type MakeArrayType()
	{
		return FormCompoundType((new string(m_bFormat) + "[]").ToCharArray(), m_baseType, 0);
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
		return FormCompoundType((new string(m_bFormat) + text2).ToCharArray(), m_baseType, 0) as SymbolType;
	}

	public override int GetArrayRank()
	{
		if (!base.IsArray)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
		}
		return m_cRank;
	}

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override string ToString()
	{
		return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.ToString);
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override Type GetInterface(string name, bool ignoreCase)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override Type[] GetInterfaces()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override EventInfo[] GetEvents()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override Type[] GetNestedTypes(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	[ComVisible(true)]
	public override InterfaceMapping GetInterfaceMap(Type interfaceType)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		Type baseType = m_baseType;
		while (baseType is SymbolType)
		{
			baseType = ((SymbolType)baseType).m_baseType;
		}
		return baseType.Attributes;
	}

	protected override bool IsArrayImpl()
	{
		return m_typeKind == TypeKind.IsArray;
	}

	protected override bool IsPointerImpl()
	{
		return m_typeKind == TypeKind.IsPointer;
	}

	protected override bool IsByRefImpl()
	{
		return m_typeKind == TypeKind.IsByRef;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}

	protected override bool IsValueTypeImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	public override Type GetElementType()
	{
		return m_baseType;
	}

	protected override bool HasElementTypeImpl()
	{
		return m_baseType != null;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NonReflectedType"));
	}
}
