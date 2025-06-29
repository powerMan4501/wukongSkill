using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Brush", "Engine", UnrealModuleType.Engine)]
public class ABrush : AActor
{
	private static bool BrushComponent_IsValid;

	private static int BrushComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.Brush:BrushComponent")]
	public UBrushComponent BrushComponent
	{
		get
		{
			CheckDestroyed();
			if (!BrushComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Brush:BrushComponent");
				return null;
			}
			return UObjectMarshaler<UBrushComponent>.FromNative(IntPtr.Add(base.Address, BrushComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Brush:BrushComponent");
			}
			else
			{
				UObjectMarshaler<UBrushComponent>.ToNative(IntPtr.Add(base.Address, BrushComponent_Offset), value);
			}
		}
	}

	static ABrush()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABrush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABrush));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Brush");
		BrushComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BrushComponent");
		BrushComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BrushComponent", Classes.FObjectProperty);
	}
}
