using System;
using System.Runtime.CompilerServices;
using UnrealEngine.ChaosSolverEngine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosRemovalEvent__DelegateSignature")]
public class FOnChaosRemovalEvent : FMulticastDelegate<FOnChaosRemovalEvent.Signature>
{
	public delegate void Signature(FChaosRemovalEvent RemovalEvent);

	private static bool OnChaosRemovalEvent__DelegateSignature_IsValid;

	private static IntPtr OnChaosRemovalEvent__DelegateSignature_FunctionAddress;

	private static int OnChaosRemovalEvent__DelegateSignature_ParamsSize;

	private static bool OnChaosRemovalEvent__DelegateSignature_RemovalEvent_IsValid;

	private static FFieldAddress OnChaosRemovalEvent__DelegateSignature_RemovalEvent_PropertyAddress;

	private static int OnChaosRemovalEvent__DelegateSignature_RemovalEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosRemovalEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosRemovalEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosRemovalEvent__DelegateSignature");
		OnChaosRemovalEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosRemovalEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosRemovalEvent__DelegateSignature_RemovalEvent_PropertyAddress, OnChaosRemovalEvent__DelegateSignature_FunctionAddress, "RemovalEvent");
		OnChaosRemovalEvent__DelegateSignature_RemovalEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosRemovalEvent__DelegateSignature_FunctionAddress, "RemovalEvent");
		OnChaosRemovalEvent__DelegateSignature_RemovalEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosRemovalEvent__DelegateSignature_FunctionAddress, "RemovalEvent", Classes.FStructProperty);
		OnChaosRemovalEvent__DelegateSignature_IsValid = OnChaosRemovalEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosRemovalEvent__DelegateSignature_RemovalEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosRemovalEvent__DelegateSignature", OnChaosRemovalEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FChaosRemovalEvent RemovalEvent)
	{
		if (!OnChaosRemovalEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosRemovalEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosRemovalEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosRemovalEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnChaosRemovalEvent__DelegateSignature_RemovalEvent_PropertyAddress.Address, intPtr);
			FChaosRemovalEvent.ToNative(IntPtr.Add(intPtr, OnChaosRemovalEvent__DelegateSignature_RemovalEvent_Offset), 0, OnChaosRemovalEvent__DelegateSignature_RemovalEvent_PropertyAddress.Address, RemovalEvent);
			ProcessDelegate(intPtr);
		}
	}
}
