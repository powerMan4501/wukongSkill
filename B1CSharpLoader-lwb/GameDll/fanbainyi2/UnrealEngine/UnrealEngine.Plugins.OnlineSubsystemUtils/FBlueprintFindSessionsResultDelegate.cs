using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.BlueprintFindSessionsResultDelegate__DelegateSignature")]
public class FBlueprintFindSessionsResultDelegate : FMulticastDelegate<FBlueprintFindSessionsResultDelegate.Signature>
{
	public delegate void Signature(List<FBlueprintSessionResult> Results);

	private static bool BlueprintFindSessionsResultDelegate__DelegateSignature_IsValid;

	private static IntPtr BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress;

	private static int BlueprintFindSessionsResultDelegate__DelegateSignature_ParamsSize;

	private static bool BlueprintFindSessionsResultDelegate__DelegateSignature_Results_IsValid;

	private static FFieldAddress BlueprintFindSessionsResultDelegate__DelegateSignature_Results_PropertyAddress;

	private static int BlueprintFindSessionsResultDelegate__DelegateSignature_Results_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBlueprintFindSessionsResultDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.BlueprintFindSessionsResultDelegate__DelegateSignature");
		BlueprintFindSessionsResultDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintFindSessionsResultDelegate__DelegateSignature_Results_PropertyAddress, BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress, "Results");
		BlueprintFindSessionsResultDelegate__DelegateSignature_Results_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress, "Results");
		BlueprintFindSessionsResultDelegate__DelegateSignature_Results_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress, "Results", Classes.FArrayProperty);
		BlueprintFindSessionsResultDelegate__DelegateSignature_IsValid = BlueprintFindSessionsResultDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && BlueprintFindSessionsResultDelegate__DelegateSignature_Results_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.BlueprintFindSessionsResultDelegate__DelegateSignature", BlueprintFindSessionsResultDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FBlueprintSessionResult> Results)
	{
		if (!BlueprintFindSessionsResultDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.BlueprintFindSessionsResultDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BlueprintFindSessionsResultDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintFindSessionsResultDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FBlueprintSessionResult>(1, BlueprintFindSessionsResultDelegate__DelegateSignature_Results_PropertyAddress, CachedMarshalingDelegates<FBlueprintSessionResult, FBlueprintSessionResult>.FromNative, CachedMarshalingDelegates<FBlueprintSessionResult, FBlueprintSessionResult>.ToNative).ToNative(IntPtr.Add(intPtr, BlueprintFindSessionsResultDelegate__DelegateSignature_Results_Offset), Results);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(BlueprintFindSessionsResultDelegate__DelegateSignature_Results_PropertyAddress.Address, intPtr);
		}
	}
}
