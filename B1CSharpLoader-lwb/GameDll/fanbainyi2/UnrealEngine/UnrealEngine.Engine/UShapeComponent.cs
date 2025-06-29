using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821039269uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ShapeComponent", "Engine", UnrealModuleType.Engine)]
public class UShapeComponent : UPrimitiveComponent
{
	private static bool ShapeColor_IsValid;

	private static int ShapeColor_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.ShapeComponent:ShapeColor")]
	public FColor ShapeColor
	{
		get
		{
			CheckDestroyed();
			if (!ShapeColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ShapeComponent:ShapeColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, ShapeColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShapeColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ShapeComponent:ShapeColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, ShapeColor_Offset), value);
			}
		}
	}

	static UShapeComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UShapeComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UShapeComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ShapeComponent");
		ShapeColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShapeColor");
		ShapeColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShapeColor", Classes.FStructProperty);
	}
}
