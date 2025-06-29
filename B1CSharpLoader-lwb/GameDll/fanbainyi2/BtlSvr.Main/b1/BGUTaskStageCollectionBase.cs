using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTaskStageCollectionBase")]
public class BGUTaskStageCollectionBase : BGUInteractiveActorBase
{
	private static bool TaskStageCollectionConfigComp_IsValid;

	private static int TaskStageCollectionConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTaskStageCollectionBase:TaskStageCollectionConfigComp")]
	public BUS_TaskStageCollectionConfigComp TaskStageCollectionConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageCollectionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTaskStageCollectionBase:TaskStageCollectionConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_TaskStageCollectionConfigComp>.FromNative(IntPtr.Add(base.Address, TaskStageCollectionConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageCollectionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTaskStageCollectionBase:TaskStageCollectionConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_TaskStageCollectionConfigComp>.ToNative(IntPtr.Add(base.Address, TaskStageCollectionConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TaskStageCollectionConfigComp = initializer.CreateDefaultSubobject<BUS_TaskStageCollectionConfigComp>(this, B1GlobalFNames.TaskStageCollectionConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TaskCollectiontStateComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_TaskCollectiontDataComp>(this, B1GlobalFNames.CollectiontTaskDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUTaskStageCollectionBase");
		TaskStageCollectionConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageCollectionConfigComp");
		TaskStageCollectionConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageCollectionConfigComp", Classes.FObjectProperty);
	}

	static BGUTaskStageCollectionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUTaskStageCollectionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUTaskStageCollectionBase));
	}
}
