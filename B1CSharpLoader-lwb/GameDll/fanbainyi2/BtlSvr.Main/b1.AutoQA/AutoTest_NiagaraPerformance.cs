using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance")]
internal class AutoTest_NiagaraPerformance : b1.AutoQA.AutoTest_Template
{
	private static bool TestType_IsValid;

	private static int TestType_Offset;

	private static FFieldAddress TestType_PropertyAddress;

	private static bool SkillIDBlackList_IsValid;

	private static int SkillIDBlackList_Offset;

	private static FFieldAddress SkillIDBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIDBlackList_Marshaler;

	private static bool TamerList_IsValid;

	private static int TamerList_Offset;

	private static bool QuitEditorPerUnit_IsValid;

	private static int QuitEditorPerUnit_Offset;

	private static FFieldAddress QuitEditorPerUnit_PropertyAddress;

	private static bool TamerString_IsValid;

	private static int TamerString_Offset;

	[EditAnywhere]
	[DisplayName("获取待测列表的方式")]
	[Category("性能监测|通用配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance:TestType")]
	public GetTamerMethod TestType
	{
		get
		{
			CheckDestroyed();
			if (!TestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TestType");
				return GetTamerMethod.Use_DA;
			}
			return EnumMarshaler<GetTamerMethod>.FromNative(IntPtr.Add(base.Address, TestType_Offset), 0, TestType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TestType");
			}
			else
			{
				EnumMarshaler<GetTamerMethod>.ToNative(IntPtr.Add(base.Address, TestType_Offset), 0, TestType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("技能黑名单，填写技能ID，其中的技能不会被释放出来")]
	[BlueprintReadWrite]
	[Category("性能监测|通用配置")]
	[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance:SkillIDBlackList")]
	public TArrayReadWrite<int> SkillIDBlackList
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:SkillIDBlackList");
				return null;
			}
			if (SkillIDBlackList_Marshaler == null)
			{
				SkillIDBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIDBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIDBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIDBlackList_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "TestType==GetTamerMethod::Use_DA")]
	[DisplayName("要用到的DA")]
	[Category("性能监测|Use_DA（By ATP）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerList")]
	public AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerList
	{
		get
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerList");
				return null;
			}
			return UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.FromNative(IntPtr.Add(base.Address, TamerList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerList");
			}
			else
			{
				UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.ToNative(IntPtr.Add(base.Address, TamerList_Offset), value);
			}
		}
	}

	[DisplayName("每测完一个怪就退出编辑器")]
	[Category("性能监测|Use_DA（By ATP）")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "TestType==GetTamerMethod::Use_DA")]
	[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance:QuitEditorPerUnit")]
	public bool QuitEditorPerUnit
	{
		get
		{
			CheckDestroyed();
			if (!QuitEditorPerUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:QuitEditorPerUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, QuitEditorPerUnit_Offset), 0, QuitEditorPerUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QuitEditorPerUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:QuitEditorPerUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, QuitEditorPerUnit_Offset), 0, QuitEditorPerUnit_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "TestType==GetTamerMethod::Use_SingleMonster")]
	[Category("性能监测|Use_SingleMonster")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("要指定的Tamer")]
	[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerString")]
	public string TamerString
	{
		get
		{
			CheckDestroyed();
			if (!TamerString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerString");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TamerString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_NiagaraPerformance:TamerString");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TamerString_Offset), value);
			}
		}
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invincible"));
		if (TestType == GetTamerMethod.Use_SingleMonster && TamerString.Length > 0)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invisible"));
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(base.WorldContext, TamerString));
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new TestState_UnitCastAllSkill(base.WorldContext, TamerString, isPlayer: false, 0, SkillIDBlackList.ToList()));
		}
		if (TestType == GetTamerMethod.Use_DA)
		{
			StateStack.Push(new TestState_ATPNiagaraPerformanceTest(base.WorldContext, TamerList, QuitEditorPerUnit, SkillIDBlackList));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_NiagaraPerformance");
		NativeReflection.GetPropertyRef(ref TestType_PropertyAddress, unrealStruct, "TestType");
		TestType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TestType");
		TestType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TestType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SkillIDBlackList_PropertyAddress, unrealStruct, "SkillIDBlackList");
		SkillIDBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillIDBlackList");
		SkillIDBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillIDBlackList", Classes.FArrayProperty);
		TamerList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerList");
		TamerList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerList", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QuitEditorPerUnit_PropertyAddress, unrealStruct, "QuitEditorPerUnit");
		QuitEditorPerUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QuitEditorPerUnit");
		QuitEditorPerUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QuitEditorPerUnit", Classes.FBoolProperty);
		TamerString_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerString");
		TamerString_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerString", Classes.FStrProperty);
	}

	static AutoTest_NiagaraPerformance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_NiagaraPerformance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_NiagaraPerformance));
	}
}
