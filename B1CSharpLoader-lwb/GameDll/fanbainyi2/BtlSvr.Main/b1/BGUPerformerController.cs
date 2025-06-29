using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPerformerController")]
internal class BGUPerformerController : BGUActorBaseCS
{
	private static bool ConfigComp_IsValid;

	private static int ConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUPerformerController:ConfigComp")]
	public BGUPerformerControlConfigComp ConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerController:ConfigComp");
				return null;
			}
			return UObjectMarshaler<BGUPerformerControlConfigComp>.FromNative(IntPtr.Add(base.Address, ConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerController:ConfigComp");
			}
			else
			{
				UObjectMarshaler<BGUPerformerControlConfigComp>.ToNative(IntPtr.Add(base.Address, ConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ConfigComp = initializer.CreateDefaultSubobject<BGUPerformerControlConfigComp>(this, B1GlobalFNames.PerformerControllerConfigComp);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BGUPerformerControlDataComp>(this, B1GlobalFNames.PerformerControllerDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_PerformerControlComp());
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUPerformerController");
		ConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigComp");
		ConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigComp", Classes.FObjectProperty);
	}

	static BGUPerformerController()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUPerformerController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUPerformerController));
	}
}
