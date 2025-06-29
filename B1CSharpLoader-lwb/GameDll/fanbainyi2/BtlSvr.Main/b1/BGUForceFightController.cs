using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUForceFightController")]
public class BGUForceFightController : BGUAreaBase
{
	private static bool ForceFightControllerConfigComp_IsValid;

	private static int ForceFightControllerConfigComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUForceFightController:ForceFightControllerConfigComp")]
	public BUS_ForceFightControllerConfigComp ForceFightControllerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ForceFightControllerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceFightController:ForceFightControllerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ForceFightControllerConfigComp>.FromNative(IntPtr.Add(base.Address, ForceFightControllerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceFightControllerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceFightController:ForceFightControllerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ForceFightControllerConfigComp>.ToNative(IntPtr.Add(base.Address, ForceFightControllerConfigComp_Offset), value);
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
		ForceFightControllerConfigComp = initializer.CreateDefaultSubobject<BUS_ForceFightControllerConfigComp>(this, B1GlobalFNames.ForceFightControllerConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_ForceFightControllerLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ForceFightControllerDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUForceFightController");
		ForceFightControllerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceFightControllerConfigComp");
		ForceFightControllerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceFightControllerConfigComp", Classes.FObjectProperty);
	}

	static BGUForceFightController()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUForceFightController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUForceFightController));
	}
}
