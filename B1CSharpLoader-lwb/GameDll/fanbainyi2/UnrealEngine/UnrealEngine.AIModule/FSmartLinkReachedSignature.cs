using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.SmartLinkReachedSignature__DelegateSignature")]
public class FSmartLinkReachedSignature : FMulticastDelegate<FSmartLinkReachedSignature.Signature>
{
	public delegate void Signature(AActor MovingActor, FVector DestinationPoint);

	private static bool SmartLinkReachedSignature__DelegateSignature_IsValid;

	private static IntPtr SmartLinkReachedSignature__DelegateSignature_FunctionAddress;

	private static int SmartLinkReachedSignature__DelegateSignature_ParamsSize;

	private static bool SmartLinkReachedSignature__DelegateSignature_MovingActor_IsValid;

	private static FFieldAddress SmartLinkReachedSignature__DelegateSignature_MovingActor_PropertyAddress;

	private static int SmartLinkReachedSignature__DelegateSignature_MovingActor_Offset;

	private static bool SmartLinkReachedSignature__DelegateSignature_DestinationPoint_IsValid;

	private static FFieldAddress SmartLinkReachedSignature__DelegateSignature_DestinationPoint_PropertyAddress;

	private static int SmartLinkReachedSignature__DelegateSignature_DestinationPoint_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FSmartLinkReachedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		SmartLinkReachedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.SmartLinkReachedSignature__DelegateSignature");
		SmartLinkReachedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SmartLinkReachedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SmartLinkReachedSignature__DelegateSignature_MovingActor_PropertyAddress, SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "MovingActor");
		SmartLinkReachedSignature__DelegateSignature_MovingActor_Offset = NativeReflectionCached.GetPropertyOffset(SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "MovingActor");
		SmartLinkReachedSignature__DelegateSignature_MovingActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "MovingActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SmartLinkReachedSignature__DelegateSignature_DestinationPoint_PropertyAddress, SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "DestinationPoint");
		SmartLinkReachedSignature__DelegateSignature_DestinationPoint_Offset = NativeReflectionCached.GetPropertyOffset(SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "DestinationPoint");
		SmartLinkReachedSignature__DelegateSignature_DestinationPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SmartLinkReachedSignature__DelegateSignature_FunctionAddress, "DestinationPoint", Classes.FStructProperty);
		SmartLinkReachedSignature__DelegateSignature_IsValid = SmartLinkReachedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && SmartLinkReachedSignature__DelegateSignature_MovingActor_IsValid && SmartLinkReachedSignature__DelegateSignature_DestinationPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.SmartLinkReachedSignature__DelegateSignature", SmartLinkReachedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor MovingActor, FVector DestinationPoint)
	{
		if (!SmartLinkReachedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.SmartLinkReachedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(SmartLinkReachedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SmartLinkReachedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SmartLinkReachedSignature__DelegateSignature_MovingActor_Offset), 0, SmartLinkReachedSignature__DelegateSignature_MovingActor_PropertyAddress.Address, MovingActor);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SmartLinkReachedSignature__DelegateSignature_DestinationPoint_Offset), 0, SmartLinkReachedSignature__DelegateSignature_DestinationPoint_PropertyAddress.Address, DestinationPoint);
			ProcessDelegate(intPtr);
		}
	}
}
