using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorZakkaComp")]
public class DispLib_EditorZakkaComp : UBaseActorCompTickable
{
	private static bool PermanentWindMotorsDataAsset_IsValid;

	private static int PermanentWindMotorsDataAsset_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorZakkaComp:PermanentWindMotorsDataAsset")]
	public BUC_DispLibDBCPermanentWEFMMotorDataAsset PermanentWindMotorsDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!PermanentWindMotorsDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorZakkaComp:PermanentWindMotorsDataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDBCPermanentWEFMMotorDataAsset>.FromNative(IntPtr.Add(base.Address, PermanentWindMotorsDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PermanentWindMotorsDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorZakkaComp:PermanentWindMotorsDataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDBCPermanentWEFMMotorDataAsset>.ToNative(IntPtr.Add(base.Address, PermanentWindMotorsDataAsset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorZakkaComp:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorZakkaComp:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorZakkaComp dispLib_EditorZakkaComp = GCHelper.Find<DispLib_EditorZakkaComp>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		dispLib_EditorZakkaComp.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorZakkaComp");
		PermanentWindMotorsDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "PermanentWindMotorsDataAsset");
		PermanentWindMotorsDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PermanentWindMotorsDataAsset", Classes.FObjectProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorZakkaComp:ReceiveTick", ReceiveTick_IsValid);
	}

	static DispLib_EditorZakkaComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorZakkaComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorZakkaComp));
	}
}
