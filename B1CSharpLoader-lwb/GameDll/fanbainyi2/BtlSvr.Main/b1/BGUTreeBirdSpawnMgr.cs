using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr")]
public class BGUTreeBirdSpawnMgr : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool ConfigComp_IsValid;

	private static int ConfigComp_Offset;

	private static bool DrawDebugTime_IsValid;

	private static int DrawDebugTime_Offset;

	private static bool DrawDebugThickness_IsValid;

	private static int DrawDebugThickness_Offset;

	private static bool CollectAllTreesInfo_IsValid;

	private static IntPtr CollectAllTreesInfo_FunctionAddress;

	private static int CollectAllTreesInfo_ParamsSize;

	private static bool DrawDebug_OnlyInEditor_IsValid;

	private static IntPtr DrawDebug_OnlyInEditor_FunctionAddress;

	private static int DrawDebug_OnlyInEditor_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:ConfigComp")]
	public BUS_TreeBirdSpawnMgrConfigComp ConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:ConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_TreeBirdSpawnMgrConfigComp>.FromNative(IntPtr.Add(base.Address, ConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:ConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_TreeBirdSpawnMgrConfigComp>.ToNative(IntPtr.Add(base.Address, ConfigComp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugTime")]
	public float DrawDebugTime
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawDebugTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawDebugTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugThickness")]
	public float DrawDebugThickness
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawDebugThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebugThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawDebugThickness_Offset), value);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_TreeBirdSpawnMgrDataComp>(this, B1GlobalFNames.DataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		ConfigComp = initializer.CreateDefaultSubobject<BUS_TreeBirdSpawnMgrConfigComp>(this, B1GlobalFNames.ConfigInfoComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TreeBirdSpawnMgrLogicComp());
	}

	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[DisplayName("收集场景中所有蓝图树的信息")]
	[Tooltip("")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:CollectAllTreesInfo")]
	public void CollectAllTreesInfo()
	{
	}

	[DisplayName("预览Bounds")]
	[BlueprintCallable]
	[UFunction]
	[Tooltip("预览的是ConfigComp中TreeArray的数据信息，若没有，请先进行收集操作")]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebug_OnlyInEditor")]
	public void DrawDebug_OnlyInEditor()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTreeBirdSpawnMgr:CollectAllTreesInfo")]
	private static void CollectAllTreesInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUTreeBirdSpawnMgr bGUTreeBirdSpawnMgr = GCHelper.Find<BGUTreeBirdSpawnMgr>(obj);
		bGUTreeBirdSpawnMgr.CollectAllTreesInfo();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebug_OnlyInEditor")]
	private static void DrawDebug_OnlyInEditor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUTreeBirdSpawnMgr bGUTreeBirdSpawnMgr = GCHelper.Find<BGUTreeBirdSpawnMgr>(obj);
		bGUTreeBirdSpawnMgr.DrawDebug_OnlyInEditor();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTreeBirdSpawnMgr");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		ConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigComp");
		ConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigComp", Classes.FObjectProperty);
		DrawDebugTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugTime");
		DrawDebugTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugTime", Classes.FFloatProperty);
		DrawDebugThickness_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugThickness");
		DrawDebugThickness_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugThickness", Classes.FFloatProperty);
		CollectAllTreesInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CollectAllTreesInfo");
		CollectAllTreesInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectAllTreesInfo_FunctionAddress);
		CollectAllTreesInfo_IsValid = CollectAllTreesInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTreeBirdSpawnMgr:CollectAllTreesInfo", CollectAllTreesInfo_IsValid);
		DrawDebug_OnlyInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawDebug_OnlyInEditor");
		DrawDebug_OnlyInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawDebug_OnlyInEditor_FunctionAddress);
		DrawDebug_OnlyInEditor_IsValid = DrawDebug_OnlyInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTreeBirdSpawnMgr:DrawDebug_OnlyInEditor", DrawDebug_OnlyInEditor_IsValid);
	}

	static BGUTreeBirdSpawnMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUTreeBirdSpawnMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUTreeBirdSpawnMgr));
	}
}
