using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("GS EQT Has Projectile In Range")]
[Blueprintable]
[UClass]
[BlueprintType]
[Tooltip("检查是否有抛射物在范围内，有则返回true，没有返回false")]
[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange")]
public class GSEQT_HasProjectileInRange : UGSEQTBase
{
	private static bool ProjectileID_IsValid;

	private static int ProjectileID_Offset;

	private static bool CheckRangeRadius_IsValid;

	private static int CheckRangeRadius_Offset;

	private static bool bOnly2DCheck_IsValid;

	private static int bOnly2DCheck_Offset;

	private static FFieldAddress bOnly2DCheck_PropertyAddress;

	private static bool ProcessItemCS_IsValid;

	private static IntPtr ProcessItemCS_FunctionAddress;

	private static int ProcessItemCS_ParamsSize;

	private static bool ProcessItemCS_World_IsValid;

	private static int ProcessItemCS_World_Offset;

	private static bool ProcessItemCS_ItemLocation_IsValid;

	private static int ProcessItemCS_ItemLocation_Offset;

	private static FFieldAddress ProcessItemCS_ItemLocation_PropertyAddress;

	private static bool ProcessItemCS_ItemActor_IsValid;

	private static int ProcessItemCS_ItemActor_Offset;

	private static bool ProcessItemCS_Querier_IsValid;

	private static int ProcessItemCS_Querier_Offset;

	private static bool ProcessItemCS_ReturnValue_IsValid;

	private static int ProcessItemCS_ReturnValue_Offset;

	private static FFieldAddress ProcessItemCS_ReturnValue_PropertyAddress;

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

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProjectileID")]
	public int ProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileID_Offset), value);
			}
		}
	}

	[DisplayName("检查范围")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:CheckRangeRadius")]
	public float CheckRangeRadius
	{
		get
		{
			CheckDestroyed();
			if (!CheckRangeRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:CheckRangeRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckRangeRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckRangeRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:CheckRangeRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckRangeRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("是否只检查2D范围")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:bOnly2DCheck")]
	public bool bOnly2DCheck
	{
		get
		{
			CheckDestroyed();
			if (!bOnly2DCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:bOnly2DCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOnly2DCheck_Offset), 0, bOnly2DCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOnly2DCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_HasProjectileInRange:bOnly2DCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOnly2DCheck_Offset), 0, bOnly2DCheck_PropertyAddress.Address, value);
			}
		}
	}

	private List<FVector> ProjectileLocations { get; } = new List<FVector>();

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:PreProcessItems")]
	protected override void PreProcessItems_Implementation(List<AActor> ContextActors, List<FVector> ContextLocations)
	{
		ProjectileLocations.Clear();
		foreach (AActor ContextActor in ContextActors)
		{
			IBUC_ProjectileCtrlData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ProjectileCtrlData, b1.BUC_ProjectileCtrData>(ContextActor);
			if (readOnlyData == null || readOnlyData.GetAllCtrableProjectilesByID(ProjectileID, out var OutProjectileList) <= 0)
			{
				continue;
			}
			foreach (BGUProjectileBaseActor item in OutProjectileList)
			{
				ProjectileLocations.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item));
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProcessItemCS")]
	protected override bool ProcessItemCS_Implementation(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		foreach (FVector projectileLocation in ProjectileLocations)
		{
			FVector fVector = projectileLocation - ItemLocation;
			if ((bOnly2DCheck ? fVector.Size2D() : fVector.Size()) < CheckRangeRadius)
			{
				return true;
			}
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:PostProcessItems")]
	protected override void PostProcessItems_Implementation()
	{
		ProjectileLocations.Clear();
	}

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionTitleCS")]
	protected override string GetDescriptionTitleCS_Implementation()
	{
		return "检查范围内是否有指定ID的抛射物";
	}

	[USharpPath("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionDetailsCS")]
	protected override string GetDescriptionDetailsCS_Implementation()
	{
		string arg = (bOnly2DCheck ? "只检查2D范围" : "检查3D范围");
		return $"Projectile ID : {ProjectileID}\n范围 : {CheckRangeRadius}\n检查选项 ：{arg}";
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProcessItemCS")]
	private static void ProcessItemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, ProcessItemCS_World_Offset));
		FVector itemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemLocation_Offset));
		AActor itemActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemActor_Offset));
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_Querier_Offset));
		bool value = gSEQT_HasProjectileInRange.ProcessItemCS_Implementation(world, itemLocation, itemActor, querier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:PreProcessItems")]
	private static void PreProcessItems__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		List<AActor> contextActors = new TArrayCopyMarshaler<AActor>(1, PreProcessItems_ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(buffer, PreProcessItems_ContextActors_Offset));
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, PreProcessItems_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, PreProcessItems_ContextLocations_Offset));
		gSEQT_HasProjectileInRange.PreProcessItems_Implementation(contextActors, contextLocations);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:PostProcessItems")]
	private static void PostProcessItems__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		gSEQT_HasProjectileInRange.PostProcessItems_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		bool value = gSEQT_HasProjectileInRange.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionTitleCS")]
	private static void GetDescriptionTitleCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		string descriptionTitleCS_Implementation = gSEQT_HasProjectileInRange.GetDescriptionTitleCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDescriptionTitleCS_ReturnValue_Offset), descriptionTitleCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionDetailsCS")]
	private static void GetDescriptionDetailsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_HasProjectileInRange gSEQT_HasProjectileInRange = GCHelper.Find<GSEQT_HasProjectileInRange>(obj);
		string descriptionDetailsCS_Implementation = gSEQT_HasProjectileInRange.GetDescriptionDetailsCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDescriptionDetailsCS_ReturnValue_Offset), descriptionDetailsCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_HasProjectileInRange");
		ProjectileID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileID");
		ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileID", Classes.FIntProperty);
		CheckRangeRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckRangeRadius");
		CheckRangeRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckRangeRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bOnly2DCheck_PropertyAddress, intPtr, "bOnly2DCheck");
		bOnly2DCheck_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOnly2DCheck");
		bOnly2DCheck_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOnly2DCheck", Classes.FBoolProperty);
		ProcessItemCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessItemCS");
		ProcessItemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessItemCS_FunctionAddress);
		ProcessItemCS_World_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "World");
		ProcessItemCS_World_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ItemLocation_PropertyAddress, ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemLocation", Classes.FStructProperty);
		ProcessItemCS_ItemActor_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemActor");
		ProcessItemCS_ItemActor_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemActor", Classes.FObjectProperty);
		ProcessItemCS_Querier_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "Querier");
		ProcessItemCS_Querier_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ReturnValue_PropertyAddress, ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessItemCS_IsValid = ProcessItemCS_FunctionAddress != IntPtr.Zero && ProcessItemCS_World_IsValid && ProcessItemCS_ItemLocation_IsValid && ProcessItemCS_ItemActor_IsValid && ProcessItemCS_Querier_IsValid && ProcessItemCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:ProcessItemCS", ProcessItemCS_IsValid);
		PreProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreProcessItems");
		PreProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PreProcessItems_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PreProcessItems_ContextActors_PropertyAddress, PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_Offset = NativeReflection.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_IsValid = NativeReflection.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PreProcessItems_ContextLocations_PropertyAddress, PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_Offset = NativeReflection.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		PreProcessItems_IsValid = PreProcessItems_FunctionAddress != IntPtr.Zero && PreProcessItems_ContextActors_IsValid && PreProcessItems_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:PreProcessItems", PreProcessItems_IsValid);
		PostProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostProcessItems");
		PostProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessItems_FunctionAddress);
		PostProcessItems_IsValid = PostProcessItems_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:PostProcessItems", PostProcessItems_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:ShouldPrepareContext", ShouldPrepareContext_IsValid);
		GetDescriptionTitleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDescriptionTitleCS");
		GetDescriptionTitleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionTitleCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDescriptionTitleCS_ReturnValue_PropertyAddress, GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDescriptionTitleCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionTitleCS_IsValid = GetDescriptionTitleCS_FunctionAddress != IntPtr.Zero && GetDescriptionTitleCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionTitleCS", GetDescriptionTitleCS_IsValid);
		GetDescriptionDetailsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDescriptionDetailsCS");
		GetDescriptionDetailsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionDetailsCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDescriptionDetailsCS_ReturnValue_PropertyAddress, GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionDetailsCS_IsValid = GetDescriptionDetailsCS_FunctionAddress != IntPtr.Zero && GetDescriptionDetailsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_HasProjectileInRange:GetDescriptionDetailsCS", GetDescriptionDetailsCS_IsValid);
	}

	static GSEQT_HasProjectileInRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_HasProjectileInRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_HasProjectileInRange));
	}
}
