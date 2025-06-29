using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSpecifyRebirthPosArea")]
internal class BGUSpecifyRebirthPosArea : BGUAreaBase
{
	private static bool ConfigComp_IsValid;

	private static int ConfigComp_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSpecifyRebirthPosArea:ConfigComp")]
	public BUS_SpecifyRebirthPosAreaConfigComp ConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpecifyRebirthPosArea:ConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_SpecifyRebirthPosAreaConfigComp>.FromNative(IntPtr.Add(base.Address, ConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpecifyRebirthPosArea:ConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_SpecifyRebirthPosAreaConfigComp>.ToNative(IntPtr.Add(base.Address, ConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
		base.BasicConfigInfoComp.bNotifyGraph = false;
		ConfigComp = initializer.CreateDefaultSubobject<BUS_SpecifyRebirthPosAreaConfigComp>(this, B1GlobalFNames.CloudMoveTriggerAreaConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_SpecifyRebirthPosAreaLogicComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SpecifyRebirthPosAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSpecifyRebirthPosArea");
		ConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigComp");
		ConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigComp", Classes.FObjectProperty);
	}

	static BGUSpecifyRebirthPosArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUSpecifyRebirthPosArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUSpecifyRebirthPosArea));
	}
}
