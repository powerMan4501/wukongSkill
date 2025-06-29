using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset")]
internal class BGWCharaterAnimMgrDataAsset : UBGWDataAsset
{
	private static bool anim_IsValid;

	private static int anim_Offset;

	private static bool ExAS_Default_IsValid;

	private static int ExAS_Default_Offset;

	private static bool ExBS_Patrol_IsValid;

	private static int ExBS_Patrol_Offset;

	private static bool ExAS_EQSRun_IsValid;

	private static int ExAS_EQSRun_Offset;

	private static bool ExAS_Shield_IsValid;

	private static int ExAS_Shield_Offset;

	private static bool ExAS_PowerStorage_IsValid;

	private static int ExAS_PowerStorage_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:anim")]
	public int anim
	{
		get
		{
			CheckDestroyed();
			if (!anim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:anim");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, anim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!anim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:anim");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, anim_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Default")]
	public FBUAnimSettingsLocomotionEx ExAS_Default
	{
		get
		{
			CheckDestroyed();
			if (!ExAS_Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Default");
				return default(FBUAnimSettingsLocomotionEx);
			}
			return FBUAnimSettingsLocomotionEx.FromNative(IntPtr.Add(base.Address, ExAS_Default_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExAS_Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Default");
			}
			else
			{
				FBUAnimSettingsLocomotionEx.ToNative(IntPtr.Add(base.Address, ExAS_Default_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExBS_Patrol")]
	public PatrolBlendSpaceSetting ExBS_Patrol
	{
		get
		{
			CheckDestroyed();
			if (!ExBS_Patrol_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExBS_Patrol");
				return default(PatrolBlendSpaceSetting);
			}
			return PatrolBlendSpaceSetting.FromNative(IntPtr.Add(base.Address, ExBS_Patrol_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExBS_Patrol_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExBS_Patrol");
			}
			else
			{
				PatrolBlendSpaceSetting.ToNative(IntPtr.Add(base.Address, ExBS_Patrol_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_EQSRun")]
	public FBUAnimSettingsLocomotionEx ExAS_EQSRun
	{
		get
		{
			CheckDestroyed();
			if (!ExAS_EQSRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_EQSRun");
				return default(FBUAnimSettingsLocomotionEx);
			}
			return FBUAnimSettingsLocomotionEx.FromNative(IntPtr.Add(base.Address, ExAS_EQSRun_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExAS_EQSRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_EQSRun");
			}
			else
			{
				FBUAnimSettingsLocomotionEx.ToNative(IntPtr.Add(base.Address, ExAS_EQSRun_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Shield")]
	public FBUAnimSettingsLocomotionEx ExAS_Shield
	{
		get
		{
			CheckDestroyed();
			if (!ExAS_Shield_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Shield");
				return default(FBUAnimSettingsLocomotionEx);
			}
			return FBUAnimSettingsLocomotionEx.FromNative(IntPtr.Add(base.Address, ExAS_Shield_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExAS_Shield_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_Shield");
			}
			else
			{
				FBUAnimSettingsLocomotionEx.ToNative(IntPtr.Add(base.Address, ExAS_Shield_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_PowerStorage")]
	public FBUAnimSettingsLocomotionEx ExAS_PowerStorage
	{
		get
		{
			CheckDestroyed();
			if (!ExAS_PowerStorage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_PowerStorage");
				return default(FBUAnimSettingsLocomotionEx);
			}
			return FBUAnimSettingsLocomotionEx.FromNative(IntPtr.Add(base.Address, ExAS_PowerStorage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExAS_PowerStorage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset:ExAS_PowerStorage");
			}
			else
			{
				FBUAnimSettingsLocomotionEx.ToNative(IntPtr.Add(base.Address, ExAS_PowerStorage_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWCharaterAnimMgrDataAsset");
		anim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "anim");
		anim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "anim", Classes.FIntProperty);
		ExAS_Default_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExAS_Default");
		ExAS_Default_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExAS_Default", Classes.FStructProperty);
		ExBS_Patrol_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExBS_Patrol");
		ExBS_Patrol_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExBS_Patrol", Classes.FStructProperty);
		ExAS_EQSRun_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExAS_EQSRun");
		ExAS_EQSRun_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExAS_EQSRun", Classes.FStructProperty);
		ExAS_Shield_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExAS_Shield");
		ExAS_Shield_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExAS_Shield", Classes.FStructProperty);
		ExAS_PowerStorage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExAS_PowerStorage");
		ExAS_PowerStorage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExAS_PowerStorage", Classes.FStructProperty);
	}

	static BGWCharaterAnimMgrDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGWCharaterAnimMgrDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGWCharaterAnimMgrDataAsset));
	}
}
