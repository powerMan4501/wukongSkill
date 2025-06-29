using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial")]
public struct BUC_DispLibDBC_ModifyMaterial
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响范围")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:Delay")]
	public float Delay;

	[BlueprintReadWrite]
	[DisplayName("结束模式")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[DisplayName("持续时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:Duration")]
	public float Duration;

	[UMeta(MD.ToolTip, "表现逻辑层通知材质表现应该结束时要额外延后多长时间真正结束材质，小于等于0会立即结束，否则会进行销毁阶段参数更新; EndMode 是 AutoRelease 时无效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[DisplayName("结束表现时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Template")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:Template")]
	public UMaterialInterface Template;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "旧参数继承方式")]
	[UMeta(MDProp.EditCondition, "Template != nullptr")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:InheriParamsMode")]
	public DispLibMaterialParamsInheritMode InheriParamsMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.DisplayName, "继承旧材质 Scalar 参数名")]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Scalar 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:InheritScalarParam")]
	public List<FName> InheritScalarParam;

	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 FLinearColor 参数")]
	[UMeta(MD.DisplayName, "继承旧材质 FLinearColor 参数名")]
	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:InheritFLinearColorParam")]
	public List<FName> InheritFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Template != nullptr && InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.DisplayName, "继承旧材质 Texture 参数名")]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Texture 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:InheritTextureParam")]
	public List<FName> InheritTextureParam;

	[UMeta(MD.DisplayName, "设置 Scalar 参数")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:SetScalarParam")]
	public List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> SetScalarParam;

	[UMeta(MD.DisplayName, "设置 Color 参数")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:SetFLinearColorParam")]
	public List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> SetFLinearColorParam;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Texture 参数")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:SetTextureParam")]
	public List<BUC_DispLibUtil_DBCTextureMatLayerParam> SetTextureParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 程序化曲线 Scalar 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:SetPCurveScalarParam")]
	public List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> SetPCurveScalarParam;

	[UMeta(MD.DisplayName, "设置 程序化曲线 Color 参数")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:SetPCurveFLinearColorParam")]
	public List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> SetPCurveFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "每次触发暂停时逻辑会给出此次暂停的优先级，不同原因触发的暂停其优先级可能不同;\n如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:PausePriority")]
	public int PausePriority;

	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[DisplayName("结束表现阶段优先级")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:EndStagePriority")]
	public int EndStagePriority;

	[UMeta(MD.ToolTip, "当多个材质事件同一帧内请求操作同一个参数时，以材质效果优先级最大的事件为准，若优先级相同，以事件开始执行的时间（PlayAtTime）越晚（越接近当前帧时间）的事件为准，若开始执行时间也一致，以当前帧逻辑请求顺序最晚的事件为准")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质效果优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:ModMatPriority")]
	public int ModMatPriority;

	[DisplayName("材质效果结束表现阶段优先级")]
	[UMeta(MD.ToolTip, "同【材质效果优先级】，但允许给结束表现阶段配置独立的优先级，因为多数情况下结束表现阶段在视觉上重要性不高，没必要抢占参数控制权")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial:ModMatEndStagePriority")]
	public int ModMatEndStagePriority;

	private static int BUC_DispLibDBC_ModifyMaterial_StructSize;

	private static int BUC_DispLibDBC_ModifyMaterial_IsValid;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

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

	private static bool InheritFLinearColorParam_IsValid;

	private static int InheritFLinearColorParam_Offset;

	private static FFieldAddress InheritFLinearColorParam_PropertyAddress;

	private static bool InheritTextureParam_IsValid;

	private static int InheritTextureParam_Offset;

	private static FFieldAddress InheritTextureParam_PropertyAddress;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private static bool SetFLinearColorParam_IsValid;

	private static int SetFLinearColorParam_Offset;

	private static FFieldAddress SetFLinearColorParam_PropertyAddress;

	private static bool SetTextureParam_IsValid;

	private static int SetTextureParam_Offset;

	private static FFieldAddress SetTextureParam_PropertyAddress;

	private static bool SetPCurveScalarParam_IsValid;

	private static int SetPCurveScalarParam_Offset;

	private static FFieldAddress SetPCurveScalarParam_PropertyAddress;

	private static bool SetPCurveFLinearColorParam_IsValid;

	private static int SetPCurveFLinearColorParam_Offset;

	private static FFieldAddress SetPCurveFLinearColorParam_PropertyAddress;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool ModMatPriority_IsValid;

	private static int ModMatPriority_Offset;

	private static bool ModMatEndStagePriority_IsValid;

	private static int ModMatEndStagePriority_Offset;

	public BUC_DispLibDBC_ModifyMaterial SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo _FilterMode, float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, UMaterialInterface _Template, DispLibMaterialParamsInheritMode _InheriParamsMode, List<FName> _InheritScalarParam, List<FName> _InheritFLinearColorParam, List<FName> _InheritTextureParam, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> _SetScalarParam, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> _SetFLinearColorParam, List<BUC_DispLibUtil_DBCTextureMatLayerParam> _SetTextureParam, List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> _SetPCurveScalarParam, List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> _SetPCurveFLinearColorParam, int _PausePriority, int _EndStagePriority, int _ModMatPriority, int _ModMatEndStagePriority)
	{
		FilterMode = _FilterMode;
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		Template = _Template;
		InheriParamsMode = _InheriParamsMode;
		InheritScalarParam = ((_InheritScalarParam == null) ? new List<FName>() : _InheritScalarParam);
		InheritFLinearColorParam = ((_InheritFLinearColorParam == null) ? new List<FName>() : _InheritFLinearColorParam);
		InheritTextureParam = ((_InheritTextureParam == null) ? new List<FName>() : _InheritTextureParam);
		SetScalarParam = ((_SetScalarParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>() : _SetScalarParam);
		SetFLinearColorParam = ((_SetFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>() : _SetFLinearColorParam);
		SetTextureParam = ((_SetTextureParam == null) ? new List<BUC_DispLibUtil_DBCTextureMatLayerParam>() : _SetTextureParam);
		SetPCurveScalarParam = ((_SetPCurveScalarParam == null) ? new List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>() : _SetPCurveScalarParam);
		SetPCurveFLinearColorParam = ((_SetPCurveFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>() : _SetPCurveFLinearColorParam);
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		ModMatPriority = _ModMatPriority;
		ModMatEndStagePriority = _ModMatEndStagePriority;
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterial SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo _FilterMode, float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> _SetScalarParam, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> _SetFLinearColorParam, List<BUC_DispLibUtil_DBCTextureMatLayerParam> _SetTextureParam, List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> _SetPCurveScalarParam, List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> _SetPCurveFLinearColorParam, int _PausePriority, int _EndStagePriority, int _ModMatPriority, int _ModMatEndStagePriority)
	{
		FilterMode = _FilterMode;
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		Template = null;
		InheriParamsMode = DispLibMaterialParamsInheritMode.NoInherit;
		InheritScalarParam = new List<FName>();
		InheritFLinearColorParam = new List<FName>();
		InheritTextureParam = new List<FName>();
		SetScalarParam = ((_SetScalarParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>() : _SetScalarParam);
		SetFLinearColorParam = ((_SetFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>() : _SetFLinearColorParam);
		SetTextureParam = ((_SetTextureParam == null) ? new List<BUC_DispLibUtil_DBCTextureMatLayerParam>() : _SetTextureParam);
		SetPCurveScalarParam = ((_SetPCurveScalarParam == null) ? new List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>() : _SetPCurveScalarParam);
		SetPCurveFLinearColorParam = ((_SetPCurveFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>() : _SetPCurveFLinearColorParam);
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		ModMatPriority = _ModMatPriority;
		ModMatEndStagePriority = _ModMatEndStagePriority;
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterial GetDefault()
	{
		return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.FixDuration, 0f, 0f, null, DispLibMaterialParamsInheritMode.NoInherit, null, null, null, null, null, null, null, null, 0, 0, 0, 0);
	}

	public BUC_DispLibDBC_ModifyMaterial Copy()
	{
		BUC_DispLibDBC_ModifyMaterial result = this;
		if (InheritScalarParam != null)
		{
			result.InheritScalarParam = new List<FName>(InheritScalarParam);
		}
		if (InheritFLinearColorParam != null)
		{
			result.InheritFLinearColorParam = new List<FName>(InheritFLinearColorParam);
		}
		if (InheritTextureParam != null)
		{
			result.InheritTextureParam = new List<FName>(InheritTextureParam);
		}
		if (SetScalarParam != null)
		{
			result.SetScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>(SetScalarParam);
		}
		if (SetFLinearColorParam != null)
		{
			result.SetFLinearColorParam = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>(SetFLinearColorParam);
		}
		if (SetTextureParam != null)
		{
			result.SetTextureParam = new List<BUC_DispLibUtil_DBCTextureMatLayerParam>(SetTextureParam);
		}
		if (SetPCurveScalarParam != null)
		{
			result.SetPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>(SetPCurveScalarParam);
		}
		if (SetPCurveFLinearColorParam != null)
		{
			result.SetPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>(SetPCurveFLinearColorParam);
		}
		return result;
	}

	public static BUC_DispLibDBC_ModifyMaterial FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ModifyMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ModifyMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ModifyMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ModifyMaterial(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyMaterial_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ModifyMaterial value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyMaterial_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial");
			return;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo.ToNative(IntPtr.Add(nativeStruct, FilterMode_Offset), FilterMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		EnumMarshaler<DispLibMaterialParamsInheritMode>.ToNative(IntPtr.Add(nativeStruct, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address, InheriParamsMode);
		new TArrayCopyMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritScalarParam_Offset), InheritScalarParam);
		new TArrayCopyMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritFLinearColorParam_Offset), InheritFLinearColorParam);
		new TArrayCopyMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritTextureParam_Offset), InheritTextureParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset), SetScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset), SetFLinearColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCTextureMatLayerParam>(1, SetTextureParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetTextureParam_Offset), SetTextureParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetPCurveScalarParam_Offset), SetPCurveScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetPCurveFLinearColorParam_Offset), SetPCurveFLinearColorParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModMatPriority_Offset), ModMatPriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModMatEndStagePriority_Offset), ModMatEndStagePriority);
	}

	public BUC_DispLibDBC_ModifyMaterial(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial");
			FilterMode = default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			Template = null;
			InheriParamsMode = DispLibMaterialParamsInheritMode.NoInherit;
			InheritScalarParam = null;
			InheritFLinearColorParam = null;
			InheritTextureParam = null;
			SetScalarParam = null;
			SetFLinearColorParam = null;
			SetTextureParam = null;
			SetPCurveScalarParam = null;
			SetPCurveFLinearColorParam = null;
			PausePriority = 0;
			EndStagePriority = 0;
			ModMatPriority = 0;
			ModMatEndStagePriority = 0;
		}
		else
		{
			FilterMode = BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(nativeStruct, FilterMode_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			Template = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			InheriParamsMode = EnumMarshaler<DispLibMaterialParamsInheritMode>.FromNative(IntPtr.Add(nativeStruct, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address);
			InheritScalarParam = new TArrayCopyMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritScalarParam_Offset));
			InheritFLinearColorParam = new TArrayCopyMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritFLinearColorParam_Offset));
			InheritTextureParam = new TArrayCopyMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritTextureParam_Offset));
			SetScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam, BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset));
			SetFLinearColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset));
			SetTextureParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCTextureMatLayerParam>(1, SetTextureParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCTextureMatLayerParam, BUC_DispLibUtil_DBCTextureMatLayerParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetTextureParam_Offset));
			SetPCurveScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam, BUC_DispLibUtil_DBCPCurveScalarMatLayerParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetPCurveScalarParam_Offset));
			SetPCurveFLinearColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveColorMatLayerParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorMatLayerParam, BUC_DispLibUtil_DBCPCurveColorMatLayerParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetPCurveFLinearColorParam_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
			ModMatPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ModMatPriority_Offset));
			ModMatEndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ModMatEndStagePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial");
		BUC_DispLibDBC_ModifyMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
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
		BUC_DispLibDBC_ModifyMaterial_IsValid = ((intPtr != IntPtr.Zero && FilterMode_IsValid && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && Template_IsValid && InheriParamsMode_IsValid && InheritScalarParam_IsValid && InheritFLinearColorParam_IsValid && InheritTextureParam_IsValid && SetScalarParam_IsValid && SetFLinearColorParam_IsValid && SetTextureParam_IsValid && SetPCurveScalarParam_IsValid && SetPCurveFLinearColorParam_IsValid && PausePriority_IsValid && EndStagePriority_IsValid && ModMatPriority_IsValid && ModMatEndStagePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterial", (byte)BUC_DispLibDBC_ModifyMaterial_IsValid != 0);
	}

	static BUC_DispLibDBC_ModifyMaterial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ModifyMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ModifyMaterial));
	}
}
