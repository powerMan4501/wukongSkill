using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_MultiKillConf")]
public class BGW_MultiKillConf : UBGWDataAsset
{
	private static bool MultiKillTime_IsValid;

	private static int MultiKillTime_Offset;

	private static bool UnparalleledValueBase_IsValid;

	private static int UnparalleledValueBase_Offset;

	private static bool UnparalleledRateMax_IsValid;

	private static int UnparalleledRateMax_Offset;

	private static bool UnparalleledRateBase_IsValid;

	private static int UnparalleledRateBase_Offset;

	private static bool UnparalleledValueMax_IsValid;

	private static int UnparalleledValueMax_Offset;

	private static bool UnparalleledValueSpeed_IsValid;

	private static int UnparalleledValueSpeed_Offset;

	private static bool UnparalleledRange_IsValid;

	private static int UnparalleledRange_Offset;

	private static bool RebirthStayTime_IsValid;

	private static int RebirthStayTime_Offset;

	private static bool RebirthCount_IsValid;

	private static int RebirthCount_Offset;

	private static bool UnparalleledRotaX_IsValid;

	private static int UnparalleledRotaX_Offset;

	private static bool UnparalleledRotaY_IsValid;

	private static int UnparalleledRotaY_Offset;

	private static bool UnparalleledSelectBack_IsValid;

	private static int UnparalleledSelectBack_Offset;

	private static FFieldAddress UnparalleledSelectBack_PropertyAddress;

	private static bool MICBOnceChangeValue_IsValid;

	private static int MICBOnceChangeValue_Offset;

	private static bool MIFBOnceChangeValue_IsValid;

	private static int MIFBOnceChangeValue_Offset;

	private static bool UnparalleledFreedomTime_IsValid;

	private static int UnparalleledFreedomTime_Offset;

