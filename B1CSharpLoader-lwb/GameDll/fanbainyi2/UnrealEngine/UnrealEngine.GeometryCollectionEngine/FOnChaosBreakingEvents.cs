using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature")]
public class FOnChaosBreakingEvents : FMulticastDelegate<FOnChaosBreakingEvents.Signature>
{
	public delegate void Signature(List<FChaosBreakingEventData> BreakingEvents);

	private static bool OnChaosBreakingEvents__DelegateSignature_IsValid;

	private static IntPtr OnChaosBreakingEvents__DelegateSignature_FunctionAddress;

	private static int OnChaosBreakingEvents__DelegateSignature_ParamsSize;

	private static bool OnChaosBreakingEvents__DelegateSignature_BreakingEvents_IsValid;

	private static FFieldAddress OnChaosBreakingEvents__DelegateSignature_BreakingEvents_PropertyAddress;

	private static int OnChaosBreakingEvents__DelegateSignature_BreakingEvents_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosBreakingEvents()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosBreakingEvents__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature");
		OnChaosBreakingEvents__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosBreakingEvents__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosBreakingEvents__DelegateSignature_BreakingEvents_PropertyAddress, OnChaosBreakingEvents__DelegateSignature_FunctionAddress, "BreakingEvents");
		OnChaosBreakingEvents__DelegateSignature_BreakingEvents_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosBreakingEvents__DelegateSignature_FunctionAddress, "BreakingEvents");
		OnChaosBreakingEvents__DelegateSignature_BreakingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosBreakingEvents__DelegateSignature_FunctionAddress, "BreakingEvents", Classes.FArrayProperty);
		OnChaosBreakingEvents__DelegateSignature_IsValid = OnChaosBreakingEvents__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosBreakingEvents__DelegateSignature_BreakingEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature", OnChaosBreakingEvents__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FChaosBreakingEventData> BreakingEvents)
	{
		if (!OnChaosBreakingEvents__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosBreakingEvents__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosBreakingEvents__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FChaosBreakingEventData>(1, OnChaosBreakingEvents__DelegateSignature_BreakingEvents_PropertyAddress, CachedMarshalingDelegates<FChaosBreakingEventData, FChaosBreakingEventData>.FromNative, CachedMarshalingDelegates<FChaosBreakingEventData, FChaosBreakingEventData>.ToNative).ToNative(IntPtr.Add(intPtr, OnChaosBreakingEvents__DelegateSignature_BreakingEvents_Offset), BreakingEvents);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnChaosBreakingEvents__DelegateSignature_BreakingEvents_PropertyAddress.Address, intPtr);
		}
	}
}
