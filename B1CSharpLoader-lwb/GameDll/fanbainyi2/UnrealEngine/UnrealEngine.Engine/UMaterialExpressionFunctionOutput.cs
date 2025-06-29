using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionFunctionOutput", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionFunctionOutput : UMaterialExpression
{
	private static bool OutputName_IsValid;

	private static int OutputName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionOutput:OutputName")]
	public FName OutputName
	{
		get
		{
			CheckDestroyed();
			if (!OutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionOutput:OutputName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionOutput:OutputName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputName_Offset), value);
			}
		}
	}

	static UMaterialExpressionFunctionOutput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionFunctionOutput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionFunctionOutput));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionFunctionOutput");
		OutputName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputName");
		OutputName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputName", Classes.FNameProperty);
	}
}
