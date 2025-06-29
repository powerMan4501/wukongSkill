using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionConstant", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionConstant : UMaterialExpression
{
	private static bool R_IsValid;

	private static int R_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionConstant:R")]
	public float R
	{
		get
		{
			CheckDestroyed();
			if (!R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant:R");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant:R");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, R_Offset), value);
			}
		}
	}

	static UMaterialExpressionConstant()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionConstant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionConstant));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionConstant");
		R_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "R");
		R_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "R", Classes.FFloatProperty);
	}
}
