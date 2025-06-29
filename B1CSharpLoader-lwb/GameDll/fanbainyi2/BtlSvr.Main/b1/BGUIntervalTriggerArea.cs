using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUIntervalTriggerArea")]
internal class BGUIntervalTriggerArea : BGUAreaBase
{
	private static bool IntervalTriggerAreaConfigComp_IsValid;

	private static int IntervalTriggerAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUIntervalTriggerArea:IntervalTriggerAreaConfigComp")]
	public BUS_IntervalTriggerAreaConfigComp IntervalTriggerAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!IntervalTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalTriggerArea:IntervalTriggerAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_IntervalTriggerAreaConfigComp>.FromNative(IntPtr.Add(base.Address, IntervalTriggerAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalTriggerArea:IntervalTriggerAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_IntervalTriggerAreaConfigComp>.ToNative(IntPtr.Add(base.Address, IntervalTriggerAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		IntervalTriggerAreaConfigComp = initializer.CreateDefaultSubobject<BUS_IntervalTriggerAreaConfigComp>(this, B1GlobalFNames.IntervalTriggerAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_IntervalTriggerLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_IntervalTriggerAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUIntervalTriggerArea");
		IntervalTriggerAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IntervalTriggerAreaConfigComp");
		IntervalTriggerAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IntervalTriggerAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUIntervalTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUIntervalTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUIntervalTriggerArea));
	}
}
