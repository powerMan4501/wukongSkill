using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BGW_AsyncLoadObject_CS__DelegateSignature")]
public class FBGW_AsyncLoadObject_CS : FDelegate<FBGW_AsyncLoadObject_CS.Signature>
{
	public delegate void Signature(UObject uObject);

	private static bool BGW_AsyncLoadObject_CS__DelegateSignature_IsValid;

	private static IntPtr BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress;

	private static int BGW_AsyncLoadObject_CS__DelegateSignature_ParamsSize;

	private static bool BGW_AsyncLoadObject_CS__DelegateSignature_uObject_IsValid;

	private static FFieldAddress BGW_AsyncLoadObject_CS__DelegateSignature_uObject_PropertyAddress;

	private static int BGW_AsyncLoadObject_CS__DelegateSignature_uObject_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGW_AsyncLoadObject_CS()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGW_AsyncLoadObject_CS__DelegateSignature");
		BGW_AsyncLoadObject_CS__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGW_AsyncLoadObject_CS__DelegateSignature_uObject_PropertyAddress, BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress, "uObject");
		BGW_AsyncLoadObject_CS__DelegateSignature_uObject_Offset = NativeReflectionCached.GetPropertyOffset(BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress, "uObject");
		BGW_AsyncLoadObject_CS__DelegateSignature_uObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress, "uObject", Classes.FObjectProperty);
		BGW_AsyncLoadObject_CS__DelegateSignature_IsValid = BGW_AsyncLoadObject_CS__DelegateSignature_FunctionAddress != IntPtr.Zero && BGW_AsyncLoadObject_CS__DelegateSignature_uObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGW_AsyncLoadObject_CS__DelegateSignature", BGW_AsyncLoadObject_CS__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject uObject)
	{
		if (!BGW_AsyncLoadObject_CS__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGW_AsyncLoadObject_CS__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGW_AsyncLoadObject_CS__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGW_AsyncLoadObject_CS__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGW_AsyncLoadObject_CS__DelegateSignature_uObject_Offset), 0, BGW_AsyncLoadObject_CS__DelegateSignature_uObject_PropertyAddress.Address, uObject);
			ProcessDelegate(intPtr);
		}
	}
}
