using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using b1.BGW;
using b1.Plugins.GSDynamicSDF;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator2")]
public class BGUDynamicSDFGenerator2 : AGSDynamicSDFInitializer
{
	private struct VelocityMotionData
	{
		public FVector Current_First_Velocity;

		public FVector Current_Next_Velocity;

		public FVector Previous_First_Velocity;

		public FVector Previous_Next_Velocity;
	}

	private struct GetPerpendicularDirParameters
	{
		public FVector VectorToGet;

		public FVector AnotherDir;

		public FVector FallbackDir;

		public GetPerpendicularDirParameters(FVector VectorToGet)
		{
			this.VectorToGet = VectorToGet;
			AnotherDir = new FVector(0.0, 0.0, 1.0);
			FallbackDir = new FVector(1.0, 0.0, 0.0);
		}

		public GetPerpendicularDirParameters(FVector VectorToGet, FVector AnotherDir)
		{
			this.VectorToGet = VectorToGet;
			this.AnotherDir = AnotherDir;
			FallbackDir = new FVector(1.0, 0.0, 0.0);
		}

		public GetPerpendicularDirParameters(FVector VectorToGet, FVector AnotherDir, FVector FallbackDir)
		{
			this.VectorToGet = VectorToGet;
			this.AnotherDir = AnotherDir;
			this.FallbackDir = FallbackDir;
		}
	}

	public const float BoneMaxPositionChangeFromPreviousThreshold = 30000f;

	public const int MaxDataHandleCount = 32;

	public const int VectorNumPerDataHandle = 4;

	private Dictionary<int, FDispInteractInfo> previousData_dict = new Dictionary<int, FDispInteractInfo>();

	private Dictionary<int, FDispInteractInfo> previousData_dict_temp = new Dictionary<int, FDispInteractInfo>();

	private Dictionary<int, FDispInteractInfo> twoBeforeData_dict = new Dictionary<int, FDispInteractInfo>();

	private Dictionary<int, int> actorID_previous_dict = new Dictionary<int, int>();

	private Dictionary<int, FVector4> data_previous_dict = new Dictionary<int, FVector4>();

	private Dictionary<int, FVector4> data_twoBefore_dict = new Dictionary<int, FVector4>();

	private OrderedDictionary data_toNiagara_pos_dict = new OrderedDictionary();

	private OrderedDictionary data_toNiagara_velocity_dict = new OrderedDictionary();

	private static readonly FName FName_CenterSnappedPos_WorldSpace;

	private static readonly FName FName_CenterSnappedOffset;

	private static readonly FName FName_PreviousCenterSnappedPosWS;

	private static readonly FName FName_PreviousCenterSnappedOffset;

	private static readonly FName FName_CenterPos;

	private static readonly FName FName_PreviousCenterPos;

	private static readonly FName FName_CenterOffset;

	private bool isInited;

	private GetPerpendicularDirParameters _getPerpendicularDirParameters = new GetPerpendicularDirParameters(FVector.ZeroVector);

	private List<FVector4> baseData_toNiagara = new List<FVector4>();

	private List<FVector4> velocityData_toNiagara = new List<FVector4>();

	private List<FVector4> vertexNormalData_toNiagara = new List<FVector4>();

	private static bool AttachTo_IsValid;

	private static int AttachTo_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaTime_IsValid;

