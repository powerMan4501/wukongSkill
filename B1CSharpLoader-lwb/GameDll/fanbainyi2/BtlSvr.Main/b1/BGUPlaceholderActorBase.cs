using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPlaceholderActorBase")]
public class BGUPlaceholderActorBase : BGUSimpleActorBaseCS
{
	private static bool PlaceholderActorConfig_IsValid;

	private static int PlaceholderActorConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPlaceholderActorBase:PlaceholderActorConfig")]
	public BUS_PlaceholderActorConfigComp PlaceholderActorConfig
	{
		get
		{
			CheckDestroyed();
			if (!PlaceholderActorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlaceholderActorBase:PlaceholderActorConfig");
				return null;
			}
			return UObjectMarshaler<BUS_PlaceholderActorConfigComp>.FromNative(IntPtr.Add(base.Address, PlaceholderActorConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaceholderActorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPlaceholderActorBase:PlaceholderActorConfig");
			}
			else
			{
				UObjectMarshaler<BUS_PlaceholderActorConfigComp>.ToNative(IntPtr.Add(base.Address, PlaceholderActorConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		PlaceholderActorConfig = initializer.CreateDefaultSubobject<BUS_PlaceholderActorConfigComp>(this, B1GlobalFNames.PlaceholderActorConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_PlaceholderActorDataComp>(this, B1GlobalFNames.PlaceholderActorComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUPlaceholderActorBase");
		PlaceholderActorConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlaceholderActorConfig");
		PlaceholderActorConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlaceholderActorConfig", Classes.FObjectProperty);
	}

	static BGUPlaceholderActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPlaceholderActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPlaceholderActorBase));
	}
}
