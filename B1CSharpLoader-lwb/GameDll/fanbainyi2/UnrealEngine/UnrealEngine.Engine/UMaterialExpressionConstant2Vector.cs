using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionConstant2Vector", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionConstant2Vector : UMaterialExpression
{
	private static bool R_IsValid;

	private static int R_Offset;

	private static bool G_IsValid;

	private static int G_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionConstant2Vector:R")]
	public float R
	{
		get
		{
			CheckDestroyed();
			if (!R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant2Vector:R");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant2Vector:R");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, R_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionConstant2Vector:G")]
	public float G
	{
		get
		{
			CheckDestroyed();
			if (!G_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant2Vector:G");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, G_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!G_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant2Vector:G");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, G_Offset), value);
			}
		}
	}

	static UMaterialExpressionConstant2Vector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionConstant2Vector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionConstant2Vector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionConstant2Vector");
		R_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "R");
		R_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "R", Classes.FFloatProperty);
		G_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "G");
		G_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "G", Classes.FFloatProperty);
	}
}
