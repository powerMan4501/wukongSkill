using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart")]
public struct FCompositeCondition_SpawnWaveStart
{
	[UProperty]
	[DisplayName("条件配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:Single")]
	public FSpawnWaveStartCondition Single;

	[EditAnywhere]
	[DisplayName("使用复合条件")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:bUseCompositeCondition")]
	public bool bUseCompositeCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("复合条件")]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:Conditions")]
	public List<FSpawnWaveStartCondition> Conditions;

	[DisplayName("复合条件逻辑关系")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[DisplayName("是否反转复合条件")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:bReverseCondition")]
	public bool bReverseCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[USharpPath("/Script/b1-Managed.CompositeCondition_SpawnWaveStart:Comment")]
	public string Comment;

	private static int CompositeCondition_SpawnWaveStart_StructSize;

	private static int CompositeCondition_SpawnWaveStart_IsValid;

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

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FCompositeCondition_SpawnWaveStart Copy()
	{
		FCompositeCondition_SpawnWaveStart result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FSpawnWaveStartCondition>(Conditions);
		}
		return result;
	}

	public static FCompositeCondition_SpawnWaveStart FromNative(IntPtr nativeBuffer)
	{
		return new FCompositeCondition_SpawnWaveStart(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCompositeCondition_SpawnWaveStart value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCompositeCondition_SpawnWaveStart FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCompositeCondition_SpawnWaveStart(IntPtr.Add(nativeBuffer, arrayIndex * CompositeCondition_SpawnWaveStart_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCompositeCondition_SpawnWaveStart value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CompositeCondition_SpawnWaveStart_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CompositeCondition_SpawnWaveStart_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeCondition_SpawnWaveStart");
			return;
		}
		FSpawnWaveStartCondition.ToNative(IntPtr.Add(nativeStruct, Single_Offset), Single);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address, bUseCompositeCondition);
		new TArrayCopyMarshaler<FSpawnWaveStartCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveStartCondition, FSpawnWaveStartCondition>.FromNative, CachedMarshalingDelegates<FSpawnWaveStartCondition, FSpawnWaveStartCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FCompositeCondition_SpawnWaveStart(IntPtr nativeStruct)
	{
		if (CompositeCondition_SpawnWaveStart_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeCondition_SpawnWaveStart");
			Single = default(FSpawnWaveStartCondition);
			bUseCompositeCondition = false;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			Single = FSpawnWaveStartCondition.FromNative(IntPtr.Add(nativeStruct, Single_Offset));
			bUseCompositeCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FSpawnWaveStartCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveStartCondition, FSpawnWaveStartCondition>.FromNative, CachedMarshalingDelegates<FSpawnWaveStartCondition, FSpawnWaveStartCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CompositeCondition_SpawnWaveStart");
		CompositeCondition_SpawnWaveStart_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		CompositeCondition_SpawnWaveStart_IsValid = ((intPtr != IntPtr.Zero && Single_IsValid && bUseCompositeCondition_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CompositeCondition_SpawnWaveStart", (byte)CompositeCondition_SpawnWaveStart_IsValid != 0);
	}

	static FCompositeCondition_SpawnWaveStart()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCompositeCondition_SpawnWaveStart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCompositeCondition_SpawnWaveStart));
	}
}
