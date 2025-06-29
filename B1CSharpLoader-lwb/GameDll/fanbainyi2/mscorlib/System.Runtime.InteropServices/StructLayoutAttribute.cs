using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class StructLayoutAttribute : Attribute
{
	private const int DEFAULT_PACKING_SIZE = 8;

	internal LayoutKind _val;

	[__DynamicallyInvokable]
	public int Pack;

	[__DynamicallyInvokable]
	public int Size;

	[__DynamicallyInvokable]
	public CharSet CharSet;

	[__DynamicallyInvokable]
	public LayoutKind Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(RuntimeType type)
	{
		if (!IsDefined(type))
		{
			return null;
		}
		int packSize = 0;
		int classSize = 0;
		LayoutKind layoutKind = LayoutKind.Auto;
		switch (type.Attributes & TypeAttributes.LayoutMask)
		{
		case TypeAttributes.ExplicitLayout:
			layoutKind = LayoutKind.Explicit;
			break;
		case TypeAttributes.NotPublic:
			layoutKind = LayoutKind.Auto;
			break;
		case TypeAttributes.SequentialLayout:
			layoutKind = LayoutKind.Sequential;
			break;
		}
		CharSet charSet = CharSet.None;
		switch (type.Attributes & TypeAttributes.StringFormatMask)
		{
		case TypeAttributes.NotPublic:
			charSet = CharSet.Ansi;
			break;
		case TypeAttributes.AutoClass:
			charSet = CharSet.Auto;
			break;
		case TypeAttributes.UnicodeClass:
			charSet = CharSet.Unicode;
			break;
		}
		type.GetRuntimeModule().MetadataImport.GetClassLayout(type.MetadataToken, out packSize, out classSize);
		if (packSize == 0)
		{
			packSize = 8;
		}
		return new StructLayoutAttribute(layoutKind, packSize, classSize, charSet);
	}

	internal static bool IsDefined(RuntimeType type)
	{
		if (type.IsInterface || type.HasElementType || type.IsGenericParameter)
		{
			return false;
		}
		return true;
	}

	internal StructLayoutAttribute(LayoutKind layoutKind, int pack, int size, CharSet charSet)
	{
		_val = layoutKind;
		Pack = pack;
		Size = size;
		CharSet = charSet;
	}

	[__DynamicallyInvokable]
	public StructLayoutAttribute(LayoutKind layoutKind)
	{
		_val = layoutKind;
	}

	public StructLayoutAttribute(short layoutKind)
	{
		_val = (LayoutKind)layoutKind;
	}
}
