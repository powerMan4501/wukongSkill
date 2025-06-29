using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature")]
public class FOnChaosTrailingEvents : FMulticastDelegate<FOnChaosTrailingEvents.Signature>
{
	public delegate void Signature(List<FChaosTrailingEventData> TrailingEvents);

	private static bool OnChaosTrailingEvents__DelegateSignature_IsValid;

	private static IntPtr OnChaosTrailingEvents__DelegateSignature_FunctionAddress;

	private static int OnChaosTrailingEvents__DelegateSignature_ParamsSize;

	private static bool OnChaosTrailingEvents__DelegateSignature_TrailingEvents_IsValid;

	private static FFieldAddress OnChaosTrailingEvents__DelegateSignature_TrailingEvents_PropertyAddress;

	private static int OnChaosTrailingEvents__DelegateSignature_TrailingEvents_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosTrailingEvents()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosTrailingEvents__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature");
		OnChaosTrailingEvents__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosTrailingEvents__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosTrailingEvents__DelegateSignature_TrailingEvents_PropertyAddress, OnChaosTrailingEvents__DelegateSignature_FunctionAddress, "TrailingEvents");
		OnChaosTrailingEvents__DelegateSignature_TrailingEvents_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosTrailingEvents__DelegateSignature_FunctionAddress, "TrailingEvents");
		OnChaosTrailingEvents__DelegateSignature_TrailingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosTrailingEvents__DelegateSignature_FunctionAddress, "TrailingEvents", Classes.FArrayProperty);
		OnChaosTrailingEvents__DelegateSignature_IsValid = OnChaosTrailingEvents__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosTrailingEvents__DelegateSignature_TrailingEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature", OnChaosTrailingEvents__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FChaosTrailingEventData> TrailingEvents)
	{
		if (!OnChaosTrailingEvents__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosTrailingEvents__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosTrailingEvents__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FChaosTrailingEventData>(1, OnChaosTrailingEvents__DelegateSignature_TrailingEvents_PropertyAddress, CachedMarshalingDelegates<FChaosTrailingEventData, FChaosTrailingEventData>.FromNative, CachedMarshalingDelegates<FChaosTrailingEventData, FChaosTrailingEventData>.ToNative).ToNative(IntPtr.Add(intPtr, OnChaosTrailingEvents__DelegateSignature_TrailingEvents_Offset), TrailingEvents);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnChaosTrailingEvents__DelegateSignature_TrailingEvents_PropertyAddress.Address, intPtr);
		}
	}
}
