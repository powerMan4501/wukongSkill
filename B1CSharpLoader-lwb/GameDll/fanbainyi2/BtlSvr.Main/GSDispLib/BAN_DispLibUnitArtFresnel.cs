using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Unit Art Fresnel")]
[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel")]
internal class BAN_DispLibUnitArtFresnel : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool UseUniversalUAF_IsValid;

	private static int UseUniversalUAF_Offset;

	private static FFieldAddress UseUniversalUAF_PropertyAddress;

	private static bool UniversalUAFIndex_IsValid;

	private static int UniversalUAFIndex_Offset;

	private static bool CustomUAFDataAsset_IsValid;

	private static int CustomUAFDataAsset_Offset;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool OverrideTime_IsValid;

	private static int OverrideTime_Offset;

	private static bool OverrideSimpleProgrammedCurve_IsValid;

	private static int OverrideSimpleProgrammedCurve_Offset;

	private static bool OverrideFadeInTime_IsValid;

	private static int OverrideFadeInTime_Offset;

	private static bool OverrideCommonTime_IsValid;

	private static int OverrideCommonTime_Offset;

	private static bool OverrideFadeOutTime_IsValid;

	private static int OverrideFadeOutTime_Offset;

	private static bool OverrideProgrammedPowerMax_IsValid;

	private static int OverrideProgrammedPowerMax_Offset;

	private static bool OverrideOnePeriodTime_IsValid;

	private static int OverrideOnePeriodTime_Offset;

	private static bool OverrideLoop_IsValid;

	private static int OverrideLoop_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[DisplayName("Editor Active")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("基于通用效果")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UseUniversalUAF")]
	public bool UseUniversalUAF
	{
		get
		{
			CheckDestroyed();
			if (!UseUniversalUAF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UseUniversalUAF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseUniversalUAF_Offset), 0, UseUniversalUAF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseUniversalUAF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UseUniversalUAF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseUniversalUAF_Offset), 0, UseUniversalUAF_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 1)]
	[UMeta(MDProp.EditCondition, "UseUniversalUAF")]
	[DisplayName("通用效果ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UniversalUAFIndex")]
	public int UniversalUAFIndex
	{
		get
		{
			CheckDestroyed();
			if (!UniversalUAFIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UniversalUAFIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UniversalUAFIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UniversalUAFIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:UniversalUAFIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UniversalUAFIndex_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!UseUniversalUAF")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("效果数据")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:CustomUAFDataAsset")]
	public BUC_DispLibUnitArtFresnelDataAsset CustomUAFDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!CustomUAFDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:CustomUAFDataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>.FromNative(IntPtr.Add(base.Address, CustomUAFDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomUAFDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:CustomUAFDataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>.ToNative(IntPtr.Add(base.Address, CustomUAFDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响范围")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode
	{
		get
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:FilterMode");
				return default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			}
			return BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(base.Address, FilterMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:FilterMode");
			}
			else
			{
				BUC_DispLibDBC_MaterialEffectTargetInfo.ToNative(IntPtr.Add(base.Address, FilterMode_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("优先级")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "OverrideLoop == 0")]
	[DisplayName("Override 总持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideTime")]
	public float OverrideTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("Override 使用程序化Power曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMax, "2")]
	[UMeta(MD.ToolTip, "0 = UseSource, 1 = False, 2 = True")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideSimpleProgrammedCurve")]
	public int OverrideSimpleProgrammedCurve
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSimpleProgrammedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideSimpleProgrammedCurve");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverrideSimpleProgrammedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSimpleProgrammedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideSimpleProgrammedCurve");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverrideSimpleProgrammedCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override 程序化Power爆发时间")]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeInTime")]
	public float OverrideFadeInTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideFadeInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideFadeInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideFadeInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideFadeInTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Override 程序化Power平稳时间")]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideCommonTime")]
	public float OverrideCommonTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideCommonTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideCommonTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideCommonTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideCommonTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideCommonTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideCommonTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override 程序化Power消退时间")]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeOutTime")]
	public float OverrideFadeOutTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideFadeOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideFadeOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideFadeOutTime_Offset), value);
			}
		}
	}

	[DisplayName("Override 程序化Power最大值")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideProgrammedPowerMax")]
	public float OverrideProgrammedPowerMax
	{
		get
		{
			CheckDestroyed();
			if (!OverrideProgrammedPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideProgrammedPowerMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideProgrammedPowerMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideProgrammedPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideProgrammedPowerMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideProgrammedPowerMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override 单次循环时间")]
	[UMeta(MD.ToolTip, "程序化Power曲线模式下，单次循环时间会自动计算 = 三段程序化时间之和")]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve != 2")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideOnePeriodTime")]
	public float OverrideOnePeriodTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideOnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideOnePeriodTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideOnePeriodTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideOnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideOnePeriodTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideOnePeriodTime_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "0 = UseSource, 1 = False, 2 = True")]
	[UMeta(MDProp.ClampMax, "2")]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("Override 无限循环")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideLoop")]
	public int OverrideLoop
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideLoop");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverrideLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:OverrideLoop");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverrideLoop_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		UseUniversalUAF = false;
		UniversalUAFIndex = 1;
		Priority = 2;
	}

	protected bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		if (MeshComp == null)
		{
			return false;
		}
		if (UseUniversalUAF)
		{
			if (UniversalUAFIndex <= 0)
			{
				return false;
			}
		}
		else
		{
			if (CustomUAFDataAsset == null)
			{
				return false;
			}
			if (OverrideSimpleProgrammedCurve == 2 && (OverrideFadeInTime < 0f || OverrideCommonTime < 0f || OverrideFadeOutTime < 0f))
			{
				return false;
			}
		}
		return true;
	}

	private bool Runtime_DoUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		if (!ValidateParameters(MeshComp))
		{
			return false;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(MeshComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return false;
		}
		if (UseUniversalUAF)
		{
			bUS_DispLibEventCollection.Evt_RequestOneOverrideUniversalUAF(FilterMode, UniversalUAFIndex, Priority, DispLibRefParam.Instance, OverrideTime, OverrideOnePeriodTime, OverrideLoop, OverrideSimpleProgrammedCurve, OverrideFadeInTime, OverrideCommonTime, OverrideFadeOutTime, OverrideProgrammedPowerMax);
		}
		else
		{
			bUS_DispLibEventCollection.Evt_RequestOneCustomUAFByDataAsset(FilterMode, CustomUAFDataAsset, Priority, DispLibRefParam.Instance, OverrideTime, OverrideOnePeriodTime, OverrideLoop, OverrideSimpleProgrammedCurve, OverrideFadeInTime, OverrideCommonTime, OverrideFadeOutTime, OverrideProgrammedPowerMax);
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		Runtime_DoUAF(FilterMode, meshComp, animation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibUnitArtFresnel bAN_DispLibUnitArtFresnel = GCHelper.Find<GSDispLib.BAN_DispLibUnitArtFresnel>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibUnitArtFresnel.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibUnitArtFresnel");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseUniversalUAF_PropertyAddress, intPtr, "UseUniversalUAF");
		UseUniversalUAF_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseUniversalUAF");
		UseUniversalUAF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseUniversalUAF", Classes.FBoolProperty);
		UniversalUAFIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "UniversalUAFIndex");
		UniversalUAFIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UniversalUAFIndex", Classes.FIntProperty);
		CustomUAFDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomUAFDataAsset");
		CustomUAFDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomUAFDataAsset", Classes.FObjectProperty);
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		OverrideTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTime");
		OverrideTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTime", Classes.FFloatProperty);
		OverrideSimpleProgrammedCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSimpleProgrammedCurve");
		OverrideSimpleProgrammedCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSimpleProgrammedCurve", Classes.FIntProperty);
		OverrideFadeInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideFadeInTime");
		OverrideFadeInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideFadeInTime", Classes.FFloatProperty);
		OverrideCommonTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideCommonTime");
		OverrideCommonTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideCommonTime", Classes.FFloatProperty);
		OverrideFadeOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideFadeOutTime");
		OverrideFadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideFadeOutTime", Classes.FFloatProperty);
		OverrideProgrammedPowerMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideProgrammedPowerMax");
		OverrideProgrammedPowerMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideProgrammedPowerMax", Classes.FFloatProperty);
		OverrideOnePeriodTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideOnePeriodTime");
		OverrideOnePeriodTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideOnePeriodTime", Classes.FFloatProperty);
		OverrideLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideLoop");
		OverrideLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideLoop", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibUnitArtFresnel:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibUnitArtFresnel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibUnitArtFresnel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibUnitArtFresnel));
	}
}
