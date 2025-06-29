using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ApexDestruction;

[UDelegate]
[UMetaPath("/Script/ApexDestruction.ActorFractureSignature__DelegateSignature")]
public class FActorFractureSignature : FMulticastDelegate<FActorFractureSignature.Signature>
{
	public delegate void Signature(FVector HitPoint, FVector HitDirection);

	private static bool ActorFractureSignature__DelegateSignature_IsValid;

	private static IntPtr ActorFractureSignature__DelegateSignature_FunctionAddress;

	private static int ActorFractureSignature__DelegateSignature_ParamsSize;

	private static bool ActorFractureSignature__DelegateSignature_HitPoint_IsValid;

	private static FFieldAddress ActorFractureSignature__DelegateSignature_HitPoint_PropertyAddress;

	private static int ActorFractureSignature__DelegateSignature_HitPoint_Offset;

	private static bool ActorFractureSignature__DelegateSignature_HitDirection_IsValid;

	private static FFieldAddress ActorFractureSignature__DelegateSignature_HitDirection_PropertyAddress;

	private static int ActorFractureSignature__DelegateSignature_HitDirection_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorFractureSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorFractureSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ApexDestruction.ActorFractureSignature__DelegateSignature");
		ActorFractureSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorFractureSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorFractureSignature__DelegateSignature_HitPoint_PropertyAddress, ActorFractureSignature__DelegateSignature_FunctionAddress, "HitPoint");
		ActorFractureSignature__DelegateSignature_HitPoint_Offset = NativeReflectionCached.GetPropertyOffset(ActorFractureSignature__DelegateSignature_FunctionAddress, "HitPoint");
		ActorFractureSignature__DelegateSignature_HitPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorFractureSignature__DelegateSignature_FunctionAddress, "HitPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorFractureSignature__DelegateSignature_HitDirection_PropertyAddress, ActorFractureSignature__DelegateSignature_FunctionAddress, "HitDirection");
		ActorFractureSignature__DelegateSignature_HitDirection_Offset = NativeReflectionCached.GetPropertyOffset(ActorFractureSignature__DelegateSignature_FunctionAddress, "HitDirection");
		ActorFractureSignature__DelegateSignature_HitDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorFractureSignature__DelegateSignature_FunctionAddress, "HitDirection", Classes.FStructProperty);
		ActorFractureSignature__DelegateSignature_IsValid = ActorFractureSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorFractureSignature__DelegateSignature_HitPoint_IsValid && ActorFractureSignature__DelegateSignature_HitDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.ActorFractureSignature__DelegateSignature", ActorFractureSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FVector HitPoint, FVector HitDirection)
	{
		if (!ActorFractureSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.ActorFractureSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorFractureSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorFractureSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ActorFractureSignature__DelegateSignature_HitPoint_Offset), 0, ActorFractureSignature__DelegateSignature_HitPoint_PropertyAddress.Address, HitPoint);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ActorFractureSignature__DelegateSignature_HitDirection_Offset), 0, ActorFractureSignature__DelegateSignature_HitDirection_PropertyAddress.Address, HitDirection);
			ProcessDelegate(intPtr);
		}
	}
}
