using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Slice Runtime Mesh")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh")]
internal class BANS_GSSliceRuntimeMesh : BANS_GSBase
{
	private FVector PreEdge;

	private FVector PostEdge;

	private FVector PivotLocation;

	private static bool OutwardSocketName_IsValid;

	private static int OutwardSocketName_Offset;

	private static bool PivotSocketName_IsValid;

	private static int PivotSocketName_Offset;

	private static bool SliceLength_IsValid;

	private static int SliceLength_Offset;

	private static bool ApplyForce_IsValid;

	private static int ApplyForce_Offset;

	private static bool bIsReflexAngle_IsValid;

	private static int bIsReflexAngle_Offset;

	private static FFieldAddress bIsReflexAngle_PropertyAddress;

	private static bool bShowDebug_IsValid;

	private static int bShowDebug_Offset;

	private static FFieldAddress bShowDebug_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:OutwardSocketName")]
	public FName OutwardSocketName
	{
		get
		{
			CheckDestroyed();
			if (!OutwardSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:OutwardSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutwardSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutwardSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:OutwardSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutwardSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:PivotSocketName")]
	public FName PivotSocketName
	{
		get
		{
			CheckDestroyed();
			if (!PivotSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:PivotSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PivotSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PivotSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:PivotSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PivotSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:SliceLength")]
	public float SliceLength
	{
		get
		{
			CheckDestroyed();
			if (!SliceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:SliceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SliceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:SliceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SliceLength_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:ApplyForce")]
	public float ApplyForce
	{
		get
		{
			CheckDestroyed();
			if (!ApplyForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:ApplyForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ApplyForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ApplyForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:ApplyForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ApplyForce_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bIsReflexAngle")]
	public bool bIsReflexAngle
	{
		get
		{
			CheckDestroyed();
			if (!bIsReflexAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bIsReflexAngle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsReflexAngle_Offset), 0, bIsReflexAngle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsReflexAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bIsReflexAngle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsReflexAngle_Offset), 0, bIsReflexAngle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bShowDebug")]
	public bool bShowDebug
	{
		get
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bShowDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:bShowDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (NotifyParam.owner as BGUCharacterCS != null)
		{
			PreEdge = ((GetSocketCompTransformByTime(NotifyParam.Animation, OutwardSocketName, NotifyParam.NotifyBeginTime) * NotifyParam.MeshComp.GetWorldTransform()).GetLocation() - (GetSocketCompTransformByTime(NotifyParam.Animation, PivotSocketName, NotifyParam.NotifyBeginTime) * NotifyParam.MeshComp.GetWorldTransform()).GetLocation()).GetSafeNormal();
			PivotLocation = NotifyParam.MeshComp.GetSocketLocation(PivotSocketName);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			PostEdge = ((GetSocketCompTransformByTime(NotifyParam.Animation, OutwardSocketName, NotifyParam.NotifyEndTime) * NotifyParam.MeshComp.GetWorldTransform()).GetLocation() - (GetSocketCompTransformByTime(NotifyParam.Animation, PivotSocketName, NotifyParam.NotifyEndTime) * NotifyParam.MeshComp.GetWorldTransform()).GetLocation()).GetSafeNormal();
			PivotLocation = (PivotLocation + NotifyParam.MeshComp.GetSocketLocation(PivotSocketName)) / 2.0;
			BGS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_BGS_TrySliceRuntimeActors.Invoke(PivotLocation, PreEdge, PostEdge, SliceLength, ApplyForce, bIsReflexAngle, bShowDebug);
		}
	}

	private FTransform GetSocketCompTransformByTime(UAnimSequenceBase AnimSeq, FName SocketName, float Time)
	{
		if (AnimSeq.IsA<UAnimSequence>())
		{
			return UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq as UAnimSequence, Time, SocketName);
		}
		return UGSE_AnimFuncLib.Montage_GetBoneTransformCS(AnimSeq as UAnimMontage, Time, SocketName, FName.None, bExtractRootMotion: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSliceRuntimeMesh bANS_GSSliceRuntimeMesh = GCHelper.Find<b1.BANS_GSSliceRuntimeMesh>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSliceRuntimeMesh.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSliceRuntimeMesh bANS_GSSliceRuntimeMesh = GCHelper.Find<b1.BANS_GSSliceRuntimeMesh>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSliceRuntimeMesh.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSliceRuntimeMesh bANS_GSSliceRuntimeMesh = GCHelper.Find<b1.BANS_GSSliceRuntimeMesh>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSliceRuntimeMesh.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSliceRuntimeMesh");
		OutwardSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutwardSocketName");
		OutwardSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutwardSocketName", Classes.FNameProperty);
		PivotSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "PivotSocketName");
		PivotSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PivotSocketName", Classes.FNameProperty);
		SliceLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "SliceLength");
		SliceLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SliceLength", Classes.FFloatProperty);
		ApplyForce_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApplyForce");
		ApplyForce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApplyForce", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bIsReflexAngle_PropertyAddress, intPtr, "bIsReflexAngle");
		bIsReflexAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsReflexAngle");
		bIsReflexAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsReflexAngle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowDebug_PropertyAddress, intPtr, "bShowDebug");
		bShowDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowDebug");
		bShowDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSliceRuntimeMesh:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSliceRuntimeMesh()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSliceRuntimeMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSliceRuntimeMesh));
	}
}
