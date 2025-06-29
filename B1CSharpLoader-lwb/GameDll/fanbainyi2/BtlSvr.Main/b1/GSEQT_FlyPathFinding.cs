using System;
using System.Collections.Generic;
using b1.Plugins.DonAINavigation;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Fly Pathfinding")]
[UClass]
[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding")]
public class GSEQT_FlyPathFinding : UGSEQTBase
{
	private static bool TestMode_IsValid;

	private static int TestMode_Offset;

	private static FFieldAddress TestMode_PropertyAddress;

	private static bool MaxIterationCount_IsValid;

	private static int MaxIterationCount_Offset;

	private static bool PreProcessItems_IsValid;

	private static IntPtr PreProcessItems_FunctionAddress;

	private static int PreProcessItems_ParamsSize;

	private static bool PreProcessItems_ContextActors_IsValid;

	private static int PreProcessItems_ContextActors_Offset;

	private static FFieldAddress PreProcessItems_ContextActors_PropertyAddress;

	private static bool PreProcessItems_ContextLocations_IsValid;

	private static int PreProcessItems_ContextLocations_Offset;

	private static FFieldAddress PreProcessItems_ContextLocations_PropertyAddress;

	private static bool PostProcessItems_IsValid;

	private static IntPtr PostProcessItems_FunctionAddress;

	private static int PostProcessItems_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static bool ShouldPrepareContext_IsValid;

	private static IntPtr ShouldPrepareContext_FunctionAddress;

	private static int ShouldPrepareContext_ParamsSize;

	private static bool ShouldPrepareContext_ReturnValue_IsValid;

	private static int ShouldPrepareContext_ReturnValue_Offset;

	private static FFieldAddress ShouldPrepareContext_ReturnValue_PropertyAddress;

	private static bool GetDescriptionTitleCS_IsValid;

	private static IntPtr GetDescriptionTitleCS_FunctionAddress;

	private static int GetDescriptionTitleCS_ParamsSize;

	private static bool GetDescriptionTitleCS_ReturnValue_IsValid;

	private static int GetDescriptionTitleCS_ReturnValue_Offset;

	private static FFieldAddress GetDescriptionTitleCS_ReturnValue_PropertyAddress;

	private static bool GetDescriptionDetailsCS_IsValid;

	private static IntPtr GetDescriptionDetailsCS_FunctionAddress;

	private static int GetDescriptionDetailsCS_ParamsSize;

	private static bool GetDescriptionDetailsCS_ReturnValue_IsValid;

	private static int GetDescriptionDetailsCS_ReturnValue_Offset;

	private static FFieldAddress GetDescriptionDetailsCS_ReturnValue_PropertyAddress;

	private static bool ProcessCustomItemScoreCS_IsValid;

	private static IntPtr ProcessCustomItemScoreCS_FunctionAddress;

	private static int ProcessCustomItemScoreCS_ParamsSize;

	private static bool ProcessCustomItemScoreCS_Item_IsValid;

	private static int ProcessCustomItemScoreCS_Item_Offset;

	private static FFieldAddress ProcessCustomItemScoreCS_Item_PropertyAddress;

	private static bool ShouldUseCustomItemScore_IsValid;

	private static IntPtr ShouldUseCustomItemScore_FunctionAddress;

	private static int ShouldUseCustomItemScore_ParamsSize;

	private static bool ShouldUseCustomItemScore_ReturnValue_IsValid;

	private static int ShouldUseCustomItemScore_ReturnValue_Offset;

	private static FFieldAddress ShouldUseCustomItemScore_ReturnValue_PropertyAddress;

	private List<ADonNavigationManager> DonNavManagerForContexts { get; } = new List<ADonNavigationManager>();

	[Category("DonNavigation")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:TestMode")]
	private EEnvTestPathfinding TestMode
	{
		get
		{
			CheckDestroyed();
			if (!TestMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_FlyPathFinding:TestMode");
				return EEnvTestPathfinding.PathExist;
			}
			return EnumMarshaler<EEnvTestPathfinding>.FromNative(IntPtr.Add(base.Address, TestMode_Offset), 0, TestMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TestMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_FlyPathFinding:TestMode");
			}
			else
			{
				EnumMarshaler<EEnvTestPathfinding>.ToNative(IntPtr.Add(base.Address, TestMode_Offset), 0, TestMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DonNavigation")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:MaxIterationCount")]
	public int MaxIterationCount
	{
		get
		{
			CheckDestroyed();
			if (!MaxIterationCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_FlyPathFinding:MaxIterationCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxIterationCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIterationCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_FlyPathFinding:MaxIterationCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxIterationCount_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		TestMode = EEnvTestPathfinding.PathExist;
		MaxIterationCount = 5000;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldUseCustomItemScore")]
	protected override bool ShouldUseCustomItemScore_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:PreProcessItems")]
	protected override void PreProcessItems_Implementation(List<AActor> ContextActors, List<FVector> ContextLocations)
	{
		bool flag = TestMode != EEnvTestPathfinding.PathExist;
		if (GetWorkOnFloatValuesCS() != flag)
		{
			SetWorkOnFloatValuesCS(flag);
		}
		UpdateDonNavManagers(ContextActors);
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:PostProcessItems")]
	protected override void PostProcessItems_Implementation()
	{
		DonNavManagerForContexts.Clear();
	}

	private void UpdateDonNavManagers(List<AActor> ContextActors)
	{
		DonNavManagerForContexts.Clear();
		foreach (AActor ContextActor in ContextActors)
		{
			if (ContextActor == null)
			{
				DonNavManagerForContexts.Add(null);
			}
			else
			{
				DonNavManagerForContexts.Add(UDonNavigationHelper.DonNavigationManagerForActor(ContextActor));
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:ProcessCustomItemScoreCS")]
	protected override void ProcessCustomItemScoreCS_Implementation(FGSEnvQueryTestItem Item)
	{
		if (Item.ContextActors.Count == 0)
		{
			ForceItemStateFailed();
			return;
		}
		if (Item.ContextActors[0] == null)
		{
			ForceItemStateFailed();
			return;
		}
		if (Item.ContextPerItem)
		{
			UpdateDonNavManagers(Item.ContextActors);
			return;
		}
		AActor querier = Item.ContextActors[0];
		ADonNavigationManager donNavManager = DonNavManagerForContexts[0];
		if (GetWorkOnFloatValuesCS())
		{
			float num = ((TestMode == EEnvTestPathfinding.PathLength) ? FindPathLengthTo(donNavManager, querier, Item.ItemLocation) : FindPathCostTo(donNavManager, querier, Item.ItemLocation));
			SetItemScoreFloat(num);
			if (num >= float.MaxValue)
			{
				ForceItemStateFailed();
			}
		}
		else
		{
			bool itemScoreBool = TestPathTo(donNavManager, querier, Item.ItemLocation);
			SetItemScoreBool(itemScoreBool);
		}
	}

	private bool TestPathTo(ADonNavigationManager DonNavManager, AActor Querier, FVector ItemPos)
	{
		if (DonNavManager == null || !DonNavManager.IsLocationWithinNavigableWorld(ItemPos))
		{
			return false;
		}
		FDonNavigationPathFindingResult OutResult;
		return DonNavManager.NavPathQuery(Querier, ItemPos, MaxIterationCount, out OutResult);
	}

	private float FindPathCostTo(ADonNavigationManager DonNavManager, AActor Querier, FVector ItemPos)
	{
		if (!DonNavManager.IsLocationWithinNavigableWorld(ItemPos))
		{
			return float.MaxValue;
		}
		if (!DonNavManager.NavPathQuery(Querier, ItemPos, MaxIterationCount, out var OutResult))
		{
			return float.MaxValue;
		}
		return OutResult.PathCost;
	}

	private float FindPathLengthTo(ADonNavigationManager DonNavManager, AActor Querier, FVector ItemPos)
	{
		if (!DonNavManager.IsLocationWithinNavigableWorld(ItemPos))
		{
			return float.MaxValue;
		}
		if (!DonNavManager.NavPathQuery(Querier, ItemPos, MaxIterationCount, out var OutResult))
		{
			return float.MaxValue;
		}
		return OutResult.PathLength;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("TestMode"))
		{
			SetWorkOnFloatValuesCS(TestMode != EEnvTestPathfinding.PathExist);
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionTitleCS")]
	protected override string GetDescriptionTitleCS_Implementation()
	{
		return $"{TestMode}:  Direction: Path From Context";
	}

	[USharpPath("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionDetailsCS")]
	protected override string GetDescriptionDetailsCS_Implementation()
	{
		return $"TestMode = {TestMode}\n  Direction: Path From Context\n MaxIterationCount = {MaxIterationCount}";
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:PreProcessItems")]
	private static void PreProcessItems__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		List<AActor> contextActors = new TArrayCopyMarshaler<AActor>(1, PreProcessItems_ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(buffer, PreProcessItems_ContextActors_Offset));
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, PreProcessItems_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, PreProcessItems_ContextLocations_Offset));
		gSEQT_FlyPathFinding.PreProcessItems_Implementation(contextActors, contextLocations);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:PostProcessItems")]
	private static void PostProcessItems__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		gSEQT_FlyPathFinding.PostProcessItems_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		gSEQT_FlyPathFinding.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		bool value = gSEQT_FlyPathFinding.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionTitleCS")]
	private static void GetDescriptionTitleCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		string descriptionTitleCS_Implementation = gSEQT_FlyPathFinding.GetDescriptionTitleCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDescriptionTitleCS_ReturnValue_Offset), descriptionTitleCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionDetailsCS")]
	private static void GetDescriptionDetailsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		string descriptionDetailsCS_Implementation = gSEQT_FlyPathFinding.GetDescriptionDetailsCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDescriptionDetailsCS_ReturnValue_Offset), descriptionDetailsCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:ProcessCustomItemScoreCS")]
	private static void ProcessCustomItemScoreCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		FGSEnvQueryTestItem item = FGSEnvQueryTestItem.FromNative(IntPtr.Add(buffer, ProcessCustomItemScoreCS_Item_Offset));
		gSEQT_FlyPathFinding.ProcessCustomItemScoreCS_Implementation(item);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldUseCustomItemScore")]
	private static void ShouldUseCustomItemScore__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_FlyPathFinding gSEQT_FlyPathFinding = GCHelper.Find<GSEQT_FlyPathFinding>(obj);
		bool value = gSEQT_FlyPathFinding.ShouldUseCustomItemScore_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldUseCustomItemScore_ReturnValue_Offset), 0, ShouldUseCustomItemScore_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_FlyPathFinding");
		NativeReflection.GetPropertyRef(ref TestMode_PropertyAddress, intPtr, "TestMode");
		TestMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestMode");
		TestMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestMode", Classes.FEnumProperty);
		MaxIterationCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxIterationCount");
		MaxIterationCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxIterationCount", Classes.FIntProperty);
		PreProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreProcessItems");
		PreProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PreProcessItems_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PreProcessItems_ContextActors_PropertyAddress, PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_Offset = NativeReflection.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_IsValid = NativeReflection.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PreProcessItems_ContextLocations_PropertyAddress, PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_Offset = NativeReflection.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		PreProcessItems_IsValid = PreProcessItems_FunctionAddress != IntPtr.Zero && PreProcessItems_ContextActors_IsValid && PreProcessItems_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:PreProcessItems", PreProcessItems_IsValid);
		PostProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostProcessItems");
		PostProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessItems_FunctionAddress);
		PostProcessItems_IsValid = PostProcessItems_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:PostProcessItems", PostProcessItems_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:OnPropertyChanged", OnPropertyChanged_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldPrepareContext", ShouldPrepareContext_IsValid);
		GetDescriptionTitleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDescriptionTitleCS");
		GetDescriptionTitleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionTitleCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDescriptionTitleCS_ReturnValue_PropertyAddress, GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDescriptionTitleCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionTitleCS_IsValid = GetDescriptionTitleCS_FunctionAddress != IntPtr.Zero && GetDescriptionTitleCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionTitleCS", GetDescriptionTitleCS_IsValid);
		GetDescriptionDetailsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDescriptionDetailsCS");
		GetDescriptionDetailsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionDetailsCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDescriptionDetailsCS_ReturnValue_PropertyAddress, GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionDetailsCS_IsValid = GetDescriptionDetailsCS_FunctionAddress != IntPtr.Zero && GetDescriptionDetailsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:GetDescriptionDetailsCS", GetDescriptionDetailsCS_IsValid);
		ProcessCustomItemScoreCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessCustomItemScoreCS");
		ProcessCustomItemScoreCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessCustomItemScoreCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ProcessCustomItemScoreCS_Item_PropertyAddress, ProcessCustomItemScoreCS_FunctionAddress, "Item");
		ProcessCustomItemScoreCS_Item_Offset = NativeReflection.GetPropertyOffset(ProcessCustomItemScoreCS_FunctionAddress, "Item");
		ProcessCustomItemScoreCS_Item_IsValid = NativeReflection.ValidatePropertyClass(ProcessCustomItemScoreCS_FunctionAddress, "Item", Classes.FStructProperty);
		ProcessCustomItemScoreCS_IsValid = ProcessCustomItemScoreCS_FunctionAddress != IntPtr.Zero && ProcessCustomItemScoreCS_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:ProcessCustomItemScoreCS", ProcessCustomItemScoreCS_IsValid);
		ShouldUseCustomItemScore_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldUseCustomItemScore");
		ShouldUseCustomItemScore_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldUseCustomItemScore_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldUseCustomItemScore_ReturnValue_PropertyAddress, ShouldUseCustomItemScore_FunctionAddress, "ReturnValue");
		ShouldUseCustomItemScore_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldUseCustomItemScore_FunctionAddress, "ReturnValue");
		ShouldUseCustomItemScore_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldUseCustomItemScore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldUseCustomItemScore_IsValid = ShouldUseCustomItemScore_FunctionAddress != IntPtr.Zero && ShouldUseCustomItemScore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_FlyPathFinding:ShouldUseCustomItemScore", ShouldUseCustomItemScore_IsValid);
	}

	static GSEQT_FlyPathFinding()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_FlyPathFinding)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_FlyPathFinding));
	}
}
