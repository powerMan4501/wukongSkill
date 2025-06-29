using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSceneRotateTriggerArea")]
public class BGUSceneRotateTriggerArea : BGUAreaBase
{
	private static bool SceneRotateTriggerConfigComp_IsValid;

	private static int SceneRotateTriggerConfigComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSceneRotateTriggerArea:SceneRotateTriggerConfigComp")]
	public BUS_SceneRotateTriggerConfigComp SceneRotateTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!SceneRotateTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneRotateTriggerArea:SceneRotateTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_SceneRotateTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, SceneRotateTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRotateTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneRotateTriggerArea:SceneRotateTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_SceneRotateTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, SceneRotateTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneRotateTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_SceneRotateTriggerConfigComp>(this, B1GlobalFNames.SceneRotateTriggerConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SceneRotateTriggerLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SceneRotateTriggerDataComp>(this, B1GlobalFNames.SceneRotateTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSceneRotateTriggerArea");
		SceneRotateTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneRotateTriggerConfigComp");
		SceneRotateTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneRotateTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUSceneRotateTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSceneRotateTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSceneRotateTriggerArea));
	}
}
