using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionConstantDouble", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionConstantDouble : UMaterialExpressionGenericConstant
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionConstantDouble:Value")]
	public double Value
	{
		get
		{
			CheckDestroyed();
			if (!Value_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstantDouble:Value");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, Value_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Value_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionConstantDouble:Value");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, Value_Offset), value);
			}
		}
	}

	static UMaterialExpressionConstantDouble()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionConstantDouble)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionConstantDouble));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionConstantDouble");
		Value_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Value", Classes.FDoubleProperty);
	}
}
