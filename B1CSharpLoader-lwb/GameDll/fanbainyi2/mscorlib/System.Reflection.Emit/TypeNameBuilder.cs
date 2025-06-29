using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection.Emit;

internal class TypeNameBuilder
{
	internal enum Format
	{
		ToString,
		FullName,
		AssemblyQualifiedName
	}

	private IntPtr m_typeNameBuilder;

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr CreateTypeNameBuilder();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ReleaseTypeNameBuilder(IntPtr pAQN);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void OpenGenericArguments(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void CloseGenericArguments(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void OpenGenericArgument(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void CloseGenericArgument(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddName(IntPtr tnb, string name);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddPointer(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddByRef(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddSzArray(IntPtr tnb);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddArray(IntPtr tnb, int rank);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddAssemblySpec(IntPtr tnb, string assemblySpec);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ToString(IntPtr tnb, StringHandleOnStack retString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void Clear(IntPtr tnb);

	[SecuritySafeCritical]
	internal static string ToString(Type type, Format format)
	{
		if ((format == Format.FullName || format == Format.AssemblyQualifiedName) && !type.IsGenericTypeDefinition && type.ContainsGenericParameters)
		{
			return null;
		}
		TypeNameBuilder typeNameBuilder = new TypeNameBuilder(CreateTypeNameBuilder());
		typeNameBuilder.Clear();
		typeNameBuilder.ConstructAssemblyQualifiedNameWorker(type, format);
		string result = typeNameBuilder.ToString();
		typeNameBuilder.Dispose();
		return result;
	}

	private TypeNameBuilder(IntPtr typeNameBuilder)
	{
		m_typeNameBuilder = typeNameBuilder;
	}

	[SecurityCritical]
	internal void Dispose()
	{
		ReleaseTypeNameBuilder(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void AddElementType(Type elementType)
	{
		if (elementType.HasElementType)
		{
			AddElementType(elementType.GetElementType());
		}
		if (elementType.IsPointer)
		{
			AddPointer();
		}
		else if (elementType.IsByRef)
		{
			AddByRef();
		}
		else if (elementType.IsSzArray)
		{
			AddSzArray();
		}
		else if (elementType.IsArray)
		{
			AddArray(elementType.GetArrayRank());
		}
	}

	[SecurityCritical]
	private void ConstructAssemblyQualifiedNameWorker(Type type, Format format)
	{
		Type type2 = type;
		while (type2.HasElementType)
		{
			type2 = type2.GetElementType();
		}
		List<Type> list = new List<Type>();
		Type type3 = type2;
		while (type3 != null)
		{
			list.Add(type3);
			type3 = (type3.IsGenericParameter ? null : type3.DeclaringType);
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			Type type4 = list[num];
			string text = type4.Name;
			if (num == list.Count - 1 && type4.Namespace != null && type4.Namespace.Length != 0)
			{
				text = type4.Namespace + "." + text;
			}
			AddName(text);
		}
		if (type2.IsGenericType && (!type2.IsGenericTypeDefinition || format == Format.ToString))
		{
			Type[] genericArguments = type2.GetGenericArguments();
			OpenGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				Format format2 = ((format == Format.FullName) ? Format.AssemblyQualifiedName : format);
				OpenGenericArgument();
				ConstructAssemblyQualifiedNameWorker(genericArguments[i], format2);
				CloseGenericArgument();
			}
			CloseGenericArguments();
		}
		AddElementType(type);
		if (format == Format.AssemblyQualifiedName)
		{
			AddAssemblySpec(type.Module.Assembly.FullName);
		}
	}

	[SecurityCritical]
	private void OpenGenericArguments()
	{
		OpenGenericArguments(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void CloseGenericArguments()
	{
		CloseGenericArguments(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void OpenGenericArgument()
	{
		OpenGenericArgument(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void CloseGenericArgument()
	{
		CloseGenericArgument(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void AddName(string name)
	{
		AddName(m_typeNameBuilder, name);
	}

	[SecurityCritical]
	private void AddPointer()
	{
		AddPointer(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void AddByRef()
	{
		AddByRef(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void AddSzArray()
	{
		AddSzArray(m_typeNameBuilder);
	}

	[SecurityCritical]
	private void AddArray(int rank)
	{
		AddArray(m_typeNameBuilder, rank);
	}

	[SecurityCritical]
	private void AddAssemblySpec(string assemblySpec)
	{
		AddAssemblySpec(m_typeNameBuilder, assemblySpec);
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		string s = null;
		ToString(m_typeNameBuilder, JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[SecurityCritical]
	private void Clear()
	{
		Clear(m_typeNameBuilder);
	}
}
