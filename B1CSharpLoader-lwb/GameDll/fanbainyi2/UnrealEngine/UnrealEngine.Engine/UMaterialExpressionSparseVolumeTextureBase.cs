using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionSparseVolumeTextureBase", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionSparseVolumeTextureBase : UMaterialExpression
{
	private static bool SparseVolumeTexture_IsValid;

	private static int SparseVolumeTexture_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionSparseVolumeTextureBase:SparseVolumeTexture")]
	public USparseVolumeTexture SparseVolumeTexture
	{
		get
		{
			CheckDestroyed();
			if (!SparseVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSparseVolumeTextureBase:SparseVolumeTexture");
				return null;
			}
			return UObjectMarshaler<USparseVolumeTexture>.FromNative(IntPtr.Add(base.Address, SparseVolumeTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SparseVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSparseVolumeTextureBase:SparseVolumeTexture");
			}
			else
			{
				UObjectMarshaler<USparseVolumeTexture>.ToNative(IntPtr.Add(base.Address, SparseVolumeTexture_Offset), value);
			}
		}
	}

	static UMaterialExpressionSparseVolumeTextureBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionSparseVolumeTextureBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionSparseVolumeTextureBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionSparseVolumeTextureBase");
		SparseVolumeTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SparseVolumeTexture");
		SparseVolumeTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SparseVolumeTexture", Classes.FObjectProperty);
	}
}
