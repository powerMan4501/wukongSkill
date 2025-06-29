using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCollectionBase")]
public class BGUCollectionBase : BGUInteractiveActorBase
{
	private static bool CollectionConfigComp_IsValid;

	private static int CollectionConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUCollectionBase:CollectionConfigComp")]
	public BUS_CollectionConfigComp CollectionConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!CollectionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCollectionBase:CollectionConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_CollectionConfigComp>.FromNative(IntPtr.Add(base.Address, CollectionConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCollectionBase:CollectionConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_CollectionConfigComp>.ToNative(IntPtr.Add(base.Address, CollectionConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CollectionConfigComp = initializer.CreateDefaultSubobject<BUS_CollectionConfigComp>(this, B1GlobalFNames.RebirthPointConfigSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_CollectiontInteractComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_CollectiontDataComp>(this, B1GlobalFNames.CollectiontDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUCollectionBase");
		CollectionConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionConfigComp");
		CollectionConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionConfigComp", Classes.FObjectProperty);
	}

	static BGUCollectionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCollectionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCollectionBase));
	}
}
