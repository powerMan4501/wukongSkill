using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature")]
public class FOnChaosCollisionEvents : FMulticastDelegate<FOnChaosCollisionEvents.Signature>
{
	public delegate void Signature(List<FChaosCollisionEventData> CollisionEvents);

	private static bool OnChaosCollisionEvents__DelegateSignature_IsValid;

	private static IntPtr OnChaosCollisionEvents__DelegateSignature_FunctionAddress;

	private static int OnChaosCollisionEvents__DelegateSignature_ParamsSize;

	private static bool OnChaosCollisionEvents__DelegateSignature_CollisionEvents_IsValid;

	private static FFieldAddress OnChaosCollisionEvents__DelegateSignature_CollisionEvents_PropertyAddress;

	private static int OnChaosCollisionEvents__DelegateSignature_CollisionEvents_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosCollisionEvents()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosCollisionEvents__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature");
		OnChaosCollisionEvents__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosCollisionEvents__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosCollisionEvents__DelegateSignature_CollisionEvents_PropertyAddress, OnChaosCollisionEvents__DelegateSignature_FunctionAddress, "CollisionEvents");
		OnChaosCollisionEvents__DelegateSignature_CollisionEvents_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosCollisionEvents__DelegateSignature_FunctionAddress, "CollisionEvents");
		OnChaosCollisionEvents__DelegateSignature_CollisionEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosCollisionEvents__DelegateSignature_FunctionAddress, "CollisionEvents", Classes.FArrayProperty);
		OnChaosCollisionEvents__DelegateSignature_IsValid = OnChaosCollisionEvents__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosCollisionEvents__DelegateSignature_CollisionEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature", OnChaosCollisionEvents__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FChaosCollisionEventData> CollisionEvents)
	{
		if (!OnChaosCollisionEvents__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosCollisionEvents__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosCollisionEvents__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FChaosCollisionEventData>(1, OnChaosCollisionEvents__DelegateSignature_CollisionEvents_PropertyAddress, CachedMarshalingDelegates<FChaosCollisionEventData, FChaosCollisionEventData>.FromNative, CachedMarshalingDelegates<FChaosCollisionEventData, FChaosCollisionEventData>.ToNative).ToNative(IntPtr.Add(intPtr, OnChaosCollisionEvents__DelegateSignature_CollisionEvents_Offset), CollisionEvents);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnChaosCollisionEvents__DelegateSignature_CollisionEvents_PropertyAddress.Address, intPtr);
		}
	}
}
