using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBattleSC")]
public class BGUBattleSC : BGUActorBaseCS
{
	private static bool MessageDistributionCenter_IsValid;

	private static int MessageDistributionCenter_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUBattleSC:MessageDistributionCenter")]
	private BUS_MessageDistributionCenter MessageDistributionCenter
	{
		get
		{
			CheckDestroyed();
			if (!MessageDistributionCenter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBattleSC:MessageDistributionCenter");
				return null;
			}
			return UObjectMarshaler<BUS_MessageDistributionCenter>.FromNative(IntPtr.Add(base.Address, MessageDistributionCenter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MessageDistributionCenter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBattleSC:MessageDistributionCenter");
			}
			else
			{
				UObjectMarshaler<BUS_MessageDistributionCenter>.ToNative(IntPtr.Add(base.Address, MessageDistributionCenter_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.ECSArcheType = 7;
		MessageDistributionCenter = initializer.CreateDefaultSubobject<BUS_MessageDistributionCenter>(this, B1GlobalFNames.MessageDistributionCenter);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BattleSCDataComp>(this, B1GlobalFNames.BattleSCDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUBattleSC");
		MessageDistributionCenter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MessageDistributionCenter");
		MessageDistributionCenter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MessageDistributionCenter", Classes.FObjectProperty);
	}

	static BGUBattleSC()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBattleSC)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBattleSC));
	}
}
