using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperSprite", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperSprite : UObject, IInterface_CollisionDataProvider, IInterface, ISlateTextureAtlasInterface
{
	private static bool DefaultMaterial_IsValid;

	private static int DefaultMaterial_Offset;

	private static bool AlternateMaterial_IsValid;

	private static int AlternateMaterial_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Paper2D.PaperSprite:DefaultMaterial")]
	protected UMaterialInterface DefaultMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DefaultMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSprite:DefaultMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DefaultMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSprite:DefaultMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DefaultMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Paper2D.PaperSprite:AlternateMaterial")]
	protected UMaterialInterface AlternateMaterial
	{
		get
		{
			CheckDestroyed();
			if (!AlternateMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSprite:AlternateMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, AlternateMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlternateMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSprite:AlternateMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, AlternateMaterial_Offset), value);
			}
		}
	}

	static UPaperSprite()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperSprite)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperSprite));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperSprite");
		DefaultMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultMaterial");
		DefaultMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultMaterial", Classes.FObjectProperty);
		AlternateMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AlternateMaterial");
		AlternateMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AlternateMaterial", Classes.FObjectProperty);
	}
}
