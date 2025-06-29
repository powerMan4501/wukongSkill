using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf")]
public class BGW_CtrlHeroIdConf : UBGWDataAsset
{
	private static bool HeroBPArray_IsValid;

	private static int HeroBPArray_Offset;

	private static FFieldAddress HeroBPArray_PropertyAddress;

	private TArrayReadWriteMarshaler<string> HeroBPArray_Marshaler;

	private static bool HeroCtrlRotaSpeed_IsValid;

	private static int HeroCtrlRotaSpeed_Offset;

	private static bool HeroCtrlSensitivity_IsValid;

	private static int HeroCtrlSensitivity_Offset;

	private static bool HeroCtrlDebounce_IsValid;

	private static int HeroCtrlDebounce_Offset;

	private static bool AnimDeadZoneRadius_IsValid;

	private static int AnimDeadZoneRadius_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("玩家可控制的英雄蓝图配置")]
	[Category("战斗相关")]
	[Tooltip("玩家可控制的英雄蓝图配置")]
	[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroBPArray")]
	public TArrayReadWrite<string> HeroBPArray
	{
		get
		{
			CheckDestroyed();
			if (!HeroBPArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroBPArray");
				return null;
			}
			if (HeroBPArray_Marshaler == null)
			{
				HeroBPArray_Marshaler = new TArrayReadWriteMarshaler<string>(1, HeroBPArray_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return HeroBPArray_Marshaler.FromNative(IntPtr.Add(base.Address, HeroBPArray_Offset));
		}
	}

	[UProperty]
	[Category("战斗相关")]
	[Tooltip("摇杆转身速度")]
	[DisplayName("摇杆转身速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlRotaSpeed")]
	public int HeroCtrlRotaSpeed
	{
		get
		{
			CheckDestroyed();
			if (!HeroCtrlRotaSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlRotaSpeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HeroCtrlRotaSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeroCtrlRotaSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlRotaSpeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HeroCtrlRotaSpeed_Offset), value);
			}
		}
	}

	[Category("战斗相关")]
	[Tooltip("摇杆灵敏度")]
	[DisplayName("摇杆灵敏度")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlSensitivity")]
	public int HeroCtrlSensitivity
	{
		get
		{
			CheckDestroyed();
			if (!HeroCtrlSensitivity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlSensitivity");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HeroCtrlSensitivity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeroCtrlSensitivity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlSensitivity");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HeroCtrlSensitivity_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("摇杆防抖动")]
	[Tooltip("摇杆防抖动")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlDebounce")]
	public float HeroCtrlDebounce
	{
		get
		{
			CheckDestroyed();
			if (!HeroCtrlDebounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlDebounce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeroCtrlDebounce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeroCtrlDebounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:HeroCtrlDebounce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeroCtrlDebounce_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("左摇杆瞄准DeadZone半径")]
	[Tooltip("摇杆瞄准DeadZone半径")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_CtrlHeroIdConf:AnimDeadZoneRadius")]
	public float AnimDeadZoneRadius
	{
		get
		{
			CheckDestroyed();
			if (!AnimDeadZoneRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:AnimDeadZoneRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimDeadZoneRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDeadZoneRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CtrlHeroIdConf:AnimDeadZoneRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimDeadZoneRadius_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_CtrlHeroIdConf");
		NativeReflection.GetPropertyRef(ref HeroBPArray_PropertyAddress, unrealStruct, "HeroBPArray");
		HeroBPArray_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeroBPArray");
		HeroBPArray_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeroBPArray", Classes.FArrayProperty);
		HeroCtrlRotaSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeroCtrlRotaSpeed");
		HeroCtrlRotaSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeroCtrlRotaSpeed", Classes.FIntProperty);
		HeroCtrlSensitivity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeroCtrlSensitivity");
		HeroCtrlSensitivity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeroCtrlSensitivity", Classes.FIntProperty);
		HeroCtrlDebounce_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeroCtrlDebounce");
		HeroCtrlDebounce_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeroCtrlDebounce", Classes.FFloatProperty);
		AnimDeadZoneRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimDeadZoneRadius");
		AnimDeadZoneRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimDeadZoneRadius", Classes.FFloatProperty);
	}

	static BGW_CtrlHeroIdConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CtrlHeroIdConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CtrlHeroIdConf));
	}
}
