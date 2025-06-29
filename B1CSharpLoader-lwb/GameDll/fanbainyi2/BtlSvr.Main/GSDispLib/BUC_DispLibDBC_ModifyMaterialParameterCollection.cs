using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection")]
public struct BUC_DispLibDBC_ModifyMaterialParameterCollection
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("MPC资源路径")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:MPCAssetPath")]
	public string MPCAssetPath;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:Delay")]
	public float Delay;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:Duration")]
	public float Duration;

	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "表现逻辑层通知材质表现应该结束时要额外延后多长时间真正结束材质，小于等于0会立即结束，否则会进行销毁阶段参数更新; EndMode 是 AutoRelease 时无效")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Scalar 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:SetScalarParam")]
	public List<BUC_DispLibUtil_DBCAdvProcessScalarParam> SetScalarParam;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Color 参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:SetFLinearColorParam")]
	public List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> SetFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "设置 程序化曲线 Scalar 参数")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:SetPCurveScalarParam")]
	public List<BUC_DispLibUtil_DBCPCurveScalarParam> SetPCurveScalarParam;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.DisplayName, "设置 程序化曲线 Color 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:SetPCurveFLinearColorParam")]
	public List<BUC_DispLibUtil_DBCPCurveColorParam> SetPCurveFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "每次触发暂停时逻辑会给出此次暂停的优先级，不同原因触发的暂停其优先级可能不同;\n如果此参数大于优先级则不会被暂停")]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:PausePriority")]
	public int PausePriority;

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[DisplayName("结束表现阶段优先级")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:EndStagePriority")]
	public int EndStagePriority;

	[DisplayName("设置MPC参数优先级")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.ToolTip, "当多个事件同一帧内请求操作同一个参数时，以优先级最大的事件为准，若优先级相同，以事件开始执行的时间（PlayAtTime）越晚（越接近当前帧时间）的事件为准，若开始执行时间也一致，以当前帧逻辑请求顺序最晚的事件为准")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:ModMPCPriority")]
	public int ModMPCPriority;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现阶段设置MPC参数优先级")]
	[UMeta(MD.ToolTip, "同【设置MPC参数优先级】，但允许给结束表现阶段配置独立的优先级，因为多数情况下结束表现阶段在视觉上重要性不高，没必要抢占参数控制权")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection:ModMPCEndStagePriority")]
	public int ModMPCEndStagePriority;

	private static int BUC_DispLibDBC_ModifyMaterialParameterCollection_StructSize;

	private static int BUC_DispLibDBC_ModifyMaterialParameterCollection_IsValid;

	private static bool MPCAssetPath_IsValid;

	private static int MPCAssetPath_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private static bool SetFLinearColorParam_IsValid;

	private static int SetFLinearColorParam_Offset;

	private static FFieldAddress SetFLinearColorParam_PropertyAddress;

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

	private static bool ModMPCPriority_IsValid;

	private static int ModMPCPriority_Offset;

	private static bool ModMPCEndStagePriority_IsValid;

	private static int ModMPCEndStagePriority_Offset;

	public BUC_DispLibDBC_ModifyMaterialParameterCollection SetCustomData(string _MPCAssetPath, float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, List<BUC_DispLibUtil_DBCAdvProcessScalarParam> _SetScalarParam, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> _SetFLinearColorParam, List<BUC_DispLibUtil_DBCPCurveScalarParam> _SetPCurveScalarParam, List<BUC_DispLibUtil_DBCPCurveColorParam> _SetPCurveFLinearColorParam, int _PausePriority, int _EndStagePriority, int _ModMPCPriority, int _ModMPCEndStagePriority)
	{
		MPCAssetPath = _MPCAssetPath;
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		SetScalarParam = ((_SetScalarParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessScalarParam>() : _SetScalarParam);
		SetFLinearColorParam = ((_SetFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>() : _SetFLinearColorParam);
		SetPCurveScalarParam = ((_SetPCurveScalarParam == null) ? new List<BUC_DispLibUtil_DBCPCurveScalarParam>() : _SetPCurveScalarParam);
		SetPCurveFLinearColorParam = ((_SetPCurveFLinearColorParam == null) ? new List<BUC_DispLibUtil_DBCPCurveColorParam>() : _SetPCurveFLinearColorParam);
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		ModMPCPriority = _ModMPCPriority;
		ModMPCEndStagePriority = _ModMPCEndStagePriority;
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection SetCustomData(float _Delay, float _Duration, float _DelayTimeAfterStop, FName _ParamName, float _Value, int _PausePriority = 0, int _EndStagePriority = 0, int _ModMPCPriority = 0, int _ModMPCEndStagePriority = 0)
	{
		MPCAssetPath = "MaterialParameterCollection'/Game/00Main/GlobalMat/FXLibrary/MaterialLayers/MPC/MPC_HFM_Character_Seq.MPC_HFM_Character_Seq'";
		Delay = _Delay;
		EndMode = ((!(_Duration <= 0f)) ? DispLibDBCEndMode.FixDuration : DispLibDBCEndMode.ProcedureNotity);
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		SetFLinearColorParam = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>();
		SetPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarParam>();
		SetPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorParam>();
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		ModMPCPriority = _ModMPCPriority;
		ModMPCEndStagePriority = _ModMPCEndStagePriority;
		BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(_Value, _Duration);
		BUC_DispLibUtil_DBCAdvProcessScalarParam item = default(BUC_DispLibUtil_DBCAdvProcessScalarParam).SetCustomData(_ParamName, processValue);
		SetScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam> { item };
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection SetCustomData(string _MPCAssetPath, float _Delay, float _Duration, FName _ParamName, float _Value)
	{
		MPCAssetPath = _MPCAssetPath;
		Delay = _Delay;
		EndMode = DispLibDBCEndMode.FixDuration;
		Duration = _Duration;
		DelayTimeAfterStop = 0f;
		SetFLinearColorParam = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>();
		SetPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarParam>();
		SetPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorParam>();
		PausePriority = 0;
		EndStagePriority = 0;
		ModMPCPriority = 0;
		ModMPCEndStagePriority = 0;
		BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(_Value, _Duration);
		BUC_DispLibUtil_DBCAdvProcessScalarParam item = default(BUC_DispLibUtil_DBCAdvProcessScalarParam).SetCustomData(_ParamName, processValue);
		SetScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam> { item };
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection SetCustomData(string _MPCAssetPath, float _Delay, float _Duration, FName _ParamName, FLinearColor _Value)
	{
		MPCAssetPath = _MPCAssetPath;
		Delay = _Delay;
		EndMode = DispLibDBCEndMode.FixDuration;
		Duration = _Duration;
		DelayTimeAfterStop = 0f;
		SetScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam>();
		SetPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarParam>();
		SetPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorParam>();
		PausePriority = 0;
		EndStagePriority = 0;
		ModMPCPriority = 0;
		ModMPCEndStagePriority = 0;
		BUC_DispLibUtil_DBCAdvProcessFLinearColor processValue = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).SetCustomData(_Value, _Duration);
		BUC_DispLibUtil_DBCAdvProcessFLinearColorParam item = default(BUC_DispLibUtil_DBCAdvProcessFLinearColorParam).SetCustomData(_ParamName, processValue);
		SetFLinearColorParam = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> { item };
		return this;
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection GetDefault()
	{
		return default(BUC_DispLibDBC_ModifyMaterialParameterCollection).SetCustomData(string.Empty, 0f, DispLibDBCEndMode.FixDuration, 0f, 0f, null, null, null, null, 0, 0, 0, 0);
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection Copy()
	{
		BUC_DispLibDBC_ModifyMaterialParameterCollection result = this;
		if (SetScalarParam != null)
		{
			result.SetScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam>(SetScalarParam);
		}
		if (SetFLinearColorParam != null)
		{
			result.SetFLinearColorParam = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>(SetFLinearColorParam);
		}
		if (SetPCurveScalarParam != null)
		{
			result.SetPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarParam>(SetPCurveScalarParam);
		}
		if (SetPCurveFLinearColorParam != null)
		{
			result.SetPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorParam>(SetPCurveFLinearColorParam);
		}
		return result;
	}

	public static BUC_DispLibDBC_ModifyMaterialParameterCollection FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ModifyMaterialParameterCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ModifyMaterialParameterCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ModifyMaterialParameterCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ModifyMaterialParameterCollection(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyMaterialParameterCollection_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ModifyMaterialParameterCollection value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyMaterialParameterCollection_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyMaterialParameterCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MPCAssetPath_Offset), MPCAssetPath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset), SetScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset), SetFLinearColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveScalarParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetPCurveScalarParam_Offset), SetPCurveScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveColorParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetPCurveFLinearColorParam_Offset), SetPCurveFLinearColorParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModMPCPriority_Offset), ModMPCPriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModMPCEndStagePriority_Offset), ModMPCEndStagePriority);
	}

	public BUC_DispLibDBC_ModifyMaterialParameterCollection(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyMaterialParameterCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection");
			MPCAssetPath = null;
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			SetScalarParam = null;
			SetFLinearColorParam = null;
			SetPCurveScalarParam = null;
			SetPCurveFLinearColorParam = null;
			PausePriority = 0;
			EndStagePriority = 0;
			ModMPCPriority = 0;
			ModMPCEndStagePriority = 0;
		}
		else
		{
			MPCAssetPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MPCAssetPath_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			SetScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset));
			SetFLinearColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetFLinearColorParam_Offset));
			SetPCurveScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveScalarParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetPCurveScalarParam_Offset));
			SetPCurveFLinearColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCPCurveColorParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetPCurveFLinearColorParam_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
			ModMPCPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ModMPCPriority_Offset));
			ModMPCEndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ModMPCEndStagePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection");
		BUC_DispLibDBC_ModifyMaterialParameterCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		MPCAssetPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "MPCAssetPath");
		MPCAssetPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MPCAssetPath", Classes.FStrProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SetScalarParam_PropertyAddress, intPtr, "SetScalarParam");
		SetScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetScalarParam");
		SetScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetFLinearColorParam_PropertyAddress, intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetFLinearColorParam");
		SetFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetFLinearColorParam", Classes.FArrayProperty);
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
		ModMPCPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModMPCPriority");
		ModMPCPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModMPCPriority", Classes.FIntProperty);
		ModMPCEndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModMPCEndStagePriority");
		ModMPCEndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModMPCEndStagePriority", Classes.FIntProperty);
		BUC_DispLibDBC_ModifyMaterialParameterCollection_IsValid = ((intPtr != IntPtr.Zero && MPCAssetPath_IsValid && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && SetScalarParam_IsValid && SetFLinearColorParam_IsValid && SetPCurveScalarParam_IsValid && SetPCurveFLinearColorParam_IsValid && PausePriority_IsValid && EndStagePriority_IsValid && ModMPCPriority_IsValid && ModMPCEndStagePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ModifyMaterialParameterCollection", (byte)BUC_DispLibDBC_ModifyMaterialParameterCollection_IsValid != 0);
	}

	static BUC_DispLibDBC_ModifyMaterialParameterCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ModifyMaterialParameterCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ModifyMaterialParameterCollection));
	}
}
