using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BGW_AsyncLoadClass_CS__DelegateSignature")]
public class FBGW_AsyncLoadClass_CS : FDelegate<FBGW_AsyncLoadClass_CS.Signature>
{
	public delegate void Signature(TSubclassOf<UObject> uClass);

	private static bool BGW_AsyncLoadClass_CS__DelegateSignature_IsValid;

	private static IntPtr BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress;

	private static int BGW_AsyncLoadClass_CS__DelegateSignature_ParamsSize;

	private static bool BGW_AsyncLoadClass_CS__DelegateSignature_uClass_IsValid;

	private static FFieldAddress BGW_AsyncLoadClass_CS__DelegateSignature_uClass_PropertyAddress;

	private static int BGW_AsyncLoadClass_CS__DelegateSignature_uClass_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGW_AsyncLoadClass_CS()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGW_AsyncLoadClass_CS__DelegateSignature");
		BGW_AsyncLoadClass_CS__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGW_AsyncLoadClass_CS__DelegateSignature_uClass_PropertyAddress, BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress, "uClass");
		BGW_AsyncLoadClass_CS__DelegateSignature_uClass_Offset = NativeReflectionCached.GetPropertyOffset(BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress, "uClass");
		BGW_AsyncLoadClass_CS__DelegateSignature_uClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress, "uClass", Classes.FClassProperty);
		BGW_AsyncLoadClass_CS__DelegateSignature_IsValid = BGW_AsyncLoadClass_CS__DelegateSignature_FunctionAddress != IntPtr.Zero && BGW_AsyncLoadClass_CS__DelegateSignature_uClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGW_AsyncLoadClass_CS__DelegateSignature", BGW_AsyncLoadClass_CS__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(TSubclassOf<UObject> uClass)
	{
		if (!BGW_AsyncLoadClass_CS__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGW_AsyncLoadClass_CS__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGW_AsyncLoadClass_CS__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGW_AsyncLoadClass_CS__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGW_AsyncLoadClass_CS__DelegateSignature_uClass_Offset), 0, BGW_AsyncLoadClass_CS__DelegateSignature_uClass_PropertyAddress.Address, uClass);
			ProcessDelegate(intPtr);
		}
	}
}
