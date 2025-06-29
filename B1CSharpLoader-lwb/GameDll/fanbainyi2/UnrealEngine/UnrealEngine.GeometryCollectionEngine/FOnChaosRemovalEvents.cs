using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosRemovalEvents__DelegateSignature")]
public class FOnChaosRemovalEvents : FMulticastDelegate<FOnChaosRemovalEvents.Signature>
{
	public delegate void Signature(List<FChaosRemovalEventData> RemovalEvents);

	private static bool OnChaosRemovalEvents__DelegateSignature_IsValid;

	private static IntPtr OnChaosRemovalEvents__DelegateSignature_FunctionAddress;

	private static int OnChaosRemovalEvents__DelegateSignature_ParamsSize;

	private static bool OnChaosRemovalEvents__DelegateSignature_RemovalEvents_IsValid;

	private static FFieldAddress OnChaosRemovalEvents__DelegateSignature_RemovalEvents_PropertyAddress;

	private static int OnChaosRemovalEvents__DelegateSignature_RemovalEvents_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosRemovalEvents()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosRemovalEvents__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosRemovalEvents__DelegateSignature");
		OnChaosRemovalEvents__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosRemovalEvents__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosRemovalEvents__DelegateSignature_RemovalEvents_PropertyAddress, OnChaosRemovalEvents__DelegateSignature_FunctionAddress, "RemovalEvents");
		OnChaosRemovalEvents__DelegateSignature_RemovalEvents_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosRemovalEvents__DelegateSignature_FunctionAddress, "RemovalEvents");
		OnChaosRemovalEvents__DelegateSignature_RemovalEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosRemovalEvents__DelegateSignature_FunctionAddress, "RemovalEvents", Classes.FArrayProperty);
		OnChaosRemovalEvents__DelegateSignature_IsValid = OnChaosRemovalEvents__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosRemovalEvents__DelegateSignature_RemovalEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosRemovalEvents__DelegateSignature", OnChaosRemovalEvents__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FChaosRemovalEventData> RemovalEvents)
	{
		if (!OnChaosRemovalEvents__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosRemovalEvents__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosRemovalEvents__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosRemovalEvents__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FChaosRemovalEventData>(1, OnChaosRemovalEvents__DelegateSignature_RemovalEvents_PropertyAddress, CachedMarshalingDelegates<FChaosRemovalEventData, FChaosRemovalEventData>.FromNative, CachedMarshalingDelegates<FChaosRemovalEventData, FChaosRemovalEventData>.ToNative).ToNative(IntPtr.Add(intPtr, OnChaosRemovalEvents__DelegateSignature_RemovalEvents_Offset), RemovalEvents);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnChaosRemovalEvents__DelegateSignature_RemovalEvents_PropertyAddress.Address, intPtr);
		}
	}
}
