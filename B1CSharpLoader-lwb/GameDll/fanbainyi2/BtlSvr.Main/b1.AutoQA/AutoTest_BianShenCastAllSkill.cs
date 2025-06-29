using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_BianShenCastAllSkill")]
internal class AutoTest_BianShenCastAllSkill : b1.AutoQA.AutoTest_Template
{
	private static bool SkillIDs_IsValid;

	private static int SkillIDs_Offset;

	private static FFieldAddress SkillIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIDs_Marshaler;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("变身技能ID")]
	[USharpPath("/Script/b1-Managed.AutoTest_BianShenCastAllSkill:SkillIDs")]
	public TArrayReadWrite<int> SkillIDs
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BianShenCastAllSkill:SkillIDs");
				return null;
			}
			if (SkillIDs_Marshaler == null)
			{
				SkillIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIDs_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIDs_Offset));
		}
	}

	[DisplayName("起始Index，从0开始（用于中断后从中间继续）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_BianShenCastAllSkill:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BianShenCastAllSkill:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BianShenCastAllSkill:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invisible"));
		StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
		for (int i = StartIndex; i < SkillIDs.Count; i++)
		{
			StateStack.Push(new TestState_BianShenCastAllSkill(base.WorldContext, SkillIDs[i]));
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_BianShenCastAllSkill");
		NativeReflection.GetPropertyRef(ref SkillIDs_PropertyAddress, unrealStruct, "SkillIDs");
		SkillIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillIDs");
		SkillIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillIDs", Classes.FArrayProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartIndex", Classes.FIntProperty);
	}

	static AutoTest_BianShenCastAllSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_BianShenCastAllSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_BianShenCastAllSkill));
	}
}
