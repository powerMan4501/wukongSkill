using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionSkyAtmosphereLightIlluminance : UMaterialExpression
{
	private static bool LightIndex_IsValid;

	private static int LightIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance:LightIndex")]
	public int LightIndex
	{
		get
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance:LightIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LightIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance:LightIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LightIndex_Offset), value);
			}
		}
	}

	static UMaterialExpressionSkyAtmosphereLightIlluminance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionSkyAtmosphereLightIlluminance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionSkyAtmosphereLightIlluminance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance");
		LightIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightIndex");
		LightIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightIndex", Classes.FIntProperty);
	}
}