	[Category("战斗相关")]
	[Tooltip("连杀状态持续时间")]
	[DisplayName("连杀状态持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:MultiKillTime")]
	public float MultiKillTime
	{
		get
		{
			CheckDestroyed();
			if (!MultiKillTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MultiKillTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MultiKillTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiKillTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MultiKillTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MultiKillTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("战斗相关")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("每击杀一个人增加一点基础无双值")]
	[DisplayName("每击杀一个人增加一点基础无双值")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueBase")]
	public int UnparalleledValueBase
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledValueBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueBase");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UnparalleledValueBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledValueBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueBase");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UnparalleledValueBase_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无双值倍率上限")]
	[Tooltip("无双值倍率上限")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateMax")]
	public int UnparalleledRateMax
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledRateMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UnparalleledRateMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledRateMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UnparalleledRateMax_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("战斗相关")]
	[Tooltip("无双倍率每层增加百分比")]
	[DisplayName("无双倍率每层增加百分比")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateBase")]
	public float UnparalleledRateBase
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledRateBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateBase");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledRateBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledRateBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRateBase");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledRateBase_Offset), value);
			}
		}
	}

	[DisplayName("无双值上限")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("无双值上限")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueMax")]
	public int UnparalleledValueMax
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledValueMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UnparalleledValueMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledValueMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UnparalleledValueMax_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("无双值自动增长速率")]
	[Tooltip("无双值自动增长速率")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueSpeed")]
	public float UnparalleledValueSpeed
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledValueSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledValueSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledValueSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledValueSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledValueSpeed_Offset), value);
			}
		}
	}

	[Tooltip("无双影响AI半径")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无双影响AI半径")]
	[Category("战斗相关")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRange")]
	public float UnparalleledRange
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledRange_Offset), value);
			}
		}
	}

	[Category("战斗相关")]
	[BlueprintReadWrite]
	[Tooltip("复活停留时间")]
	[EditAnywhere]
	[DisplayName("复活停留时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:RebirthStayTime")]
	public float RebirthStayTime
	{
		get
		{
			CheckDestroyed();
			if (!RebirthStayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:RebirthStayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RebirthStayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthStayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:RebirthStayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RebirthStayTime_Offset), value);
			}
		}
	}

	[Tooltip("复活次数")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗相关")]
	[DisplayName("复活次数")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:RebirthCount")]
	public int RebirthCount
	{
		get
		{
			CheckDestroyed();
			if (!RebirthCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:RebirthCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RebirthCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:RebirthCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RebirthCount_Offset), value);
			}
		}
	}

	[Tooltip("无双固定角度X")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无双固定角度")]
	[Category("无双配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaX")]
	public float UnparalleledRotaX
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledRotaX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledRotaX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledRotaX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledRotaX_Offset), value);
			}
		}
	}

	[Tooltip("无双固定角度Y")]
	[Category("无双配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无双固定角度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaY")]
	public float UnparalleledRotaY
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledRotaY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledRotaY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledRotaY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledRotaY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledRotaY_Offset), value);
			}
		}
	}

	[DisplayName("无双结束后恢复原角色")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("无双结束后恢复原角色")]
	[Category("无双配置")]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledSelectBack")]
	public bool UnparalleledSelectBack
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledSelectBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledSelectBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UnparalleledSelectBack_Offset), 0, UnparalleledSelectBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledSelectBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledSelectBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UnparalleledSelectBack_Offset), 0, UnparalleledSelectBack_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("MICBOnceChangeValue")]
	[Tooltip("MICBOnceChangeValue")]
	[Category("无双值UI配置")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:MICBOnceChangeValue")]
	public float MICBOnceChangeValue
	{
		get
		{
			CheckDestroyed();
			if (!MICBOnceChangeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MICBOnceChangeValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MICBOnceChangeValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MICBOnceChangeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MICBOnceChangeValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MICBOnceChangeValue_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("MIFBOnceChangeValue")]
	[DisplayName("MIFBOnceChangeValue")]
	[UProperty]
	[Category("无双值UI配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:MIFBOnceChangeValue")]
	public float MIFBOnceChangeValue
	{
		get
		{
			CheckDestroyed();
			if (!MIFBOnceChangeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MIFBOnceChangeValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MIFBOnceChangeValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MIFBOnceChangeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:MIFBOnceChangeValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MIFBOnceChangeValue_Offset), value);
			}
		}
	}

	[Category("自由无双模式")]
	[DisplayName("自由无双模式持续时间")]
	[UProperty]
	[Tooltip("自由无双模式持续时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledFreedomTime")]
	public float UnparalleledFreedomTime
	{
		get
		{
			CheckDestroyed();
			if (!UnparalleledFreedomTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledFreedomTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnparalleledFreedomTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnparalleledFreedomTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_MultiKillConf:UnparalleledFreedomTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnparalleledFreedomTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_MultiKillConf");
		MultiKillTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MultiKillTime");
		MultiKillTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MultiKillTime", Classes.FFloatProperty);
		UnparalleledValueBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledValueBase");
		UnparalleledValueBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledValueBase", Classes.FIntProperty);
		UnparalleledRateMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledRateMax");
		UnparalleledRateMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledRateMax", Classes.FIntProperty);
		UnparalleledRateBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledRateBase");
		UnparalleledRateBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledRateBase", Classes.FFloatProperty);
		UnparalleledValueMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledValueMax");
		UnparalleledValueMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledValueMax", Classes.FIntProperty);
		UnparalleledValueSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledValueSpeed");
		UnparalleledValueSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledValueSpeed", Classes.FFloatProperty);
		UnparalleledRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledRange");
		UnparalleledRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledRange", Classes.FFloatProperty);
		RebirthStayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthStayTime");
		RebirthStayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthStayTime", Classes.FFloatProperty);
		RebirthCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthCount");
		RebirthCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthCount", Classes.FIntProperty);
		UnparalleledRotaX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledRotaX");
		UnparalleledRotaX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledRotaX", Classes.FFloatProperty);
		UnparalleledRotaY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledRotaY");
		UnparalleledRotaY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledRotaY", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UnparalleledSelectBack_PropertyAddress, unrealStruct, "UnparalleledSelectBack");
		UnparalleledSelectBack_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledSelectBack");
		UnparalleledSelectBack_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledSelectBack", Classes.FBoolProperty);
		MICBOnceChangeValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MICBOnceChangeValue");
		MICBOnceChangeValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MICBOnceChangeValue", Classes.FFloatProperty);
		MIFBOnceChangeValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MIFBOnceChangeValue");
		MIFBOnceChangeValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MIFBOnceChangeValue", Classes.FFloatProperty);
		UnparalleledFreedomTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnparalleledFreedomTime");
		UnparalleledFreedomTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnparalleledFreedomTime", Classes.FFloatProperty);
	}

	static BGW_MultiKillConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_MultiKillConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_MultiKillConf));
	}
}
