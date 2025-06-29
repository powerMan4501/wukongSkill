using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("检测当前释放的技能")]
[USharpPath("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId")]
public class BED_Behavior_CheckCurrentCastSkillId : BED_BehaviorNode
{
	private static bool SkillIds_IsValid;

	private static int SkillIds_Offset;

	private static FFieldAddress SkillIds_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIds_Marshaler;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("技能Id")]
	[USharpPath("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId:SkillIds")]
	public TArrayReadWrite<int> SkillIds
	{
		get
		{
			CheckDestroyed();
			if (!SkillIds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId:SkillIds");
				return null;
			}
			if (SkillIds_Marshaler == null)
			{
				SkillIds_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIds_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIds_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Condition");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.CheckCurrentCastSkillId;
	}

	[USharpPath("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.OutputPins.Clear();
		foreach (int skillId in SkillIds)
		{
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = new FName(skillId.ToString())
			});
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_Behavior_CheckCurrentCastSkillId bED_Behavior_CheckCurrentCastSkillId = GCHelper.Find<BED_Behavior_CheckCurrentCastSkillId>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_Behavior_CheckCurrentCastSkillId.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId");
		NativeReflection.GetPropertyRef(ref SkillIds_PropertyAddress, intPtr, "SkillIds");
		SkillIds_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIds");
		SkillIds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIds", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_Behavior_CheckCurrentCastSkillId:PostPropertyChanged", PostPropertyChanged_IsValid);
	}

	static BED_Behavior_CheckCurrentCastSkillId()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_Behavior_CheckCurrentCastSkillId)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_Behavior_CheckCurrentCastSkillId));
	}
}
