using System;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill")]
internal class AutoTest_UnitCastAllSkill : b1.AutoQA.AutoTest_Template
{
	private static bool TamerClassList_IsValid;

	private static int TamerClassList_Offset;

	private static FFieldAddress TamerClassList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>> TamerClassList_Marshaler;

	private static bool SkillIDBlackList_IsValid;

	private static int SkillIDBlackList_Offset;

	private static FFieldAddress SkillIDBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIDBlackList_Marshaler;

	private static bool DistanceBetween_IsValid;

	private static int DistanceBetween_Offset;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	private static bool GetTamersInFolder_IsValid;

	private static IntPtr GetTamersInFolder_FunctionAddress;

	private static int GetTamersInFolder_ParamsSize;

	[EditAnywhere]
	[DisplayName("待测类")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill:TamerClassList")]
	public TArrayReadWrite<TSubclassOf<BUTamerActor>> TamerClassList
	{
		get
		{
			CheckDestroyed();
			if (!TamerClassList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:TamerClassList");
				return null;
			}
			if (TamerClassList_Marshaler == null)
			{
				TamerClassList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>>(1, TamerClassList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.ToNative);
			}
			return TamerClassList_Marshaler.FromNative(IntPtr.Add(base.Address, TamerClassList_Offset));
		}
	}

	[DisplayName("技能黑名单，填写技能ID，其中的技能不会被释放出来")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill:SkillIDBlackList")]
	public TArrayReadWrite<int> SkillIDBlackList
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:SkillIDBlackList");
				return null;
			}
			if (SkillIDBlackList_Marshaler == null)
			{
				SkillIDBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIDBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIDBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIDBlackList_Offset));
		}
	}

	[DisplayName("怪物和主角之间的距离")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill:DistanceBetween")]
	public int DistanceBetween
	{
		get
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:DistanceBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DistanceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:DistanceBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DistanceBetween_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("起始怪物Index，从0开始")]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitCastAllSkill:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Quick Tool")]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitCastAllSkill:GetTamersInFolder")]
	public void GetTamersInFolder()
	{
		TamerClassList.Clear();
		foreach (string selectedFolder in UGSFuncLibForEditor.GetSelectedFolders())
		{
			foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName(selectedFolder.Replace("/All", "")), bRecursive: true).AssetDataArr)
			{
				UBlueprint uBlueprint = item.GetAsset() as UBlueprint;
				if (!(uBlueprint == null))
				{
					BUTamerActor bUTamerActor = uBlueprint.GeneratedClass.ClassDefaultObject as BUTamerActor;
					if (bUTamerActor != null)
					{
						TamerClassList.Add(bUTamerActor.GetClass());
					}
				}
			}
		}
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invisible"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invincible"));
		StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
		StartIndex = FMath.Clamp(StartIndex, 0, TamerClassList.Count);
		for (int i = StartIndex; i < TamerClassList.Count; i++)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(base.WorldContext, TamerClassList[i].Value));
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new TestState_UnitCastAllSkill(base.WorldContext, TamerClassList[i].Value, isPlayer: false, 0, SkillIDBlackList.ToList()));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_UnitCastAllSkill:GetTamersInFolder")]
	private static void GetTamersInFolder__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_UnitCastAllSkill autoTest_UnitCastAllSkill = GCHelper.Find<b1.AutoQA.AutoTest_UnitCastAllSkill>(obj);
		autoTest_UnitCastAllSkill.GetTamersInFolder();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_UnitCastAllSkill");
		NativeReflection.GetPropertyRef(ref TamerClassList_PropertyAddress, intPtr, "TamerClassList");
		TamerClassList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClassList");
		TamerClassList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClassList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillIDBlackList_PropertyAddress, intPtr, "SkillIDBlackList");
		SkillIDBlackList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIDBlackList");
		SkillIDBlackList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIDBlackList", Classes.FArrayProperty);
		DistanceBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceBetween");
		DistanceBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceBetween", Classes.FIntProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartIndex", Classes.FIntProperty);
		GetTamersInFolder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTamersInFolder");
		GetTamersInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTamersInFolder_FunctionAddress);
		GetTamersInFolder_IsValid = GetTamersInFolder_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_UnitCastAllSkill:GetTamersInFolder", GetTamersInFolder_IsValid);
	}

	static AutoTest_UnitCastAllSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_UnitCastAllSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_UnitCastAllSkill));
	}
}
