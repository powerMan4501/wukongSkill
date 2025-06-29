using System;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool")]
internal class AutoTest_DingShenEffectCheckTool : b1.AutoQA.AutoTest_Template
{
	private static bool TamerClassList_IsValid;

	private static int TamerClassList_Offset;

	private static FFieldAddress TamerClassList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>> TamerClassList_Marshaler;

	private static bool DistanceBetween_IsValid;

	private static int DistanceBetween_Offset;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	private static bool GetTamersInFolder_IsValid;

	private static IntPtr GetTamersInFolder_FunctionAddress;

	private static int GetTamersInFolder_ParamsSize;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("待测类")]
	[USharpPath("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:TamerClassList")]
	public TArrayReadWrite<TSubclassOf<BUTamerActor>> TamerClassList
	{
		get
		{
			CheckDestroyed();
			if (!TamerClassList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:TamerClassList");
				return null;
			}
			if (TamerClassList_Marshaler == null)
			{
				TamerClassList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<BUTamerActor>>(1, TamerClassList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BUTamerActor>, TSubclassOfMarshaler<BUTamerActor>>.ToNative);
			}
			return TamerClassList_Marshaler.FromNative(IntPtr.Add(base.Address, TamerClassList_Offset));
		}
	}

	[DisplayName("拍照相机和怪物的间距。数越大越远，不应小于8")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:DistanceBetween")]
	public int DistanceBetween
	{
		get
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:DistanceBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DistanceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:DistanceBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DistanceBetween_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("起始怪物Index，从0开始")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	[Category("Quick Tool")]
	[BlueprintCallable]
	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:GetTamersInFolder")]
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
		ACameraActor aCameraActor = null;
		ACameraActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACameraActor>(base.WorldContext);
		foreach (ACameraActor aCameraActor2 in allActorsOfClass)
		{
			if (aCameraActor2.GetName() == "CameraActor_1")
			{
				aCameraActor = aCameraActor2;
				break;
			}
		}
		if (!(aCameraActor == null))
		{
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.AddBuff 210"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.CancelCD 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SetMaxMP 100000000"));
			StartIndex = FMath.Clamp(StartIndex, 0, TamerClassList.Count);
			for (int j = StartIndex; j < TamerClassList.Count; j++)
			{
				StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(base.WorldContext, TamerClassList[j].Value));
				StateStack.Push(new TestState_UnitDingShenEffect(base.WorldContext, TamerClassList[j].Value, DistanceBetween, aCameraActor));
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:GetTamersInFolder")]
	private static void GetTamersInFolder__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_DingShenEffectCheckTool autoTest_DingShenEffectCheckTool = GCHelper.Find<b1.AutoQA.AutoTest_DingShenEffectCheckTool>(obj);
		autoTest_DingShenEffectCheckTool.GetTamersInFolder();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool");
		NativeReflection.GetPropertyRef(ref TamerClassList_PropertyAddress, intPtr, "TamerClassList");
		TamerClassList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClassList");
		TamerClassList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClassList", Classes.FArrayProperty);
		DistanceBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceBetween");
		DistanceBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceBetween", Classes.FIntProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartIndex", Classes.FIntProperty);
		GetTamersInFolder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTamersInFolder");
		GetTamersInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTamersInFolder_FunctionAddress);
		GetTamersInFolder_IsValid = GetTamersInFolder_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_DingShenEffectCheckTool:GetTamersInFolder", GetTamersInFolder_IsValid);
	}

	static AutoTest_DingShenEffectCheckTool()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_DingShenEffectCheckTool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_DingShenEffectCheckTool));
	}
}
