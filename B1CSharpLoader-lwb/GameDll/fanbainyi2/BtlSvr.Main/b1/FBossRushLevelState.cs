using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BossRushLevelState")]
public struct FBossRushLevelState
{
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:LevelName")]
	public string LevelName;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:bModify")]
	public bool bModify;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:bHasSeqControl")]
	public bool bHasSeqControl;

	[UProperty]
	[DisplayName("启用关键词匹配")]
	[UMeta(MDProp.EditCondition, "bModify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:bHasKeywords")]
	public bool bHasKeywords;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:OriginLevelState")]
	public ELevelLoadState OriginLevelState;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:ModifyLevelState")]
	public ELevelLoadState ModifyLevelState;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelState:SeqControlLevelState")]
	public ELevelLoadState SeqControlLevelState;

	private static int BossRushLevelState_StructSize;

	private static int BossRushLevelState_IsValid;

	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	private static bool bModify_IsValid;

	private static int bModify_Offset;

	private static FFieldAddress bModify_PropertyAddress;

	private static bool bHasSeqControl_IsValid;

	private static int bHasSeqControl_Offset;

	private static FFieldAddress bHasSeqControl_PropertyAddress;

	private static bool bHasKeywords_IsValid;

	private static int bHasKeywords_Offset;

	private static FFieldAddress bHasKeywords_PropertyAddress;

	private static bool OriginLevelState_IsValid;

	private static int OriginLevelState_Offset;

	private static FFieldAddress OriginLevelState_PropertyAddress;

	private static bool ModifyLevelState_IsValid;

	private static int ModifyLevelState_Offset;

	private static FFieldAddress ModifyLevelState_PropertyAddress;

	private static bool SeqControlLevelState_IsValid;

	private static int SeqControlLevelState_Offset;

	private static FFieldAddress SeqControlLevelState_PropertyAddress;

	public ELevelLoadState GetFinalLevelState()
	{
		if (!bModify)
		{
			if (!bHasSeqControl)
			{
				return OriginLevelState;
			}
			return SeqControlLevelState;
		}
		return ModifyLevelState;
	}

	public EBossRushLevelLoadState GetFinalBossRushLevelLoadState()
	{
		int num = (int)GetFinalLevelState();
		if (bHasKeywords)
		{
			num += 3;
		}
		return (EBossRushLevelLoadState)num;
	}

	public FBossRushLevelState Copy()
	{
		return this;
	}

	public static FBossRushLevelState FromNative(IntPtr nativeBuffer)
	{
		return new FBossRushLevelState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBossRushLevelState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBossRushLevelState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBossRushLevelState(IntPtr.Add(nativeBuffer, arrayIndex * BossRushLevelState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBossRushLevelState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BossRushLevelState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BossRushLevelState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossRushLevelState");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelName_Offset), LevelName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bModify_Offset), 0, bModify_PropertyAddress.Address, bModify);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bHasSeqControl_Offset), 0, bHasSeqControl_PropertyAddress.Address, bHasSeqControl);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bHasKeywords_Offset), 0, bHasKeywords_PropertyAddress.Address, bHasKeywords);
		EnumMarshaler<ELevelLoadState>.ToNative(IntPtr.Add(nativeStruct, OriginLevelState_Offset), 0, OriginLevelState_PropertyAddress.Address, OriginLevelState);
		EnumMarshaler<ELevelLoadState>.ToNative(IntPtr.Add(nativeStruct, ModifyLevelState_Offset), 0, ModifyLevelState_PropertyAddress.Address, ModifyLevelState);
		EnumMarshaler<ELevelLoadState>.ToNative(IntPtr.Add(nativeStruct, SeqControlLevelState_Offset), 0, SeqControlLevelState_PropertyAddress.Address, SeqControlLevelState);
	}

	public FBossRushLevelState(IntPtr nativeStruct)
	{
		if (BossRushLevelState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossRushLevelState");
			LevelName = null;
			bModify = false;
			bHasSeqControl = false;
			bHasKeywords = false;
			OriginLevelState = ELevelLoadState.Auto;
			ModifyLevelState = ELevelLoadState.Auto;
			SeqControlLevelState = ELevelLoadState.Auto;
		}
		else
		{
			LevelName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelName_Offset));
			bModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bModify_Offset), 0, bModify_PropertyAddress.Address);
			bHasSeqControl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bHasSeqControl_Offset), 0, bHasSeqControl_PropertyAddress.Address);
			bHasKeywords = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bHasKeywords_Offset), 0, bHasKeywords_PropertyAddress.Address);
			OriginLevelState = EnumMarshaler<ELevelLoadState>.FromNative(IntPtr.Add(nativeStruct, OriginLevelState_Offset), 0, OriginLevelState_PropertyAddress.Address);
			ModifyLevelState = EnumMarshaler<ELevelLoadState>.FromNative(IntPtr.Add(nativeStruct, ModifyLevelState_Offset), 0, ModifyLevelState_PropertyAddress.Address);
			SeqControlLevelState = EnumMarshaler<ELevelLoadState>.FromNative(IntPtr.Add(nativeStruct, SeqControlLevelState_Offset), 0, SeqControlLevelState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BossRushLevelState");
		BossRushLevelState_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bModify_PropertyAddress, intPtr, "bModify");
		bModify_Offset = NativeReflection.GetPropertyOffset(intPtr, "bModify");
		bModify_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bModify", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasSeqControl_PropertyAddress, intPtr, "bHasSeqControl");
		bHasSeqControl_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasSeqControl");
		bHasSeqControl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasSeqControl", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasKeywords_PropertyAddress, intPtr, "bHasKeywords");
		bHasKeywords_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasKeywords");
		bHasKeywords_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasKeywords", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OriginLevelState_PropertyAddress, intPtr, "OriginLevelState");
		OriginLevelState_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginLevelState");
		OriginLevelState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginLevelState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ModifyLevelState_PropertyAddress, intPtr, "ModifyLevelState");
		ModifyLevelState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModifyLevelState");
		ModifyLevelState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModifyLevelState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SeqControlLevelState_PropertyAddress, intPtr, "SeqControlLevelState");
		SeqControlLevelState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SeqControlLevelState");
		SeqControlLevelState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SeqControlLevelState", Classes.FEnumProperty);
		BossRushLevelState_IsValid = ((intPtr != IntPtr.Zero && LevelName_IsValid && bModify_IsValid && bHasSeqControl_IsValid && bHasKeywords_IsValid && OriginLevelState_IsValid && ModifyLevelState_IsValid && SeqControlLevelState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BossRushLevelState", (byte)BossRushLevelState_IsValid != 0);
	}

	static FBossRushLevelState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBossRushLevelState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBossRushLevelState));
	}
}
