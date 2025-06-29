using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BGW_AsyncLoadObjects_CS__DelegateSignature")]
public class FBGW_AsyncLoadObjects_CS : FDelegate<FBGW_AsyncLoadObjects_CS.Signature>
{
	public delegate void Signature(List<FSoftObjectPath> objectsList);

	private static bool BGW_AsyncLoadObjects_CS__DelegateSignature_IsValid;

	private static IntPtr BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress;

	private static int BGW_AsyncLoadObjects_CS__DelegateSignature_ParamsSize;

	private static bool BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_IsValid;

	private static FFieldAddress BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_PropertyAddress;

	private static int BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGW_AsyncLoadObjects_CS()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGW_AsyncLoadObjects_CS__DelegateSignature");
		BGW_AsyncLoadObjects_CS__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_PropertyAddress, BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress, "objectsList");
		BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_Offset = NativeReflectionCached.GetPropertyOffset(BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress, "objectsList");
		BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_IsValid = NativeReflectionCached.ValidatePropertyClass(BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress, "objectsList", Classes.FArrayProperty);
		BGW_AsyncLoadObjects_CS__DelegateSignature_IsValid = BGW_AsyncLoadObjects_CS__DelegateSignature_FunctionAddress != IntPtr.Zero && BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGW_AsyncLoadObjects_CS__DelegateSignature", BGW_AsyncLoadObjects_CS__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FSoftObjectPath> objectsList)
	{
		if (!BGW_AsyncLoadObjects_CS__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGW_AsyncLoadObjects_CS__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGW_AsyncLoadObjects_CS__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGW_AsyncLoadObjects_CS__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FSoftObjectPath>(1, BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(intPtr, BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_Offset), objectsList);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(BGW_AsyncLoadObjects_CS__DelegateSignature_objectsList_PropertyAddress.Address, intPtr);
		}
	}
}
