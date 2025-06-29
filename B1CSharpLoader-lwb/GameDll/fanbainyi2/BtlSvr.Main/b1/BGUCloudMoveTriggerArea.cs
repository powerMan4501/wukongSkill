using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCloudMoveTriggerArea")]
internal class BGUCloudMoveTriggerArea : BGUAreaBase
{
	private static bool CloudMoveTriggerAreaConfigComp_IsValid;

	private static int CloudMoveTriggerAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUCloudMoveTriggerArea:CloudMoveTriggerAreaConfigComp")]
	public BUS_CloudMoveTriggerAreaConfigComp CloudMoveTriggerAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCloudMoveTriggerArea:CloudMoveTriggerAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_CloudMoveTriggerAreaConfigComp>.FromNative(IntPtr.Add(base.Address, CloudMoveTriggerAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudMoveTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCloudMoveTriggerArea:CloudMoveTriggerAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_CloudMoveTriggerAreaConfigComp>.ToNative(IntPtr.Add(base.Address, CloudMoveTriggerAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
		base.BasicConfigInfoComp.bNotifyGraph = false;
		CloudMoveTriggerAreaConfigComp = initializer.CreateDefaultSubobject<BUS_CloudMoveTriggerAreaConfigComp>(this, B1GlobalFNames.CloudMoveTriggerAreaConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_CloudMoveTriggerAreaLogicComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_CloudMoveTriggerAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUCloudMoveTriggerArea");
		CloudMoveTriggerAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveTriggerAreaConfigComp");
		CloudMoveTriggerAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveTriggerAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUCloudMoveTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUCloudMoveTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUCloudMoveTriggerArea));
	}
}
