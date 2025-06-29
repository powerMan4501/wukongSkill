using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGroupAIArea")]
internal class BGUGroupAIArea : BGUAreaBase
{
	private static bool GroupAIAreaConfigInfoComp_IsValid;

	private static int GroupAIAreaConfigInfoComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUGroupAIArea:GroupAIAreaConfigInfoComp")]
	public BUS_GroupAIAreaConfigInfoComp GroupAIAreaConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!GroupAIAreaConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIArea:GroupAIAreaConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_GroupAIAreaConfigInfoComp>.FromNative(IntPtr.Add(base.Address, GroupAIAreaConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupAIAreaConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIArea:GroupAIAreaConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_GroupAIAreaConfigInfoComp>.ToNative(IntPtr.Add(base.Address, GroupAIAreaConfigInfoComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		GroupAIAreaConfigInfoComp = initializer.CreateDefaultSubobject<BUS_GroupAIAreaConfigInfoComp>(this, B1GlobalFNames.GroupAIAreaConfigInfoComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_GroupAIAreaLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_GroupAIDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUGroupAIArea");
		GroupAIAreaConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupAIAreaConfigInfoComp");
		GroupAIAreaConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupAIAreaConfigInfoComp", Classes.FObjectProperty);
	}

	static BGUGroupAIArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUGroupAIArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUGroupAIArea));
	}
}
