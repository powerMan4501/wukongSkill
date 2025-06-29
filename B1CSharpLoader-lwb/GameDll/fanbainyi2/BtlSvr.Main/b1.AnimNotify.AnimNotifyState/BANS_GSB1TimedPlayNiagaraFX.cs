using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1.AnimNotify.AnimNotifyState;

[DisplayName("BANS GSB1 Timed Play Niagara FX")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX")]
internal class BANS_GSB1TimedPlayNiagaraFX : BANS_GSBase
{
	protected FQuat rotationOffsetQuat;

	private bool hasAttachedSocket;

	private static bool template_IsValid;

	private static int template_Offset;

	private static bool socketName_IsValid;

	private static int socketName_Offset;

	private static bool locationOffset_IsValid;

	private static int locationOffset_Offset;

	private static bool rotationOffset_IsValid;

	private static int rotationOffset_Offset;

	private static bool scale_IsValid;

	private static int scale_Offset;

	private static bool ignoreRootBoneScale_IsValid;

	private static int ignoreRootBoneScale_Offset;

	private static FFieldAddress ignoreRootBoneScale_PropertyAddress;

	private static bool destroyAtEnd_IsValid;

	private static int destroyAtEnd_Offset;

	private static FFieldAddress destroyAtEnd_PropertyAddress;

	private static bool customParams_IsValid;

	private static int customParams_Offset;

	private static FFieldAddress customParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSNiagaraSysParam> customParams_Marshaler;

	private static bool translucentSortPriority_IsValid;

	private static int translucentSortPriority_Offset;

	private static bool AddTagForSearch_IsValid;

	private static int AddTagForSearch_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:template")]
	public TSoftObject<UNiagaraSystem> template
	{
		get
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:template");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:template");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, template_Offset), value);
			}
		}
	}

	[UMeta("AnimNotifyBoneName", "true")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:socketName")]
	public FName socketName
	{
		get
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:socketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, socketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:socketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, socketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:locationOffset")]
	public FVector locationOffset
	{
		get
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:locationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, locationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:locationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, locationOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:rotationOffset")]
	public FRotator rotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:rotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, rotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:rotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, rotationOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:scale")]
	public FVector scale
	{
		get
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:scale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, scale_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "Ignore Root Bone Scale")]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:ignoreRootBoneScale")]
	public bool ignoreRootBoneScale
	{
		get
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:ignoreRootBoneScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:ignoreRootBoneScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Destroy Immediately")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:destroyAtEnd")]
	public bool destroyAtEnd
	{
		get
		{
			CheckDestroyed();
			if (!destroyAtEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:destroyAtEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, destroyAtEnd_Offset), 0, destroyAtEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!destroyAtEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:destroyAtEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, destroyAtEnd_Offset), 0, destroyAtEnd_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.DisplayName, "Set Custom Params ")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:customParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> customParams
	{
		get
		{
			CheckDestroyed();
			if (!customParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:customParams");
				return null;
			}
			if (customParams_Marshaler == null)
			{
				customParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, customParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return customParams_Marshaler.FromNative(IntPtr.Add(base.Address, customParams_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:translucentSortPriority")]
	public int translucentSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:translucentSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, translucentSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:translucentSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, translucentSortPriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:AddTagForSearch")]
	public FName AddTagForSearch
	{
		get
		{
			CheckDestroyed();
			if (!AddTagForSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:AddTagForSearch");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AddTagForSearch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddTagForSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:AddTagForSearch");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AddTagForSearch_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
		scale = FVector.OneVector;
		ignoreRootBoneScale = true;
		socketName = FName.None;
		hasAttachedSocket = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		if (!template.IsNull)
		{
			return new List<FSoftObjectPath> { template.ObjectPath };
		}
		return new List<FSoftObjectPath>();
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!template.IsNull)
		{
			SoftPathSet.Add(template.ObjectPath);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UNiagaraSystem validResource = GetValidResource(template);
		if (validResource == null)
		{
			return;
		}
		UNiagaraComponent uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(validResource, meshComp, socketName, locationOffset, rotationOffset, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true);
		if (!(uNiagaraComponent != null))
		{
			return;
		}
		if (AddTagForSearch != FName.None)
		{
			uNiagaraComponent.ComponentTags.Add(AddTagForSearch);
		}
		if (hasAttachedSocket && ignoreRootBoneScale)
		{
			FVector scale3D = UGSE_CharacterFuncLib.GetBoneTransformByMesh(meshComp, 0).GetScale3D();
			uNiagaraComponent.SetRelativeScale3D(scale * new FVector(1f / scale3D.X, 1f / scale3D.Y, 1f / scale3D.Z));
		}
		else
		{
			uNiagaraComponent.SetRelativeScale3D(scale);
		}
		uNiagaraComponent.SetTranslucentSortPriority(translucentSortPriority);
		for (int i = 0; i < customParams.Count; i++)
		{
			FName name = customParams[i].Name;
			switch (customParams[i].ParamType)
			{
			case EGSNiagaraSysParamType.GSNPT_Float:
				uNiagaraComponent.SetVariableFloat(name, customParams[i].FloatValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Int:
				uNiagaraComponent.SetVariableInt(name, customParams[i].IntValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Vector:
				uNiagaraComponent.SetVariableVec3(name, customParams[i].VectorValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Bool:
				uNiagaraComponent.SetVariableBool(name, customParams[i].BoolValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_LinearColor:
				uNiagaraComponent.SetVariableLinearColor(name, customParams[i].LinearColorValue);
				break;
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (meshComp == null)
		{
			return;
		}
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return;
		}
		UNiagaraSystem validResource = GetValidResource(template);
		if (validResource == null)
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>()))
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (uNiagaraComponent.GetFXSystemAsset() == validResource && uNiagaraComponent.GetAttachSocketName() == socketName)
			{
				if (destroyAtEnd)
				{
					item.DestroyComponent(owner);
				}
				else
				{
					item.Deactivate();
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX bANS_GSB1TimedPlayNiagaraFX = GCHelper.Find<b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSB1TimedPlayNiagaraFX.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX bANS_GSB1TimedPlayNiagaraFX = GCHelper.Find<b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSB1TimedPlayNiagaraFX.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX bANS_GSB1TimedPlayNiagaraFX = GCHelper.Find<b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bANS_GSB1TimedPlayNiagaraFX.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX");
		template_Offset = NativeReflection.GetPropertyOffset(intPtr, "template");
		template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "template", Classes.FSoftObjectProperty);
		socketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "socketName");
		socketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "socketName", Classes.FNameProperty);
		locationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "locationOffset");
		locationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "locationOffset", Classes.FStructProperty);
		rotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "rotationOffset");
		rotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "rotationOffset", Classes.FStructProperty);
		scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "scale");
		scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ignoreRootBoneScale_PropertyAddress, intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ignoreRootBoneScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref destroyAtEnd_PropertyAddress, intPtr, "destroyAtEnd");
		destroyAtEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "destroyAtEnd");
		destroyAtEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "destroyAtEnd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref customParams_PropertyAddress, intPtr, "customParams");
		customParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "customParams");
		customParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "customParams", Classes.FArrayProperty);
		translucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "translucentSortPriority");
		translucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "translucentSortPriority", Classes.FIntProperty);
		AddTagForSearch_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddTagForSearch");
		AddTagForSearch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddTagForSearch", Classes.FNameProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSB1TimedPlayNiagaraFX:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BANS_GSB1TimedPlayNiagaraFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AnimNotify.AnimNotifyState.BANS_GSB1TimedPlayNiagaraFX));
	}
}
