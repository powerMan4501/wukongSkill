using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAN_SwitchTransSpellSolution")]
internal class BAN_SwitchTransSpellSolution : UAnimNotify_GSBase
{
	private static bool SolutionID_IsValid;

	private static int SolutionID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetNotifyName_IsValid;

	private static IntPtr GetNotifyName_FunctionAddress;

	private static int GetNotifyName_ParamsSize;

	private static bool GetNotifyName_ReturnValue_IsValid;

	private static int GetNotifyName_ReturnValue_Offset;

	private static FFieldAddress GetNotifyName_ReturnValue_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UMeta(MDProp.ClampMin, 0)]
	[UProperty]
	[DisplayName("法术方案ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_SwitchTransSpellSolution:SolutionID")]
	public int SolutionID
	{
		get
		{
			CheckDestroyed();
			if (!SolutionID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SwitchTransSpellSolution:SolutionID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SolutionID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SolutionID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SwitchTransSpellSolution:SolutionID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SolutionID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_SwitchTransSpellSolution:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SolutionID = 0;
	}

	[USharpPath("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!(NotifyParam.owner == null))
		{
			BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_SwitchSpellSolution.Invoke(SolutionID);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GetNotifyName")]
	protected override string GetNotifyName_Implementation()
	{
		if (base.NotifyNameForShow == FName.None)
		{
			return $"切换到方案{SolutionID}";
		}
		return base.NotifyNameForShow.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SwitchTransSpellSolution bAN_SwitchTransSpellSolution = GCHelper.Find<b1.BAN_SwitchTransSpellSolution>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_SwitchTransSpellSolution.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GetNotifyName")]
	private static void GetNotifyName__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SwitchTransSpellSolution bAN_SwitchTransSpellSolution = GCHelper.Find<b1.BAN_SwitchTransSpellSolution>(obj);
		string notifyName_Implementation = bAN_SwitchTransSpellSolution.GetNotifyName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNotifyName_ReturnValue_Offset), notifyName_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SwitchTransSpellSolution:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SwitchTransSpellSolution bAN_SwitchTransSpellSolution = GCHelper.Find<b1.BAN_SwitchTransSpellSolution>(obj);
		bool value = bAN_SwitchTransSpellSolution.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_SwitchTransSpellSolution");
		SolutionID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SolutionID");
		SolutionID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SolutionID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GSNotifyCS", GSNotifyCS_IsValid);
		GetNotifyName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNotifyName");
		GetNotifyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNotifyName_ReturnValue_PropertyAddress, GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNotifyName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNotifyName_IsValid = GetNotifyName_FunctionAddress != IntPtr.Zero && GetNotifyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SwitchTransSpellSolution:GetNotifyName", GetNotifyName_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SwitchTransSpellSolution:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_SwitchTransSpellSolution()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_SwitchTransSpellSolution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_SwitchTransSpellSolution));
	}
}
