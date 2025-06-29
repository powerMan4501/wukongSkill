using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp")]
public class BUS_DestructibleConfigComp : UActorEditCompBase
{
	private static bool MassLevel_IsValid;

	private static int MassLevel_Offset;

	private static FFieldAddress MassLevel_PropertyAddress;

	private static bool StrengthLevel_IsValid;

	private static int StrengthLevel_Offset;

	private static FFieldAddress StrengthLevel_PropertyAddress;

	private static bool DestroyedDebrisLifeTime_IsValid;

	private static int DestroyedDebrisLifeTime_Offset;

	private static bool DebrisDissipationTime_IsValid;

	private static int DebrisDissipationTime_Offset;

	private static bool CanParryStrengthLevel_IsValid;

	private static int CanParryStrengthLevel_Offset;

	private static FFieldAddress CanParryStrengthLevel_PropertyAddress;

	private TArrayReadWriteMarshaler<EGSHitDestructibleStrengthLevel> CanParryStrengthLevel_Marshaler;

	private static bool DestructibleParryEvent_IsValid;

	private static int DestructibleParryEvent_Offset;

	private static bool DestructibleParryDispConfig_IsValid;

	private static int DestructibleParryDispConfig_Offset;

	private static bool DestructionDropInfoID_IsValid;

	private static int DestructionDropInfoID_Offset;

	private static bool CanBeHitByBullet_IsValid;

	private static int CanBeHitByBullet_Offset;

	private static FFieldAddress CanBeHitByBullet_PropertyAddress;

	[Category("破碎物配置")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("破碎物移动破碎强度")]
	[Tooltip("面对角色移动碰撞时，破碎物的强度")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:MassLevel")]
	public DestructibleMassLevel MassLevel
	{
		get
		{
			CheckDestroyed();
			if (!MassLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:MassLevel");
				return DestructibleMassLevel.Basic;
			}
			return EnumMarshaler<DestructibleMassLevel>.FromNative(IntPtr.Add(base.Address, MassLevel_Offset), 0, MassLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MassLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:MassLevel");
			}
			else
			{
				EnumMarshaler<DestructibleMassLevel>.ToNative(IntPtr.Add(base.Address, MassLevel_Offset), 0, MassLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("破碎物面对受击时的强度")]
	[DisplayName("破碎物攻击破碎强度")]
	[Category("破碎物配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:StrengthLevel")]
	public DestructibleStrengthLevel StrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!StrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:StrengthLevel");
				return DestructibleStrengthLevel.LightHitDestroy;
			}
			return EnumMarshaler<DestructibleStrengthLevel>.FromNative(IntPtr.Add(base.Address, StrengthLevel_Offset), 0, StrengthLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:StrengthLevel");
			}
			else
			{
				EnumMarshaler<DestructibleStrengthLevel>.ToNative(IntPtr.Add(base.Address, StrengthLevel_Offset), 0, StrengthLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("破碎后物体销毁时间")]
	[Category("破碎物配置")]
	[Tooltip("破碎相应时间后会销毁破碎后的碎片及整个Actor，值小于等于0时不进行销毁，单位: s ")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:DestroyedDebrisLifeTime")]
	public float DestroyedDebrisLifeTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyedDebrisLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestroyedDebrisLifeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyedDebrisLifeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyedDebrisLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestroyedDebrisLifeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyedDebrisLifeTime_Offset), value);
			}
		}
	}

