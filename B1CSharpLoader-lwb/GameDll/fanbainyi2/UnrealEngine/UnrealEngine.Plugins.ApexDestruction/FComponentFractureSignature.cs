using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ApexDestruction;

[UDelegate]
[UMetaPath("/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature")]
public class FComponentFractureSignature : FMulticastDelegate<FComponentFractureSignature.Signature>
{
	public delegate void Signature(FVector HitPoint, FVector HitDirection);

	private static bool ComponentFractureSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentFractureSignature__DelegateSignature_FunctionAddress;

	private static int ComponentFractureSignature__DelegateSignature_ParamsSize;

	private static bool ComponentFractureSignature__DelegateSignature_HitPoint_IsValid;

	private static FFieldAddress ComponentFractureSignature__DelegateSignature_HitPoint_PropertyAddress;

	private static int ComponentFractureSignature__DelegateSignature_HitPoint_Offset;

	private static bool ComponentFractureSignature__DelegateSignature_HitDirection_IsValid;

	private static FFieldAddress ComponentFractureSignature__DelegateSignature_HitDirection_PropertyAddress;

	private static int ComponentFractureSignature__DelegateSignature_HitDirection_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentFractureSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentFractureSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature");
		ComponentFractureSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentFractureSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentFractureSignature__DelegateSignature_HitPoint_PropertyAddress, ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitPoint");
		ComponentFractureSignature__DelegateSignature_HitPoint_Offset = NativeReflectionCached.GetPropertyOffset(ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitPoint");
		ComponentFractureSignature__DelegateSignature_HitPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentFractureSignature__DelegateSignature_HitDirection_PropertyAddress, ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitDirection");
		ComponentFractureSignature__DelegateSignature_HitDirection_Offset = NativeReflectionCached.GetPropertyOffset(ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitDirection");
		ComponentFractureSignature__DelegateSignature_HitDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentFractureSignature__DelegateSignature_FunctionAddress, "HitDirection", Classes.FStructProperty);
		ComponentFractureSignature__DelegateSignature_IsValid = ComponentFractureSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentFractureSignature__DelegateSignature_HitPoint_IsValid && ComponentFractureSignature__DelegateSignature_HitDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature", ComponentFractureSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FVector HitPoint, FVector HitDirection)
	{
		if (!ComponentFractureSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentFractureSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentFractureSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ComponentFractureSignature__DelegateSignature_HitPoint_Offset), 0, ComponentFractureSignature__DelegateSignature_HitPoint_PropertyAddress.Address, HitPoint);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ComponentFractureSignature__DelegateSignature_HitDirection_Offset), 0, ComponentFractureSignature__DelegateSignature_HitDirection_PropertyAddress.Address, HitDirection);
			ProcessDelegate(intPtr);
		}
	}
}
