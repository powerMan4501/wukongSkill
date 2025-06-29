using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUForceOriginalFormTriggerArea")]
internal class BGUForceOriginalFormTriggerArea : BGUAreaBase
{
	private static bool ForceOriginalFormAreaConfigComp_IsValid;

	private static int ForceOriginalFormAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUForceOriginalFormTriggerArea:ForceOriginalFormAreaConfigComp")]
	public BUS_ForceOriginalFormAreaConfigComp ForceOriginalFormAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ForceOriginalFormAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerArea:ForceOriginalFormAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ForceOriginalFormAreaConfigComp>.FromNative(IntPtr.Add(base.Address, ForceOriginalFormAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceOriginalFormAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerArea:ForceOriginalFormAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ForceOriginalFormAreaConfigComp>.ToNative(IntPtr.Add(base.Address, ForceOriginalFormAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ForceOriginalFormAreaConfigComp = initializer.CreateDefaultSubobject<BUS_ForceOriginalFormAreaConfigComp>(this, B1GlobalFNames.ForceOriginalFormAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ForceOriginalFormAreaLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ForceOriginalFormAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUForceOriginalFormTriggerArea");
		ForceOriginalFormAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceOriginalFormAreaConfigComp");
		ForceOriginalFormAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceOriginalFormAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUForceOriginalFormTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUForceOriginalFormTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUForceOriginalFormTriggerArea));
	}
}
