using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DllImportAttribute : Attribute
{
	internal string _val;

	[__DynamicallyInvokable]
	public string EntryPoint;

	[__DynamicallyInvokable]
	public CharSet CharSet;

	[__DynamicallyInvokable]
	public bool SetLastError;

	[__DynamicallyInvokable]
	public bool ExactSpelling;

	[__DynamicallyInvokable]
	public bool PreserveSig;

	[__DynamicallyInvokable]
	public CallingConvention CallingConvention;

	[__DynamicallyInvokable]
	public bool BestFitMapping;

	[__DynamicallyInvokable]
	public bool ThrowOnUnmappableChar;

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
	{
		if ((method.Attributes & MethodAttributes.PinvokeImpl) == 0)
		{
			return null;
		}
		MetadataImport metadataImport = ModuleHandle.GetMetadataImport(method.Module.ModuleHandle.GetRuntimeModule());
		string importDll = null;
		int metadataToken = method.MetadataToken;
		PInvokeAttributes attributes = PInvokeAttributes.CharSetNotSpec;
		metadataImport.GetPInvokeMap(metadataToken, out attributes, out var importName, out importDll);
		CharSet charSet = CharSet.None;
		switch (attributes & PInvokeAttributes.CharSetMask)
		{
		case PInvokeAttributes.CharSetNotSpec:
			charSet = CharSet.None;
			break;
		case PInvokeAttributes.CharSetAnsi:
			charSet = CharSet.Ansi;
			break;
		case PInvokeAttributes.CharSetUnicode:
			charSet = CharSet.Unicode;
			break;
		case PInvokeAttributes.CharSetMask:
			charSet = CharSet.Auto;
			break;
		}
		CallingConvention callingConvention = CallingConvention.Cdecl;
		switch (attributes & PInvokeAttributes.CallConvMask)
		{
		case PInvokeAttributes.CallConvWinapi:
			callingConvention = CallingConvention.Winapi;
			break;
		case PInvokeAttributes.CallConvCdecl:
			callingConvention = CallingConvention.Cdecl;
			break;
		case PInvokeAttributes.CallConvStdcall:
			callingConvention = CallingConvention.StdCall;
			break;
		case PInvokeAttributes.CallConvThiscall:
			callingConvention = CallingConvention.ThisCall;
			break;
		case PInvokeAttributes.CallConvFastcall:
			callingConvention = CallingConvention.FastCall;
			break;
		}
		bool exactSpelling = (attributes & PInvokeAttributes.NoMangle) != 0;
		bool setLastError = (attributes & PInvokeAttributes.SupportsLastError) != 0;
		bool bestFitMapping = (attributes & PInvokeAttributes.BestFitMask) == PInvokeAttributes.BestFitEnabled;
		bool throwOnUnmappableChar = (attributes & PInvokeAttributes.ThrowOnUnmappableCharMask) == PInvokeAttributes.ThrowOnUnmappableCharEnabled;
		bool preserveSig = (method.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) != 0;
		return new DllImportAttribute(importDll, importName, charSet, exactSpelling, setLastError, preserveSig, callingConvention, bestFitMapping, throwOnUnmappableChar);
	}

	internal static bool IsDefined(RuntimeMethodInfo method)
	{
		return (method.Attributes & MethodAttributes.PinvokeImpl) != 0;
	}

	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
	{
		_val = dllName;
		EntryPoint = entryPoint;
		CharSet = charSet;
		ExactSpelling = exactSpelling;
		SetLastError = setLastError;
		PreserveSig = preserveSig;
		CallingConvention = callingConvention;
		BestFitMapping = bestFitMapping;
		ThrowOnUnmappableChar = throwOnUnmappableChar;
	}

	[__DynamicallyInvokable]
	public DllImportAttribute(string dllName)
	{
		_val = dllName;
	}
}
