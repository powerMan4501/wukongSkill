using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentOnClickedSignature__DelegateSignature")]
public class FComponentOnClickedSignature : FMulticastDelegate<FComponentOnClickedSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent TouchedComponent, FKey ButtonPressed);

	private static bool ComponentOnClickedSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentOnClickedSignature__DelegateSignature_FunctionAddress;

	private static int ComponentOnClickedSignature__DelegateSignature_ParamsSize;

	private static bool ComponentOnClickedSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentOnClickedSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentOnClickedSignature__DelegateSignature_TouchedComponent_Offset;

	private static bool ComponentOnClickedSignature__DelegateSignature_ButtonPressed_IsValid;

	private static FFieldAddress ComponentOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress;

	private static int ComponentOnClickedSignature__DelegateSignature_ButtonPressed_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentOnClickedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentOnClickedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentOnClickedSignature__DelegateSignature");
		ComponentOnClickedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentOnClickedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnClickedSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnClickedSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnClickedSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress, ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed");
		ComponentOnClickedSignature__DelegateSignature_ButtonPressed_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed");
		ComponentOnClickedSignature__DelegateSignature_ButtonPressed_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed", Classes.FStructProperty);
		ComponentOnClickedSignature__DelegateSignature_IsValid = ComponentOnClickedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentOnClickedSignature__DelegateSignature_TouchedComponent_IsValid && ComponentOnClickedSignature__DelegateSignature_ButtonPressed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentOnClickedSignature__DelegateSignature", ComponentOnClickedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent TouchedComponent, FKey ButtonPressed)
	{
		if (!ComponentOnClickedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentOnClickedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentOnClickedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentOnClickedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentOnClickedSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentOnClickedSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			NativeReflection.InitializeValue_InContainer(ComponentOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, ComponentOnClickedSignature__DelegateSignature_ButtonPressed_Offset), 0, ComponentOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, ButtonPressed);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ComponentOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, intPtr);
		}
	}
}
