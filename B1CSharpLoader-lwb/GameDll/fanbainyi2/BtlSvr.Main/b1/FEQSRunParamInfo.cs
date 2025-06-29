using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FEQSRunParamInfo")]
public struct FEQSRunParamInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:AcceptableRadius")]
	public float AcceptableRadius;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:IncludeSelfRadius")]
	public bool IncludeSelfRadius;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:EQSTemplate")]
	public UEnvQuery EQSTemplate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:MoveAIType")]
	public EBGUMoveAIType MoveAIType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:SpeedRateDistanceCurve")]
	public UCurveFloat SpeedRateDistanceCurve;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:MinAcceptableRadius")]
	public float MinAcceptableRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:MaxAcceptableRadius")]
	public float MaxAcceptableRadius;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:bEnableContinuousPathFinding")]
	public bool bEnableContinuousPathFinding;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:ContinuousPathFindingRadiusThreshold")]
	public float ContinuousPathFindingRadiusThreshold;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:AutoUpdatePathTime")]
	public float AutoUpdatePathTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:EnableDebug")]
	public bool EnableDebug;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:EnableLeisure")]
	public bool EnableLeisure;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:IntervalTime")]
	public float IntervalTime;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:LeisureList")]
	public List<FGSLeisureWithWeight> LeisureList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FEQSRunParamInfo:EnableDrawLineDebug")]
	public bool EnableDrawLineDebug;

	private static int FEQSRunParamInfo_StructSize;

	private static int FEQSRunParamInfo_IsValid;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool SpeedRateDistanceCurve_IsValid;

	private static int SpeedRateDistanceCurve_Offset;

	private static bool EnableRangeAcceptableRadius_IsValid;

	private static int EnableRangeAcceptableRadius_Offset;

	private static FFieldAddress EnableRangeAcceptableRadius_PropertyAddress;

	private static bool MinAcceptableRadius_IsValid;

	private static int MinAcceptableRadius_Offset;

	private static bool MaxAcceptableRadius_IsValid;

	private static int MaxAcceptableRadius_Offset;

	private static bool bEnableContinuousPathFinding_IsValid;

	private static int bEnableContinuousPathFinding_Offset;

	private static FFieldAddress bEnableContinuousPathFinding_PropertyAddress;

	private static bool ContinuousPathFindingRadiusThreshold_IsValid;

	private static int ContinuousPathFindingRadiusThreshold_Offset;

	private static bool AutoUpdatePathTime_IsValid;

	private static int AutoUpdatePathTime_Offset;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	private static bool EnableLeisure_IsValid;

	private static int EnableLeisure_Offset;

	private static FFieldAddress EnableLeisure_PropertyAddress;

	private static bool IntervalTime_IsValid;

	private static int IntervalTime_Offset;

	private static bool LeisureList_IsValid;

	private static int LeisureList_Offset;

	private static FFieldAddress LeisureList_PropertyAddress;

	private static bool EnableDrawLineDebug_IsValid;

	private static int EnableDrawLineDebug_Offset;

	private static FFieldAddress EnableDrawLineDebug_PropertyAddress;

	public FEQSRunParamInfo Copy()
	{
		FEQSRunParamInfo result = this;
		if (LeisureList != null)
		{
			result.LeisureList = new List<FGSLeisureWithWeight>(LeisureList);
		}
		return result;
	}

	public static FEQSRunParamInfo FromNative(IntPtr nativeBuffer)
	{
		return new FEQSRunParamInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEQSRunParamInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEQSRunParamInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEQSRunParamInfo(IntPtr.Add(nativeBuffer, arrayIndex * FEQSRunParamInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEQSRunParamInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FEQSRunParamInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FEQSRunParamInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FEQSRunParamInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AcceptableRadius_Offset), AcceptableRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, IncludeSelfRadius);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset), EQSTemplate);
		EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, MoveAIType);
		EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(nativeStruct, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, SpeedRateType);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, SpeedRateDistanceCurve_Offset), SpeedRateDistanceCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, EnableRangeAcceptableRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinAcceptableRadius_Offset), MinAcceptableRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAcceptableRadius_Offset), MaxAcceptableRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableContinuousPathFinding_Offset), 0, bEnableContinuousPathFinding_PropertyAddress.Address, bEnableContinuousPathFinding);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ContinuousPathFindingRadiusThreshold_Offset), ContinuousPathFindingRadiusThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AutoUpdatePathTime_Offset), AutoUpdatePathTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, EnableDebug);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableLeisure_Offset), 0, EnableLeisure_PropertyAddress.Address, EnableLeisure);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IntervalTime_Offset), IntervalTime);
		new TArrayCopyMarshaler<FGSLeisureWithWeight>(1, LeisureList_PropertyAddress, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.FromNative, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.ToNative).ToNative(IntPtr.Add(nativeStruct, LeisureList_Offset), LeisureList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableDrawLineDebug_Offset), 0, EnableDrawLineDebug_PropertyAddress.Address, EnableDrawLineDebug);
	}

	public FEQSRunParamInfo(IntPtr nativeStruct)
	{
		if (FEQSRunParamInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FEQSRunParamInfo");
			AcceptableRadius = 0f;
			IncludeSelfRadius = false;
			EQSTemplate = null;
			MoveAIType = EBGUMoveAIType.None;
			SpeedRateType = EAIMoveSpeedType.JOG;
			SpeedRateDistanceCurve = null;
			EnableRangeAcceptableRadius = false;
			MinAcceptableRadius = 0f;
			MaxAcceptableRadius = 0f;
			bEnableContinuousPathFinding = false;
			ContinuousPathFindingRadiusThreshold = 0f;
			AutoUpdatePathTime = 0f;
			EnableDebug = false;
			EnableLeisure = false;
			IntervalTime = 0f;
			LeisureList = null;
			EnableDrawLineDebug = false;
		}
		else
		{
			AcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AcceptableRadius_Offset));
			IncludeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
			EQSTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset));
			MoveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
			SpeedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(nativeStruct, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
			SpeedRateDistanceCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, SpeedRateDistanceCurve_Offset));
			EnableRangeAcceptableRadius = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
			MinAcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinAcceptableRadius_Offset));
			MaxAcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAcceptableRadius_Offset));
			bEnableContinuousPathFinding = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableContinuousPathFinding_Offset), 0, bEnableContinuousPathFinding_PropertyAddress.Address);
			ContinuousPathFindingRadiusThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ContinuousPathFindingRadiusThreshold_Offset));
			AutoUpdatePathTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AutoUpdatePathTime_Offset));
			EnableDebug = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
			EnableLeisure = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableLeisure_Offset), 0, EnableLeisure_PropertyAddress.Address);
			IntervalTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IntervalTime_Offset));
			LeisureList = new TArrayCopyMarshaler<FGSLeisureWithWeight>(1, LeisureList_PropertyAddress, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.FromNative, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.ToNative).FromNative(IntPtr.Add(nativeStruct, LeisureList_Offset));
			EnableDrawLineDebug = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableDrawLineDebug_Offset), 0, EnableDrawLineDebug_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FEQSRunParamInfo");
		FEQSRunParamInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, intPtr, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncludeSelfRadius", Classes.FBoolProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, intPtr, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, intPtr, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateType", Classes.FEnumProperty);
		SpeedRateDistanceCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateDistanceCurve");
		SpeedRateDistanceCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateDistanceCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableRangeAcceptableRadius_PropertyAddress, intPtr, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableRangeAcceptableRadius", Classes.FBoolProperty);
		MinAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinAcceptableRadius");
		MinAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinAcceptableRadius", Classes.FFloatProperty);
		MaxAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxAcceptableRadius");
		MaxAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxAcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableContinuousPathFinding_PropertyAddress, intPtr, "bEnableContinuousPathFinding");
		bEnableContinuousPathFinding_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableContinuousPathFinding");
		bEnableContinuousPathFinding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableContinuousPathFinding", Classes.FBoolProperty);
		ContinuousPathFindingRadiusThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "ContinuousPathFindingRadiusThreshold");
		ContinuousPathFindingRadiusThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ContinuousPathFindingRadiusThreshold", Classes.FFloatProperty);
		AutoUpdatePathTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoUpdatePathTime");
		AutoUpdatePathTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoUpdatePathTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableLeisure_PropertyAddress, intPtr, "EnableLeisure");
		EnableLeisure_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableLeisure");
		EnableLeisure_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableLeisure", Classes.FBoolProperty);
		IntervalTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntervalTime");
		IntervalTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntervalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LeisureList_PropertyAddress, intPtr, "LeisureList");
		LeisureList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureList");
		LeisureList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EnableDrawLineDebug_PropertyAddress, intPtr, "EnableDrawLineDebug");
		EnableDrawLineDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDrawLineDebug");
		EnableDrawLineDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDrawLineDebug", Classes.FBoolProperty);
		FEQSRunParamInfo_IsValid = ((intPtr != IntPtr.Zero && AcceptableRadius_IsValid && IncludeSelfRadius_IsValid && EQSTemplate_IsValid && MoveAIType_IsValid && SpeedRateType_IsValid && SpeedRateDistanceCurve_IsValid && EnableRangeAcceptableRadius_IsValid && MinAcceptableRadius_IsValid && MaxAcceptableRadius_IsValid && bEnableContinuousPathFinding_IsValid && ContinuousPathFindingRadiusThreshold_IsValid && AutoUpdatePathTime_IsValid && EnableDebug_IsValid && EnableLeisure_IsValid && IntervalTime_IsValid && LeisureList_IsValid && EnableDrawLineDebug_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FEQSRunParamInfo", (byte)FEQSRunParamInfo_IsValid != 0);
	}

	static FEQSRunParamInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEQSRunParamInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEQSRunParamInfo));
	}
}
