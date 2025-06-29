using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionSkyAtmosphereLightDirection : UMaterialExpression
{
	private static bool LightIndex_IsValid;

	private static int LightIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection:LightIndex")]
	public int LightIndex
	{
		get
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection:LightIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LightIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection:LightIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LightIndex_Offset), value);
			}
		}
	}

	static UMaterialExpressionSkyAtmosphereLightDirection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionSkyAtmosphereLightDirection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionSkyAtmosphereLightDirection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection");
		LightIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightIndex");
		LightIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightIndex", Classes.FIntProperty);
	}
}
