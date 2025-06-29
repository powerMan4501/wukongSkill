using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams", "DonAINavigation", UnrealModuleType.GamePlugin)]
public struct FDoNNavigationQueryParams
{
	private static bool QueryTimeout_IsValid;

	private static int QueryTimeout_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:QueryTimeout")]
	public float QueryTimeout;

	private static bool FlexibleOriginGoal_IsValid;

	private static FFieldAddress FlexibleOriginGoal_PropertyAddress;

	private static int FlexibleOriginGoal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:bFlexibleOriginGoal")]
	public bool FlexibleOriginGoal;

	private static bool SkipOptimizationPass_IsValid;

	private static FFieldAddress SkipOptimizationPass_PropertyAddress;

	private static int SkipOptimizationPass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:bSkipOptimizationPass")]
	public bool SkipOptimizationPass;

	private static bool MaxOptimizerSweepAttemptsPerNode_IsValid;

	private static int MaxOptimizerSweepAttemptsPerNode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:MaxOptimizerSweepAttemptsPerNode")]
	public int MaxOptimizerSweepAttemptsPerNode;

	private static bool PreciseDynamicCollisionRepathing_IsValid;

	private static FFieldAddress PreciseDynamicCollisionRepathing_PropertyAddress;

	private static int PreciseDynamicCollisionRepathing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:bPreciseDynamicCollisionRepathing")]
	public bool PreciseDynamicCollisionRepathing;

	private static bool IgnoreDynamicCollisionRepathingForDirectGoals_IsValid;

	private static FFieldAddress IgnoreDynamicCollisionRepathingForDirectGoals_PropertyAddress;

	private static int IgnoreDynamicCollisionRepathingForDirectGoals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:bIgnoreDynamicCollisionRepathingForDirectGoals")]
	public bool IgnoreDynamicCollisionRepathingForDirectGoals;

	private static bool CollisionShapeInflation_IsValid;

	private static int CollisionShapeInflation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:CollisionShapeInflation")]
	public float CollisionShapeInflation;

	private static bool ForceRescheduleQuery_IsValid;

	private static FFieldAddress ForceRescheduleQuery_PropertyAddress;

	private static int ForceRescheduleQuery_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:bForceRescheduleQuery")]
	public bool ForceRescheduleQuery;

	private static bool OwnerPayload_IsValid;

	private static int OwnerPayload_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryParams:OwnerPayload")]
	public TWeakObject<AActor> OwnerPayload;

	private static bool FDoNNavigationQueryParams_IsValid;

	private static int FDoNNavigationQueryParams_StructSize;

	public FDoNNavigationQueryParams Copy()
	{
		return this;
	}