	private static int ReceiveTick_DeltaTime_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator2:AttachTo")]
	public AActor AttachTo
	{
		get
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator2:AttachTo");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, AttachTo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator2:AttachTo");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, AttachTo_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaTime)
	{
		base.ReceiveTick_Implementation(DeltaTime);
	}

	public void SendInfos(Dictionary<int, FDispInteractInfo> Infos)
	{
		BGW_DynamicSDFMgr bGW_DynamicSDFMgr = BGW_DynamicSDFMgr.Get(this);
		if (bGW_DynamicSDFMgr == null)
		{
			return;
		}
		base.CenterSnappedPosWS = bGW_DynamicSDFMgr.CenterSnappedPos;
		base.PreviousCenterSnappedPosWS = bGW_DynamicSDFMgr.CenterSnappedPos_Previous;
		base.CenterSnappedOffset = bGW_DynamicSDFMgr.CenterSnappedOffset;
		base.PreviousCenterSnappedOffset = bGW_DynamicSDFMgr.PreviousCenterSnappedOffset;
		base.CenterPos = bGW_DynamicSDFMgr.CenterPos;
		base.PreviousCenterPos = bGW_DynamicSDFMgr.PreviousCenterPos;
		base.CenterOffset = bGW_DynamicSDFMgr.CenterOffset;
		_ = bGW_DynamicSDFMgr.CenterSnappedPos_TwoBefore;
		base.UsedElementCount = FMath.Min(Infos.Count, 32);
		if (AttachTo.IsNullOrDestroyed())
		{
			AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
			if (!controlledPawn.IsNullOrDestroyed())
			{
				AttachTo = controlledPawn;
			}
		}
		if (!AttachTo.IsNullOrDestroyed())
		{
			PrepareMotionData_Send_to_Niagara(Infos, AttachTo);
		}
	}

	private FDispInteractInfo ChangeDataPosition(FDispInteractInfo OrigData, FVector newPosition_First, FVector newPosition_Next)
	{
		return new FDispInteractInfo
		{
			FirstPos = newPosition_First,
			FirstRadius = OrigData.FirstRadius,
			NextPos = newPosition_Next,
			NextRadius = OrigData.NextRadius
		};
	}

	private FDispInteractInfo TransformDataPosition_World_to_Local(FDispInteractInfo OrigData)
	{
		FVector newPosition_First = OrigData.FirstPos - base.CenterSnappedPosWS;
		FVector newPosition_Next = OrigData.NextPos - base.CenterSnappedPosWS;
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FVector GetPerpendicularDir_ofVector(ref GetPerpendicularDirParameters inputs)
	{
		float num = FVector.DotProduct(inputs.VectorToGet, inputs.VectorToGet);
		float num2 = FVector.DotProduct(inputs.VectorToGet, inputs.AnotherDir);
		if (num <= 1E-06f || num2 * num2 / num > 0.99999f)
		{
			return inputs.FallbackDir;
		}
		if (Math.Abs(num2) < 1E-08f)
		{
			return FVector.ZeroVector;
		}
		return (num / num2 * inputs.AnotherDir - inputs.VectorToGet).GetSafeNormal();
	}

	private FVector GetFaceNormal(FVector O, FVector A, FVector B, FVector MainVectorWhenFallback)
	{
		FVector fVector = A - O;
		FVector fVector2 = B - O;
		FVector result = ((!(FVector.DotProduct(fVector, fVector) < 1E-05f) && !(FVector.DotProduct(fVector2, fVector2) < 1E-05f)) ? MathLib.CrossProduct(fVector, fVector2).GetSafeNormal() : FVector.ZeroVector);
		bool num = !result.Normalize();
		_getPerpendicularDirParameters.VectorToGet = MainVectorWhenFallback;
		_getPerpendicularDirParameters.AnotherDir = FVector.UpVector;
		_getPerpendicularDirParameters.FallbackDir = -FVector.ForwardVector;
		FVector perpendicularDir_ofVector = GetPerpendicularDir_ofVector(ref _getPerpendicularDirParameters);
		if (num)
		{
			return perpendicularDir_ofVector;
		}
		return result;
	}

	private FDispInteractInfo JitterDataPosition(FDispInteractInfo OrigData)
	{
		FVector newPosition_First = OrigData.FirstPos + new FVector(5.0, 5.0, 0.0);
		FVector newPosition_Next = OrigData.NextPos + new FVector(-5.0, -5.0, 0.0);
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FDispInteractInfo TransformDataPosition_PreviousLocal_to_CurrentLocal(FDispInteractInfo PreviousLocalData)
	{
		FVector newPosition_First = PreviousLocalData.FirstPos - base.CenterSnappedOffset;
		FVector newPosition_Next = PreviousLocalData.NextPos - base.CenterSnappedOffset;
		return ChangeDataPosition(PreviousLocalData, newPosition_First, newPosition_Next);
	}

	private float GetMaxSquaredDistanceBetweenDispInteractInfo(FDispInteractInfo infoA, FDispInteractInfo infoB)
	{
		FVector firstPos = infoA.FirstPos;
		FVector nextPos = infoA.NextPos;
		FVector firstPos2 = infoB.FirstPos;
		FVector nextPos2 = infoB.NextPos;
		float val = FVector.DotProduct(firstPos, nextPos);
		float val2 = FVector.DotProduct(firstPos2, nextPos2);
		return FMath.Max(val, val2);
	}

	private FDispInteractInfo GetStoredData(int dataID, Dictionary<int, FDispInteractInfo> DataStorageDict, FDispInteractInfo defaultData)
	{
		if (DataStorageDict.TryGetValue(dataID, out var value))
		{
			if (GetMaxSquaredDistanceBetweenDispInteractInfo(value, defaultData) > 900000000f)
			{
				return JitterDataPosition(defaultData);
			}
			return TransformDataPosition_PreviousLocal_to_CurrentLocal(value);
		}
		return JitterDataPosition(defaultData);
	}

	private void CalculateVelocity(FDispInteractInfo current, FDispInteractInfo previous, out FVector outFirst, out FVector outNext)
	{
		FVector fVector = current.FirstPos - previous.FirstPos;
		FVector fVector2 = current.NextPos - previous.NextPos;
		if (fVector.SizeSquared2D() < 9.999999747378752E-06)
		{
			fVector.Set(0.10000000149011612, 0.10000000149011612, 0.10000000149011612);
		}
		if (fVector2.SizeSquared2D() < 9.999999747378752E-06)
		{
			fVector2.Set(0.10000000149011612, 0.10000000149011612, 0.10000000149011612);
		}
		outFirst = fVector;
		outNext = fVector2;
	}

	private void SerializeMotionData_Base(FDispInteractInfo data, List<FVector4> storeBuffer)
	{
		FVector4 item = new FVector4(data.FirstPos, data.FirstRadius);
		FVector4 item2 = new FVector4(data.NextPos, data.NextRadius);
		storeBuffer.Add(item);
		storeBuffer.Add(item2);
	}

	private void SerializeMotionData_Velocity(ref VelocityMotionData data, List<FVector4> storeBuffer)
	{
		storeBuffer.Add(data.Current_First_Velocity);
		storeBuffer.Add(data.Current_Next_Velocity);
		storeBuffer.Add(data.Previous_First_Velocity);
		storeBuffer.Add(data.Previous_Next_Velocity);
	}

	private void PrepareMotionData_Send_to_Niagara(Dictionary<int, FDispInteractInfo> DataDict, AActor CenterActor)
	{
		baseData_toNiagara.Clear();
		velocityData_toNiagara.Clear();
		vertexNormalData_toNiagara.Clear();
		previousData_dict_temp.Clear();
		VelocityMotionData data = default(VelocityMotionData);
		foreach (KeyValuePair<int, FDispInteractInfo> item in DataDict)
		{
			FDispInteractInfo fDispInteractInfo = TransformDataPosition_World_to_Local(item.Value);
			FDispInteractInfo storedData = GetStoredData(item.Key, previousData_dict, fDispInteractInfo);
			CalculateVelocity(fDispInteractInfo, storedData, out var outFirst, out var outNext);
			data.Current_First_Velocity = outFirst;
			data.Current_Next_Velocity = outNext;
			data.Previous_First_Velocity = outFirst;
			data.Previous_Next_Velocity = outNext;
			FVector firstPos = fDispInteractInfo.FirstPos;
			FVector nextPos = fDispInteractInfo.NextPos;
			FVector nextPos2 = storedData.NextPos;
			FVector firstPos2 = storedData.FirstPos;
			FVector faceNormal = GetFaceNormal(firstPos, nextPos, firstPos2, firstPos - nextPos);
			FVector faceNormal2 = GetFaceNormal(nextPos, nextPos2, firstPos, firstPos - nextPos);
			FVector faceNormal3 = GetFaceNormal(nextPos2, firstPos2, nextPos, firstPos2 - nextPos2);
			FVector faceNormal4 = GetFaceNormal(firstPos2, firstPos, nextPos2, firstPos2 - nextPos2);
			vertexNormalData_toNiagara.Add(faceNormal);
			vertexNormalData_toNiagara.Add(faceNormal2);
			vertexNormalData_toNiagara.Add(faceNormal4);
			vertexNormalData_toNiagara.Add(faceNormal3);
			SerializeMotionData_Base(fDispInteractInfo, baseData_toNiagara);
			SerializeMotionData_Base(storedData, baseData_toNiagara);
			SerializeMotionData_Velocity(ref data, velocityData_toNiagara);
			previousData_dict_temp.Add(item.Key, fDispInteractInfo);
		}
		previousData_dict.Clear();
		foreach (KeyValuePair<int, FDispInteractInfo> item2 in previousData_dict_temp)
		{
			previousData_dict.Add(item2.Key, item2.Value);
		}
		base.Data.SetValues(baseData_toNiagara.GetRange(0, Math.Min(DataDict.Count, 32) * 4));
		base.Velocity.SetValues(velocityData_toNiagara.GetRange(0, Math.Min(DataDict.Count, 32) * 4));
		base.VertexNormal.SetValues(vertexNormalData_toNiagara.GetRange(0, Math.Min(DataDict.Count, 32) * 4));
		if (base.MPC != null)
		{
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_CenterSnappedPos_WorldSpace, new FLinearColor(base.CenterSnappedPosWS));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_CenterSnappedOffset, new FLinearColor(base.CenterSnappedOffset));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_PreviousCenterSnappedPosWS, new FLinearColor(base.PreviousCenterSnappedPosWS));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_PreviousCenterSnappedOffset, new FLinearColor(base.PreviousCenterSnappedOffset));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_CenterPos, new FLinearColor(base.CenterPos));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_PreviousCenterPos, new FLinearColor(base.PreviousCenterPos));
			UMaterialLibrary.SetVectorParameterValue(this, base.MPC, FName_CenterOffset, new FLinearColor(base.CenterOffset));
		}
	}

	static BGUDynamicSDFGenerator2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDynamicSDFGenerator2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDynamicSDFGenerator2));
		FName_CenterSnappedPos_WorldSpace = new FName("CenterSnappedPos_WorldSpace");
		FName_CenterSnappedOffset = new FName("CenterSnappedOffset");
		FName_PreviousCenterSnappedPosWS = new FName("PreviousCenterSnappedPosWS");
		FName_PreviousCenterSnappedOffset = new FName("PreviousCenterSnappedOffset");
		FName_CenterPos = new FName("CenterPos");
		FName_PreviousCenterPos = new FName("PreviousCenterPos");
		FName_CenterOffset = new FName("CenterOffset");
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDynamicSDFGenerator2 bGUDynamicSDFGenerator = GCHelper.Find<BGUDynamicSDFGenerator2>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaTime_Offset));
		bGUDynamicSDFGenerator.ReceiveTick_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDynamicSDFGenerator2 bGUDynamicSDFGenerator = GCHelper.Find<BGUDynamicSDFGenerator2>(obj);
		bGUDynamicSDFGenerator.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDynamicSDFGenerator2");
		AttachTo_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachTo");
		AttachTo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachTo", Classes.FObjectProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaTime_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaTime");
		ReceiveTick_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveTick", ReceiveTick_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDynamicSDFGenerator2:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}
}
