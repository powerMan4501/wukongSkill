using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentSleepSignature__DelegateSignature")]
public class FComponentSleepSignature : FMulticastDelegate<FComponentSleepSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent SleepingComponent, FName BoneName);

	private static bool ComponentSleepSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentSleepSignature__DelegateSignature_FunctionAddress;

	private static int ComponentSleepSignature__DelegateSignature_ParamsSize;

	private static bool ComponentSleepSignature__DelegateSignature_SleepingComponent_IsValid;

	private static FFieldAddress ComponentSleepSignature__DelegateSignature_SleepingComponent_PropertyAddress;

	private static int ComponentSleepSignature__DelegateSignature_SleepingComponent_Offset;

	private static bool ComponentSleepSignature__DelegateSignature_BoneName_IsValid;

	private static FFieldAddress ComponentSleepSignature__DelegateSignature_BoneName_PropertyAddress;

	private static int ComponentSleepSignature__DelegateSignature_BoneName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentSleepSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentSleepSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentSleepSignature__DelegateSignature");
		ComponentSleepSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentSleepSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentSleepSignature__DelegateSignature_SleepingComponent_PropertyAddress, ComponentSleepSignature__DelegateSignature_FunctionAddress, "SleepingComponent");
		ComponentSleepSignature__DelegateSignature_SleepingComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentSleepSignature__DelegateSignature_FunctionAddress, "SleepingComponent");
		ComponentSleepSignature__DelegateSignature_SleepingComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentSleepSignature__DelegateSignature_FunctionAddress, "SleepingComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentSleepSignature__DelegateSignature_BoneName_PropertyAddress, ComponentSleepSignature__DelegateSignature_FunctionAddress, "BoneName");
		ComponentSleepSignature__DelegateSignature_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(ComponentSleepSignature__DelegateSignature_FunctionAddress, "BoneName");
		ComponentSleepSignature__DelegateSignature_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentSleepSignature__DelegateSignature_FunctionAddress, "BoneName", Classes.FNameProperty);
		ComponentSleepSignature__DelegateSignature_IsValid = ComponentSleepSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentSleepSignature__DelegateSignature_SleepingComponent_IsValid && ComponentSleepSignature__DelegateSignature_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentSleepSignature__DelegateSignature", ComponentSleepSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent SleepingComponent, FName BoneName)
	{
		if (!ComponentSleepSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentSleepSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentSleepSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentSleepSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentSleepSignature__DelegateSignature_SleepingComponent_Offset), 0, ComponentSleepSignature__DelegateSignature_SleepingComponent_PropertyAddress.Address, SleepingComponent);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ComponentSleepSignature__DelegateSignature_BoneName_Offset), 0, ComponentSleepSignature__DelegateSignature_BoneName_PropertyAddress.Address, BoneName);
			ProcessDelegate(intPtr);
		}
	}
}