	public static FDoNNavigationQueryParams FromNative(IntPtr nativeBuffer)
	{
		return new FDoNNavigationQueryParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDoNNavigationQueryParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDoNNavigationQueryParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDoNNavigationQueryParams(nativeBuffer + arrayIndex * FDoNNavigationQueryParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDoNNavigationQueryParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDoNNavigationQueryParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDoNNavigationQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationQueryParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, QueryTimeout_Offset), QueryTimeout);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlexibleOriginGoal_Offset), 0, FlexibleOriginGoal_PropertyAddress.Address, FlexibleOriginGoal);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipOptimizationPass_Offset), 0, SkipOptimizationPass_PropertyAddress.Address, SkipOptimizationPass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxOptimizerSweepAttemptsPerNode_Offset), MaxOptimizerSweepAttemptsPerNode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PreciseDynamicCollisionRepathing_Offset), 0, PreciseDynamicCollisionRepathing_PropertyAddress.Address, PreciseDynamicCollisionRepathing);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreDynamicCollisionRepathingForDirectGoals_Offset), 0, IgnoreDynamicCollisionRepathingForDirectGoals_PropertyAddress.Address, IgnoreDynamicCollisionRepathingForDirectGoals);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CollisionShapeInflation_Offset), CollisionShapeInflation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceRescheduleQuery_Offset), 0, ForceRescheduleQuery_PropertyAddress.Address, ForceRescheduleQuery);
		TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, OwnerPayload_Offset), OwnerPayload);
	}

	public FDoNNavigationQueryParams(IntPtr nativeStruct)
	{
		if (!FDoNNavigationQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationQueryParams");
			QueryTimeout = 0f;
			FlexibleOriginGoal = false;
			SkipOptimizationPass = false;
			MaxOptimizerSweepAttemptsPerNode = 0;
			PreciseDynamicCollisionRepathing = false;
			IgnoreDynamicCollisionRepathingForDirectGoals = false;
			CollisionShapeInflation = 0f;
			ForceRescheduleQuery = false;
			OwnerPayload = default(TWeakObject<AActor>);
		}
		else
		{
			QueryTimeout = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, QueryTimeout_Offset));
			FlexibleOriginGoal = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlexibleOriginGoal_Offset), 0, FlexibleOriginGoal_PropertyAddress.Address);
			SkipOptimizationPass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipOptimizationPass_Offset), 0, SkipOptimizationPass_PropertyAddress.Address);
			MaxOptimizerSweepAttemptsPerNode = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxOptimizerSweepAttemptsPerNode_Offset));
			PreciseDynamicCollisionRepathing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PreciseDynamicCollisionRepathing_Offset), 0, PreciseDynamicCollisionRepathing_PropertyAddress.Address);
			IgnoreDynamicCollisionRepathingForDirectGoals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreDynamicCollisionRepathingForDirectGoals_Offset), 0, IgnoreDynamicCollisionRepathingForDirectGoals_PropertyAddress.Address);
			CollisionShapeInflation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CollisionShapeInflation_Offset));
			ForceRescheduleQuery = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceRescheduleQuery_Offset), 0, ForceRescheduleQuery_PropertyAddress.Address);
			OwnerPayload = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, OwnerPayload_Offset));
		}
	}

	static FDoNNavigationQueryParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDoNNavigationQueryParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDoNNavigationQueryParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DonAINavigation.DoNNavigationQueryParams");
		FDoNNavigationQueryParams_StructSize = NativeReflection.GetStructSize(intPtr);
		QueryTimeout_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryTimeout");
		QueryTimeout_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryTimeout", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FlexibleOriginGoal_PropertyAddress, intPtr, "bFlexibleOriginGoal");
		FlexibleOriginGoal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlexibleOriginGoal");
		FlexibleOriginGoal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlexibleOriginGoal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipOptimizationPass_PropertyAddress, intPtr, "bSkipOptimizationPass");
		SkipOptimizationPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipOptimizationPass");
		SkipOptimizationPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipOptimizationPass", Classes.FBoolProperty);
		MaxOptimizerSweepAttemptsPerNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxOptimizerSweepAttemptsPerNode");
		MaxOptimizerSweepAttemptsPerNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxOptimizerSweepAttemptsPerNode", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PreciseDynamicCollisionRepathing_PropertyAddress, intPtr, "bPreciseDynamicCollisionRepathing");
		PreciseDynamicCollisionRepathing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPreciseDynamicCollisionRepathing");
		PreciseDynamicCollisionRepathing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPreciseDynamicCollisionRepathing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreDynamicCollisionRepathingForDirectGoals_PropertyAddress, intPtr, "bIgnoreDynamicCollisionRepathingForDirectGoals");
		IgnoreDynamicCollisionRepathingForDirectGoals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreDynamicCollisionRepathingForDirectGoals");
		IgnoreDynamicCollisionRepathingForDirectGoals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreDynamicCollisionRepathingForDirectGoals", Classes.FBoolProperty);
		CollisionShapeInflation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionShapeInflation");
		CollisionShapeInflation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionShapeInflation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceRescheduleQuery_PropertyAddress, intPtr, "bForceRescheduleQuery");
		ForceRescheduleQuery_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceRescheduleQuery");
		ForceRescheduleQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceRescheduleQuery", Classes.FBoolProperty);
		OwnerPayload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OwnerPayload");
		OwnerPayload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OwnerPayload", Classes.FWeakObjectProperty);
		FDoNNavigationQueryParams_IsValid = intPtr != IntPtr.Zero && QueryTimeout_IsValid && FlexibleOriginGoal_IsValid && SkipOptimizationPass_IsValid && MaxOptimizerSweepAttemptsPerNode_IsValid && PreciseDynamicCollisionRepathing_IsValid && IgnoreDynamicCollisionRepathingForDirectGoals_IsValid && CollisionShapeInflation_IsValid && ForceRescheduleQuery_IsValid && OwnerPayload_IsValid;
		NativeReflection.LogStructIsValid("/Script/DonAINavigation.DoNNavigationQueryParams", FDoNNavigationQueryParams_IsValid);
	}
}
