using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("施放技能")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_CastSkill")]
internal class BED_ProcessStateNode_CastSkill : BED_ProcessStateNode
{
	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool NeedCheckSkillCanCast_IsValid;

	private static int NeedCheckSkillCanCast_Offset;

	private static FFieldAddress NeedCheckSkillCanCast_PropertyAddress;

	[Category("CastSkill")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("技能ID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:SkillId")]
	public int SkillId
	{
		get
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:SkillId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:SkillId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillId_Offset), value);
			}
		}
	}

	[DisplayName("是否需要检测能否释放")]
	[Category("CastSkill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:NeedCheckSkillCanCast")]
	public bool NeedCheckSkillCanCast
	{
		get
		{
			CheckDestroyed();
			if (!NeedCheckSkillCanCast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:NeedCheckSkillCanCast");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedCheckSkillCanCast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_CastSkill:NeedCheckSkillCanCast");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SkillId = 0;
		NeedCheckSkillCanCast = true;
	}

	public override string GetNodeName()
	{
		return "Process.State.CastSkill";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_CastSkill");
		SkillId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedCheckSkillCanCast_PropertyAddress, unrealStruct, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedCheckSkillCanCast", Classes.FBoolProperty);
	}

	static BED_ProcessStateNode_CastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ProcessStateNode_CastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ProcessStateNode_CastSkill));
	}
}
