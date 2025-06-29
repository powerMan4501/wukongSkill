using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset")]
public class BGWAISkillScoreConfigDataAsset : UBGWDataAsset
{
	private static bool RealComboAddition_IsValid;

	private static int RealComboAddition_Offset;

	private static bool OtherComboSkillSubtraction_IsValid;

	private static int OtherComboSkillSubtraction_Offset;

	private static bool FirstSkillRealComboAddition_IsValid;

	private static int FirstSkillRealComboAddition_Offset;

	private static bool FirstSkillRealComboSkillReduceNum_IsValid;

	private static int FirstSkillRealComboSkillReduceNum_Offset;

	private static bool EndSkillAddition_IsValid;

	private static int EndSkillAddition_Offset;

	private static bool EndSkillSubtraction_IsValid;

	private static int EndSkillSubtraction_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("真连招加分系数")]
	[Tooltip("准备释放的技能与上一招构成真连招，加成")]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:RealComboAddition")]
	public float RealComboAddition
	{
		get
		{
			CheckDestroyed();
			if (!RealComboAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:RealComboAddition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RealComboAddition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RealComboAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:RealComboAddition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RealComboAddition_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是另外连招的序列减分系数")]
	[Tooltip("准备释放的技能是别的连招序列，减分")]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:OtherComboSkillSubtraction")]
	public float OtherComboSkillSubtraction
	{
		get
		{
			CheckDestroyed();
			if (!OtherComboSkillSubtraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:OtherComboSkillSubtraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OtherComboSkillSubtraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherComboSkillSubtraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:OtherComboSkillSubtraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OtherComboSkillSubtraction_Offset), value);
			}
		}
	}

	[Tooltip("准备释放的技能是该连招的第一招，且在表格里面他存在后续连招技能，加成")]
	[BlueprintReadWrite]
	[DisplayName("真连招第一招加分")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboAddition")]
	public float FirstSkillRealComboAddition
	{
		get
		{
			CheckDestroyed();
			if (!FirstSkillRealComboAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboAddition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FirstSkillRealComboAddition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstSkillRealComboAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboAddition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FirstSkillRealComboAddition_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("真连招长度限制减分")]
	[Tooltip("准备释放的技能是该连招的第一招，连招上限减少值")]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboSkillReduceNum")]
	public int FirstSkillRealComboSkillReduceNum
	{
		get
		{
			CheckDestroyed();
			if (!FirstSkillRealComboSkillReduceNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboSkillReduceNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FirstSkillRealComboSkillReduceNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstSkillRealComboSkillReduceNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:FirstSkillRealComboSkillReduceNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FirstSkillRealComboSkillReduceNum_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("终结技加分")]
	[Tooltip("准备释放的技能是当前随机出来连招数的最后一招且他没有后续技能释放，加成")]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillAddition")]
	public float EndSkillAddition
	{
		get
		{
			CheckDestroyed();
			if (!EndSkillAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillAddition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EndSkillAddition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndSkillAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillAddition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EndSkillAddition_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("准备释放的技能不是当前随机出来连招数的最后一招且他没有后续技能释放，减分")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("终结技减分")]
	[USharpPath("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillSubtraction")]
	public float EndSkillSubtraction
	{
		get
		{
			CheckDestroyed();
			if (!EndSkillSubtraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillSubtraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EndSkillSubtraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndSkillSubtraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset:EndSkillSubtraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EndSkillSubtraction_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWAISkillScoreConfigDataAsset");
		RealComboAddition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RealComboAddition");
		RealComboAddition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RealComboAddition", Classes.FFloatProperty);
		OtherComboSkillSubtraction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OtherComboSkillSubtraction");
		OtherComboSkillSubtraction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OtherComboSkillSubtraction", Classes.FFloatProperty);
		FirstSkillRealComboAddition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstSkillRealComboAddition");
		FirstSkillRealComboAddition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstSkillRealComboAddition", Classes.FFloatProperty);
		FirstSkillRealComboSkillReduceNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstSkillRealComboSkillReduceNum");
		FirstSkillRealComboSkillReduceNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstSkillRealComboSkillReduceNum", Classes.FIntProperty);
		EndSkillAddition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndSkillAddition");
		EndSkillAddition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndSkillAddition", Classes.FFloatProperty);
		EndSkillSubtraction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndSkillSubtraction");
		EndSkillSubtraction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndSkillSubtraction", Classes.FFloatProperty);
	}

	static BGWAISkillScoreConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWAISkillScoreConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWAISkillScoreConfigDataAsset));
	}
}
