using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NameTriggerConfigComp")]
public class BUS_NameTriggerConfigComp : UActorEditCompBase
{
	private static bool NameID_IsValid;

	private static int NameID_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty]
	[Category("OnName Trigger Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_NameTriggerConfigComp:NameID")]
	public int NameID
	{
		get
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NameTriggerConfigComp:NameID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NameID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NameTriggerConfigComp:NameID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NameID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("OnName Trigger Config")]
	[USharpPath("/Script/b1-Managed.BUS_NameTriggerConfigComp:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NameTriggerConfigComp:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NameTriggerConfigComp:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_NameTriggerConfigData bUC_NameTriggerConfigData = RequireWritableData<b1.BUC_NameTriggerConfigData>();
		bUC_NameTriggerConfigData.NameID = NameID;
		bUC_NameTriggerConfigData.Duration = Duration;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_NameTriggerConfigComp");
		NameID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NameID");
		NameID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NameID", Classes.FIntProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
	}

	static BUS_NameTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NameTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NameTriggerConfigComp));
	}
}
