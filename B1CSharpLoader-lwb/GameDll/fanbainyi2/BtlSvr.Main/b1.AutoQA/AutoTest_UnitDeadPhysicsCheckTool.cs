using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool")]
internal class AutoTest_UnitDeadPhysicsCheckTool : b1.AutoQA.AutoTest_Template
{
	private static bool TamerList_IsValid;

	private static int TamerList_Offset;

	private static bool DistanceBetween_IsValid;

	private static int DistanceBetween_Offset;

	private static bool Configs_IsValid;

	private static int Configs_Offset;

	private static FFieldAddress Configs_PropertyAddress;

	private TArrayReadWriteMarshaler<UnitDeadPhysicsConfig> Configs_Marshaler;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	[UProperty]
	[UMeta(MDProp.EditCondition, "TestType==GetTamerMethod::Use_DA")]
	[DisplayName("要用到的DA")]
	[EditAnywhere]
	[Category("性能监测|Use_DA（By ATP）")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:TamerList")]
	public AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerList
	{
		get
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:TamerList");
				return null;
			}
			return UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.FromNative(IntPtr.Add(base.Address, TamerList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:TamerList");
			}
			else
			{
				UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.ToNative(IntPtr.Add(base.Address, TamerList_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("拍照相机和怪物的间距。数越大越远，不应小于8")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:DistanceBetween")]
	public int DistanceBetween
	{
		get
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:DistanceBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DistanceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:DistanceBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DistanceBetween_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("测试挡位Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:Configs")]
	public TArrayReadWrite<UnitDeadPhysicsConfig> Configs
	{
		get
		{
			CheckDestroyed();
			if (!Configs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:Configs");
				return null;
			}
			if (Configs_Marshaler == null)
			{
				Configs_Marshaler = new TArrayReadWriteMarshaler<UnitDeadPhysicsConfig>(1, Configs_PropertyAddress, CachedMarshalingDelegates<UnitDeadPhysicsConfig, UnitDeadPhysicsConfig>.FromNative, CachedMarshalingDelegates<UnitDeadPhysicsConfig, UnitDeadPhysicsConfig>.ToNative);
			}
			return Configs_Marshaler.FromNative(IntPtr.Add(base.Address, Configs_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("起始怪物Index，从0开始")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	protected override void RegisterTestState()
	{
		ACameraActor aCameraActor = null;
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(base.WorldContext);
		foreach (AActor aActor in allActorsOfClass)
		{
			if (aActor.GetName() == "CameraActor_2" && aActor.GetLevel().GetOutermost().GetName()
				.Contains("DeadRoom"))
			{
				aCameraActor = aActor as ACameraActor;
			}
			if (aActor.GetName() == "CameraActor_0")
			{
				aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom");
			}
			if (aActor.GetName() == "StaticMeshActor_11")
			{
				aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom");
			}
			if (aActor.GetName() == "StaticMeshActor_9")
			{
				aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom");
			}
		}
		if (!(aCameraActor == null))
		{
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invisible"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllPlaySequenceNode 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllChapterMovie 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "DebugConfig.DisableDissolveDisplay 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "DebugConfig.OpenSwitchPhysicInDeadAM 1"));
			StateStack.Push(new TestState_ATPAllUnitDeadPhysicsTest(base.WorldContext, TamerList, QuitBiuPerUnit: false, DistanceBetween, Configs));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_UnitDeadPhysicsCheckTool");
		TamerList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerList");
		TamerList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerList", Classes.FObjectProperty);
		DistanceBetween_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceBetween");
		DistanceBetween_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceBetween", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Configs_PropertyAddress, unrealStruct, "Configs");
		Configs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Configs");
		Configs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Configs", Classes.FArrayProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartIndex", Classes.FIntProperty);
	}

	static AutoTest_UnitDeadPhysicsCheckTool()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_UnitDeadPhysicsCheckTool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_UnitDeadPhysicsCheckTool));
	}
}
