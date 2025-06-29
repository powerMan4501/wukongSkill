using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSetting")]
public class BGWDataAsset_SpiderSetting : UBGWDataAsset
{
	private static bool SpiderSetting_IsValid;

	private static int SpiderSetting_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSetting:SpiderSetting")]
	public FAnimHumanoidSetting_Spider SpiderSetting
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSetting:SpiderSetting");
				return default(FAnimHumanoidSetting_Spider);
			}
			return FAnimHumanoidSetting_Spider.FromNative(IntPtr.Add(base.Address, SpiderSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSetting:SpiderSetting");
			}
			else
			{
				FAnimHumanoidSetting_Spider.ToNative(IntPtr.Add(base.Address, SpiderSetting_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SpiderSetting");
		SpiderSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSetting");
		SpiderSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSetting", Classes.FStructProperty);
	}

	static BGWDataAsset_SpiderSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SpiderSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SpiderSetting));
	}
}
