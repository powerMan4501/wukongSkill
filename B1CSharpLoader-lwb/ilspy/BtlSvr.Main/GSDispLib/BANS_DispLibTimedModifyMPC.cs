using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[DisplayName("BANS DispLib Timed Modify MPC")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC")]
internal class BANS_DispLibTimedModifyMPC : BANS_GSBase
{
	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam> SetScalarParam_Marshaler;

	private static bool SetFLinearColorParam_IsValid;

	private static int SetFLinearColorParam_Offset;

	private static FFieldAddress SetFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> SetFLinearColorParam_Marshaler;

	private static bool SetPCurveScalarParam_IsValid;

	private static int SetPCurveScalarParam_Offset;

	private static FFieldAddress SetPCurveScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveScalarParam> SetPCurveScalarParam_Marshaler;

	private static bool SetPCurveFLinearColorParam_IsValid;

	private static int SetPCurveFLinearColorParam_Offset;

	private static FFieldAddress SetPCurveFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveColorParam> SetPCurveFLinearColorParam_Marshaler;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool ModMPCPriority_IsValid;

	private static int ModMPCPriority_Offset;

	private static bool ModMPCEndStagePriority_IsValid;

	private static int ModMPCEndStagePriority_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[DisplayName("结束表现时间")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "表现逻辑层通知材质表现应该结束时要额外延后多长时间真正结束材质，小于等于0会立即结束，否则会进行销毁阶段参数更新; EndMode 是 AutoRelease 时无效")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置 Scalar 参数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetScalarParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCAdvProcessScalarParam> SetScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!SetScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetScalarParam");
				return null;
			}
			if (SetScalarParam_Marshaler == null)
			{
				SetScalarParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.ToNative);
			}
			return SetScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetScalarParam_Offset));
		}
	}

	[UProperty]
	[UMeta(MD.DisplayName, "设置 Color 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetFLinearColorParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> SetFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!SetFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetFLinearColorParam");
				return null;
			}
			if (SetFLinearColorParam_Marshaler == null)
			{
				SetFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>(1, SetFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam>.ToNative);
			}
			return SetFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetFLinearColorParam_Offset));
		}
	}

	[UMeta(MD.DisplayName, "设置 程序化曲线 Scalar 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetPCurveScalarParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCPCurveScalarParam> SetPCurveScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!SetPCurveScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetPCurveScalarParam");
				return null;
			}
			if (SetPCurveScalarParam_Marshaler == null)
			{
				SetPCurveScalarParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveScalarParam>(1, SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveScalarParam, BUC_DispLibUtil_DBCPCurveScalarParam>.ToNative);
			}
			return SetPCurveScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetPCurveScalarParam_Offset));
		}
	}

	[UMeta(MD.DisplayName, "设置 程序化曲线 Color 参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetPCurveFLinearColorParam")]
	public TArrayReadWrite<BUC_DispLibUtil_DBCPCurveColorParam> SetPCurveFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!SetPCurveFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:SetPCurveFLinearColorParam");
				return null;
			}
			if (SetPCurveFLinearColorParam_Marshaler == null)
			{
				SetPCurveFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibUtil_DBCPCurveColorParam>(1, SetPCurveFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCPCurveColorParam, BUC_DispLibUtil_DBCPCurveColorParam>.ToNative);
			}
			return SetPCurveFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, SetPCurveFLinearColorParam_Offset));
		}
	}

	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "每次触发暂停时逻辑会给出此次暂停的优先级，不同原因触发的暂停其优先级可能不同;\n如果此参数大于优先级则不会被暂停")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:PausePriority")]
	public int PausePriority
	{
		get
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:PausePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PausePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:PausePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PausePriority_Offset), value);
			}
		}
	}

	[DisplayName("结束表现阶段优先级")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("设置MPC参数优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "当多个事件同一帧内请求操作同一个参数时，以优先级最大的事件为准，若优先级相同，以事件开始执行的时间（PlayAtTime）越晚（越接近当前帧时间）的事件为准，若开始执行时间也一致，以当前帧逻辑请求顺序最晚的事件为准")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCPriority")]
	public int ModMPCPriority
	{
		get
		{
			CheckDestroyed();
			if (!ModMPCPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ModMPCPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModMPCPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ModMPCPriority_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现阶段设置MPC参数优先级")]
	[UMeta(MD.ToolTip, "同【设置MPC参数优先级】，但允许给结束表现阶段配置独立的优先级，因为多数情况下结束表现阶段在视觉上重要性不高，没必要抢占参数控制权")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCEndStagePriority")]
	public int ModMPCEndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!ModMPCEndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCEndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ModMPCEndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModMPCEndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:ModMPCEndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ModMPCEndStagePriority_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
	}

	protected bool ValidateParameters()
	{
		if (MPC.IsNullOrDestroyed())
		{
			return false;
		}
		if (SetScalarParam.Count > 0 || SetFLinearColorParam.Count > 0 || SetPCurveScalarParam.Count > 0 || SetPCurveFLinearColorParam.Count > 0)
		{
			return true;
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		if (ValidateParameters())
		{
			DoModMPC(meshComp, animation, TotalDuration);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		EndModMPC(meshComp, animation);
	}

	private void DoModMPC(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation, float TotalDuration)
	{
		AActor owner = SourceDispOwnerComp.GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			string pathName = MPC.GetPathName();
			BUC_DispLibDBC_ModifyMaterialParameterCollection d = default(BUC_DispLibDBC_ModifyMaterialParameterCollection).SetCustomData(pathName, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, DelayTimeAfterStop, SetScalarParam.ToList(), SetFLinearColorParam.ToList(), SetPCurveScalarParam.ToList(), SetPCurveFLinearColorParam.ToList(), PausePriority, EndStagePriority, ModMPCPriority, ModMPCEndStagePriority);
			BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(owner);
			if (bUS_DispLibEventCollection == null)
			{
				BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(SourceDispOwnerComp))?.Evt_RequestApply_One_ModMPC?.Invoke(SourceDispOwnerComp, d, out var _, GetUniqueID());
			}
			else
			{
				bUS_DispLibEventCollection.Evt_RequestApply_One_ModMPC?.Invoke(d, out var _, GetUniqueID());
			}
		}
	}

	private void EndModMPC(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation)
	{
		AActor owner = SourceDispOwnerComp.GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			uint uniqueID = GetUniqueID();
			BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(owner);
			if (bUS_DispLibEventCollection != null)
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID?.Invoke(uniqueID, 0u);
			}
			else
			{
				BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(owner))?.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID?.Invoke(SourceDispOwnerComp, uniqueID, 0u, OnlyEndFX: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_DispLibTimedModifyMPC bANS_DispLibTimedModifyMPC = GCHelper.Find<GSDispLib.BANS_DispLibTimedModifyMPC>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_DispLibTimedModifyMPC.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_DispLibTimedModifyMPC bANS_DispLibTimedModifyMPC = GCHelper.Find<GSDispLib.BANS_DispLibTimedModifyMPC>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_DispLibTimedModifyMPC.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_DispLibTimedModifyMPC");
		MPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "MPC");
		MPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MPC", Classes.FObjectProperty);
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
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_DispLibTimedModifyMPC:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_DispLibTimedModifyMPC()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BANS_DispLibTimedModifyMPC)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BANS_DispLibTimedModifyMPC));
	}
}
