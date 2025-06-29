using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_PlayerCastAllSkill")]
internal class AutoTest_PlayerCastAllSkill : b1.AutoQA.AutoTest_Template
{
	private static bool RoleDataConfigIDs_IsValid;

	private static int RoleDataConfigIDs_Offset;

	private static FFieldAddress RoleDataConfigIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> RoleDataConfigIDs_Marshaler;

	private static bool SkillIDBlackList_IsValid;

	private static int SkillIDBlackList_Offset;

	private static FFieldAddress SkillIDBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIDBlackList_Marshaler;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	[DisplayName("角色初始配置ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:RoleDataConfigIDs")]
	public TArrayReadWrite<int> RoleDataConfigIDs
	{
		get
		{
			CheckDestroyed();
			if (!RoleDataConfigIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:RoleDataConfigIDs");
				return null;
			}
			if (RoleDataConfigIDs_Marshaler == null)
			{
				RoleDataConfigIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, RoleDataConfigIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return RoleDataConfigIDs_Marshaler.FromNative(IntPtr.Add(base.Address, RoleDataConfigIDs_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("技能黑名单，填写技能ID，其中的技能不会被释放出来")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:SkillIDBlackList")]
	public TArrayReadWrite<int> SkillIDBlackList
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:SkillIDBlackList");
				return null;
			}
			if (SkillIDBlackList_Marshaler == null)
			{
				SkillIDBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIDBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIDBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIDBlackList_Offset));
		}
	}

	[DisplayName("起始角色配置Index，从0开始（用于中断后从中间套装继续）")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlayerCastAllSkill:StartIndex");
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
		SkillIDBlackList.Add(10556);
		SkillIDBlackList.Add(10563);
		StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.WorldContext).GetControlledPawn() as BGUCharacterCS;
		for (int i = StartIndex; i < RoleDataConfigIDs.Count; i++)
		{
			StateStack.Push(new TestState_AdjustRoleDataByID(base.WorldContext, RoleDataConfigIDs[i]));
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
			StateStack.Push(new TestState_UnitCastAllSkill(base.WorldContext, bGUCharacterCS.GetClass(), isPlayer: true, RoleDataConfigIDs[i], SkillIDBlackList.ToList()));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PlayerCastAllSkill");
		NativeReflection.GetPropertyRef(ref RoleDataConfigIDs_PropertyAddress, unrealStruct, "RoleDataConfigIDs");
		RoleDataConfigIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RoleDataConfigIDs");
		RoleDataConfigIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RoleDataConfigIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillIDBlackList_PropertyAddress, unrealStruct, "SkillIDBlackList");
		SkillIDBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillIDBlackList");
		SkillIDBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillIDBlackList", Classes.FArrayProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartIndex", Classes.FIntProperty);
	}

	static AutoTest_PlayerCastAllSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PlayerCastAllSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PlayerCastAllSkill));
	}
}
