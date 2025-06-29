using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentWakeSignature__DelegateSignature")]
public class FComponentWakeSignature : FMulticastDelegate<FComponentWakeSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent WakingComponent, FName BoneName);

	private static bool ComponentWakeSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentWakeSignature__DelegateSignature_FunctionAddress;

	private static int ComponentWakeSignature__DelegateSignature_ParamsSize;

	private static bool ComponentWakeSignature__DelegateSignature_WakingComponent_IsValid;

	private static FFieldAddress ComponentWakeSignature__DelegateSignature_WakingComponent_PropertyAddress;

	private static int ComponentWakeSignature__DelegateSignature_WakingComponent_Offset;

	private static bool ComponentWakeSignature__DelegateSignature_BoneName_IsValid;

	private static FFieldAddress ComponentWakeSignature__DelegateSignature_BoneName_PropertyAddress;

	private static int ComponentWakeSignature__DelegateSignature_BoneName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentWakeSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentWakeSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentWakeSignature__DelegateSignature");
		ComponentWakeSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentWakeSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentWakeSignature__DelegateSignature_WakingComponent_PropertyAddress, ComponentWakeSignature__DelegateSignature_FunctionAddress, "WakingComponent");
		ComponentWakeSignature__DelegateSignature_WakingComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentWakeSignature__DelegateSignature_FunctionAddress, "WakingComponent");
		ComponentWakeSignature__DelegateSignature_WakingComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentWakeSignature__DelegateSignature_FunctionAddress, "WakingComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentWakeSignature__DelegateSignature_BoneName_PropertyAddress, ComponentWakeSignature__DelegateSignature_FunctionAddress, "BoneName");
		ComponentWakeSignature__DelegateSignature_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(ComponentWakeSignature__DelegateSignature_FunctionAddress, "BoneName");
		ComponentWakeSignature__DelegateSignature_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentWakeSignature__DelegateSignature_FunctionAddress, "BoneName", Classes.FNameProperty);
		ComponentWakeSignature__DelegateSignature_IsValid = ComponentWakeSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentWakeSignature__DelegateSignature_WakingComponent_IsValid && ComponentWakeSignature__DelegateSignature_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentWakeSignature__DelegateSignature", ComponentWakeSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent WakingComponent, FName BoneName)
	{
		if (!ComponentWakeSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentWakeSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentWakeSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentWakeSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentWakeSignature__DelegateSignature_WakingComponent_Offset), 0, ComponentWakeSignature__DelegateSignature_WakingComponent_PropertyAddress.Address, WakingComponent);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ComponentWakeSignature__DelegateSignature_BoneName_Offset), 0, ComponentWakeSignature__DelegateSignature_BoneName_PropertyAddress.Address, BoneName);
			ProcessDelegate(intPtr);
		}
	}
}
