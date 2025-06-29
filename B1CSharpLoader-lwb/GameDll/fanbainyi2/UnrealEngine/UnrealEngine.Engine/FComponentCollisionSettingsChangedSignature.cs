using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentCollisionSettingsChangedSignature__DelegateSignature")]
public class FComponentCollisionSettingsChangedSignature : FMulticastDelegate<FComponentCollisionSettingsChangedSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent ChangedComponent);

	private static bool ComponentCollisionSettingsChangedSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress;

	private static int ComponentCollisionSettingsChangedSignature__DelegateSignature_ParamsSize;

	private static bool ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_IsValid;

	private static FFieldAddress ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_PropertyAddress;

	private static int ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentCollisionSettingsChangedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentCollisionSettingsChangedSignature__DelegateSignature");
		ComponentCollisionSettingsChangedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_PropertyAddress, ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress, "ChangedComponent");
		ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress, "ChangedComponent");
		ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress, "ChangedComponent", Classes.FObjectProperty);
		ComponentCollisionSettingsChangedSignature__DelegateSignature_IsValid = ComponentCollisionSettingsChangedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentCollisionSettingsChangedSignature__DelegateSignature", ComponentCollisionSettingsChangedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent ChangedComponent)
	{
		if (!ComponentCollisionSettingsChangedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentCollisionSettingsChangedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentCollisionSettingsChangedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentCollisionSettingsChangedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_Offset), 0, ComponentCollisionSettingsChangedSignature__DelegateSignature_ChangedComponent_PropertyAddress.Address, ChangedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
