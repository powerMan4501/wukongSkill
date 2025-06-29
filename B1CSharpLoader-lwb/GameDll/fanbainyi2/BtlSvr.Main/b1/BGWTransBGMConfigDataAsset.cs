using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWTransBGMConfigDataAsset")]
public class BGWTransBGMConfigDataAsset : UBGWDataAsset
{
	private static bool TransBGMConfig_IsValid;

	private static int TransBGMConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("变身BGM配置")]
	[USharpPath("/Script/b1-Managed.BGWTransBGMConfigDataAsset:TransBGMConfig")]
	public FSingleTransBGMConfig TransBGMConfig
	{
		get
		{
			CheckDestroyed();
			if (!TransBGMConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTransBGMConfigDataAsset:TransBGMConfig");
				return default(FSingleTransBGMConfig);
			}
			return FSingleTransBGMConfig.FromNative(IntPtr.Add(base.Address, TransBGMConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransBGMConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTransBGMConfigDataAsset:TransBGMConfig");
			}
			else
			{
				FSingleTransBGMConfig.ToNative(IntPtr.Add(base.Address, TransBGMConfig_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWTransBGMConfigDataAsset");
		TransBGMConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TransBGMConfig");
		TransBGMConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TransBGMConfig", Classes.FStructProperty);
	}

	static BGWTransBGMConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWTransBGMConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWTransBGMConfigDataAsset));
	}
}
