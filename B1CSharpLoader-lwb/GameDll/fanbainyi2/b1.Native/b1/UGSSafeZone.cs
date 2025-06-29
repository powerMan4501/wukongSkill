using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSSafeZone", "UnrealExtent", UnrealModuleType.Game)]
public class UGSSafeZone : UWidget
{
	private static bool SafeZoneBrushColor_IsValid;

	private static int SafeZoneBrushColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSSafeZone:SafeZoneBrushColor")]
	public FLinearColor SafeZoneBrushColor
	{
		get
		{
			CheckDestroyed();
			if (!SafeZoneBrushColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSSafeZone:SafeZoneBrushColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SafeZoneBrushColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SafeZoneBrushColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSSafeZone:SafeZoneBrushColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SafeZoneBrushColor_Offset), value);
			}
		}
	}

	static UGSSafeZone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSSafeZone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSSafeZone));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSSafeZone");
		SafeZoneBrushColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SafeZoneBrushColor");
		SafeZoneBrushColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SafeZoneBrushColor", Classes.FStructProperty);
	}
}
