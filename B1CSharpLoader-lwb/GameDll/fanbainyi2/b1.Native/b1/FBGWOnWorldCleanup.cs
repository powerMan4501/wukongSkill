using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BGWOnWorldCleanup__DelegateSignature")]
public class FBGWOnWorldCleanup : FMulticastDelegate<FBGWOnWorldCleanup.Signature>
{
	public delegate void Signature(UWorld World, bool bSessionEnded, bool bCleanupResources);

	private static bool BGWOnWorldCleanup__DelegateSignature_IsValid;

	private static IntPtr BGWOnWorldCleanup__DelegateSignature_FunctionAddress;

	private static int BGWOnWorldCleanup__DelegateSignature_ParamsSize;

	private static bool BGWOnWorldCleanup__DelegateSignature_World_IsValid;

	private static FFieldAddress BGWOnWorldCleanup__DelegateSignature_World_PropertyAddress;

	private static int BGWOnWorldCleanup__DelegateSignature_World_Offset;

	private static bool BGWOnWorldCleanup__DelegateSignature_bSessionEnded_IsValid;

	private static FFieldAddress BGWOnWorldCleanup__DelegateSignature_bSessionEnded_PropertyAddress;

	private static int BGWOnWorldCleanup__DelegateSignature_bSessionEnded_Offset;

	private static bool BGWOnWorldCleanup__DelegateSignature_bCleanupResources_IsValid;

	private static FFieldAddress BGWOnWorldCleanup__DelegateSignature_bCleanupResources_PropertyAddress;

	private static int BGWOnWorldCleanup__DelegateSignature_bCleanupResources_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGWOnWorldCleanup()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGWOnWorldCleanup__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGWOnWorldCleanup__DelegateSignature");
		BGWOnWorldCleanup__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWOnWorldCleanup__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWOnWorldCleanup__DelegateSignature_World_PropertyAddress, BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "World");
		BGWOnWorldCleanup__DelegateSignature_World_Offset = NativeReflectionCached.GetPropertyOffset(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "World");
		BGWOnWorldCleanup__DelegateSignature_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWOnWorldCleanup__DelegateSignature_bSessionEnded_PropertyAddress, BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bSessionEnded");
		BGWOnWorldCleanup__DelegateSignature_bSessionEnded_Offset = NativeReflectionCached.GetPropertyOffset(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bSessionEnded");
		BGWOnWorldCleanup__DelegateSignature_bSessionEnded_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bSessionEnded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWOnWorldCleanup__DelegateSignature_bCleanupResources_PropertyAddress, BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bCleanupResources");
		BGWOnWorldCleanup__DelegateSignature_bCleanupResources_Offset = NativeReflectionCached.GetPropertyOffset(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bCleanupResources");
		BGWOnWorldCleanup__DelegateSignature_bCleanupResources_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWOnWorldCleanup__DelegateSignature_FunctionAddress, "bCleanupResources", Classes.FBoolProperty);
		BGWOnWorldCleanup__DelegateSignature_IsValid = BGWOnWorldCleanup__DelegateSignature_FunctionAddress != IntPtr.Zero && BGWOnWorldCleanup__DelegateSignature_World_IsValid && BGWOnWorldCleanup__DelegateSignature_bSessionEnded_IsValid && BGWOnWorldCleanup__DelegateSignature_bCleanupResources_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnWorldCleanup__DelegateSignature", BGWOnWorldCleanup__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UWorld World, bool bSessionEnded, bool bCleanupResources)
	{
		if (!BGWOnWorldCleanup__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnWorldCleanup__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGWOnWorldCleanup__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWOnWorldCleanup__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGWOnWorldCleanup__DelegateSignature_World_Offset), 0, BGWOnWorldCleanup__DelegateSignature_World_PropertyAddress.Address, World);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWOnWorldCleanup__DelegateSignature_bSessionEnded_Offset), 0, BGWOnWorldCleanup__DelegateSignature_bSessionEnded_PropertyAddress.Address, bSessionEnded);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWOnWorldCleanup__DelegateSignature_bCleanupResources_Offset), 0, BGWOnWorldCleanup__DelegateSignature_bCleanupResources_PropertyAddress.Address, bCleanupResources);
			ProcessDelegate(intPtr);
		}
	}
}
