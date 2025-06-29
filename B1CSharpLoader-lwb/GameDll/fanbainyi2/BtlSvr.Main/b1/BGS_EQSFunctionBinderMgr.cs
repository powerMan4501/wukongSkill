using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_EQSFunctionBinderMgr : GameStateSystemBase
{
	private delegate T Del_GetFuncationBinder<T>();

	[UClass]
	[USharpPath("/Script/b1-Managed.BGUFunctionBinder")]
	public class BGUFunctionBinder : UObject
	{
		public UActorCompBaseCS OwnerComp;

		public void Init(UActorCompBaseCS Component)
		{
			OwnerComp = Component;
		}

		public virtual void Clean()
		{
		}

		private static void LoadNativeType()
		{
			IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFunctionBinder");
		}

		static BGUFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(BGUFunctionBinder));
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.BGUEQSFunctionBinder")]
	public class BGUEQSFunctionBinder : BGUFunctionBinder
	{
		private Action<List<FVector>, List<float>, FGSEQSExParam, int> EQSFinishCallBackAction;

		private static bool EQSObject_IsValid;

		private static int EQSObject_Offset;

		private static bool OnEQSFinish_IsValid;

		private static IntPtr OnEQSFinish_FunctionAddress;

		private static int OnEQSFinish_ParamsSize;

		private static bool OnEQSFinish_Results_IsValid;

		private static int OnEQSFinish_Results_Offset;

		private static FFieldAddress OnEQSFinish_Results_PropertyAddress;

		private static bool OnEQSFinish_Scores_IsValid;

		private static int OnEQSFinish_Scores_Offset;

		private static FFieldAddress OnEQSFinish_Scores_PropertyAddress;

		private static bool OnEQSFinish_ExParam_IsValid;

		private static int OnEQSFinish_ExParam_Offset;

		private static FFieldAddress OnEQSFinish_ExParam_PropertyAddress;

		private static bool OnEQSFinish_QueryID_IsValid;

		private static int OnEQSFinish_QueryID_Offset;

		[UProperty]
		[USharpPath("/Script/b1-Managed.BGUEQSFunctionBinder:EQSObject")]
		private UBGUEQSObject EQSObject
		{
			get
			{
				CheckDestroyed();
				if (!EQSObject_IsValid)
				{
					NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEQSFunctionBinder:EQSObject");
					return null;
				}
				return UObjectMarshaler<UBGUEQSObject>.FromNative(IntPtr.Add(base.Address, EQSObject_Offset));
			}
			set
			{
				CheckDestroyed();
				if (!EQSObject_IsValid)
				{
					NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEQSFunctionBinder:EQSObject");
				}
				else
				{
					UObjectMarshaler<UBGUEQSObject>.ToNative(IntPtr.Add(base.Address, EQSObject_Offset), value);
				}
			}
		}

		public void InitiateObject(Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack)
		{
			EQSFinishCallBackAction = CallBack;
			if (EQSObject == null)
			{
				EQSObject = UObject.NewObject<UBGUEQSObject>(this);
				EQSObject.FBUE_RunEQSFinish.Bind(this, B1GlobalFNames.OnEQSFinish);
			}
		}

		public override void Clean()
		{
			EQSFinishCallBackAction = null;
			EQSObject = null;
		}

		public int EQSObjRun(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam)
		{
			if (EQSObject != null && Querier != null)
			{
				return EQSObject.EQSObjRun(EnvQueryObj, Querier, Reason, _ExParam);
			}
			return -1;
		}

		public void EQSObjRunInstant(UEnvQuery EnvQueryObj, AActor Querier, out List<FVector> Locations, out List<float> Scores)
		{
			Locations = new List<FVector>();
			Scores = new List<float>();
			if (EQSObject != null && Querier != null)
			{
				EQSObject.EQSObjRunInstant(EnvQueryObj, Querier, out Locations, out Scores);
				DrawDebugEQSResult(Locations, Scores);
			}
		}

		public int EQSObjRunWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, List<FGSEnvNamedValue> EQSParamList)
		{
			if (EQSObject != null && Querier != null)
			{
				return EQSObject.EQSObjRunWithCustomParams(EnvQueryObj, Querier, EBGURunEQSObjReason.None, EQSParamList);
			}
			return -1;
		}

		public void EQSObjRunInstantWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, List<FGSEnvNamedValue> NamedParams, out List<FVector> Locations, out List<float> Scores)
		{
			Locations = new List<FVector>();
			Scores = new List<float>();
			if (EQSObject != null && Querier != null)
			{
				EQSObject.EQSObjRunInstantWithCustomParams(EnvQueryObj, Querier, NamedParams, out Locations, out Scores);
				DrawDebugEQSResult(Locations, Scores);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGUEQSFunctionBinder:OnEQSFinish")]
		private void OnEQSFinish(List<FVector> Results, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
		{
			DrawDebugEQSResult(Results, Scores);
			EQSFinishCallBackAction?.Invoke(Results, Scores, ExParam, QueryID);
			EQSFinishCallBackAction = null;
			BGS_EventCollectionCS.Get(this).Evt_BGS_CollectEQSFunctionBinder.Invoke(this);
		}

		private void DrawDebugEQSResult(List<FVector> Results, List<float> Scores)
		{
			if (GSGameplayCVar.CVar_ShowEQSResult.GetValueInGameThread() == 0 || Results == null || Scores == null || Results.Count != Scores.Count)
			{
				return;
			}
			float num = 1f / (float)Scores.Count;
			float num2 = -1f;
			FLinearColor green = FLinearColor.Green;
			for (int i = 0; i < Results.Count; i++)
			{
				FVector center = Results[i];
				float num3 = Scores[i];
				if (num2 < 0f || num2 > num3)
				{
					green.R = FMath.Clamp(green.R + num, 0f, 1f);
					green.G = FMath.Clamp(green.G - num, 0f, 1f);
					num2 = num3;
				}
				USystemLibrary.DrawDebugSphere(this, center, 30f, 12, green, 5f, 1f);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.BGUEQSFunctionBinder:OnEQSFinish")]
		private static void OnEQSFinish__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGUEQSFunctionBinder bGUEQSFunctionBinder = GCHelper.Find<BGUEQSFunctionBinder>(obj);
			List<FVector> results = new TArrayCopyMarshaler<FVector>(1, OnEQSFinish_Results_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, OnEQSFinish_Results_Offset));
			List<float> scores = new TArrayCopyMarshaler<float>(1, OnEQSFinish_Scores_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(buffer, OnEQSFinish_Scores_Offset));
			FGSEQSExParam exParam = FGSEQSExParam.FromNative(IntPtr.Add(buffer, OnEQSFinish_ExParam_Offset));
			int queryID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnEQSFinish_QueryID_Offset));
			bGUEQSFunctionBinder.OnEQSFinish(results, scores, exParam, queryID);
		}

		private static void LoadNativeType()
		{
			IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUEQSFunctionBinder");
			EQSObject_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSObject");
			EQSObject_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSObject", Classes.FObjectProperty);
			OnEQSFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEQSFinish");
			OnEQSFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEQSFinish_FunctionAddress);
			NativeReflection.GetPropertyRef(ref OnEQSFinish_Results_PropertyAddress, OnEQSFinish_FunctionAddress, "Results");
			OnEQSFinish_Results_Offset = NativeReflection.GetPropertyOffset(OnEQSFinish_FunctionAddress, "Results");
			OnEQSFinish_Results_IsValid = NativeReflection.ValidatePropertyClass(OnEQSFinish_FunctionAddress, "Results", Classes.FArrayProperty);
			NativeReflection.GetPropertyRef(ref OnEQSFinish_Scores_PropertyAddress, OnEQSFinish_FunctionAddress, "Scores");
			OnEQSFinish_Scores_Offset = NativeReflection.GetPropertyOffset(OnEQSFinish_FunctionAddress, "Scores");
			OnEQSFinish_Scores_IsValid = NativeReflection.ValidatePropertyClass(OnEQSFinish_FunctionAddress, "Scores", Classes.FArrayProperty);
			NativeReflection.GetPropertyRef(ref OnEQSFinish_ExParam_PropertyAddress, OnEQSFinish_FunctionAddress, "ExParam");
			OnEQSFinish_ExParam_Offset = NativeReflection.GetPropertyOffset(OnEQSFinish_FunctionAddress, "ExParam");
			OnEQSFinish_ExParam_IsValid = NativeReflection.ValidatePropertyClass(OnEQSFinish_FunctionAddress, "ExParam", Classes.FStructProperty);
			OnEQSFinish_QueryID_Offset = NativeReflection.GetPropertyOffset(OnEQSFinish_FunctionAddress, "QueryID");
			OnEQSFinish_QueryID_IsValid = NativeReflection.ValidatePropertyClass(OnEQSFinish_FunctionAddress, "QueryID", Classes.FIntProperty);
			OnEQSFinish_IsValid = OnEQSFinish_FunctionAddress != IntPtr.Zero && OnEQSFinish_Results_IsValid && OnEQSFinish_Scores_IsValid && OnEQSFinish_ExParam_IsValid && OnEQSFinish_QueryID_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEQSFunctionBinder:OnEQSFinish", OnEQSFinish_IsValid);
		}

		static BGUEQSFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUEQSFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(BGUEQSFunctionBinder));
		}
	}

	private Dictionary<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>> FunctionBindersPoolDic = new Dictionary<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>>();

	private Dictionary<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>> FunctionBindersPoolDic_Using = new Dictionary<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>>();

	private int ObjectPoolMaxCount { get; set; }

	public static BGS_EQSFunctionBinderMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGS_EQSFunctionBinderMgr>(WorldContext);
	}

	public override void OnAttach()
	{
		base.OnAttach();
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.ObjectPoolMaxCount, out var ConfigInfo);
		ObjectPoolMaxCount = ConfigInfo.IntValue;
		base.BGSEventCollection.Evt_BGS_EQSObjRun += new Del_EQSObjRun(EQSObjRun);
		base.BGSEventCollection.Evt_BGS_EQSObjRunInstant += new Del_EQSObjRunInstant(EQSObjRunInstant);
		base.BGSEventCollection.Evt_BGS_EQSObjRunWithCustomParams += new Del_EQSObjRunWithCustomParams(EQSObjRunWithCustomParams);
		base.BGSEventCollection.Evt_BGS_EQSObjRunInstantWithCustomParams += new Del_EQSObjRunInstantWithCustomParams(EQSObjRunInstantWithCustomParams);
		base.BGSEventCollection.Evt_BGS_CollectEQSFunctionBinder += new Del_Void_UObject(CollectEQSFunctionBinder);
	}

	public void CleanAll()
	{
		foreach (KeyValuePair<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>> item in FunctionBindersPoolDic)
		{
			foreach (TStrongObjectPtr_NoCollect<BGUFunctionBinder> item2 in item.Value)
			{
				item2.Get().Clean();
				item2.Delete();
			}
		}
		foreach (KeyValuePair<Type, List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>> item3 in FunctionBindersPoolDic_Using)
		{
			foreach (TStrongObjectPtr_NoCollect<BGUFunctionBinder> item4 in item3.Value)
			{
				item4.Get().Clean();
				item4.Delete();
			}
		}
		FunctionBindersPoolDic.Clear();
		FunctionBindersPoolDic_Using.Clear();
	}

	private T GetFunctionBinderfromPool<T>() where T : BGUFunctionBinder
	{
		T val = null;
		if (FunctionBindersPoolDic.ContainsKey(typeof(T)) && FunctionBindersPoolDic[typeof(T)].Count != 0)
		{
			TStrongObjectPtr_NoCollect<BGUFunctionBinder> tStrongObjectPtr_NoCollect = FunctionBindersPoolDic[typeof(T)][0];
			FunctionBindersPoolDic[typeof(T)].RemoveAt(0);
			val = tStrongObjectPtr_NoCollect.Get() as T;
		}
		else
		{
			val = UObject.NewObject<T>(Owner);
		}
		AddToUsingPool(val);
		return val;
	}

	public void CollectEQSFunctionBinder(UObject Object)
	{
		BGUEQSFunctionBinder bGUEQSFunctionBinder = Object as BGUEQSFunctionBinder;
		if (!(bGUEQSFunctionBinder == null))
		{
			CollectFunctionBinderfromPool(bGUEQSFunctionBinder);
		}
	}

	private void CollectFunctionBinderfromPool<T>(T CollectedObject) where T : BGUFunctionBinder
	{
		CollectFunctionBinderfromUsingPool(CollectedObject);
		if (FunctionBindersPoolDic.ContainsKey(typeof(T)))
		{
			if (FunctionBindersPoolDic[typeof(T)].Count < ObjectPoolMaxCount)
			{
				FunctionBindersPoolDic[typeof(T)].Add(new TStrongObjectPtr_NoCollect<BGUFunctionBinder>(CollectedObject));
			}
		}
		else
		{
			FunctionBindersPoolDic.Add(typeof(T), new List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>(new TStrongObjectPtr_NoCollect<BGUFunctionBinder>[1]
			{
				new TStrongObjectPtr_NoCollect<BGUFunctionBinder>(CollectedObject)
			}));
		}
	}

	private void AddToUsingPool<T>(T CollectedObject) where T : BGUFunctionBinder
	{
		if (FunctionBindersPoolDic_Using.ContainsKey(typeof(T)))
		{
			FunctionBindersPoolDic_Using[typeof(T)].Add(new TStrongObjectPtr_NoCollect<BGUFunctionBinder>(CollectedObject));
			return;
		}
		FunctionBindersPoolDic_Using.Add(typeof(T), new List<TStrongObjectPtr_NoCollect<BGUFunctionBinder>>(new TStrongObjectPtr_NoCollect<BGUFunctionBinder>[1]
		{
			new TStrongObjectPtr_NoCollect<BGUFunctionBinder>(CollectedObject)
		}));
	}

	private void CollectFunctionBinderfromUsingPool<T>(T CollectedObject) where T : BGUFunctionBinder
	{
		TStrongObjectPtr_NoCollect<BGUFunctionBinder> item = new TStrongObjectPtr_NoCollect<BGUFunctionBinder>(CollectedObject);
		if (FunctionBindersPoolDic_Using.ContainsKey(typeof(T)) && FunctionBindersPoolDic_Using[typeof(T)].Contains(item))
		{
			FunctionBindersPoolDic_Using[typeof(T)].Remove(item);
		}
	}

	private int EQSObjRun(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam, Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack)
	{
		BGUEQSFunctionBinder functionBinderfromPool = GetFunctionBinderfromPool<BGUEQSFunctionBinder>();
		functionBinderfromPool.InitiateObject(CallBack);
		return functionBinderfromPool.EQSObjRun(EnvQueryObj, Querier, Reason, _ExParam);
	}

	private void EQSObjRunInstant(UEnvQuery EnvQueryObj, AActor Querier, out List<FVector> Locations, out List<float> Scores)
	{
		BGUEQSFunctionBinder functionBinderfromPool = GetFunctionBinderfromPool<BGUEQSFunctionBinder>();
		functionBinderfromPool.InitiateObject(null);
		functionBinderfromPool.EQSObjRunInstant(EnvQueryObj, Querier, out Locations, out Scores);
	}

	private int EQSObjRunWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, List<FGSEnvNamedValue> EQSParamList, Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack)
	{
		BGUEQSFunctionBinder functionBinderfromPool = GetFunctionBinderfromPool<BGUEQSFunctionBinder>();
		functionBinderfromPool.InitiateObject(CallBack);
		return functionBinderfromPool.EQSObjRunWithCustomParams(EnvQueryObj, Querier, Reason, EQSParamList);
	}

	private void EQSObjRunInstantWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, List<FGSEnvNamedValue> NamedParams, out List<FVector> Locations, out List<float> Scores)
	{
		GetFunctionBinderfromPool<BGUEQSFunctionBinder>().EQSObjRunInstantWithCustomParams(EnvQueryObj, Querier, NamedParams, out Locations, out Scores);
	}
}
