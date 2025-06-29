using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using b1.BGU.Util;
using b1.EventDelDefine;
using b1.Plugins.MM;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp")]
internal class BGUMotionMatchingDebugComp : UBaseActorCompTickable
{
	private readonly float DelayTime = 1f;

	private readonly int TextureWidth = 1024;

	private readonly int TextureHeight = 128;

	private string RequestSpawnUnitGuid = "";

	private AActor TestUnit;

	private USplineComponent SplineComp;

	private float StartMoveTimer;

	private float FinishMoveTimer;

	private float FinishDebugPlayerTimer;

	private EState_MM CurMMMode;

	private int CurMoveIndex;

	private int CurPathIndex;

	private List<FVector> Path = new List<FVector>();

	private Dictionary<string, b1.FMMAnimData> MapMMAnimData = new Dictionary<string, b1.FMMAnimData>();

	private static bool bDisable_IsValid;

	private static int bDisable_Offset;

	private static FFieldAddress bDisable_PropertyAddress;

	private static bool bDebugPlayer_IsValid;

	private static int bDebugPlayer_Offset;

	private static FFieldAddress bDebugPlayer_PropertyAddress;

	private static bool TamerBP_IsValid;

	private static int TamerBP_Offset;

	private static bool Restart_IsValid;

	private static IntPtr Restart_FunctionAddress;

	private static int Restart_ParamsSize;

	private static bool StopDebugPlayer_IsValid;

	private static IntPtr StopDebugPlayer_FunctionAddress;

