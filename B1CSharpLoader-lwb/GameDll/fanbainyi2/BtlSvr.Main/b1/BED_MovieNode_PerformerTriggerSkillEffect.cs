using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("演员: 触发技能效果")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect")]
internal class BED_MovieNode_PerformerTriggerSkillEffect : b1.BED_MovieNode_PerformerAction
{
	private static bool SkillEffectId_IsValid;

	private static int SkillEffectId_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:SkillEffectId")]
	public int SkillEffectId
	{
		get
		{
			CheckDestroyed();
			if (!SkillEffectId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:SkillEffectId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillEffectId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillEffectId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:SkillEffectId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillEffectId_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerTriggerSkillEffect;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		stringBuilder.Append($"触发技能效果：{SkillEffectId}");
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerTriggerSkillEffect
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			SkillEffectId = SkillEffectId
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerTriggerSkillEffect bED_MovieNode_PerformerTriggerSkillEffect = GCHelper.Find<b1.BED_MovieNode_PerformerTriggerSkillEffect>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerTriggerSkillEffect.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect");
		SkillEffectId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectId");
		SkillEffectId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectId", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerTriggerSkillEffect:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerTriggerSkillEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerTriggerSkillEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerTriggerSkillEffect));
	}
}
