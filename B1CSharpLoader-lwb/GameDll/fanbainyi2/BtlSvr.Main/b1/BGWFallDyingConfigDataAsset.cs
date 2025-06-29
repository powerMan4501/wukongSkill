using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset")]
public class BGWFallDyingConfigDataAsset : UBGWDataAsset
{
	private static bool SaveSelfWaitTime_IsValid;

	private static int SaveSelfWaitTime_Offset;

	private static bool SaveSelfNeedTime_IsValid;

	private static int SaveSelfNeedTime_Offset;

	private static bool SaveTeammateWaitTime_IsValid;

	private static int SaveTeammateWaitTime_Offset;

	private static bool FallDyingLifeTime_IsValid;

	private static int FallDyingLifeTime_Offset;

	private static bool TeamRebirthSkillID_IsValid;

	private static int TeamRebirthSkillID_Offset;

	private static bool SelfRebirthSkillID_IsValid;

	private static int SelfRebirthSkillID_Offset;

	private static bool ChallengeRebirthTime_IsValid;

	private static int ChallengeRebirthTime_Offset;

	[DisplayName("自救等待时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfWaitTime")]
	public int SaveSelfWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!SaveSelfWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfWaitTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SaveSelfWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SaveSelfWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SaveSelfWaitTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("自救所需时间")]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfNeedTime")]
	public int SaveSelfNeedTime
	{
		get
		{
			CheckDestroyed();
			if (!SaveSelfNeedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfNeedTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SaveSelfNeedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SaveSelfNeedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveSelfNeedTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SaveSelfNeedTime_Offset), value);
			}
		}
	}

	[DisplayName("拉起队友等待时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveTeammateWaitTime")]
	public int SaveTeammateWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!SaveTeammateWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveTeammateWaitTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SaveTeammateWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SaveTeammateWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SaveTeammateWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SaveTeammateWaitTime_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("倒地存活时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:FallDyingLifeTime")]
	public int FallDyingLifeTime
	{
		get
		{
			CheckDestroyed();
			if (!FallDyingLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:FallDyingLifeTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FallDyingLifeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallDyingLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:FallDyingLifeTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FallDyingLifeTime_Offset), value);
			}
		}
	}

	[DisplayName("队友救援复活技能")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:TeamRebirthSkillID")]
	public int TeamRebirthSkillID
	{
		get
		{
			CheckDestroyed();
			if (!TeamRebirthSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:TeamRebirthSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TeamRebirthSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeamRebirthSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:TeamRebirthSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TeamRebirthSkillID_Offset), value);
			}
		}
	}

	[DisplayName("自救复活技能")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SelfRebirthSkillID")]
	public int SelfRebirthSkillID
	{
		get
		{
			CheckDestroyed();
			if (!SelfRebirthSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SelfRebirthSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SelfRebirthSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelfRebirthSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:SelfRebirthSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SelfRebirthSkillID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("试炼中死亡表演时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWFallDyingConfigDataAsset:ChallengeRebirthTime")]
	public int ChallengeRebirthTime
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeRebirthTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:ChallengeRebirthTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeRebirthTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeRebirthTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWFallDyingConfigDataAsset:ChallengeRebirthTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeRebirthTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWFallDyingConfigDataAsset");
		SaveSelfWaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SaveSelfWaitTime");
		SaveSelfWaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SaveSelfWaitTime", Classes.FIntProperty);
		SaveSelfNeedTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SaveSelfNeedTime");
		SaveSelfNeedTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SaveSelfNeedTime", Classes.FIntProperty);
		SaveTeammateWaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SaveTeammateWaitTime");
		SaveTeammateWaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SaveTeammateWaitTime", Classes.FIntProperty);
		FallDyingLifeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FallDyingLifeTime");
		FallDyingLifeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FallDyingLifeTime", Classes.FIntProperty);
		TeamRebirthSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeamRebirthSkillID");
		TeamRebirthSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeamRebirthSkillID", Classes.FIntProperty);
		SelfRebirthSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelfRebirthSkillID");
		SelfRebirthSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelfRebirthSkillID", Classes.FIntProperty);
		ChallengeRebirthTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChallengeRebirthTime");
		ChallengeRebirthTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChallengeRebirthTime", Classes.FIntProperty);
	}

	static BGWFallDyingConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWFallDyingConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWFallDyingConfigDataAsset));
	}
}
