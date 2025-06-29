using System;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGULandscapeReaderActor")]
public class BGULandscapeReaderActor : BGUActorBaseCS
{
	private static bool LandscapeProxy_IsValid;

	private static int LandscapeProxy_Offset;

	private static bool LandscapeReader_IsValid;

	private static int LandscapeReader_Offset;

	private static bool CacheLandscapeData_IsValid;

	private static IntPtr CacheLandscapeData_FunctionAddress;

	private static int CacheLandscapeData_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("LandscapeReader")]
	[USharpPath("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeProxy")]
	public ALandscapeProxy LandscapeProxy
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeProxy");
				return null;
			}
			return UObjectMarshaler<ALandscapeProxy>.FromNative(IntPtr.Add(base.Address, LandscapeProxy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeProxy");
			}
			else
			{
				UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(base.Address, LandscapeProxy_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeReader")]
	public ULandscapeReader LandscapeReader
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeReader_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeReader");
				return null;
			}
			return UObjectMarshaler<ULandscapeReader>.FromNative(IntPtr.Add(base.Address, LandscapeReader_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeReader_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULandscapeReaderActor:LandscapeReader");
			}
			else
			{
				UObjectMarshaler<ULandscapeReader>.ToNative(IntPtr.Add(base.Address, LandscapeReader_Offset), value);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.ActorBaseDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		LandscapeReader = initializer.CreateDefaultSubobject<ULandscapeReader>(this, B1GlobalFNames.LandscapeReader);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	[UFunction]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[Category("LandscapeReader")]
	[USharpPath("/Script/b1-Managed.BGULandscapeReaderActor:CacheLandscapeData")]
	public void CacheLandscapeData()
	{
		LandscapeReader.Cache(LandscapeProxy);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULandscapeReaderActor:CacheLandscapeData")]
	private static void CacheLandscapeData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULandscapeReaderActor bGULandscapeReaderActor = GCHelper.Find<BGULandscapeReaderActor>(obj);
		bGULandscapeReaderActor.CacheLandscapeData();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGULandscapeReaderActor");
		LandscapeProxy_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandscapeProxy");
		LandscapeProxy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandscapeProxy", Classes.FObjectProperty);
		LandscapeReader_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandscapeReader");
		LandscapeReader_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandscapeReader", Classes.FObjectProperty);
		CacheLandscapeData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CacheLandscapeData");
		CacheLandscapeData_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheLandscapeData_FunctionAddress);
		CacheLandscapeData_IsValid = CacheLandscapeData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULandscapeReaderActor:CacheLandscapeData", CacheLandscapeData_IsValid);
	}

	static BGULandscapeReaderActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULandscapeReaderActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGULandscapeReaderActor));
	}
}
