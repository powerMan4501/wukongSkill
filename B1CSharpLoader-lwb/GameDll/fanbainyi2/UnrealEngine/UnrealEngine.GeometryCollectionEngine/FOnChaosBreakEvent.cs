using System;
using System.Runtime.CompilerServices;
using UnrealEngine.ChaosSolverEngine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UDelegate]
[UMetaPath("/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature")]
public class FOnChaosBreakEvent : FMulticastDelegate<FOnChaosBreakEvent.Signature>
{
	public delegate void Signature(FChaosBreakEvent BreakEvent);

	private static bool OnChaosBreakEvent__DelegateSignature_IsValid;

	private static IntPtr OnChaosBreakEvent__DelegateSignature_FunctionAddress;

	private static int OnChaosBreakEvent__DelegateSignature_ParamsSize;

	private static bool OnChaosBreakEvent__DelegateSignature_BreakEvent_IsValid;

	private static FFieldAddress OnChaosBreakEvent__DelegateSignature_BreakEvent_PropertyAddress;

	private static int OnChaosBreakEvent__DelegateSignature_BreakEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosBreakEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosBreakEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature");
		OnChaosBreakEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosBreakEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosBreakEvent__DelegateSignature_BreakEvent_PropertyAddress, OnChaosBreakEvent__DelegateSignature_FunctionAddress, "BreakEvent");
		OnChaosBreakEvent__DelegateSignature_BreakEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosBreakEvent__DelegateSignature_FunctionAddress, "BreakEvent");
		OnChaosBreakEvent__DelegateSignature_BreakEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosBreakEvent__DelegateSignature_FunctionAddress, "BreakEvent", Classes.FStructProperty);
		OnChaosBreakEvent__DelegateSignature_IsValid = OnChaosBreakEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosBreakEvent__DelegateSignature_BreakEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature", OnChaosBreakEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FChaosBreakEvent BreakEvent)
	{
		if (!OnChaosBreakEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosBreakEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosBreakEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnChaosBreakEvent__DelegateSignature_BreakEvent_PropertyAddress.Address, intPtr);
			FChaosBreakEvent.ToNative(IntPtr.Add(intPtr, OnChaosBreakEvent__DelegateSignature_BreakEvent_Offset), 0, OnChaosBreakEvent__DelegateSignature_BreakEvent_PropertyAddress.Address, BreakEvent);
			ProcessDelegate(intPtr);
		}
	}
}
