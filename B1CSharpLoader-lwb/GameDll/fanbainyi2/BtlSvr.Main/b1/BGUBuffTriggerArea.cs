using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBuffTriggerArea")]
public class BGUBuffTriggerArea : BGUAreaBase
{
	private static bool BuffTriggerAreaConfigComp_IsValid;

	private static int BuffTriggerAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUBuffTriggerArea:BuffTriggerAreaConfigComp")]
	public BUS_BuffTriggerAreaConfigComp BuffTriggerAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!BuffTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBuffTriggerArea:BuffTriggerAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_BuffTriggerAreaConfigComp>.FromNative(IntPtr.Add(base.Address, BuffTriggerAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffTriggerAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBuffTriggerArea:BuffTriggerAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_BuffTriggerAreaConfigComp>.ToNative(IntPtr.Add(base.Address, BuffTriggerAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BuffTriggerAreaConfigComp = initializer.CreateDefaultSubobject<BUS_BuffTriggerAreaConfigComp>(this, B1GlobalFNames.IntervalTriggerAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_BuffTriggerLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BuffTriggerAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUBuffTriggerArea");
		BuffTriggerAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffTriggerAreaConfigComp");
		BuffTriggerAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffTriggerAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUBuffTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBuffTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBuffTriggerArea));
	}
}
