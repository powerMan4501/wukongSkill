using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Modify Material")]
[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial")]
internal class BAN_DispLibModifyMaterial : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool InheriParamsMode_IsValid;

	private static int InheriParamsMode_Offset;

	private static FFieldAddress InheriParamsMode_PropertyAddress;

	private static bool InheritScalarParam_IsValid;

	private static int InheritScalarParam_Offset;

	private static FFieldAddress InheritScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritScalarParam_Marshaler;

	private static bool InheritFLinearColorParam_IsValid;

	private static int InheritFLinearColorParam_Offset;

	private static FFieldAddress InheritFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritFLinearColorParam_Marshaler;

	private static bool InheritTextureParam_IsValid;

	private static int InheritTextureParam_Offset;

	private static FFieldAddress InheritTextureParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritTextureParam_Marshaler;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> SetScalarParam_Marshaler;

	private static bool SetFLinearColorParam_IsValid;

	private static int SetFLinearColorParam_Offset;

	private static FFieldAddress SetFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> SetFLinearColorParam_Marshaler;

	private static bool SetTextureParam_IsValid;

	private static int SetTextureParam_Offset;

	private static FFieldAddress SetTextureParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCTextureMatLayerParam> SetTextureParam_Marshaler;

	private static bool SetPCurveScalarParam_IsValid;

	private static int SetPCurveScalarParam_Offset;

	private static FFieldAddress SetPCurveScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> SetPCurveScalarParam_Marshaler;

	private static bool SetPCurveFLinearColorParam_IsValid;

	private static int SetPCurveFLinearColorParam_Offset;

	private static FFieldAddress SetPCurveFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> SetPCurveFLinearColorParam_Marshaler;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool ModMatPriority_IsValid;

	private static int ModMatPriority_Offset;

	private static bool ModMatEndStagePriority_IsValid;

	private static int ModMatEndStagePriority_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[DisplayName("Editor Active")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响范围")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode
	{
		get
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:FilterMode");
				return default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			}
			return BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(base.Address, FilterMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:FilterMode");
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
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:Delay")]
	public float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[UMeta(MD.ToolTip, "表现逻辑层通知材质表现应该结束时要额外延后多长时间真正结束材质，小于等于0会立即结束，否则会进行销毁阶段参数更新; EndMode 是 AutoRelease 时无效")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Template")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:Template")]
	public UMaterialInterface Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Template");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:Template");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "Template != nullptr")]
	[UMeta(MD.DisplayName, "旧参数继承方式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheriParamsMode")]
	public DispLibMaterialParamsInheritMode InheriParamsMode
	{
		get
		{
			CheckDestroyed();
			if (!InheriParamsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheriParamsMode");
				return DispLibMaterialParamsInheritMode.NoInherit;
			}
			return EnumMarshaler<DispLibMaterialParamsInheritMode>.FromNative(IntPtr.Add(base.Address, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheriParamsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheriParamsMode");
			}
			else
			{
				EnumMarshaler<DispLibMaterialParamsInheritMode>.ToNative(IntPtr.Add(base.Address, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Scalar 参数")]
	[UMeta(MD.DisplayName, "继承旧材质 Scalar 参数名")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritScalarParam")]
	public TArrayReadWrite<FName> InheritScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritScalarParam");
				return null;
			}
			if (InheritScalarParam_Marshaler == null)
			{
				InheritScalarParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritScalarParam_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 FLinearColor 参数")]
	[UMeta(MD.DisplayName, "继承旧材质 FLinearColor 参数名")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritFLinearColorParam")]
	public TArrayReadWrite<FName> InheritFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritFLinearColorParam");
				return null;
			}
			if (InheritFLinearColorParam_Marshaler == null)
			{
				InheritFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritFLinearColorParam_Offset));
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Texture 参数")]
	[UMeta(MD.DisplayName, "继承旧材质 Texture 参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritTextureParam")]
	public TArrayReadWrite<FName> InheritTextureParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritTextureParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:InheritTextureParam");
				return null;
			}
			if (InheritTextureParam_Marshaler == null)
			{
				InheritTextureParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritTextureParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritTextureParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Scalar 参数")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetScalarParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> SetScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!SetScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetScalarParam");
				return null;
			}
			if (SetScalarParam_Marshaler == null)
			{
				SetScalarParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.ToNative);
			}
			return SetScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetScalarParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Color 参数")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetFLinearColorParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> SetFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!SetFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetFLinearColorParam");
				return null;
			}
			if (SetFLinearColorParam_Marshaler == null)
			{
				SetFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.ToNative);
			}
			return SetFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetFLinearColorParam_Offset));
		}
	}

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Texture 参数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetTextureParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCTextureMatLayerParam> SetTextureParam
	{
		get
		{
			CheckDestroyed();
			if (!SetTextureParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetTextureParam");
				return null;
			}
			if (SetTextureParam_Marshaler == null)
			{
				SetTextureParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCTextureMatLayerParam>(1, SetTextureParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.ToNative);
			}
			return SetTextureParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetTextureParam_Offset));
		}
	}

	[UMeta(MD.DisplayName, "设置 程序化曲线 Scalar 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetPCurveScalarParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> SetPCurveScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!SetPCurveScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetPCurveScalarParam");
				return null;
			}
			if (SetPCurveScalarParam_Marshaler == null)
			{
				SetPCurveScalarParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.ToNative);
			}
			return SetPCurveScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetPCurveScalarParam_Offset));
		}
	}

	[UMeta(MD.DisplayName, "设置 程序化曲线 Color 参数")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetPCurveFLinearColorParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> SetPCurveFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!SetPCurveFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:SetPCurveFLinearColorParam");
				return null;
			}
			if (SetPCurveFLinearColorParam_Marshaler == null)
			{
				SetPCurveFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.ToNative);
			}
			return SetPCurveFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetPCurveFLinearColorParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:PausePriority")]
	public int PausePriority
	{
		get
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:PausePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PausePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:PausePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PausePriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现阶段优先级")]
	[UMeta(MD.ToolTip, "角色死亡时各种效果默认不进入结束表现阶段，如果此效果需要进入则填写1")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "当多个材质事件同一帧内请求操作同一个参数时，以材质效果优先级最大的事件为准，若优先级相同，以事件开始执行的时间（PlayAtTime）越新的事件为准，若开始执行时间也一致，以当前逻辑请求顺序为准")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("材质效果优先级")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatPriority")]
	public int ModMatPriority
	{
		get
		{
			CheckDestroyed();
			if (!ModMatPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ModMatPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModMatPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ModMatPriority_Offset), value);
			}
		}
	}

	[DisplayName("材质效果结束表现阶段优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "同【材质效果优先级】，但允许给结束表现阶段配置独立的优先级，因为多数情况下结束表现阶段在视觉上重要性不高，没必要抢占参数控制权")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatEndStagePriority")]
	public int ModMatEndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!ModMatEndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatEndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ModMatEndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModMatEndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibModifyMaterial:ModMatEndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ModMatEndStagePriority_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FilterMode = BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats;
		Duration = 8f;
	}

	protected bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		return FilterMode.isVaild();
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibModifyMaterial:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (ValidateParameters(meshComp))
		{
			DoModMat(NotifyParam.MeshComp, NotifyParam.Animation);
		}
	}

	protected void DoModMat(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation)
	{
		Runtime_Do_ModMat(SourceDispOwnerComp, Animation);
	}

	private void Runtime_Do_ModMat(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation)
	{
		AActor owner = SourceDispOwnerComp.GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(FilterMode, Delay, (Duration > 0f) ? DispLibDBCEndMode.FixDuration : DispLibDBCEndMode.AutoRelease, Duration, DelayTimeAfterStop, Template, InheriParamsMode, InheritScalarParam.ToList(), InheritFLinearColorParam.ToList(), InheritTextureParam.ToList(), SetScalarParam.ToList(), SetFLinearColorParam.ToList(), SetTextureParam.ToList(), SetPCurveScalarParam.ToList(), SetPCurveFLinearColorParam.ToList(), PausePriority, EndStagePriority, ModMatPriority, ModMatEndStagePriority);
			if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d))
			{
				BUS_DispLibEventCollection.Get(owner)?.Evt_RequestApply_One_ModMat?.Invoke(d, out var _, GetUniqueID());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibModifyMaterial:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibModifyMaterial bAN_DispLibModifyMaterial = GCHelper.Find<GSDispLib.BAN_DispLibModifyMaterial>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibModifyMaterial.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibModifyMaterial");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref InheriParamsMode_PropertyAddress, intPtr, "InheriParamsMode");
		InheriParamsMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheriParamsMode");
		InheriParamsMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheriParamsMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InheritScalarParam_PropertyAddress, intPtr, "InheritScalarParam");
		InheritScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritScalarParam");
		InheritScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InheritFLinearColorParam_PropertyAddress, intPtr, "InheritFLinearColorParam");
		InheritFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritFLinearColorParam");
		InheritFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritFLinearColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InheritTextureParam_PropertyAddress, intPtr, "InheritTextureParam");
		InheritTextureParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritTextureParam");
		InheritTextureParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritTextureParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetScalarParam_PropertyAddress, intPtr, "SetScalarParam");
		SetScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetScalarParam");
		SetScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFLinearColorParam_PropertyAddress, intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFLinearColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetTextureParam_PropertyAddress, intPtr, "SetTextureParam");
		SetTextureParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetTextureParam");
		SetTextureParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetTextureParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetPCurveScalarParam_PropertyAddress, intPtr, "SetPCurveScalarParam");
		SetPCurveScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetPCurveScalarParam");
		SetPCurveScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetPCurveScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetPCurveFLinearColorParam_PropertyAddress, intPtr, "SetPCurveFLinearColorParam");
		SetPCurveFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetPCurveFLinearColorParam");
		SetPCurveFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetPCurveFLinearColorParam", Classes.FArrayProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		ModMatPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModMatPriority");
		ModMatPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModMatPriority", Classes.FIntProperty);
		ModMatEndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModMatEndStagePriority");
		ModMatEndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModMatEndStagePriority", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibModifyMaterial:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibModifyMaterial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibModifyMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibModifyMaterial));
	}
}
