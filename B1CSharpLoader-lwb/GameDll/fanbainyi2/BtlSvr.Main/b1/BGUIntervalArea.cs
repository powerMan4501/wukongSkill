using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUIntervalArea")]
public class BGUIntervalArea : BGUAreaBase
{
	private static bool WanderBGMAreaConfigComp_IsValid;

	private static int WanderBGMAreaConfigComp_Offset;

	private static bool IntervalTriggerConfigComp_IsValid;

	private static int IntervalTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUIntervalArea:WanderBGMAreaConfigComp")]
	public BUS_WanderBGMAreaConfigComp WanderBGMAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!WanderBGMAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalArea:WanderBGMAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_WanderBGMAreaConfigComp>.FromNative(IntPtr.Add(base.Address, WanderBGMAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WanderBGMAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalArea:WanderBGMAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_WanderBGMAreaConfigComp>.ToNative(IntPtr.Add(base.Address, WanderBGMAreaConfigComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUIntervalArea:IntervalTriggerConfigComp")]
	public BUS_IntervalTriggerConfigComp IntervalTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!IntervalTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalArea:IntervalTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_IntervalTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, IntervalTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUIntervalArea:IntervalTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_IntervalTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, IntervalTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		WanderBGMAreaConfigComp = initializer.CreateDefaultSubobject<BUS_WanderBGMAreaConfigComp>(this, B1GlobalFNames.WanderBGMAreaConfigComp);
		IntervalTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_IntervalTriggerConfigComp>(this, B1GlobalFNames.IntervalTriggerConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_WanderBGMAreaLogicComp());
		base.ActorCompContainerCS.AddComp(new BUS_IntervalTriggerImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BGMAreaDataComp>(this, B1GlobalFNames.BGMAreaDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUIntervalArea");
		WanderBGMAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WanderBGMAreaConfigComp");
		WanderBGMAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WanderBGMAreaConfigComp", Classes.FObjectProperty);
		IntervalTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IntervalTriggerConfigComp");
		IntervalTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IntervalTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUIntervalArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUIntervalArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUIntervalArea));
	}
}