	[DisplayName("销毁前碎片渐隐时间")]
	[Category("破碎物配置")]
	[Tooltip("破碎后碎片在销毁前的对应长度时间内会渐隐直至销毁，单位: s ")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:DebrisDissipationTime")]
	public float DebrisDissipationTime
	{
		get
		{
			CheckDestroyed();
			if (!DebrisDissipationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DebrisDissipationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebrisDissipationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebrisDissipationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DebrisDissipationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebrisDissipationTime_Offset), value);
			}
		}
	}

	[Category("破碎物弹刀配置")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("受到在列表中的强度的攻击，会对攻击者造成弹刀。")]
	[DisplayName("可弹刀的命中强度")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:CanParryStrengthLevel")]
	public TArrayReadWrite<EGSHitDestructibleStrengthLevel> CanParryStrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!CanParryStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:CanParryStrengthLevel");
				return null;
			}
			if (CanParryStrengthLevel_Marshaler == null)
			{
				CanParryStrengthLevel_Marshaler = new TArrayReadWriteMarshaler<EGSHitDestructibleStrengthLevel>(1, CanParryStrengthLevel_PropertyAddress, CachedMarshalingDelegates<EGSHitDestructibleStrengthLevel, EnumMarshaler<EGSHitDestructibleStrengthLevel>>.FromNative, CachedMarshalingDelegates<EGSHitDestructibleStrengthLevel, EnumMarshaler<EGSHitDestructibleStrengthLevel>>.ToNative);
			}
			return CanParryStrengthLevel_Marshaler.FromNative(IntPtr.Add(base.Address, CanParryStrengthLevel_Offset));
		}
	}

	[Tooltip("破碎物弹刀时播放的音效")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("弹刀音效")]
	[Category("破碎物弹刀配置")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryEvent")]
	public UAkAudioEvent DestructibleParryEvent
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleParryEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, DestructibleParryEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleParryEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, DestructibleParryEvent_Offset), value);
			}
		}
	}

	[Category("破碎物弹刀配置")]
	[DisplayName("弹刀特效")]
	[Tooltip("破碎物弹刀时播放的特效")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryDispConfig")]
	public UBGWDataAsset DestructibleParryDispConfig
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleParryDispConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryDispConfig");
				return null;
			}
			return UObjectMarshaler<UBGWDataAsset>.FromNative(IntPtr.Add(base.Address, DestructibleParryDispConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleParryDispConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructibleParryDispConfig");
			}
			else
			{
				UObjectMarshaler<UBGWDataAsset>.ToNative(IntPtr.Add(base.Address, DestructibleParryDispConfig_Offset), value);
			}
		}
	}

	[DisplayName("掉落信息ID")]
	[Category("破碎物掉落")]
	[EditAnywhere]
	[Tooltip("与破碎表关联的掉落物信息ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructionDropInfoID")]
	public int DestructionDropInfoID
	{
		get
		{
			CheckDestroyed();
			if (!DestructionDropInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructionDropInfoID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DestructionDropInfoID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructionDropInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:DestructionDropInfoID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DestructionDropInfoID_Offset), value);
			}
		}
	}

	[Tooltip("仅820版本临时使用，用于配置是否可被子弹命中")]
	[Category("破碎物掉落")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("(820版本)破碎物掉落物可被子弹命中")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleConfigComp:CanBeHitByBullet")]
	public bool CanBeHitByBullet
	{
		get
		{
			CheckDestroyed();
			if (!CanBeHitByBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:CanBeHitByBullet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanBeHitByBullet_Offset), 0, CanBeHitByBullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanBeHitByBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleConfigComp:CanBeHitByBullet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanBeHitByBullet_Offset), 0, CanBeHitByBullet_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DestroyedDebrisLifeTime = 10f;
		DebrisDissipationTime = 2f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_DestructibleData bUC_DestructibleData = RequireWritableData<b1.BUC_DestructibleData>();
		bUC_DestructibleData.CanParryStrengthLevel = CanParryStrengthLevel.ToList();
		bUC_DestructibleData.DestructibleParryEvent = DestructibleParryEvent;
		bUC_DestructibleData.DestructibleParryDispConfig = DestructibleParryDispConfig;
		float mass = 0f;
		switch (MassLevel)
		{
		case DestructibleMassLevel.Basic:
			mass = 0f;
			break;
		case DestructibleMassLevel.WalkDestroy:
			mass = 500f;
			break;
		case DestructibleMassLevel.RunDestroy:
			mass = 3000f;
			break;
		case DestructibleMassLevel.SprintDestroy:
			mass = 4000f;
			break;
		case DestructibleMassLevel.GiantDestroy:
			mass = 10000f;
			break;
		case DestructibleMassLevel.Indestructible:
			mass = 1000000f;
			break;
		}
		bUC_DestructibleData.Mass = mass;
		bUC_DestructibleData.StrengthLevel = StrengthLevel;
		bUC_DestructibleData.DestroyedLifeTime = DestroyedDebrisLifeTime;
		bUC_DestructibleData.DebrisDissipationTime = DebrisDissipationTime;
		bUC_DestructibleData.DestructionDropInfoID = DestructionDropInfoID;
		bUC_DestructibleData.CanBeHitByBullet = CanBeHitByBullet;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DestructibleConfigComp");
		NativeReflection.GetPropertyRef(ref MassLevel_PropertyAddress, unrealStruct, "MassLevel");
		MassLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MassLevel");
		MassLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MassLevel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref StrengthLevel_PropertyAddress, unrealStruct, "StrengthLevel");
		StrengthLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StrengthLevel");
		StrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StrengthLevel", Classes.FEnumProperty);
		DestroyedDebrisLifeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyedDebrisLifeTime");
		DestroyedDebrisLifeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyedDebrisLifeTime", Classes.FFloatProperty);
		DebrisDissipationTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebrisDissipationTime");
		DebrisDissipationTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebrisDissipationTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CanParryStrengthLevel_PropertyAddress, unrealStruct, "CanParryStrengthLevel");
		CanParryStrengthLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanParryStrengthLevel");
		CanParryStrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanParryStrengthLevel", Classes.FArrayProperty);
		DestructibleParryEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleParryEvent");
		DestructibleParryEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleParryEvent", Classes.FObjectProperty);
		DestructibleParryDispConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleParryDispConfig");
		DestructibleParryDispConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleParryDispConfig", Classes.FObjectProperty);
		DestructionDropInfoID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructionDropInfoID");
		DestructionDropInfoID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructionDropInfoID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CanBeHitByBullet_PropertyAddress, unrealStruct, "CanBeHitByBullet");
		CanBeHitByBullet_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanBeHitByBullet");
		CanBeHitByBullet_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanBeHitByBullet", Classes.FBoolProperty);
	}

	static BUS_DestructibleConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DestructibleConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DestructibleConfigComp));
	}
}
