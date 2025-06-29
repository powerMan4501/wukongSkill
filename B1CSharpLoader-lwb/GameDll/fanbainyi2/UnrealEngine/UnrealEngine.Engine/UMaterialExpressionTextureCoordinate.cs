using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionTextureCoordinate", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionTextureCoordinate : UMaterialExpression
{
	private static bool CoordinateIndex_IsValid;

	private static int CoordinateIndex_Offset;

	private static bool UTiling_IsValid;

	private static int UTiling_Offset;

	private static bool VTiling_IsValid;

	private static int VTiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionTextureCoordinate:CoordinateIndex")]
	public int CoordinateIndex
	{
		get
		{
			CheckDestroyed();
			if (!CoordinateIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:CoordinateIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CoordinateIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CoordinateIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:CoordinateIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CoordinateIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionTextureCoordinate:UTiling")]
	public float UTiling
	{
		get
		{
			CheckDestroyed();
			if (!UTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:UTiling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UTiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:UTiling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UTiling_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionTextureCoordinate:VTiling")]
	public float VTiling
	{
		get
		{
			CheckDestroyed();
			if (!VTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:VTiling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VTiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureCoordinate:VTiling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VTiling_Offset), value);
			}
		}
	}

	static UMaterialExpressionTextureCoordinate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionTextureCoordinate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionTextureCoordinate));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionTextureCoordinate");
		CoordinateIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CoordinateIndex");
		CoordinateIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CoordinateIndex", Classes.FIntProperty);
		UTiling_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UTiling");
		UTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UTiling", Classes.FFloatProperty);
		VTiling_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VTiling");
		VTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VTiling", Classes.FFloatProperty);
	}
}
