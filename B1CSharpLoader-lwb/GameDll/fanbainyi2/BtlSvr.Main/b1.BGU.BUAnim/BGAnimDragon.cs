using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BGAnimDragon")]
internal class BGAnimDragon : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	protected AActor Owner;

	protected USkeletalMeshComponent Mesh;

	protected List<FVector> SplinePoints = new List<FVector>();

	protected List<FVector> BonesLoc = new List<FVector>();

	protected List<float> BonesLength = new List<float>();

	protected List<int> BonesIndex = new List<int>();

	protected int NumBones;

	private static bool ChainRootName_IsValid;

	private static int ChainRootName_Offset;

	private static bool ChainEndName_IsValid;

	private static int ChainEndName_Offset;

	private static bool Spline_IsValid;

	private static int Spline_Offset;

	private static bool BonesRot_IsValid;

	private static int BonesRot_Offset;

	private static FFieldAddress BonesRot_PropertyAddress;

	private TArrayReadWriteMarshaler<FRotator> BonesRot_Marshaler;

	private static bool BonesLocCS_IsValid;

	private static int BonesLocCS_Offset;

	private static FFieldAddress BonesLocCS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> BonesLocCS_Marshaler;

	private static bool EffectiveNumBones_IsValid;

	private static int EffectiveNumBones_Offset;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_IsValid;

	private static IntPtr BlueprintThreadSafeUpdateAnimation_FunctionAddress;

	private static int BlueprintThreadSafeUpdateAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_DeltaSeconds_IsValid;

	private static int BlueprintThreadSafeUpdateAnimation_DeltaSeconds_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Dragon")]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:ChainRootName")]
	public FName ChainRootName
	{
		get
		{
			CheckDestroyed();
			if (!ChainRootName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:ChainRootName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ChainRootName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChainRootName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:ChainRootName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ChainRootName_Offset), value);
			}
		}
	}

	[Category("Dragon")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:ChainEndName")]
	public FName ChainEndName
	{
		get
		{
			CheckDestroyed();
			if (!ChainEndName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:ChainEndName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ChainEndName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChainEndName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:ChainEndName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ChainEndName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Dragon")]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:Spline")]
	public USplineComponent Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:Spline");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:Spline");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Dragon")]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:BonesRot")]
	public TArrayReadWrite<FRotator> BonesRot
	{
		get
		{
			CheckDestroyed();
			if (!BonesRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:BonesRot");
				return null;
			}
			if (BonesRot_Marshaler == null)
			{
				BonesRot_Marshaler = new TArrayReadWriteMarshaler<FRotator>(1, BonesRot_PropertyAddress, CachedMarshalingDelegates<FRotator, BlittableTypeMarshaler<FRotator>>.FromNative, CachedMarshalingDelegates<FRotator, BlittableTypeMarshaler<FRotator>>.ToNative);
			}
			return BonesRot_Marshaler.FromNative(IntPtr.Add(base.Address, BonesRot_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Dragon")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:BonesLocCS")]
	public TArrayReadWrite<FVector> BonesLocCS
	{
		get
		{
			CheckDestroyed();
			if (!BonesLocCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:BonesLocCS");
				return null;
			}
			if (BonesLocCS_Marshaler == null)
			{
				BonesLocCS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, BonesLocCS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return BonesLocCS_Marshaler.FromNative(IntPtr.Add(base.Address, BonesLocCS_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Dragon")]
	[USharpPath("/Script/b1-Managed.BGAnimDragon:EffectiveNumBones")]
	public int EffectiveNumBones
	{
		get
		{
			CheckDestroyed();
			if (!EffectiveNumBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:EffectiveNumBones");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EffectiveNumBones_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectiveNumBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimDragon:EffectiveNumBones");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EffectiveNumBones_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGAnimDragon:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		Owner = GetOwningActor();
		Mesh = GetOwningComponent();
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(Owner))
		{
			InitSplinePoints();
			InitBoneData();
		}
	}

	[USharpPath("/Script/b1-Managed.BGAnimDragon:BlueprintThreadSafeUpdateAnimation")]
	protected override void BlueprintThreadSafeUpdateAnimation_Implementation(float DeltaSeconds)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(Owner))
		{
			if (Spline == null)
			{
				Spline = Owner.GetComponentByClass<USplineComponent>();
			}
			CalcBonesRotation();
			CalcBoneTranslation();
		}
	}

	[USharpPath("/Script/b1-Managed.BGAnimDragon:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		base.BlueprintUpdateAnimation_Implementation(DeltaTimeX);
		FVector InLoc = Mesh.GetWorldLocation();
		UpdateSpline(ref InLoc);
	}

	private void CalcBoneTranslation()
	{
		for (int i = 0; i < NumBones; i++)
		{
			BonesLocCS[i] = UMathLibrary.InverseTransformLocation(Mesh.GetWorldTransform(), BonesLoc[i]);
		}
	}

	private void CalcBonesRotation()
	{
		float num = 0f;
		for (int i = 0; i < NumBones; i++)
		{
			BonesLoc[i] = Spline.GetLocationAtDistanceAlongSpline(num, ESplineCoordinateSpace.World);
			if (Spline.GetSplineLength() > num)
			{
				EffectiveNumBones = i + 1;
			}
			if (i < NumBones - 1)
			{
				num += BonesLength[i + 1];
			}
		}
		for (int j = 0; j < NumBones - 1; j++)
		{
			Mesh.GetWorldRotation();
			BonesRot[j] = UMathLibrary.InverseTransformRotation(Mesh.GetWorldTransform(), (BonesLoc[j + 1] - BonesLoc[j]).Rotation());
			BonesRot[j] = BonesRot[j].Add(0.0, 0.0, -90.0);
		}
	}

	private void InitSplinePoints()
	{
		FVector worldLocation = Mesh.GetWorldLocation();
		SplinePoints.Add(worldLocation);
		SplinePoints.Add(worldLocation);
	}

	private void InitBoneData()
	{
		FName boneName = ChainEndName;
		int boneIndex = Mesh.GetBoneIndex(boneName);
		int boneIndex2 = Mesh.GetBoneIndex(ChainRootName);
		while (boneIndex != boneIndex2 && boneIndex != -1)
		{
			BonesIndex.Add(boneIndex);
			boneName = Mesh.GetParentBone(boneName);
			boneIndex = Mesh.GetBoneIndex(boneName);
		}
		BonesIndex.Add(boneIndex2);
		BonesIndex.Reverse();
		NumBones = BonesIndex.Count;
		foreach (int item in BonesIndex)
		{
			BonesLength.Add(Mesh.GetRefPosePosition(item).Size());
			BonesLoc.Add(default(FVector));
			BonesLocCS.Add(default(FVector));
			BonesRot.Add(default(FRotator));
		}
	}

	private void UpdateSpline(ref FVector InLoc)
	{
		SplinePoints[0] = InLoc;
		if (FVector.Dist(InLoc, SplinePoints[1]) > BonesLength[1])
		{
			SplinePoints.Insert(1, InLoc);
		}
		if (SplinePoints.Count > NumBones + 1)
		{
			SplinePoints.RemoveAt(SplinePoints.Count - 1);
		}
		if (Spline != null)
		{
			Spline.SetSplinePoints(SplinePoints, ESplineCoordinateSpace.World);
		}
	}

	private void AttachEvent()
	{
		BUC_ABPEventCollection.Get(this);
	}

	private void UnAttachEvent()
	{
		BUC_ABPEventCollection.Get(this);
	}

	private void InitData()
	{
	}

	public void OnEntityInitFinish()
	{
		AttachEvent();
		InitData();
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
		UnAttachEvent();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGAnimDragon:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BGAnimDragon bGAnimDragon = GCHelper.Find<b1.BGU.BUAnim.BGAnimDragon>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bGAnimDragon.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGAnimDragon:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BGAnimDragon bGAnimDragon = GCHelper.Find<b1.BGU.BUAnim.BGAnimDragon>(obj);
		bGAnimDragon.BlueprintInitializeAnimation_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGAnimDragon:BlueprintThreadSafeUpdateAnimation")]
	private static void BlueprintThreadSafeUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BGAnimDragon bGAnimDragon = GCHelper.Find<b1.BGU.BUAnim.BGAnimDragon>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintThreadSafeUpdateAnimation_DeltaSeconds_Offset));
		bGAnimDragon.BlueprintThreadSafeUpdateAnimation_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGAnimDragon");
		ChainRootName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChainRootName");
		ChainRootName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChainRootName", Classes.FNameProperty);
		ChainEndName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChainEndName");
		ChainEndName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChainEndName", Classes.FNameProperty);
		Spline_Offset = NativeReflection.GetPropertyOffset(intPtr, "Spline");
		Spline_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Spline", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BonesRot_PropertyAddress, intPtr, "BonesRot");
		BonesRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "BonesRot");
		BonesRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BonesRot", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BonesLocCS_PropertyAddress, intPtr, "BonesLocCS");
		BonesLocCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "BonesLocCS");
		BonesLocCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BonesLocCS", Classes.FArrayProperty);
		EffectiveNumBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectiveNumBones");
		EffectiveNumBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectiveNumBones", Classes.FIntProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGAnimDragon:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGAnimDragon:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
		BlueprintThreadSafeUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintThreadSafeUpdateAnimation");
		BlueprintThreadSafeUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintThreadSafeUpdateAnimation_FunctionAddress);
		BlueprintThreadSafeUpdateAnimation_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaSeconds");
		BlueprintThreadSafeUpdateAnimation_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_IsValid = BlueprintThreadSafeUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintThreadSafeUpdateAnimation_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGAnimDragon:BlueprintThreadSafeUpdateAnimation", BlueprintThreadSafeUpdateAnimation_IsValid);
	}

	static BGAnimDragon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BGAnimDragon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BGAnimDragon));
	}
}
