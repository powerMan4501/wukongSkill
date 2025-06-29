using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("创建缓存点集")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet")]
internal class BED_BehaviorNode_GenAndCachePointSet : b1.BED_BehaviorNode_Action
{
	private static bool RegisterID_IsValid;

	private static int RegisterID_Offset;

	private static bool GenType_IsValid;

	private static int GenType_Offset;

	private static FFieldAddress GenType_PropertyAddress;

	private static bool GenExtParam_IsValid;

	private static int GenExtParam_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:RegisterID")]
	public int RegisterID
	{
		get
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:RegisterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RegisterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:RegisterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RegisterID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenType")]
	public PointsGenType GenType
	{
		get
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenType");
				return PointsGenType.ByEQS_Async;
			}
			return EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenType");
			}
			else
			{
				EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenExtParam")]
	public PointsGenExtParam GenExtParam
	{
		get
		{
			CheckDestroyed();
			if (!GenExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenExtParam");
				return default(PointsGenExtParam);
			}
			return PointsGenExtParam.FromNative(IntPtr.Add(base.Address, GenExtParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GenExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GenExtParam");
			}
			else
			{
				PointsGenExtParam.ToNative(IntPtr.Add(base.Address, GenExtParam_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.GenAndCachePointSet;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_GenAndCachePointSet obj = new BehaviorCustom_GenAndCachePointSet
		{
			GenType = (int)GenType,
			EqsPath = ((GenExtParam.EQSTemplate != null) ? GenExtParam.EQSTemplate.GetPathName() : GenExtParam.EQSPath),
			SceneItemTag = GenExtParam.SceneItemTag,
			ExplodeDesiredNum = GenExtParam.Explode_DesiredNum,
			ExplodeLineTraceMaxLength = GenExtParam.Explode_LineTraceMaxLength,
			ExplodeTraceTypeQuery = (int)GenExtParam.Explode_TraceTypeQuery,
			ExplodePointMinBetween = GenExtParam.Explode_PointMinBetween,
			SocketName = GenExtParam.SocketName.ToString()
		};
		FFloatRangeBound lowerBound = GenExtParam.Explode_RangeDir_X.LowerBound;
		FFloatRangeBound upperBound = GenExtParam.Explode_RangeDir_X.UpperBound;
		obj.ExplodeRangeDirXMin = lowerBound.Value;
		obj.ExplodeRangeDirXMinRangeType = (int)lowerBound.Type;
		obj.ExplodeRangeDirXMax = upperBound.Value;
		obj.ExplodeRangeDirXMaxRangeType = (int)upperBound.Type;
		lowerBound = GenExtParam.Explode_RangeDir_Y.LowerBound;
		upperBound = GenExtParam.Explode_RangeDir_Y.UpperBound;
		obj.ExplodeRangeDirYMin = lowerBound.Value;
		obj.ExplodeRangeDirYMinRangeType = (int)lowerBound.Type;
		obj.ExplodeRangeDirYMax = upperBound.Value;
		obj.ExplodeRangeDirYMaxRangeType = (int)upperBound.Type;
		lowerBound = GenExtParam.Explode_RangeDir_Z.LowerBound;
		upperBound = GenExtParam.Explode_RangeDir_Z.UpperBound;
		obj.ExplodeRangeDirZMin = lowerBound.Value;
		obj.ExplodeRangeDirZMinRangeType = (int)lowerBound.Type;
		obj.ExplodeRangeDirZMax = upperBound.Value;
		obj.ExplodeRangeDirZMaxRangeType = (int)upperBound.Type;
		obj.RegisterId = RegisterID;
		return obj.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"生成缓存点集ID：{RegisterID}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_GenAndCachePointSet bED_BehaviorNode_GenAndCachePointSet = GCHelper.Find<b1.BED_BehaviorNode_GenAndCachePointSet>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_GenAndCachePointSet.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet");
		RegisterID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RegisterID");
		RegisterID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RegisterID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GenType_PropertyAddress, intPtr, "GenType");
		GenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GenType");
		GenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GenType", Classes.FEnumProperty);
		GenExtParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "GenExtParam");
		GenExtParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GenExtParam", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_GenAndCachePointSet:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_GenAndCachePointSet()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_GenAndCachePointSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_GenAndCachePointSet));
	}
}