	private static int StopDebugPlayer_ParamsSize;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[Category("Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDisable")]
	public bool bDisable
	{
		get
		{
			CheckDestroyed();
			if (!bDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDisable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisable_Offset), 0, bDisable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDisable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisable_Offset), 0, bDisable_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bDisable")]
	[EditAnywhere]
	[UProperty]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDebugPlayer")]
	public bool bDebugPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bDebugPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDebugPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDebugPlayer_Offset), 0, bDebugPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDebugPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:bDebugPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDebugPlayer_Offset), 0, bDebugPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!bDisable && !bDebugPlayer")]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:TamerBP")]
	public TSubclassOf<BUTamerActor> TamerBP
	{
		get
		{
			CheckDestroyed();
			if (!TamerBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:TamerBP");
				return default(TSubclassOf<BUTamerActor>);
			}
			return TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, TamerBP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMotionMatchingDebugComp:TamerBP");
			}
			else
			{
				TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, TamerBP_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		if (!bDisable)
		{
			if (bDebugPlayer)
			{
				StartDebugPlayer();
			}
			else
			{
				Init();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		if (bDisable)
		{
			return;
		}
		if (!RequestSpawnUnitGuid.Equals(""))
		{
			TestUnit = BGU_DataUtil.GetActorByGuid(GetOwner(), RequestSpawnUnitGuid);
			if (!TestUnit.IsNullOrDestroyed())
			{
				OnTestUnitSpawned();
				RequestSpawnUnitGuid = "";
			}
		}
		if (bDebugPlayer && TestUnit.IsNullOrDestroyed())
		{
			StartDebugPlayer();
		}
		if (TestUnit.IsNullOrDestroyed())
		{
			return;
		}
		if (FinishMoveTimer > 0f)
		{
			FinishMoveTimer -= DeltaTime;
			if (FinishMoveTimer <= 0f)
			{
				FinishMoveTimer = 0f;
				ProcessMoveFinish();
			}
		}
		if (StartMoveTimer > 0f)
		{
			StartMoveTimer -= DeltaTime;
			if (StartMoveTimer <= 0f)
			{
				StartMoveTimer = 0f;
				ProcessMoveStart();
			}
		}
		if (FinishDebugPlayerTimer > 0f)
		{
			FinishDebugPlayerTimer -= DeltaTime;
			if (FinishDebugPlayerTimer <= 0f)
			{
				FinishDebugPlayerTimer = 0f;
				OnRecordFinish();
			}
		}
	}

	private void OnTestUnitSpawned()
	{
		if (!TestUnit.IsNullOrDestroyed())
		{
			AIController aIController = UAIHelperLibrary.GetAIController(TestUnit);
			if (aIController != null && aIController.BrainComponent != null)
			{
				aIController.BrainComponent.StopLogic("");
			}
			BUS_EventCollectionCS.Get(TestUnit).Evt_AIPerceptionSetting.Invoke(P1: false);
			BGUFunctionLibraryCS.BGUAddBuff(TestUnit, TestUnit, 212);
			SetDisableLocomotionIdle(bDisable: true);
			BUS_EventCollectionCS.Get(TestUnit).Evt_AIPathMoveComplete += new Del_AIPathMoveComplete(OnTestUnitAIPathMoveComplete);
			DelayStartMove();
		}
	}

	private void Init()
	{
		StartMoveTimer = 0f;
		CurMMMode = EState_MM.None;
		CurMoveIndex = -1;
		InitSplinePath();
		CreateTestUnit();
	}

	private void StartDebugPlayer()
	{
		TestUnit = UBGUFunctionLibrary.GetPlayerCharacter(GetOwner());
		if (!(TestUnit == null))
		{
			ClearMMAnimDataRecordFile();
			SetDisableLocomotionIdle(bDisable: true);
			SetRecordMMAnimData(bEnabled: true);
		}
	}

	private void DelayStartMove()
	{
		StartMoveTimer = DelayTime;
	}

	private void DelayFinishMove()
	{
		FinishMoveTimer = DelayTime;
	}

	private void DelayFinishDebugPlayer()
	{
		FinishDebugPlayerTimer = DelayTime;
	}

	private void ChangeMMMode(EState_MM Mode)
	{
		BUS_EventCollectionCS.Get(TestUnit).Evt_ChangeMotionMatchingState.Invoke(Mode);
	}

	private void SetRecordMMAnimData(bool bEnabled)
	{
		BUS_EventCollectionCS.Get(TestUnit).Evt_SetRecordMMAnimData.Invoke(bEnabled);
	}

	private void SetDisableLocomotionIdle(bool bDisable)
	{
		BUS_EventCollectionCS.Get(TestUnit).Evt_SetDisableLocomotionIdle.Invoke(bDisable);
	}

	private void MoveStep()
	{
		CurPathIndex++;
		if (CurPathIndex >= Path.Count)
		{
			OnMoveFinish();
			return;
		}
		FVector fVector = Path[CurPathIndex];
		if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(TestUnit) - fVector).Size() <= 200f)
		{
			MoveStep();
		}
		else if (BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SpeedCtrlData>(TestUnit) != null)
		{
			EAIMoveSpeedType speedRateType = ((CurMMMode != EState_MM.Free) ? EAIMoveSpeedType.RUN : EAIMoveSpeedType.SPRINT);
			CurMoveIndex = BGUFuncLibAICS.BGURequestAIMoveToLocation(TestUnit, fVector, speedRateType, 0f, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: false);
		}
	}

	private void OnMoveFinish()
	{
		DelayFinishMove();
	}

	private void ProcessMoveFinish()
	{
		ResetTestUnitTransform();
		SetRecordMMAnimData(bEnabled: false);
		DelayStartMove();
	}

	private void ProcessMoveStart()
	{
		if (CurMMMode == EState_MM.None)
		{
			ClearMMAnimDataRecordFile();
			SetRecordMMAnimData(bEnabled: true);
			CurMMMode = EState_MM.Free;
			ChangeMMMode(CurMMMode);
			MoveStep();
		}
		else if (CurMMMode == EState_MM.Free)
		{
			SetRecordMMAnimData(bEnabled: true);
			CurMMMode = EState_MM.Lock;
			CurPathIndex = 0;
			ChangeMMMode(CurMMMode);
			MoveStep();
		}
		else
		{
			OnRecordFinish();
		}
	}

	private void OnRecordFinish()
	{
		ReadXMLRecordFile();
		GenerateMMAnimDataTexture();
	}

	private void ReadXMLRecordFile()
	{
		MapMMAnimData.Clear();
		string mMAnimDataRecordFilePath = UMotionMatchingHelpers.GetMMAnimDataRecordFilePath();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(mMAnimDataRecordFilePath);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("root");
		if (xmlNode == null)
		{
			return;
		}
		foreach (XmlNode childNode in xmlNode.ChildNodes)
		{
			XmlNode xmlNode3 = childNode.SelectSingleNode("TotalTime");
			b1.FMMAnimData value = new b1.FMMAnimData
			{
				StartTimeList = new List<float>()
			};
			if (xmlNode3 != null)
			{
				value.TotalTime = Convert.ToSingle(xmlNode3.InnerText);
			}
			foreach (XmlNode childNode2 in childNode.ChildNodes)
			{
				if (childNode2.Name.Equals("Time"))
				{
					value.StartTimeList.Add(Convert.ToSingle(childNode2.InnerText));
				}
			}
			if (value.StartTimeList.Count != 0)
			{
				string name = childNode.Name;
				MapMMAnimData.Add(name, value);
			}
		}
	}

	private void GenerateMMAnimDataTexture()
	{
		FColor fColor = new FColor(150, byte.MaxValue, 180);
		FColor fColor2 = new FColor(217, 83, 79);
		foreach (KeyValuePair<string, b1.FMMAnimData> mapMMAnimDatum in MapMMAnimData)
		{
			FColor[] Color = new FColor[TextureWidth * TextureHeight];
			for (int i = 0; i < Color.Length; i++)
			{
				Color[i] = fColor2;
			}
			foreach (float startTime in mapMMAnimDatum.Value.StartTimeList)
			{
				int num = FMath.FloorToInt(startTime / mapMMAnimDatum.Value.TotalTime * (float)TextureWidth);
				int num2 = FMath.FloorToInt((startTime + 0.1f) / mapMMAnimDatum.Value.TotalTime * (float)TextureWidth);
				FMath.Clamp(num, 0, TextureWidth - 1);
				FMath.Clamp(num2, 0, TextureWidth - 1);
				Color[num] = fColor;
				for (int j = num + 1; j < num2; j++)
				{
					Color[j] = fColor;
				}
			}
			for (int k = TextureWidth; k < Color.Length; k++)
			{
				Color[k] = Color[k - TextureWidth];
			}
			DirectoryInfo parent = Directory.GetParent(UMotionMatchingHelpers.GetMMAnimDataRecordFilePath());
			if (parent != null && TestUnit != null)
			{
				DirectoryInfo directoryInfo = parent.CreateSubdirectory(TestUnit.GetClass().GetName());
				string filepath = string.Format("{0}/{1}.{2}", directoryInfo.FullName, mapMMAnimDatum.Key, "png");
				BGU_TextureUtil.ExportColorDataAsPNG(TextureWidth, TextureHeight, filepath, in Color);
			}
		}
	}

	private void ResetTestUnitTransform()
	{
		if (!(TestUnit == null))
		{
			BUS_EventCollectionCS.Get(TestUnit)?.Evt_SetActorTransform.Invoke(BGUFuncLibActorTransformCS.BGUGetActorTransform(GetOwner()), bSweep: false, bTeleport: false);
		}
	}

	private void InitSplinePath()
	{
		SplineComp = GetOwner().GetComponentByClass<USplineComponent>();
		if (!(SplineComp == null))
		{
			CurPathIndex = 0;
			Path.Clear();
			int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
			for (int i = 0; i < numberOfSplinePoints; i++)
			{
				FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World);
				Path.Add(locationAtSplinePoint);
			}
		}
	}

	private void CreateTestUnit()
	{
		if (TamerBP.Value != null)
		{
			CreateActor(TamerBP.Value, BGUFuncLibActorTransformCS.BGUGetActorTransform(GetOwner()));
		}
	}

	private void CreateActor(UClass BPClass, FTransform transform)
	{
		RequestSpawnUnitGuid = BGU_UnrealWorldUtil.RequestSpawnUnit(GetOwner().World, BPClass, in transform, GetOwner());
	}

	private void OnTestUnitAIPathMoveComplete(int MoveIndex, EPathFollowingResult FollowingResult)
	{
		if (MoveIndex == CurMoveIndex)
		{
			MoveStep();
		}
	}

	[BlueprintCallable]
	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[Category("Restart")]
	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:Restart")]
	public void Restart()
	{
		if (!(TestUnit == null) && !bDebugPlayer)
		{
			BUS_EventCollectionCS.Get(TestUnit).Evt_MovementForceStop.Invoke();
			SetRecordMMAnimData(bEnabled: false);
			ResetTestUnitTransform();
			CurMMMode = EState_MM.None;
			CurPathIndex = 0;
			CurMoveIndex = -1;
			StartMoveTimer = 0f;
			FinishMoveTimer = 0f;
			DelayStartMove();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[Category("DebugPlayer")]
	[USharpPath("/Script/b1-Managed.BGUMotionMatchingDebugComp:StopDebugPlayer")]
	public void StopDebugPlayer()
	{
		if (!(TestUnit == null) && bDebugPlayer)
		{
			SetRecordMMAnimData(bEnabled: false);
			SetDisableLocomotionIdle(bDisable: false);
			DelayFinishDebugPlayer();
		}
	}

	private void ClearMMAnimDataRecordFile()
	{
		string mMAnimDataRecordFilePath = UMotionMatchingHelpers.GetMMAnimDataRecordFilePath();
		try
		{
			if (File.Exists(mMAnimDataRecordFilePath))
			{
				File.Delete(mMAnimDataRecordFilePath);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("ClearMMAnimDataRecordFile failed! exception: {0}", ex.ToString());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMotionMatchingDebugComp:Restart")]
	private static void Restart__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUMotionMatchingDebugComp bGUMotionMatchingDebugComp = GCHelper.Find<b1.BGUMotionMatchingDebugComp>(obj);
		bGUMotionMatchingDebugComp.Restart();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMotionMatchingDebugComp:StopDebugPlayer")]
	private static void StopDebugPlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUMotionMatchingDebugComp bGUMotionMatchingDebugComp = GCHelper.Find<b1.BGUMotionMatchingDebugComp>(obj);
		bGUMotionMatchingDebugComp.StopDebugPlayer();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMotionMatchingDebugComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUMotionMatchingDebugComp bGUMotionMatchingDebugComp = GCHelper.Find<b1.BGUMotionMatchingDebugComp>(obj);
		bGUMotionMatchingDebugComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMotionMatchingDebugComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUMotionMatchingDebugComp bGUMotionMatchingDebugComp = GCHelper.Find<b1.BGUMotionMatchingDebugComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bGUMotionMatchingDebugComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUMotionMatchingDebugComp");
		NativeReflection.GetPropertyRef(ref bDisable_PropertyAddress, intPtr, "bDisable");
		bDisable_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisable");
		bDisable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDebugPlayer_PropertyAddress, intPtr, "bDebugPlayer");
		bDebugPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDebugPlayer");
		bDebugPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDebugPlayer", Classes.FBoolProperty);
		TamerBP_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerBP");
		TamerBP_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerBP", Classes.FClassProperty);
		Restart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Restart");
		Restart_ParamsSize = NativeReflection.GetFunctionParamsSize(Restart_FunctionAddress);
		Restart_IsValid = Restart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMotionMatchingDebugComp:Restart", Restart_IsValid);
		StopDebugPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopDebugPlayer");
		StopDebugPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(StopDebugPlayer_FunctionAddress);
		StopDebugPlayer_IsValid = StopDebugPlayer_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMotionMatchingDebugComp:StopDebugPlayer", StopDebugPlayer_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMotionMatchingDebugComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMotionMatchingDebugComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BGUMotionMatchingDebugComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUMotionMatchingDebugComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUMotionMatchingDebugComp));
	}
}
