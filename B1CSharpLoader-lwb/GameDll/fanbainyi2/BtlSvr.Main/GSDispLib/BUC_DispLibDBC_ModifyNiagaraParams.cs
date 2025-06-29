using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams")]
public struct BUC_DispLibDBC_ModifyNiagaraParams
{
	[UMeta(MD.ToolTip, "")]
	[DisplayName("目标组件筛选")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:MeshCompFilterInfo")]
	public BUC_DispLibDBC_EntityEffectTargetInfo MeshCompFilterInfo;

	[DisplayName("Niagara实例筛选")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:NiagaraCompFilterInfo")]
	public BUC_DispLibDBC_ModifyNiagaraTargetInfo NiagaraCompFilterInfo;

	[UProperty]
	[EditAnywhere]
	[DisplayName("延迟时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:Delay")]
	public float Delay;

	[DisplayName("结束模式")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UProperty]
	[UMeta(MD.ToolTip, "只有【结束模式】是【固定持续时间】此参数才有效")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:Duration")]
	public float Duration;

	[UMeta(MD.ToolTip, "DBC通知效果结束时要额外延后多长时间真正结束效果，小于等于0会立即结束，大于0会按消散阶段（也称结束表现阶段或收尾阶段）的逻辑更新各参数，消散阶段和正常阶段的更新逻辑可能不同; 【结束模式】 是 【自动销毁】 时此参数无效")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[DisplayName("结束表现时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Bool 参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetBoolParam")]
	public List<BUC_DispLibUtil_ModNiagara_NameAndBoolValue> SetBoolParam;

	[UMeta(MD.DisplayName, "设置 Float 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetFloatParam")]
	public List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> SetFloatParam;

	[UMeta(MD.DisplayName, "设置 Int 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetInt32Param")]
	public List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> SetInt32Param;

	[UProperty]
	[UMeta(MD.DisplayName, "设置 Vector3 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetFVectorParam")]
	public List<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam> SetFVectorParam;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Linear Color 参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetFLinearColorParam")]
	public List<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam> SetFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Float Array 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetFloatArrayParam")]
	public List<BUC_DispLibUtil_NameAndFloatArray> SetFloatArrayParam;

	[UMeta(MD.DisplayName, "设置 Int32 Array 参数")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetInt32ArrayParam")]
	public List<BUC_DispLibUtil_NameAndInt32Array> SetInt32ArrayParam;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 FVector Array 参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetFVectorArrayParam")]
	public List<BUC_DispLibUtil_NameAndFVectorArray> SetFVectorArrayParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置自身模型 骨骼")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetOverrideSelfMeshBones")]
	public List<FName> SetOverrideSelfMeshBones;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置自身模型 插槽")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:SetOverrideSelfMeshSockets")]
	public List<FName> SetOverrideSelfMeshSockets;

	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停模式")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:PauseMode")]
	public DispLibDBCModNiagaraParamsPauseMode PauseMode;

	[UProperty]
	[DisplayName("暂停优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "每次触发暂停时逻辑会给出此次暂停的优先级，不同原因触发的暂停其优先级可能不同，如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:PausePriority")]
	public int PausePriority;

	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[DisplayName("结束表现阶段优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams:EndStagePriority")]
	public int EndStagePriority;

	private static int BUC_DispLibDBC_ModifyNiagaraParams_StructSize;

	private static int BUC_DispLibDBC_ModifyNiagaraParams_IsValid;

	private static bool MeshCompFilterInfo_IsValid;

	private static int MeshCompFilterInfo_Offset;

	private static bool NiagaraCompFilterInfo_IsValid;

	private static int NiagaraCompFilterInfo_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool SetBoolParam_IsValid;

	private static int SetBoolParam_Offset;

	private static FFieldAddress SetBoolParam_PropertyAddress;

	private static bool SetFloatParam_IsValid;

	private static int SetFloatParam_Offset;

	private static FFieldAddress SetFloatParam_PropertyAddress;

	private static bool SetInt32Param_IsValid;

	private static int SetInt32Param_Offset;

	private static FFieldAddress SetInt32Param_PropertyAddress;

	private static bool SetFVectorParam_IsValid;

	private static int SetFVectorParam_Offset;

	private static FFieldAddress SetFVectorParam_PropertyAddress;

	private static bool SetFLinearColorParam_IsValid;

	private static int SetFLinearColorParam_Offset;

	private static FFieldAddress SetFLinearColorParam_PropertyAddress;

	private static bool SetFloatArrayParam_IsValid;

	private static int SetFloatArrayParam_Offset;

	private static FFieldAddress SetFloatArrayParam_PropertyAddress;

	private static bool SetInt32ArrayParam_IsValid;

	private static int SetInt32ArrayParam_Offset;

	private static FFieldAddress SetInt32ArrayParam_PropertyAddress;

	private static bool SetFVectorArrayParam_IsValid;

	private static int SetFVectorArrayParam_Offset;

	private static FFieldAddress SetFVectorArrayParam_PropertyAddress;

	private static bool SetOverrideSelfMeshBones_IsValid;

	private static int SetOverrideSelfMeshBones_Offset;

	private static FFieldAddress SetOverrideSelfMeshBones_PropertyAddress;

	private static bool SetOverrideSelfMeshSockets_IsValid;

	private static int SetOverrideSelfMeshSockets_Offset;

	private static FFieldAddress SetOverrideSelfMeshSockets_PropertyAddress;

	private static bool PauseMode_IsValid;

	private static int PauseMode_Offset;

	private static FFieldAddress PauseMode_PropertyAddress;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	public BUC_DispLibDBC_ModifyNiagaraParams SetCustomData(BUC_DispLibDBC_ModifyNiagaraTargetInfo _FilterMode, float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, List<BUC_DispLibUtil_ModNiagara_NameAndBoolValue> _SetBoolParam, List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> _SetFloatScalarParam, List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> _SetInt32ScalarParam, List<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam> _SetFVectorParam, List<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam> _SetFLinearColorParam, List<BUC_DispLibUtil_NameAndFloatArray> _SetFloatArrayParam, List<BUC_DispLibUtil_NameAndInt32Array> _SetInt32ArrayParam, List<BUC_DispLibUtil_NameAndFVectorArray> _SetFVectorArrayParam, List<FName> _SetOverrideSelfMeshBones, List<FName> _SetOverrideSelfMeshSockets, DispLibDBCModNiagaraParamsPauseMode _PauseMode, int _PausePriority, int _EndStagePriority)
	{
		NiagaraCompFilterInfo = _FilterMode;
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		SetBoolParam = _SetBoolParam;
		SetFloatParam = _SetFloatScalarParam;
		SetInt32Param = _SetInt32ScalarParam;
		SetFVectorParam = _SetFVectorParam;
		SetFLinearColorParam = _SetFLinearColorParam;
		SetFloatArrayParam = _SetFloatArrayParam;
		SetInt32ArrayParam = _SetInt32ArrayParam;
		SetFVectorArrayParam = _SetFVectorArrayParam;
		SetOverrideSelfMeshBones = _SetOverrideSelfMeshBones;
		SetOverrideSelfMeshSockets = _SetOverrideSelfMeshSockets;
		PauseMode = _PauseMode;
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		return this;
	}

	public BUC_DispLibDBC_ModifyNiagaraParams Copy()
	{
		BUC_DispLibDBC_ModifyNiagaraParams result = this;
		if (SetBoolParam != null)
		{
			result.SetBoolParam = new List<BUC_DispLibUtil_ModNiagara_NameAndBoolValue>(SetBoolParam);
		}
		if (SetFloatParam != null)
		{
			result.SetFloatParam = new List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(SetFloatParam);
		}
		if (SetInt32Param != null)
		{
			result.SetInt32Param = new List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(SetInt32Param);
		}
		if (SetFVectorParam != null)
		{
			result.SetFVectorParam = new List<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>(SetFVectorParam);
		}
		if (SetFLinearColorParam != null)
		{
			result.SetFLinearColorParam = new List<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>(SetFLinearColorParam);
		}
		if (SetFloatArrayParam != null)
		{
			result.SetFloatArrayParam = new List<BUC_DispLibUtil_NameAndFloatArray>(SetFloatArrayParam);
		}
		if (SetInt32ArrayParam != null)
		{
			result.SetInt32ArrayParam = new List<BUC_DispLibUtil_NameAndInt32Array>(SetInt32ArrayParam);
		}
		if (SetFVectorArrayParam != null)
		{
			result.SetFVectorArrayParam = new List<BUC_DispLibUtil_NameAndFVectorArray>(SetFVectorArrayParam);
		}
		if (SetOverrideSelfMeshBones != null)
		{
			result.SetOverrideSelfMeshBones = new List<FName>(SetOverrideSelfMeshBones);
		}
		if (SetOverrideSelfMeshSockets != null)
		{
			result.SetOverrideSelfMeshSockets = new List<FName>(SetOverrideSelfMeshSockets);
		}
		return result;
	}

	public static BUC_DispLibDBC_ModifyNiagaraParams FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ModifyNiagaraParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ModifyNiagaraParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ModifyNiagaraParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ModifyNiagaraParams(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyNiagaraParams_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ModifyNiagaraParams value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyNiagaraParams_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyNiagaraParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams");
			return;
		}
		BUC_DispLibDBC_EntityEffectTargetInfo.ToNative(IntPtr.Add(nativeStruct, MeshCompFilterInfo_Offset), MeshCompFilterInfo);
		BUC_DispLibDBC_ModifyNiagaraTargetInfo.ToNative(IntPtr.Add(nativeStruct, NiagaraCompFilterInfo_Offset), NiagaraCompFilterInfo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ModNiagara_NameAndBoolValue>(1, SetBoolParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModNiagara_NameAndBoolValue, BUC_DispLibUtil_ModNiagara_NameAndBoolValue>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModNiagara_NameAndBoolValue, BUC_DispLibUtil_ModNiagara_NameAndBoolValue>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetBoolParam_Offset), SetBoolParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(1, SetFloatParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFloatParam_Offset), SetFloatParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(1, SetInt32Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetInt32Param_Offset), SetInt32Param);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>(1, SetFVectorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFVectorParam_Offset), SetFVectorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset), SetFLinearColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndFloatArray>(1, SetFloatArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFloatArray, BUC_DispLibUtil_NameAndFloatArray>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFloatArray, BUC_DispLibUtil_NameAndFloatArray>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFloatArrayParam_Offset), SetFloatArrayParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndInt32Array>(1, SetInt32ArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndInt32Array, BUC_DispLibUtil_NameAndInt32Array>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndInt32Array, BUC_DispLibUtil_NameAndInt32Array>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetInt32ArrayParam_Offset), SetInt32ArrayParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndFVectorArray>(1, SetFVectorArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFVectorArray, BUC_DispLibUtil_NameAndFVectorArray>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFVectorArray, BUC_DispLibUtil_NameAndFVectorArray>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFVectorArrayParam_Offset), SetFVectorArrayParam);
		new TArrayCopyMarshaler<FName>(1, SetOverrideSelfMeshBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetOverrideSelfMeshBones_Offset), SetOverrideSelfMeshBones);
		new TArrayCopyMarshaler<FName>(1, SetOverrideSelfMeshSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetOverrideSelfMeshSockets_Offset), SetOverrideSelfMeshSockets);
		EnumMarshaler<DispLibDBCModNiagaraParamsPauseMode>.ToNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, PauseMode);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
	}

	public BUC_DispLibDBC_ModifyNiagaraParams(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyNiagaraParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams");
			MeshCompFilterInfo = default(BUC_DispLibDBC_EntityEffectTargetInfo);
			NiagaraCompFilterInfo = default(BUC_DispLibDBC_ModifyNiagaraTargetInfo);
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			SetBoolParam = null;
			SetFloatParam = null;
			SetInt32Param = null;
			SetFVectorParam = null;
			SetFLinearColorParam = null;
			SetFloatArrayParam = null;
			SetInt32ArrayParam = null;
			SetFVectorArrayParam = null;
			SetOverrideSelfMeshBones = null;
			SetOverrideSelfMeshSockets = null;
			PauseMode = DispLibDBCModNiagaraParamsPauseMode.Pause;
			PausePriority = 0;
			EndStagePriority = 0;
		}
		else
		{
			MeshCompFilterInfo = BUC_DispLibDBC_EntityEffectTargetInfo.FromNative(IntPtr.Add(nativeStruct, MeshCompFilterInfo_Offset));
			NiagaraCompFilterInfo = BUC_DispLibDBC_ModifyNiagaraTargetInfo.FromNative(IntPtr.Add(nativeStruct, NiagaraCompFilterInfo_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			SetBoolParam = new TArrayCopyMarshaler<BUC_DispLibUtil_ModNiagara_NameAndBoolValue>(1, SetBoolParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModNiagara_NameAndBoolValue, BUC_DispLibUtil_ModNiagara_NameAndBoolValue>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModNiagara_NameAndBoolValue, BUC_DispLibUtil_ModNiagara_NameAndBoolValue>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetBoolParam_Offset));
			SetFloatParam = new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(1, SetFloatParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFloatParam_Offset));
			SetInt32Param = new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>(1, SetInt32Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetInt32Param_Offset));
			SetFVectorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>(1, SetFVectorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFVectorParam_Offset));
			SetFLinearColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset));
			SetFloatArrayParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndFloatArray>(1, SetFloatArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFloatArray, BUC_DispLibUtil_NameAndFloatArray>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFloatArray, BUC_DispLibUtil_NameAndFloatArray>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFloatArrayParam_Offset));
			SetInt32ArrayParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndInt32Array>(1, SetInt32ArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndInt32Array, BUC_DispLibUtil_NameAndInt32Array>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndInt32Array, BUC_DispLibUtil_NameAndInt32Array>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetInt32ArrayParam_Offset));
			SetFVectorArrayParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndFVectorArray>(1, SetFVectorArrayParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFVectorArray, BUC_DispLibUtil_NameAndFVectorArray>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndFVectorArray, BUC_DispLibUtil_NameAndFVectorArray>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFVectorArrayParam_Offset));
			SetOverrideSelfMeshBones = new TArrayCopyMarshaler<FName>(1, SetOverrideSelfMeshBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetOverrideSelfMeshBones_Offset));
			SetOverrideSelfMeshSockets = new TArrayCopyMarshaler<FName>(1, SetOverrideSelfMeshSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetOverrideSelfMeshSockets_Offset));
			PauseMode = EnumMarshaler<DispLibDBCModNiagaraParamsPauseMode>.FromNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams");
		BUC_DispLibDBC_ModifyNiagaraParams_StructSize = NativeReflection.GetStructSize(intPtr);
		MeshCompFilterInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeshCompFilterInfo");
		MeshCompFilterInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeshCompFilterInfo", Classes.FStructProperty);
		NiagaraCompFilterInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "NiagaraCompFilterInfo");
		NiagaraCompFilterInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NiagaraCompFilterInfo", Classes.FStructProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SetBoolParam_PropertyAddress, intPtr, "SetBoolParam");
		SetBoolParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetBoolParam");
		SetBoolParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetBoolParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFloatParam_PropertyAddress, intPtr, "SetFloatParam");
		SetFloatParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFloatParam");
		SetFloatParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFloatParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetInt32Param_PropertyAddress, intPtr, "SetInt32Param");
		SetInt32Param_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetInt32Param");
		SetInt32Param_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetInt32Param", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFVectorParam_PropertyAddress, intPtr, "SetFVectorParam");
		SetFVectorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFVectorParam");
		SetFVectorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFVectorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFLinearColorParam_PropertyAddress, intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFLinearColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFloatArrayParam_PropertyAddress, intPtr, "SetFloatArrayParam");
		SetFloatArrayParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFloatArrayParam");
		SetFloatArrayParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFloatArrayParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetInt32ArrayParam_PropertyAddress, intPtr, "SetInt32ArrayParam");
		SetInt32ArrayParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetInt32ArrayParam");
		SetInt32ArrayParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetInt32ArrayParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFVectorArrayParam_PropertyAddress, intPtr, "SetFVectorArrayParam");
		SetFVectorArrayParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFVectorArrayParam");
		SetFVectorArrayParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFVectorArrayParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetOverrideSelfMeshBones_PropertyAddress, intPtr, "SetOverrideSelfMeshBones");
		SetOverrideSelfMeshBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetOverrideSelfMeshBones");
		SetOverrideSelfMeshBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetOverrideSelfMeshBones", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetOverrideSelfMeshSockets_PropertyAddress, intPtr, "SetOverrideSelfMeshSockets");
		SetOverrideSelfMeshSockets_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetOverrideSelfMeshSockets");
		SetOverrideSelfMeshSockets_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetOverrideSelfMeshSockets", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PauseMode_PropertyAddress, intPtr, "PauseMode");
		PauseMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "PauseMode");
		PauseMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PauseMode", Classes.FEnumProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		BUC_DispLibDBC_ModifyNiagaraParams_IsValid = ((intPtr != IntPtr.Zero && MeshCompFilterInfo_IsValid && NiagaraCompFilterInfo_IsValid && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && SetBoolParam_IsValid && SetFloatParam_IsValid && SetInt32Param_IsValid && SetFVectorParam_IsValid && SetFLinearColorParam_IsValid && SetFloatArrayParam_IsValid && SetInt32ArrayParam_IsValid && SetFVectorArrayParam_IsValid && SetOverrideSelfMeshBones_IsValid && SetOverrideSelfMeshSockets_IsValid && PauseMode_IsValid && PausePriority_IsValid && EndStagePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraParams", (byte)BUC_DispLibDBC_ModifyNiagaraParams_IsValid != 0);
	}

	static BUC_DispLibDBC_ModifyNiagaraParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ModifyNiagaraParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ModifyNiagaraParams));
	}
}
