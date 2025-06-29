using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentOnReleasedSignature__DelegateSignature")]
public class FComponentOnReleasedSignature : FMulticastDelegate<FComponentOnReleasedSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent TouchedComponent, FKey ButtonReleased);

	private static bool ComponentOnReleasedSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentOnReleasedSignature__DelegateSignature_FunctionAddress;

	private static int ComponentOnReleasedSignature__DelegateSignature_ParamsSize;

	private static bool ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_Offset;

	private static bool ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid;

	private static FFieldAddress ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress;

	private static int ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentOnReleasedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentOnReleasedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentOnReleasedSignature__DelegateSignature");
		ComponentOnReleasedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentOnReleasedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress, ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased");
		ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased");
		ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased", Classes.FStructProperty);
		ComponentOnReleasedSignature__DelegateSignature_IsValid = ComponentOnReleasedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_IsValid && ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentOnReleasedSignature__DelegateSignature", ComponentOnReleasedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent TouchedComponent, FKey ButtonReleased)
	{
		if (!ComponentOnReleasedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentOnReleasedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentOnReleasedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentOnReleasedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentOnReleasedSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			NativeReflection.InitializeValue_InContainer(ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_Offset), 0, ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, ButtonReleased);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ComponentOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, intPtr);
		}
	}
}
