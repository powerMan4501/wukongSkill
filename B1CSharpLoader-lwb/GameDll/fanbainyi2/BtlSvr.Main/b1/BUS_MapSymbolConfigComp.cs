using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MapSymbolConfigComp")]
public class BUS_MapSymbolConfigComp : UActorEditCompBase
{
	private static bool MapSymbolConfig_IsValid;

	private static int MapSymbolConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("MapSymbolConfig")]
	[USharpPath("/Script/b1-Managed.BUS_MapSymbolConfigComp:MapSymbolConfig")]
	public FMapSymbolConfig MapSymbolConfig
	{
		get
		{
			CheckDestroyed();
			if (!MapSymbolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MapSymbolConfigComp:MapSymbolConfig");
				return default(FMapSymbolConfig);
			}
			return FMapSymbolConfig.FromNative(IntPtr.Add(base.Address, MapSymbolConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapSymbolConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MapSymbolConfigComp:MapSymbolConfig");
			}
			else
			{
				FMapSymbolConfig.ToNative(IntPtr.Add(base.Address, MapSymbolConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_MapSymbolConfigComp");
		MapSymbolConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapSymbolConfig");
		MapSymbolConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapSymbolConfig", Classes.FStructProperty);
	}

	static BUS_MapSymbolConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MapSymbolConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MapSymbolConfigComp));
	}
}
