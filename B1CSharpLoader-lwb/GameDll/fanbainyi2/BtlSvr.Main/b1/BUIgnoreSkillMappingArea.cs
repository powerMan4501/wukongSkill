using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUIgnoreSkillMappingArea")]
internal class BUIgnoreSkillMappingArea : BGUAreaBase
{
	private static bool IgnoreSkillMappingAreaConfigComp_IsValid;

	private static int IgnoreSkillMappingAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUIgnoreSkillMappingArea:IgnoreSkillMappingAreaConfigComp")]
	public BUS_IgnoreSkillMappingAreaConfigComp IgnoreSkillMappingAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreSkillMappingAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUIgnoreSkillMappingArea:IgnoreSkillMappingAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_IgnoreSkillMappingAreaConfigComp>.FromNative(IntPtr.Add(base.Address, IgnoreSkillMappingAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreSkillMappingAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUIgnoreSkillMappingArea:IgnoreSkillMappingAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_IgnoreSkillMappingAreaConfigComp>.ToNative(IntPtr.Add(base.Address, IgnoreSkillMappingAreaConfigComp_Offset), value);
			}
		}
	}

	protected override FName GetRootCompName()
	{
		return B1GlobalFNames.DefaultSceneRoot;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		IgnoreSkillMappingAreaConfigComp = initializer.CreateDefaultSubobject<BUS_IgnoreSkillMappingAreaConfigComp>(this, B1GlobalFNames.IntervalTriggerAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_IgnoreSkillMappingLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_IgnoreSkillMappingAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUIgnoreSkillMappingArea");
		IgnoreSkillMappingAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IgnoreSkillMappingAreaConfigComp");
		IgnoreSkillMappingAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IgnoreSkillMappingAreaConfigComp", Classes.FObjectProperty);
	}

	static BUIgnoreSkillMappingArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUIgnoreSkillMappingArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUIgnoreSkillMappingArea));
	}
}
