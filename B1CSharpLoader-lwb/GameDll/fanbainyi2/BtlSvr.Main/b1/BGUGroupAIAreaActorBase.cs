using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGroupAIAreaActorBase")]
public class BGUGroupAIAreaActorBase : BGUActorBaseCS
{
	private static bool GroupAIAreaComp_IsValid;

	private static int GroupAIAreaComp_Offset;

	private static bool BoxCollisionComponent_IsValid;

	private static int BoxCollisionComponent_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUGroupAIAreaActorBase:GroupAIAreaComp")]
	public BUS_GroupAIAreaComp GroupAIAreaComp
	{
		get
		{
			CheckDestroyed();
			if (!GroupAIAreaComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIAreaActorBase:GroupAIAreaComp");
				return null;
			}
			return UObjectMarshaler<BUS_GroupAIAreaComp>.FromNative(IntPtr.Add(base.Address, GroupAIAreaComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupAIAreaComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIAreaActorBase:GroupAIAreaComp");
			}
			else
			{
				UObjectMarshaler<BUS_GroupAIAreaComp>.ToNative(IntPtr.Add(base.Address, GroupAIAreaComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUGroupAIAreaActorBase:BoxCollisionComponent")]
	protected UBoxComponent BoxCollisionComponent
	{
		get
		{
			CheckDestroyed();
			if (!BoxCollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIAreaActorBase:BoxCollisionComponent");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoxCollisionComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxCollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGroupAIAreaActorBase:BoxCollisionComponent");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoxCollisionComponent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		GroupAIAreaComp = initializer.CreateDefaultSubobject<BUS_GroupAIAreaComp>(this, B1GlobalFNames.GroupAIAreaComp);
		BoxCollisionComponent = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.BoxComp);
		SetRootComponentCS(BoxCollisionComponent);
		BoxCollisionComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_GroupAIAreaCompImpl>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_GroupAIAreaDataComp>(this, B1GlobalFNames.GroupAIAreaDataComp);
	}

	public UBoxComponent GetBoxCollisionComponent()
	{
		return BoxCollisionComponent;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUGroupAIAreaActorBase");
		GroupAIAreaComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupAIAreaComp");
		GroupAIAreaComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupAIAreaComp", Classes.FObjectProperty);
		BoxCollisionComponent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoxCollisionComponent");
		BoxCollisionComponent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoxCollisionComponent", Classes.FObjectProperty);
	}

	static BGUGroupAIAreaActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUGroupAIAreaActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUGroupAIAreaActorBase));
	}
}
