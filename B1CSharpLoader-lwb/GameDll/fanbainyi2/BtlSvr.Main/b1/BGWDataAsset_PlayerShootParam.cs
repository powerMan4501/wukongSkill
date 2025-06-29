using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam")]
internal class BGWDataAsset_PlayerShootParam : UBGWDataAsset
{
	private static bool BlazeDuration_IsValid;

	private static int BlazeDuration_Offset;

	private static bool OneLightShotStaminaCost_IsValid;

	private static int OneLightShotStaminaCost_Offset;

	private static bool StaminaFreezeTimer_IsValid;

	private static int StaminaFreezeTimer_Offset;

	private static bool ShootRadius_IsValid;

	private static int ShootRadius_Offset;

	private static bool LightShootSkillID_IsValid;

	private static int LightShootSkillID_Offset;

	private static bool LightShootEffectID_IsValid;

	private static int LightShootEffectID_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:BlazeDuration")]
	public float BlazeDuration
	{
		get
		{
			CheckDestroyed();
			if (!BlazeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:BlazeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlazeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlazeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:BlazeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlazeDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:OneLightShotStaminaCost")]
	public float OneLightShotStaminaCost
	{
		get
		{
			CheckDestroyed();
			if (!OneLightShotStaminaCost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:OneLightShotStaminaCost");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OneLightShotStaminaCost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OneLightShotStaminaCost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:OneLightShotStaminaCost");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OneLightShotStaminaCost_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:StaminaFreezeTimer")]
	public float StaminaFreezeTimer
	{
		get
		{
			CheckDestroyed();
			if (!StaminaFreezeTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:StaminaFreezeTimer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaminaFreezeTimer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaFreezeTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:StaminaFreezeTimer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaminaFreezeTimer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:ShootRadius")]
	public float ShootRadius
	{
		get
		{
			CheckDestroyed();
			if (!ShootRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:ShootRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShootRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShootRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:ShootRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShootRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootSkillID")]
	public int LightShootSkillID
	{
		get
		{
			CheckDestroyed();
			if (!LightShootSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LightShootSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightShootSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LightShootSkillID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootEffectID")]
	public int LightShootEffectID
	{
		get
		{
			CheckDestroyed();
			if (!LightShootEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LightShootEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightShootEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PlayerShootParam:LightShootEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LightShootEffectID_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PlayerShootParam");
		BlazeDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlazeDuration");
		BlazeDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlazeDuration", Classes.FFloatProperty);
		OneLightShotStaminaCost_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OneLightShotStaminaCost");
		OneLightShotStaminaCost_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OneLightShotStaminaCost", Classes.FFloatProperty);
		StaminaFreezeTimer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaFreezeTimer");
		StaminaFreezeTimer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaFreezeTimer", Classes.FFloatProperty);
		ShootRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShootRadius");
		ShootRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShootRadius", Classes.FFloatProperty);
		LightShootSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightShootSkillID");
		LightShootSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightShootSkillID", Classes.FIntProperty);
		LightShootEffectID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightShootEffectID");
		LightShootEffectID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightShootEffectID", Classes.FIntProperty);
	}

	static BGWDataAsset_PlayerShootParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGWDataAsset_PlayerShootParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGWDataAsset_PlayerShootParam));
	}
}
