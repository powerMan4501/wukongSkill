using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MovieLevelStateRequestConfig")]
public struct FMovieLevelStateRequestConfig
{
	[DisplayName("关卡ID")]
	[Category("Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieLevelStateRequestConfig:LevelID")]
	public int LevelID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("关卡状态配置DataAssetID")]
	[USharpPath("/Script/b1-Managed.MovieLevelStateRequestConfig:ConfigID")]
	public int ConfigID;

	private static int MovieLevelStateRequestConfig_StructSize;

	public FMovieLevelStateRequestConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MovieLevelStateRequestConfig");
		MovieLevelStateRequestConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMovieLevelStateRequestConfig));
	}

	static FMovieLevelStateRequestConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieLevelStateRequestConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieLevelStateRequestConfig));
	}
}
