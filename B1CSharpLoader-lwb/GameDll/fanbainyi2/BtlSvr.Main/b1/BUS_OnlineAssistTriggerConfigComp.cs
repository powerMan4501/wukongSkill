using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp")]
public class BUS_OnlineAssistTriggerConfigComp : UActorEditCompBase
{
	private static bool RebirthPointId_IsValid;

	private static int RebirthPointId_Offset;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	[Category("OnlineAssist")]
	[DisplayName("救援复活点Id")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:RebirthPointId")]
	public int RebirthPointId
	{
		get
		{
			CheckDestroyed();
			if (!RebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:RebirthPointId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RebirthPointId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:RebirthPointId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RebirthPointId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("OnlineAssist")]
	[DisplayName("讨伐怪物Guid")]
	[USharpPath("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:UnitGuid")]
	public string UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:UnitGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp:UnitGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_OnlineAssistTriggerData bUC_OnlineAssistTriggerData = RequireWritableData<BUC_OnlineAssistTriggerData>();
		bUC_OnlineAssistTriggerData.RebirthPointId = RebirthPointId;
		bUC_OnlineAssistTriggerData.UnitGuid = UnitGuid;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_OnlineAssistTriggerConfigComp");
		RebirthPointId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthPointId");
		RebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthPointId", Classes.FIntProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitGuid", Classes.FStrProperty);
	}

	static BUS_OnlineAssistTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_OnlineAssistTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_OnlineAssistTriggerConfigComp));
	}
}
