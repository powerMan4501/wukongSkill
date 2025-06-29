using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnActorReady__DelegateSignature")]
public class FOnActorReady : FDelegate<FOnActorReady.Signature>
{
	public delegate FActorInstanceHandle Signature(FActorInstanceHandle InHandle);

	private static bool OnActorReady__DelegateSignature_IsValid;

	private static IntPtr OnActorReady__DelegateSignature_FunctionAddress;

	private static int OnActorReady__DelegateSignature_ParamsSize;

	private static bool OnActorReady__DelegateSignature_InHandle_IsValid;

	private static FFieldAddress OnActorReady__DelegateSignature_InHandle_PropertyAddress;

	private static int OnActorReady__DelegateSignature_InHandle_Offset;

	private static bool OnActorReady__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress OnActorReady__DelegateSignature_ReturnValue_PropertyAddress;

	private static int OnActorReady__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnActorReady()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnActorReady__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnActorReady__DelegateSignature");
		OnActorReady__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorReady__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnActorReady__DelegateSignature_InHandle_PropertyAddress, OnActorReady__DelegateSignature_FunctionAddress, "InHandle");
		OnActorReady__DelegateSignature_InHandle_Offset = NativeReflectionCached.GetPropertyOffset(OnActorReady__DelegateSignature_FunctionAddress, "InHandle");
		OnActorReady__DelegateSignature_InHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(OnActorReady__DelegateSignature_FunctionAddress, "InHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnActorReady__DelegateSignature_ReturnValue_PropertyAddress, OnActorReady__DelegateSignature_FunctionAddress, "ReturnValue");
		OnActorReady__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnActorReady__DelegateSignature_FunctionAddress, "ReturnValue");
		OnActorReady__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnActorReady__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnActorReady__DelegateSignature_IsValid = OnActorReady__DelegateSignature_FunctionAddress != IntPtr.Zero && OnActorReady__DelegateSignature_InHandle_IsValid && OnActorReady__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnActorReady__DelegateSignature", OnActorReady__DelegateSignature_IsValid);
	}

	private unsafe FActorInstanceHandle Invoker(FActorInstanceHandle InHandle)
	{
		if (!OnActorReady__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnActorReady__DelegateSignature");
			return default(FActorInstanceHandle);
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnActorReady__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnActorReady__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnActorReady__DelegateSignature_InHandle_PropertyAddress.Address, intPtr);
			FActorInstanceHandle.ToNative(IntPtr.Add(intPtr, OnActorReady__DelegateSignature_InHandle_Offset), 0, OnActorReady__DelegateSignature_InHandle_PropertyAddress.Address, InHandle);
			ProcessDelegate(intPtr);
			return FActorInstanceHandle.FromNative(IntPtr.Add(intPtr, OnActorReady__DelegateSignature_ReturnValue_Offset), 0, OnActorReady__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return default(FActorInstanceHandle);
	}
}
