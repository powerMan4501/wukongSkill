using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped")]
internal class BUAnim_PostProcess_Quadruped : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool IKSpinePitch_IsValid;

	private static int IKSpinePitch_Offset;

	private static bool IKSpineRoll_IsValid;

	private static int IKSpineRoll_Offset;

	private static bool IKSpineAlpha_IsValid;

	private static int IKSpineAlpha_Offset;

	private static bool LimbIKAlpha_IsValid;

	private static int LimbIKAlpha_Offset;

	private static bool LimbIKEffectorList_IsValid;

	private static int LimbIKEffectorList_Offset;

	private static FFieldAddress LimbIKEffectorList_PropertyAddress;

	private TArrayReadWriteMarshaler<FEffectorData> LimbIKEffectorList_Marshaler;

	private static bool EnableAttackIK_IsValid;

	private static int EnableAttackIK_Offset;

	private static FFieldAddress EnableAttackIK_PropertyAddress;

	private static bool AttackIKRollList_IsValid;

	private static int AttackIKRollList_Offset;

	private static FFieldAddress AttackIKRollList_PropertyAddress;

	private TArrayReadWriteMarshaler<float> AttackIKRollList_Marshaler;

	private static bool AttackIKPitchList_IsValid;

	private static int AttackIKPitchList_Offset;

	private static FFieldAddress AttackIKPitchList_PropertyAddress;

	private TArrayReadWriteMarshaler<float> AttackIKPitchList_Marshaler;

	private static bool RootName_IsValid;

	private static int RootName_Offset;

	private static bool SolverRootBoneNameList_IsValid;

	private static int SolverRootBoneNameList_Offset;

	private static FFieldAddress SolverRootBoneNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SolverRootBoneNameList_Marshaler;

	private static bool SolverEffectorBoneNameList_IsValid;

	private static int SolverEffectorBoneNameList_Offset;

	private static FFieldAddress SolverEffectorBoneNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SolverEffectorBoneNameList_Marshaler;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpinePitch")]
	public float IKSpinePitch
	{
		get
		{
			CheckDestroyed();
			if (!IKSpinePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpinePitch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKSpinePitch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKSpinePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpinePitch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKSpinePitch_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineRoll")]
	public float IKSpineRoll
	{
		get
		{
			CheckDestroyed();
			if (!IKSpineRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineRoll");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKSpineRoll_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKSpineRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineRoll");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKSpineRoll_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineAlpha")]
	public float IKSpineAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKSpineAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKSpineAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKSpineAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:IKSpineAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKSpineAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:LimbIKAlpha")]
	public float LimbIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!LimbIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:LimbIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LimbIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LimbIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:LimbIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LimbIKAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:LimbIKEffectorList")]
	public TArrayReadWrite<FEffectorData> LimbIKEffectorList
	{
		get
		{
			CheckDestroyed();
			if (!LimbIKEffectorList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:LimbIKEffectorList");
				return null;
			}
			if (LimbIKEffectorList_Marshaler == null)
			{
				LimbIKEffectorList_Marshaler = new TArrayReadWriteMarshaler<FEffectorData>(1, LimbIKEffectorList_PropertyAddress, CachedMarshalingDelegates<FEffectorData, BlittableTypeMarshaler<FEffectorData>>.FromNative, CachedMarshalingDelegates<FEffectorData, BlittableTypeMarshaler<FEffectorData>>.ToNative);
			}
			return LimbIKEffectorList_Marshaler.FromNative(IntPtr.Add(base.Address, LimbIKEffectorList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:EnableAttackIK")]
	public bool EnableAttackIK
	{
		get
		{
			CheckDestroyed();
			if (!EnableAttackIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:EnableAttackIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAttackIK_Offset), 0, EnableAttackIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAttackIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:EnableAttackIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAttackIK_Offset), 0, EnableAttackIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:AttackIKRollList")]
	public TArrayReadWrite<float> AttackIKRollList
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKRollList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:AttackIKRollList");
				return null;
			}
			if (AttackIKRollList_Marshaler == null)
			{
				AttackIKRollList_Marshaler = new TArrayReadWriteMarshaler<float>(1, AttackIKRollList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AttackIKRollList_Marshaler.FromNative(IntPtr.Add(base.Address, AttackIKRollList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:AttackIKPitchList")]
	public TArrayReadWrite<float> AttackIKPitchList
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKPitchList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:AttackIKPitchList");
				return null;
			}
			if (AttackIKPitchList_Marshaler == null)
			{
				AttackIKPitchList_Marshaler = new TArrayReadWriteMarshaler<float>(1, AttackIKPitchList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AttackIKPitchList_Marshaler.FromNative(IntPtr.Add(base.Address, AttackIKPitchList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:RootName")]
	public FName RootName
	{
		get
		{
			CheckDestroyed();
			if (!RootName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:RootName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RootName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:RootName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RootName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:SolverRootBoneNameList")]
	public TArrayReadWrite<FName> SolverRootBoneNameList
	{
		get
		{
			CheckDestroyed();
			if (!SolverRootBoneNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:SolverRootBoneNameList");
				return null;
			}
			if (SolverRootBoneNameList_Marshaler == null)
			{
				SolverRootBoneNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SolverRootBoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SolverRootBoneNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SolverRootBoneNameList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:SolverEffectorBoneNameList")]
	public TArrayReadWrite<FName> SolverEffectorBoneNameList
	{
		get
		{
			CheckDestroyed();
			if (!SolverEffectorBoneNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:SolverEffectorBoneNameList");
				return null;
			}
			if (SolverEffectorBoneNameList_Marshaler == null)
			{
				SolverEffectorBoneNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SolverEffectorBoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SolverEffectorBoneNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SolverEffectorBoneNameList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		RootName = B1GlobalFNames.root;
		base.BlueprintInitializeAnimation_Implementation();
	}

	public void InitData()
	{
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		base.BlueprintUpdateAnimation_Implementation(DeltaTimeX);
		AActor owningActor = GetOwningActor();
		if (owningActor == null || !UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(owningActor) || owningActor is BUTamerActor)
		{
			return;
		}
		IBUC_ABPSpineIKData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSpineIKData, BUC_ABPSpineIKData>(owningActor);
		IBUC_ABPAttackIKData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackIKData, BUC_ABPAttackIKData>(owningActor);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null)
		{
			return;
		}
		IKSpinePitch = unPersistentReadOnlyData.IKSpinePitch;
		IKSpineRoll = unPersistentReadOnlyData.IKSpineRoll;
		IKSpineAlpha = unPersistentReadOnlyData.IKSpineAlpha;
		LimbIKAlpha = unPersistentReadOnlyData.LimbIKAlpha;
		LimbIKEffectorList.Clear();
		FEffectorData item = default(FEffectorData);
		item.EffectorRootName = B1GlobalFNames.thigh_r;
		item.BoneName = B1GlobalFNames.foot_r;
		item.Position = unPersistentReadOnlyData.SpineIKFootRPos;
		item.Alpha = unPersistentReadOnlyData.IKFootRAlpha * GetLimbsCurveData(item.BoneName, unPersistentReadOnlyData);
		item.AlphaCurveValue = item.Alpha;
		LimbIKEffectorList.Add(item);
		FEffectorData item2 = default(FEffectorData);
		item2.EffectorRootName = B1GlobalFNames.thigh_l;
		item2.BoneName = B1GlobalFNames.foot_l;
		item2.Position = unPersistentReadOnlyData.SpineIKFootLPos;
		item2.Alpha = unPersistentReadOnlyData.IKFootLAlpha * GetLimbsCurveData(item2.BoneName, unPersistentReadOnlyData);
		item2.AlphaCurveValue = item2.Alpha;
		LimbIKEffectorList.Add(item2);
		FEffectorData item3 = default(FEffectorData);
		item3.EffectorRootName = B1GlobalFNames.clavicle_r;
		item3.BoneName = B1GlobalFNames.hand_r;
		item3.Position = unPersistentReadOnlyData.SpineIKHandRPos;
		item3.Alpha = unPersistentReadOnlyData.IKHandRAlpha * GetLimbsCurveData(item3.BoneName, unPersistentReadOnlyData);
		item3.AlphaCurveValue = item3.Alpha;
		LimbIKEffectorList.Add(item3);
		FEffectorData item4 = default(FEffectorData);
		item4.EffectorRootName = B1GlobalFNames.clavicle_l;
		item4.BoneName = B1GlobalFNames.hand_l;
		item4.Position = unPersistentReadOnlyData.SpineIKHandLPos;
		item4.Alpha = unPersistentReadOnlyData.IKHandLAlpha * GetLimbsCurveData(item4.BoneName, unPersistentReadOnlyData);
		item4.AlphaCurveValue = item4.Alpha;
		LimbIKEffectorList.Add(item4);
		if (!unPersistentReadOnlyData.EnableCustomLimbIK || unPersistentReadOnlyData.LimbsEndBonePositions.Count != unPersistentReadOnlyData.LimbRootBoneNames.Count)
		{
			return;
		}
		for (int i = 0; i < unPersistentReadOnlyData.LimbIKDataList.Count; i++)
		{
			LimbIKData limbIKData = unPersistentReadOnlyData.LimbIKDataList[i];
			int num = 0;
			for (int j = 0; j < limbIKData.LimbEndBoneName.Count; j++)
			{
				num = i * unPersistentReadOnlyData.LimbIKDataList.Count + j;
				FEffectorData item5 = default(FEffectorData);
				item5.EffectorRootName = unPersistentReadOnlyData.LimbRootBoneNames[num];
				item5.BoneName = unPersistentReadOnlyData.LimbEndBoneNames[num];
				item5.Position = unPersistentReadOnlyData.LimbsEndBonePositions[num];
				item5.Alpha = unPersistentReadOnlyData.LimbsPisitionAlphas[num] * GetLimbsCurveData(item5.EffectorRootName, unPersistentReadOnlyData);
				item5.AlphaCurveValue = unPersistentReadOnlyData.LimbsPisitionAlphas[num];
				LimbIKEffectorList.Add(item5);
			}
		}
	}

	public float GetLimbsCurveData(FName CurveName, IBUC_ABPSpineIKData SpineIKData)
	{
		if (SpineIKData.LimbIKDataList != null)
		{
			for (int i = 0; i < SpineIKData.LimbIKDataList.Count; i++)
			{
				if (SpineIKData.LimbIKDataList[i].LimbCurveName == CurveName)
				{
					return SpineIKData.LimbsCurveAlphas[i];
				}
			}
		}
		return 1f;
	}

	public void OnEntityInitFinish()
	{
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped bUAnim_PostProcess_Quadruped = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnim_PostProcess_Quadruped.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped bUAnim_PostProcess_Quadruped = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped>(obj);
		bUAnim_PostProcess_Quadruped.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnim_PostProcess_Quadruped");
		IKSpinePitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKSpinePitch");
		IKSpinePitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKSpinePitch", Classes.FFloatProperty);
		IKSpineRoll_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKSpineRoll");
		IKSpineRoll_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKSpineRoll", Classes.FFloatProperty);
		IKSpineAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKSpineAlpha");
		IKSpineAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKSpineAlpha", Classes.FFloatProperty);
		LimbIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbIKAlpha");
		LimbIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbIKAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LimbIKEffectorList_PropertyAddress, intPtr, "LimbIKEffectorList");
		LimbIKEffectorList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbIKEffectorList");
		LimbIKEffectorList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbIKEffectorList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EnableAttackIK_PropertyAddress, intPtr, "EnableAttackIK");
		EnableAttackIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableAttackIK");
		EnableAttackIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableAttackIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttackIKRollList_PropertyAddress, intPtr, "AttackIKRollList");
		AttackIKRollList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKRollList");
		AttackIKRollList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKRollList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackIKPitchList_PropertyAddress, intPtr, "AttackIKPitchList");
		AttackIKPitchList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKPitchList");
		AttackIKPitchList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKPitchList", Classes.FArrayProperty);
		RootName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RootName");
		RootName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RootName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SolverRootBoneNameList_PropertyAddress, intPtr, "SolverRootBoneNameList");
		SolverRootBoneNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SolverRootBoneNameList");
		SolverRootBoneNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SolverRootBoneNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SolverEffectorBoneNameList_PropertyAddress, intPtr, "SolverEffectorBoneNameList");
		SolverEffectorBoneNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SolverEffectorBoneNameList");
		SolverEffectorBoneNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SolverEffectorBoneNameList", Classes.FArrayProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess_Quadruped:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnim_PostProcess_Quadruped()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BUAnim_PostProcess_Quadruped));
	}
}
