using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor")]
internal class BGUTortoiseLevelStreamingMgrActor : BGUActorBaseCS
{
	private static bool TortoiseLevelStreamingConfigComp_IsValid;

	private static int TortoiseLevelStreamingConfigComp_Offset;

	private static bool OnAllSetLevelsStateFinished_IsValid;

	private static IntPtr OnAllSetLevelsStateFinished_FunctionAddress;

	private static int OnAllSetLevelsStateFinished_ParamsSize;

	private static bool OnSingleSetLevelsStateFinished_IsValid;

	private static IntPtr OnSingleSetLevelsStateFinished_FunctionAddress;

	private static int OnSingleSetLevelsStateFinished_ParamsSize;

	private static bool OnSingleSetLevelsStateFinished_LevelKeyword_IsValid;

	private static int OnSingleSetLevelsStateFinished_LevelKeyword_Offset;

	private static FFieldAddress OnSingleSetLevelsStateFinished_LevelKeyword_PropertyAddress;

	private static bool OnSingleSetLevelsStateFinished_LevelState_IsValid;

	private static int OnSingleSetLevelsStateFinished_LevelState_Offset;

	private static FFieldAddress OnSingleSetLevelsStateFinished_LevelState_PropertyAddress;

	private static bool OnSingleSetLevelsStateFinished_OperationID_IsValid;

	private static int OnSingleSetLevelsStateFinished_OperationID_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:TortoiseLevelStreamingConfigComp")]
	public b1.BUS_TortoiseLevelStreamingConfigComp TortoiseLevelStreamingConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!TortoiseLevelStreamingConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:TortoiseLevelStreamingConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_TortoiseLevelStreamingConfigComp>.FromNative(IntPtr.Add(base.Address, TortoiseLevelStreamingConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TortoiseLevelStreamingConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:TortoiseLevelStreamingConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_TortoiseLevelStreamingConfigComp>.ToNative(IntPtr.Add(base.Address, TortoiseLevelStreamingConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TortoiseLevelStreamingConfigComp = initializer.CreateDefaultSubobject<b1.BUS_TortoiseLevelStreamingConfigComp>(this, B1GlobalFNames.TortoiseLevelStreamingConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TortoiseLevelStreamingMgrComp());
		UBGUFunctionLibraryForCS.BGUBindOnSetLevelsStateFinished(this, new FName("OnSingleSetLevelsStateFinished"));
		UBGUFunctionLibraryForCS.BGUBindOnAllSetLevelsStateFinished(this, new FName("OnAllSetLevelsStateFinished"));
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_TortoiseLevelStreamingMgrDataComp>(this, B1GlobalFNames.TortoiseLevelStreamingMgrDataComp);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnSingleSetLevelsStateFinished")]
	private void OnSingleSetLevelsStateFinished(string LevelKeyword, string LevelState, int OperationID)
	{
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnAllSetLevelsStateFinished")]
	private void OnAllSetLevelsStateFinished()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnAllSetLevelsStateFinished")]
	private static void OnAllSetLevelsStateFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUTortoiseLevelStreamingMgrActor bGUTortoiseLevelStreamingMgrActor = GCHelper.Find<b1.BGUTortoiseLevelStreamingMgrActor>(obj);
		bGUTortoiseLevelStreamingMgrActor.OnAllSetLevelsStateFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnSingleSetLevelsStateFinished")]
	private static void OnSingleSetLevelsStateFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUTortoiseLevelStreamingMgrActor bGUTortoiseLevelStreamingMgrActor = GCHelper.Find<b1.BGUTortoiseLevelStreamingMgrActor>(obj);
		string levelKeyword = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnSingleSetLevelsStateFinished_LevelKeyword_Offset));
		string levelState = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnSingleSetLevelsStateFinished_LevelState_Offset));
		int operationID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnSingleSetLevelsStateFinished_OperationID_Offset));
		bGUTortoiseLevelStreamingMgrActor.OnSingleSetLevelsStateFinished(levelKeyword, levelState, operationID);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor");
		TortoiseLevelStreamingConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "TortoiseLevelStreamingConfigComp");
		TortoiseLevelStreamingConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TortoiseLevelStreamingConfigComp", Classes.FObjectProperty);
		OnAllSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAllSetLevelsStateFinished");
		OnAllSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAllSetLevelsStateFinished_FunctionAddress);
		OnAllSetLevelsStateFinished_IsValid = OnAllSetLevelsStateFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnAllSetLevelsStateFinished", OnAllSetLevelsStateFinished_IsValid);
		OnSingleSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSingleSetLevelsStateFinished");
		OnSingleSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSingleSetLevelsStateFinished_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSingleSetLevelsStateFinished_LevelKeyword_PropertyAddress, OnSingleSetLevelsStateFinished_FunctionAddress, "LevelKeyword");
		OnSingleSetLevelsStateFinished_LevelKeyword_Offset = NativeReflection.GetPropertyOffset(OnSingleSetLevelsStateFinished_FunctionAddress, "LevelKeyword");
		OnSingleSetLevelsStateFinished_LevelKeyword_IsValid = NativeReflection.ValidatePropertyClass(OnSingleSetLevelsStateFinished_FunctionAddress, "LevelKeyword", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnSingleSetLevelsStateFinished_LevelState_PropertyAddress, OnSingleSetLevelsStateFinished_FunctionAddress, "LevelState");
		OnSingleSetLevelsStateFinished_LevelState_Offset = NativeReflection.GetPropertyOffset(OnSingleSetLevelsStateFinished_FunctionAddress, "LevelState");
		OnSingleSetLevelsStateFinished_LevelState_IsValid = NativeReflection.ValidatePropertyClass(OnSingleSetLevelsStateFinished_FunctionAddress, "LevelState", Classes.FStrProperty);
		OnSingleSetLevelsStateFinished_OperationID_Offset = NativeReflection.GetPropertyOffset(OnSingleSetLevelsStateFinished_FunctionAddress, "OperationID");
		OnSingleSetLevelsStateFinished_OperationID_IsValid = NativeReflection.ValidatePropertyClass(OnSingleSetLevelsStateFinished_FunctionAddress, "OperationID", Classes.FIntProperty);
		OnSingleSetLevelsStateFinished_IsValid = OnSingleSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && OnSingleSetLevelsStateFinished_LevelKeyword_IsValid && OnSingleSetLevelsStateFinished_LevelState_IsValid && OnSingleSetLevelsStateFinished_OperationID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTortoiseLevelStreamingMgrActor:OnSingleSetLevelsStateFinished", OnSingleSetLevelsStateFinished_IsValid);
	}

	static BGUTortoiseLevelStreamingMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTortoiseLevelStreamingMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTortoiseLevelStreamingMgrActor));
	}
}
