using System;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_BattleWithUnit")]
internal class AutoTest_BattleWithUnit : b1.AutoQA.AutoTest_Template
{
	private static bool TamerClassList_IsValid;

	private static int TamerClassList_Offset;

	private static FFieldAddress TamerClassList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>> TamerClassList_Marshaler;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	private static bool GetTamersInFolder_IsValid;

	private static IntPtr GetTamersInFolder_FunctionAddress;

	private static int GetTamersInFolder_ParamsSize;

	[DisplayName("待测类")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_BattleWithUnit:TamerClassList")]
	public TArrayReadWrite<TSubclassOf<BUTamerActor>> TamerClassList
	{
		get
		{
			CheckDestroyed();
			if (!TamerClassList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BattleWithUnit:TamerClassList");
				return null;
			}
			if (TamerClassList_Marshaler == null)
			{
				TamerClassList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>>(1, TamerClassList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.ToNative);
			}
			return TamerClassList_Marshaler.FromNative(IntPtr.Add(base.Address, TamerClassList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("起始怪物Index，从0开始")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_BattleWithUnit:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BattleWithUnit:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_BattleWithUnit:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	[Category("Quick Tool")]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTest_BattleWithUnit:GetTamersInFolder")]
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
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(this));
		StartIndex = FMath.Clamp(StartIndex, 0, TamerClassList.Count);
		for (int i = StartIndex; i < TamerClassList.Count; i++)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(this, "b.teleportToPosition 0 0 100"));
			StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(this, TamerClassList[i].Value));
			StateStack.Push(new TestState_AdjustRoleData(this, TamerClassList[i].Value));
			StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(this, TamerClassList[i].Value, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		}
		StateStack.Push(new b1.AutoQA.TestState_OpenBagTest(this));
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_BattleWithUnit:GetTamersInFolder")]
	private static void GetTamersInFolder__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_BattleWithUnit autoTest_BattleWithUnit = GCHelper.Find<b1.AutoQA.AutoTest_BattleWithUnit>(obj);
		autoTest_BattleWithUnit.GetTamersInFolder();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_BattleWithUnit");
		NativeReflection.GetPropertyRef(ref TamerClassList_PropertyAddress, intPtr, "TamerClassList");
		TamerClassList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClassList");
		TamerClassList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClassList", Classes.FArrayProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartIndex", Classes.FIntProperty);
		GetTamersInFolder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTamersInFolder");
		GetTamersInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTamersInFolder_FunctionAddress);
		GetTamersInFolder_IsValid = GetTamersInFolder_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_BattleWithUnit:GetTamersInFolder", GetTamersInFolder_IsValid);
	}

	static AutoTest_BattleWithUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_BattleWithUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_BattleWithUnit));
	}
}
