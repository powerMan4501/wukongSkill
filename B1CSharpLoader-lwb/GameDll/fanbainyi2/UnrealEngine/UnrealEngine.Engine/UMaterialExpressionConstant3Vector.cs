using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionConstant3Vector", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionConstant3Vector : UMaterialExpression
{
	private static bool Constant_IsValid;

	private static int Constant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionConstant3Vector:Constant")]
	public FLinearColor Constant
	{
		get
		{
			CheckDestroyed();
			if (!Constant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant3Vector:Constant");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, Constant_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Constant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstant3Vector:Constant");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, Constant_Offset), value);
			}
		}
	}

	static UMaterialExpressionConstant3Vector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionConstant3Vector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionConstant3Vector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionConstant3Vector");
		Constant_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Constant");
		Constant_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Constant", Classes.FStructProperty);
	}
}
