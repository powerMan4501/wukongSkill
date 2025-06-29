using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionSkyAtmosphereLightDiskLuminance : UMaterialExpression
{
	private static bool LightIndex_IsValid;

	private static int LightIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance:LightIndex")]
	public int LightIndex
	{
		get
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance:LightIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LightIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance:LightIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LightIndex_Offset), value);
			}
		}
	}

	static UMaterialExpressionSkyAtmosphereLightDiskLuminance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionSkyAtmosphereLightDiskLuminance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionSkyAtmosphereLightDiskLuminance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance");
		LightIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightIndex");
		LightIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightIndex", Classes.FIntProperty);
	}
}
