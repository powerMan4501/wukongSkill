using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("施放技能")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill")]
internal class BED_BehaviorNode_CastSkill : b1.BED_BehaviorNode_Action
{
	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool NeedCheckSkillCanCast_IsValid;

	private static int NeedCheckSkillCanCast_Offset;

	private static FFieldAddress NeedCheckSkillCanCast_PropertyAddress;

	private static bool MontageStartSectionName_IsValid;

	private static int MontageStartSectionName_Offset;

	private static bool bCanCastWhenDead_IsValid;

	private static int bCanCastWhenDead_Offset;

	private static FFieldAddress bCanCastWhenDead_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Cast Skill")]
	[DisplayName("技能ID")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill:SkillId")]
	public int SkillId
	{
		get
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:SkillId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:SkillId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Cast Skill")]
	[DisplayName("是否需要检测能否释放")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill:NeedCheckSkillCanCast")]
	public bool NeedCheckSkillCanCast
	{
		get
		{
			CheckDestroyed();
			if (!NeedCheckSkillCanCast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:NeedCheckSkillCanCast");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedCheckSkillCanCast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:NeedCheckSkillCanCast");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("播放起始位置")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Cast Skill")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill:MontageStartSectionName")]
	public FName MontageStartSectionName
	{
		get
		{
			CheckDestroyed();
			if (!MontageStartSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:MontageStartSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MontageStartSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MontageStartSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:MontageStartSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MontageStartSectionName_Offset), value);
			}
		}
	}

	[DisplayName("死亡时是否生效")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Cast Skill")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill:bCanCastWhenDead")]
	public bool bCanCastWhenDead
	{
		get
		{
			CheckDestroyed();
			if (!bCanCastWhenDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:bCanCastWhenDead");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanCastWhenDead_Offset), 0, bCanCastWhenDead_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanCastWhenDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkill:bCanCastWhenDead");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanCastWhenDead_Offset), 0, bCanCastWhenDead_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SkillId = 0;
		NeedCheckSkillCanCast = true;
		bCanCastWhenDead = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.CastSkill;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_CastSkill
		{
			SkillId = SkillId,
			NeedCheckSkillCanCast = NeedCheckSkillCanCast,
			MontageStartSectionName = MontageStartSectionName.ToString(),
			CanCastWhenDead = bCanCastWhenDead
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkill:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"施放技能：{SkillId}");
		if (!NeedCheckSkillCanCast)
		{
			stringBuilder.Append("\n无视检测条件施放");
		}
		if (MontageStartSectionName != FName.None)
		{
			stringBuilder.Append($"\n从Section : {MontageStartSectionName} 开始播动画");
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_CastSkill:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_CastSkill bED_BehaviorNode_CastSkill = GCHelper.Find<b1.BED_BehaviorNode_CastSkill>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_CastSkill.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_CastSkill");
		SkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedCheckSkillCanCast_PropertyAddress, intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedCheckSkillCanCast", Classes.FBoolProperty);
		MontageStartSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontageStartSectionName");
		MontageStartSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontageStartSectionName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bCanCastWhenDead_PropertyAddress, intPtr, "bCanCastWhenDead");
		bCanCastWhenDead_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanCastWhenDead");
		bCanCastWhenDead_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanCastWhenDead", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_CastSkill:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_CastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_CastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_CastSkill));
	}
}
