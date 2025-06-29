using System;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_UnitPicTaker")]
internal class AutoTest_UnitPicTaker : b1.AutoQA.AutoTest_Template
{
	private static bool UnitClassList_IsValid;

	private static int UnitClassList_Offset;

	private static FFieldAddress UnitClassList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<ABGUCharacter>> UnitClassList_Marshaler;

	private static bool DistanceBetween_IsValid;

	private static int DistanceBetween_Offset;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	private static bool GetUnitsInFolder_IsValid;

	private static IntPtr GetUnitsInFolder_FunctionAddress;

	private static int GetUnitsInFolder_ParamsSize;

	[DisplayName("待测类")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitPicTaker:UnitClassList")]
	public TArrayReadWrite<TSubclassOf<ABGUCharacter>> UnitClassList
	{
		get
		{
			CheckDestroyed();
			if (!UnitClassList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitPicTaker:UnitClassList");
				return null;
			}
			if (UnitClassList_Marshaler == null)
			{
				UnitClassList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<ABGUCharacter>>(1, UnitClassList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<ABGUCharacter>, TSubclassOfMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<TSubclassOf<ABGUCharacter>, TSubclassOfMarshaler<ABGUCharacter>>.ToNative);
			}
			return UnitClassList_Marshaler.FromNative(IntPtr.Add(base.Address, UnitClassList_Offset));
		}
	}

	[DisplayName("拍照相机和怪物的间距。数越大越远，不应小于8")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitPicTaker:DistanceBetween")]
	public int DistanceBetween
	{
		get
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitPicTaker:DistanceBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DistanceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitPicTaker:DistanceBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DistanceBetween_Offset), value);
			}
		}
	}

	[DisplayName("起始怪物Index，从0开始")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitPicTaker:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitPicTaker:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitPicTaker:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[Category("Quick Tool")]
	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitPicTaker:GetUnitsInFolder")]
	public void GetUnitsInFolder()
	{
		UnitClassList.Clear();
		foreach (string selectedFolder in UGSFuncLibForEditor.GetSelectedFolders())
		{
			foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName(selectedFolder.Replace("/All", "")), bRecursive: true).AssetDataArr)
			{
				UBlueprint uBlueprint = item.GetAsset() as UBlueprint;
				if (!(uBlueprint == null))
				{
					ABGUCharacter aBGUCharacter = uBlueprint.GeneratedClass.ClassDefaultObject as ABGUCharacter;
					if (aBGUCharacter != null)
					{
						UnitClassList.Add(aBGUCharacter.GetClass());
					}
				}
			}
		}
	}

	protected override void RegisterTestState()
	{
		ACameraActor aCameraActor = null;
		ACameraActor aCameraActor2 = null;
		ACameraActor aCameraActor3 = null;
		ACameraActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACameraActor>(base.WorldContext);
		foreach (ACameraActor aCameraActor4 in allActorsOfClass)
		{
			if (aCameraActor4.GetName() == "CameraActor_1")
			{
				aCameraActor = aCameraActor4;
			}
			if (aCameraActor4.GetName() == "CameraActor_0")
			{
				aCameraActor2 = aCameraActor4;
			}
			if (aCameraActor4.GetName() == "CameraActor_2")
			{
				aCameraActor3 = aCameraActor4;
			}
		}
		if (!(aCameraActor == null) && !(aCameraActor2 == null) && !(aCameraActor3 == null))
		{
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.AddBuff 210"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.CancelCD 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SetMaxMP 100000000"));
			StartIndex = FMath.Clamp(StartIndex, 0, UnitClassList.Count);
			for (int j = StartIndex; j < UnitClassList.Count; j++)
			{
				StateStack.Push(new TestState_GenerateUnit(base.WorldContext, UnitClassList[j].Value));
				StateStack.Push(new TestState_UnitPicTaker(base.WorldContext, UnitClassList[j].Value, DistanceBetween, aCameraActor, aCameraActor2, aCameraActor3));
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_UnitPicTaker:GetUnitsInFolder")]
	private static void GetUnitsInFolder__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_UnitPicTaker autoTest_UnitPicTaker = GCHelper.Find<b1.AutoQA.AutoTest_UnitPicTaker>(obj);
		autoTest_UnitPicTaker.GetUnitsInFolder();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_UnitPicTaker");
		NativeReflection.GetPropertyRef(ref UnitClassList_PropertyAddress, intPtr, "UnitClassList");
		UnitClassList_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitClassList");
		UnitClassList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitClassList", Classes.FArrayProperty);
		DistanceBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceBetween");
		DistanceBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceBetween", Classes.FIntProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartIndex", Classes.FIntProperty);
		GetUnitsInFolder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnitsInFolder");
		GetUnitsInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnitsInFolder_FunctionAddress);
		GetUnitsInFolder_IsValid = GetUnitsInFolder_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_UnitPicTaker:GetUnitsInFolder", GetUnitsInFolder_IsValid);
	}

	static AutoTest_UnitPicTaker()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_UnitPicTaker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_UnitPicTaker));
	}
}
