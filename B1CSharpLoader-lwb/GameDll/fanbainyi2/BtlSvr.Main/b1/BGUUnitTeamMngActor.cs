using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUUnitTeamMngActor")]
internal class BGUUnitTeamMngActor : BGUActorBaseCS
{
	private static bool UnitTeamMngConfigComp_IsValid;

	private static int UnitTeamMngConfigComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUUnitTeamMngActor:UnitTeamMngConfigComp")]
	public b1.BUS_UnitTeamMngConfigComp UnitTeamMngConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!UnitTeamMngConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUnitTeamMngActor:UnitTeamMngConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_UnitTeamMngConfigComp>.FromNative(IntPtr.Add(base.Address, UnitTeamMngConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitTeamMngConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUnitTeamMngActor:UnitTeamMngConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_UnitTeamMngConfigComp>.ToNative(IntPtr.Add(base.Address, UnitTeamMngConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		UnitTeamMngConfigComp = initializer.CreateDefaultSubobject<b1.BUS_UnitTeamMngConfigComp>(this, B1GlobalFNames.UnitTeamMngConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_UnitTeamMngComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_UnitTeamMngDataComp>(this, B1GlobalFNames.UnitTeamMngDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUUnitTeamMngActor");
		UnitTeamMngConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitTeamMngConfigComp");
		UnitTeamMngConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitTeamMngConfigComp", Classes.FObjectProperty);
	}

	static BGUUnitTeamMngActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUUnitTeamMngActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUUnitTeamMngActor));
	}
}
