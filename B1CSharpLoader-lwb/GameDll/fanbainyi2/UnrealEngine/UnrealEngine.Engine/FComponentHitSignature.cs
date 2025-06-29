using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentHitSignature__DelegateSignature")]
public class FComponentHitSignature : FMulticastDelegate<FComponentHitSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, FHitResult Hit);

	private static bool ComponentHitSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentHitSignature__DelegateSignature_FunctionAddress;

	private static int ComponentHitSignature__DelegateSignature_ParamsSize;

	private static bool ComponentHitSignature__DelegateSignature_HitComponent_IsValid;

	private static FFieldAddress ComponentHitSignature__DelegateSignature_HitComponent_PropertyAddress;

	private static int ComponentHitSignature__DelegateSignature_HitComponent_Offset;

	private static bool ComponentHitSignature__DelegateSignature_OtherActor_IsValid;

	private static FFieldAddress ComponentHitSignature__DelegateSignature_OtherActor_PropertyAddress;

	private static int ComponentHitSignature__DelegateSignature_OtherActor_Offset;

	private static bool ComponentHitSignature__DelegateSignature_OtherComp_IsValid;

	private static FFieldAddress ComponentHitSignature__DelegateSignature_OtherComp_PropertyAddress;

	private static int ComponentHitSignature__DelegateSignature_OtherComp_Offset;

	private static bool ComponentHitSignature__DelegateSignature_NormalImpulse_IsValid;

	private static FFieldAddress ComponentHitSignature__DelegateSignature_NormalImpulse_PropertyAddress;

	private static int ComponentHitSignature__DelegateSignature_NormalImpulse_Offset;

	private static bool ComponentHitSignature__DelegateSignature_Hit_IsValid;

	private static FFieldAddress ComponentHitSignature__DelegateSignature_Hit_PropertyAddress;

	private static int ComponentHitSignature__DelegateSignature_Hit_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentHitSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentHitSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentHitSignature__DelegateSignature");
		ComponentHitSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentHitSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentHitSignature__DelegateSignature_HitComponent_PropertyAddress, ComponentHitSignature__DelegateSignature_FunctionAddress, "HitComponent");
		ComponentHitSignature__DelegateSignature_HitComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHitSignature__DelegateSignature_FunctionAddress, "HitComponent");
		ComponentHitSignature__DelegateSignature_HitComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHitSignature__DelegateSignature_FunctionAddress, "HitComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentHitSignature__DelegateSignature_OtherActor_PropertyAddress, ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ComponentHitSignature__DelegateSignature_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ComponentHitSignature__DelegateSignature_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentHitSignature__DelegateSignature_OtherComp_PropertyAddress, ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherComp");
		ComponentHitSignature__DelegateSignature_OtherComp_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherComp");
		ComponentHitSignature__DelegateSignature_OtherComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHitSignature__DelegateSignature_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentHitSignature__DelegateSignature_NormalImpulse_PropertyAddress, ComponentHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse");
		ComponentHitSignature__DelegateSignature_NormalImpulse_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse");
		ComponentHitSignature__DelegateSignature_NormalImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentHitSignature__DelegateSignature_Hit_PropertyAddress, ComponentHitSignature__DelegateSignature_FunctionAddress, "Hit");
		ComponentHitSignature__DelegateSignature_Hit_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHitSignature__DelegateSignature_FunctionAddress, "Hit");
		ComponentHitSignature__DelegateSignature_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHitSignature__DelegateSignature_FunctionAddress, "Hit", Classes.FStructProperty);
		ComponentHitSignature__DelegateSignature_IsValid = ComponentHitSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentHitSignature__DelegateSignature_HitComponent_IsValid && ComponentHitSignature__DelegateSignature_OtherActor_IsValid && ComponentHitSignature__DelegateSignature_OtherComp_IsValid && ComponentHitSignature__DelegateSignature_NormalImpulse_IsValid && ComponentHitSignature__DelegateSignature_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentHitSignature__DelegateSignature", ComponentHitSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, FHitResult Hit)
	{
		if (!ComponentHitSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentHitSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentHitSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentHitSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentHitSignature__DelegateSignature_HitComponent_Offset), 0, ComponentHitSignature__DelegateSignature_HitComponent_PropertyAddress.Address, HitComponent);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ComponentHitSignature__DelegateSignature_OtherActor_Offset), 0, ComponentHitSignature__DelegateSignature_OtherActor_PropertyAddress.Address, OtherActor);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentHitSignature__DelegateSignature_OtherComp_Offset), 0, ComponentHitSignature__DelegateSignature_OtherComp_PropertyAddress.Address, OtherComp);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ComponentHitSignature__DelegateSignature_NormalImpulse_Offset), 0, ComponentHitSignature__DelegateSignature_NormalImpulse_PropertyAddress.Address, NormalImpulse);
			NativeReflection.InitializeValue_InContainer(ComponentHitSignature__DelegateSignature_Hit_PropertyAddress.Address, intPtr);
			FHitResult.ToNative(IntPtr.Add(intPtr, ComponentHitSignature__DelegateSignature_Hit_Offset), 0, ComponentHitSignature__DelegateSignature_Hit_PropertyAddress.Address, Hit);
			ProcessDelegate(intPtr);
		}
	}
}
