using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature")]
public class FPerceptionUpdatedDelegate : FMulticastDelegate<FPerceptionUpdatedDelegate.Signature>
{
	public delegate void Signature(List<AActor> UpdatedActors);

	private static bool PerceptionUpdatedDelegate__DelegateSignature_IsValid;

	private static IntPtr PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress;

	private static int PerceptionUpdatedDelegate__DelegateSignature_ParamsSize;

	private static bool PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_IsValid;

	private static FFieldAddress PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_PropertyAddress;

	private static int PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPerceptionUpdatedDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature");
		PerceptionUpdatedDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_PropertyAddress, PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdatedActors");
		PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_Offset = NativeReflectionCached.GetPropertyOffset(PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdatedActors");
		PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_IsValid = NativeReflectionCached.ValidatePropertyClass(PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdatedActors", Classes.FArrayProperty);
		PerceptionUpdatedDelegate__DelegateSignature_IsValid = PerceptionUpdatedDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature", PerceptionUpdatedDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<AActor> UpdatedActors)
	{
		if (!PerceptionUpdatedDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PerceptionUpdatedDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerceptionUpdatedDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<AActor>(1, PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_Offset), UpdatedActors);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(PerceptionUpdatedDelegate__DelegateSignature_UpdatedActors_PropertyAddress.Address, intPtr);
		}
	}
}
