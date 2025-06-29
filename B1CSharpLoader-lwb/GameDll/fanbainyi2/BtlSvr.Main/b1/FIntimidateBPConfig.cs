using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.IntimidateBPConfig")]
public struct FIntimidateBPConfig
{
	[UMeta(MDProp.ClampMax, "10000")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("万分比")]
	[DisplayName("发起恐吓概率")]
	[Category("发起恐吓相关")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatingProbability")]
	public int IntimidatingProbability;

	[Tooltip("必须大于等于这个等级才会发起恐吓")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("发起恐吓相关")]
	[DisplayName("发起恐吓最低受击等级")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "10000")]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatingMinStiffLevel")]
	public int IntimidatingMinStiffLevel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("发起恐吓相关")]
	[DisplayName("发起恐吓后CD")]
	[Tooltip("单位：秒；在CD内不会发起恐吓")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatingCD")]
	public float IntimidatingCD;

	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("单位：厘米；发起恐吓影响范围半径")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("发起恐吓相关")]
	[DisplayName("发起恐吓范围")]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatingRange")]
	public int IntimidatingRange;

	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[Tooltip("每次恐吓影响单位数量最大值")]
	[DisplayName("发起恐吓影响最大人数")]
	[Category("发起恐吓相关")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatingInfluenceMaxNum")]
	public int IntimidatingInfluenceMaxNum;

	[DisplayName("受到恐吓技能List")]
	[UProperty]
	[EditAnywhere]
	[Category("受到恐吓相关")]
	[Tooltip("受到恐吓后，会随机选取一个技能播放；有恐吓技能，才会受到恐吓")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatedSkillList")]
	public List<int> IntimidatedSkillList;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("受到恐吓相关")]
	[DisplayName("受到恐吓概率")]
	[UProperty]
	[UMeta(MDProp.ClampMax, "10000")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("万分比")]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatedProbability")]
	public int IntimidatedProbability;

	[EditAnywhere]
	[DisplayName("受到恐吓后CD")]
	[Tooltip("单位：秒；在CD内不会受到恐吓")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("受到恐吓相关")]
	[USharpPath("/Script/b1-Managed.IntimidateBPConfig:IntimidatedCD")]
	public float IntimidatedCD;

	private static int IntimidateBPConfig_StructSize;

	private static int IntimidateBPConfig_IsValid;

	private static bool IntimidatingProbability_IsValid;

	private static int IntimidatingProbability_Offset;

	private static bool IntimidatingMinStiffLevel_IsValid;

	private static int IntimidatingMinStiffLevel_Offset;

	private static bool IntimidatingCD_IsValid;

	private static int IntimidatingCD_Offset;

	private static bool IntimidatingRange_IsValid;

	private static int IntimidatingRange_Offset;

	private static bool IntimidatingInfluenceMaxNum_IsValid;

	private static int IntimidatingInfluenceMaxNum_Offset;

	private static bool IntimidatedSkillList_IsValid;

	private static int IntimidatedSkillList_Offset;

	private static FFieldAddress IntimidatedSkillList_PropertyAddress;

	private static bool IntimidatedProbability_IsValid;

	private static int IntimidatedProbability_Offset;

	private static bool IntimidatedCD_IsValid;

	private static int IntimidatedCD_Offset;

	public FIntimidateBPConfig Copy()
	{
		FIntimidateBPConfig result = this;
		if (IntimidatedSkillList != null)
		{
			result.IntimidatedSkillList = new List<int>(IntimidatedSkillList);
		}
		return result;
	}

	public static FIntimidateBPConfig FromNative(IntPtr nativeBuffer)
	{
		return new FIntimidateBPConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIntimidateBPConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIntimidateBPConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIntimidateBPConfig(IntPtr.Add(nativeBuffer, arrayIndex * IntimidateBPConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIntimidateBPConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IntimidateBPConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IntimidateBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IntimidateBPConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntimidatingProbability_Offset), IntimidatingProbability);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntimidatingMinStiffLevel_Offset), IntimidatingMinStiffLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IntimidatingCD_Offset), IntimidatingCD);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntimidatingRange_Offset), IntimidatingRange);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntimidatingInfluenceMaxNum_Offset), IntimidatingInfluenceMaxNum);
		new TArrayCopyMarshaler<int>(1, IntimidatedSkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, IntimidatedSkillList_Offset), IntimidatedSkillList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntimidatedProbability_Offset), IntimidatedProbability);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IntimidatedCD_Offset), IntimidatedCD);
	}

	public FIntimidateBPConfig(IntPtr nativeStruct)
	{
		if (IntimidateBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IntimidateBPConfig");
			IntimidatingProbability = 0;
			IntimidatingMinStiffLevel = 0;
			IntimidatingCD = 0f;
			IntimidatingRange = 0;
			IntimidatingInfluenceMaxNum = 0;
			IntimidatedSkillList = null;
			IntimidatedProbability = 0;
			IntimidatedCD = 0f;
		}
		else
		{
			IntimidatingProbability = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntimidatingProbability_Offset));
			IntimidatingMinStiffLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntimidatingMinStiffLevel_Offset));
			IntimidatingCD = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IntimidatingCD_Offset));
			IntimidatingRange = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntimidatingRange_Offset));
			IntimidatingInfluenceMaxNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntimidatingInfluenceMaxNum_Offset));
			IntimidatedSkillList = new TArrayCopyMarshaler<int>(1, IntimidatedSkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, IntimidatedSkillList_Offset));
			IntimidatedProbability = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntimidatedProbability_Offset));
			IntimidatedCD = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IntimidatedCD_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IntimidateBPConfig");
		IntimidateBPConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		IntimidatingProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatingProbability");
		IntimidatingProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatingProbability", Classes.FIntProperty);
		IntimidatingMinStiffLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatingMinStiffLevel");
		IntimidatingMinStiffLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatingMinStiffLevel", Classes.FIntProperty);
		IntimidatingCD_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatingCD");
		IntimidatingCD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatingCD", Classes.FFloatProperty);
		IntimidatingRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatingRange");
		IntimidatingRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatingRange", Classes.FIntProperty);
		IntimidatingInfluenceMaxNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatingInfluenceMaxNum");
		IntimidatingInfluenceMaxNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatingInfluenceMaxNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IntimidatedSkillList_PropertyAddress, intPtr, "IntimidatedSkillList");
		IntimidatedSkillList_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatedSkillList");
		IntimidatedSkillList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatedSkillList", Classes.FArrayProperty);
		IntimidatedProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatedProbability");
		IntimidatedProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatedProbability", Classes.FIntProperty);
		IntimidatedCD_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntimidatedCD");
		IntimidatedCD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntimidatedCD", Classes.FFloatProperty);
		IntimidateBPConfig_IsValid = ((intPtr != IntPtr.Zero && IntimidatingProbability_IsValid && IntimidatingMinStiffLevel_IsValid && IntimidatingCD_IsValid && IntimidatingRange_IsValid && IntimidatingInfluenceMaxNum_IsValid && IntimidatedSkillList_IsValid && IntimidatedProbability_IsValid && IntimidatedCD_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IntimidateBPConfig", (byte)IntimidateBPConfig_IsValid != 0);
	}

	static FIntimidateBPConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FIntimidateBPConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntimidateBPConfig));
	}
}
