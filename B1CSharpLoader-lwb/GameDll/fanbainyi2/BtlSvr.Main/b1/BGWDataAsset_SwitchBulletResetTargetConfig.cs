using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig")]
public class BGWDataAsset_SwitchBulletResetTargetConfig : UBGWDataAsset
{
	private static bool TargetBase_IsValid;

	private static int TargetBase_Offset;

	private static bool TargetPosOffsetInfo_IsValid;

	private static int TargetPosOffsetInfo_Offset;

	[DisplayName("目标基准")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetBase")]
	public ProjectileBaseStruct TargetBase
	{
		get
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetBase");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, TargetBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetBase");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, TargetBase_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("目标偏移")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetPosOffsetInfo")]
	public ProjectilePosOffsetStruct TargetPosOffsetInfo
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetPosOffsetInfo");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig:TargetPosOffsetInfo");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SwitchBulletResetTargetConfig");
		TargetBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetBase");
		TargetBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetBase", Classes.FStructProperty);
		TargetPosOffsetInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetPosOffsetInfo");
		TargetPosOffsetInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetPosOffsetInfo", Classes.FStructProperty);
	}

	static BGWDataAsset_SwitchBulletResetTargetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SwitchBulletResetTargetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SwitchBulletResetTargetConfig));
	}
}
