using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State")]
public struct FCompositeTransitionCondition_State
{
	[DisplayName("条件配置")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:Single")]
	public FTransitionCondition_State Single;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("使用复合条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:bUseCompositeCondition")]
	public bool bUseCompositeCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("复合条件")]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:Conditions")]
	public List<FTransitionCondition_State> Conditions;

	[EditAnywhere]
	[DisplayName("复合条件逻辑关系")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:Comment")]
	public string Comment;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("转阶段参数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_State:BossPhaseInfo")]
	public FBossPhaseInfo BossPhaseInfo;

	private static int CompositeTransitionCondition_State_StructSize;

	private static int CompositeTransitionCondition_State_IsValid;

	private static bool Single_IsValid;

	private static int Single_Offset;

	private static bool bUseCompositeCondition_IsValid;

	private static int bUseCompositeCondition_Offset;

	private static FFieldAddress bUseCompositeCondition_PropertyAddress;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private static bool ConditionalRelation_IsValid;

	private static int ConditionalRelation_Offset;

	private static FFieldAddress ConditionalRelation_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	private static bool BossPhaseInfo_IsValid;

	private static int BossPhaseInfo_Offset;

	public FCompositeTransitionCondition_State Copy()
	{
		FCompositeTransitionCondition_State result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FTransitionCondition_State>(Conditions);
		}
		return result;
	}

	public static FCompositeTransitionCondition_State FromNative(IntPtr nativeBuffer)
	{
		return new FCompositeTransitionCondition_State(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCompositeTransitionCondition_State value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCompositeTransitionCondition_State FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCompositeTransitionCondition_State(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_State_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCompositeTransitionCondition_State value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_State_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_State_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_State");
			return;
		}
		FTransitionCondition_State.ToNative(IntPtr.Add(nativeStruct, Single_Offset), Single);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address, bUseCompositeCondition);
		new TArrayCopyMarshaler<FTransitionCondition_State>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_State, FTransitionCondition_State>.FromNative, CachedMarshalingDelegates<FTransitionCondition_State, FTransitionCondition_State>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
		FBossPhaseInfo.ToNative(IntPtr.Add(nativeStruct, BossPhaseInfo_Offset), BossPhaseInfo);
	}

	public FCompositeTransitionCondition_State(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_State_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_State");
			Single = default(FTransitionCondition_State);
			bUseCompositeCondition = false;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			Comment = null;
			BossPhaseInfo = default(FBossPhaseInfo);
		}
		else
		{
			Single = FTransitionCondition_State.FromNative(IntPtr.Add(nativeStruct, Single_Offset));
			bUseCompositeCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FTransitionCondition_State>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_State, FTransitionCondition_State>.FromNative, CachedMarshalingDelegates<FTransitionCondition_State, FTransitionCondition_State>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
			BossPhaseInfo = FBossPhaseInfo.FromNative(IntPtr.Add(nativeStruct, BossPhaseInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CompositeTransitionCondition_State");
		CompositeTransitionCondition_State_StructSize = NativeReflection.GetStructSize(intPtr);
		Single_Offset = NativeReflection.GetPropertyOffset(intPtr, "Single");
		Single_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Single", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUseCompositeCondition_PropertyAddress, intPtr, "bUseCompositeCondition");
		bUseCompositeCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCompositeCondition");
		bUseCompositeCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCompositeCondition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionalRelation_PropertyAddress, intPtr, "ConditionalRelation");
		ConditionalRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionalRelation");
		ConditionalRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionalRelation", Classes.FEnumProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		BossPhaseInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossPhaseInfo");
		BossPhaseInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossPhaseInfo", Classes.FStructProperty);
		CompositeTransitionCondition_State_IsValid = ((intPtr != IntPtr.Zero && Single_IsValid && bUseCompositeCondition_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && Comment_IsValid && BossPhaseInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CompositeTransitionCondition_State", (byte)CompositeTransitionCondition_State_IsValid != 0);
	}

	static FCompositeTransitionCondition_State()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCompositeTransitionCondition_State)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCompositeTransitionCondition_State));
	}
}
