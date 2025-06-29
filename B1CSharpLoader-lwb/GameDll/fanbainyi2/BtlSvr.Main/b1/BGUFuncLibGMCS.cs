using System;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS")]
public class BGUFuncLibGMCS : UBlueprintFunctionLibrary
{
	private static IECSWorldObj WorldObj;

	private static EntitySharedRef WorldObjRef;

	public static EBGUAttrFloat[] sAttrNeedInSnapShot;

	private static bool TestECSWorldObj_IsValid;

	private static IntPtr TestECSWorldObj_FunctionAddress;

	private static int TestECSWorldObj_ParamsSize;

	private static bool TestECSWorldObj_Chr_IsValid;

	private static int TestECSWorldObj_Chr_Offset;

	private static bool IsShenZhenDebug_IsValid;

	private static IntPtr IsShenZhenDebug_FunctionAddress;

	private static int IsShenZhenDebug_ParamsSize;

	private static bool IsShenZhenDebug_ReturnValue_IsValid;

	private static int IsShenZhenDebug_ReturnValue_Offset;

	private static FFieldAddress IsShenZhenDebug_ReturnValue_PropertyAddress;

	private static bool PrintTestECSWorldObj_IsValid;

	private static IntPtr PrintTestECSWorldObj_FunctionAddress;

	private static int PrintTestECSWorldObj_ParamsSize;

	private static bool PrintTestECSWorldObj_Chr_IsValid;

	private static int PrintTestECSWorldObj_Chr_Offset;

	private static bool TestDestroyECSWorldObj_IsValid;

	private static IntPtr TestDestroyECSWorldObj_FunctionAddress;

	private static int TestDestroyECSWorldObj_ParamsSize;

	private static bool TestDestroyECSWorldObj_Chr_IsValid;

	private static int TestDestroyECSWorldObj_Chr_Offset;

	private static bool TestReleaseECSWorldObjRef_IsValid;

	private static IntPtr TestReleaseECSWorldObjRef_FunctionAddress;

	private static int TestReleaseECSWorldObjRef_ParamsSize;

	private static bool TestReleaseECSWorldObjRef_Chr_IsValid;

	private static int TestReleaseECSWorldObjRef_Chr_Offset;

	public static string ObjectToString(object O)
	{
		if (O == null)
		{
			return "null";
		}
		return O.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Actor")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS:TestECSWorldObj")]
	public static void TestECSWorldObj(BGUCharacterCS Chr)
	{
		WorldObj = Chr;
		WorldObjRef = new EntitySharedRef(Chr);
	}

	[Category("BGU|Actor")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS:PrintTestECSWorldObj")]
	public static void PrintTestECSWorldObj(BGUCharacterCS Chr)
	{
		_ = WorldObjRef != null;
	}

	[UFunction]
	[Category("BGU|Actor")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS:TestDestroyECSWorldObj")]
	public static void TestDestroyECSWorldObj(BGUCharacterCS Chr)
	{
		BGW_ECSWorld.Get(Chr).DestroyActor(Chr);
	}

	[Category("BGU|Actor")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS:TestReleaseECSWorldObjRef")]
	public static void TestReleaseECSWorldObjRef(BGUCharacterCS Chr)
	{
		WorldObjRef = null;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|GM")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibGMCS:IsShenZhenDebug")]
	public static bool IsShenZhenDebug()
	{
		return BGW_LocalDevEnvUtils.GetDevNetRegion() == "sz";
	}

	public static void GetPlayerAttrListForGMSnapShot(UObject WorldCtx, out EffectAttrList effectAttrList, out CustomAttrList customAttrList)
	{
		effectAttrList = new EffectAttrList();
		customAttrList = new CustomAttrList();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldCtx);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn == null)
		{
			return;
		}
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(controlledPawn);
		if (readOnlyData == null)
		{
			return;
		}
		EBGUAttrFloat[] array = sAttrNeedInSnapShot;
		foreach (EBGUAttrFloat eBGUAttrFloat in array)
		{
			EffectAttrFloat effectAttrFloat = new EffectAttrFloat();
			effectAttrFloat.Type = eBGUAttrFloat;
			effectAttrFloat.Value = readOnlyData.GetFloatValue(eBGUAttrFloat);
			effectAttrList.Attrs.Add(effectAttrFloat);
		}
		IBPC_PlayerRoleData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData2 == null)
		{
			return;
		}
		IBUC_SkillMappingData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>(controlledPawn);
		IBUC_SkillInstsData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(controlledPawn);
		for (int j = 0; j < readOnlyData2.RoleData.RoleCs.Actor.Wear.SpellList.Count; j++)
		{
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(readOnlyData2.RoleData.RoleCs.Actor.Wear.SpellList[j].SpellId);
			if (spellDesc != null)
			{
				int curResultSkillID = readOnlyData3.GetCurResultSkillID(spellDesc.SkillId);
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(curResultSkillID, controlledPawn);
				if (skillSDesc != null && readOnlyData4 != null && skillSDesc != null && !readOnlyData4.GetSkillCooldownTime(curResultSkillID, out var RemainingCooldownTime, out var _))
				{
					customAttrList.Attrs.Add(new CustomAttrFloat
					{
						Type = curResultSkillID,
						Value = RemainingCooldownTime
					});
				}
			}
		}
	}

	static BGUFuncLibGMCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibGMCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibGMCS));
		WorldObj = null;
		WorldObjRef = null;
		sAttrNeedInSnapShot = new EBGUAttrFloat[6]
		{
			EBGUAttrFloat.Hp,
			EBGUAttrFloat.Mp,
			EBGUAttrFloat.Stamina,
			EBGUAttrFloat.CurEnergy,
			EBGUAttrFloat.BloodBottomNum,
			EBGUAttrFloat.Pevalue
		};
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibGMCS:TestECSWorldObj")]
	private static void TestECSWorldObj__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS chr = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, TestECSWorldObj_Chr_Offset));
		TestECSWorldObj(chr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibGMCS:IsShenZhenDebug")]
	private static void IsShenZhenDebug__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = IsShenZhenDebug();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsShenZhenDebug_ReturnValue_Offset), 0, IsShenZhenDebug_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibGMCS:PrintTestECSWorldObj")]
	private static void PrintTestECSWorldObj__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS chr = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, PrintTestECSWorldObj_Chr_Offset));
		PrintTestECSWorldObj(chr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibGMCS:TestDestroyECSWorldObj")]
	private static void TestDestroyECSWorldObj__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS chr = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, TestDestroyECSWorldObj_Chr_Offset));
		TestDestroyECSWorldObj(chr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibGMCS:TestReleaseECSWorldObjRef")]
	private static void TestReleaseECSWorldObjRef__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS chr = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, TestReleaseECSWorldObjRef_Chr_Offset));
		TestReleaseECSWorldObjRef(chr);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibGMCS");
		TestECSWorldObj_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestECSWorldObj");
		TestECSWorldObj_ParamsSize = NativeReflection.GetFunctionParamsSize(TestECSWorldObj_FunctionAddress);
		TestECSWorldObj_Chr_Offset = NativeReflection.GetPropertyOffset(TestECSWorldObj_FunctionAddress, "Chr");
		TestECSWorldObj_Chr_IsValid = NativeReflection.ValidatePropertyClass(TestECSWorldObj_FunctionAddress, "Chr", Classes.FObjectProperty);
		TestECSWorldObj_IsValid = TestECSWorldObj_FunctionAddress != IntPtr.Zero && TestECSWorldObj_Chr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibGMCS:TestECSWorldObj", TestECSWorldObj_IsValid);
		IsShenZhenDebug_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsShenZhenDebug");
		IsShenZhenDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShenZhenDebug_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsShenZhenDebug_ReturnValue_PropertyAddress, IsShenZhenDebug_FunctionAddress, "ReturnValue");
		IsShenZhenDebug_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsShenZhenDebug_FunctionAddress, "ReturnValue");
		IsShenZhenDebug_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsShenZhenDebug_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShenZhenDebug_IsValid = IsShenZhenDebug_FunctionAddress != IntPtr.Zero && IsShenZhenDebug_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibGMCS:IsShenZhenDebug", IsShenZhenDebug_IsValid);
		PrintTestECSWorldObj_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrintTestECSWorldObj");
		PrintTestECSWorldObj_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintTestECSWorldObj_FunctionAddress);
		PrintTestECSWorldObj_Chr_Offset = NativeReflection.GetPropertyOffset(PrintTestECSWorldObj_FunctionAddress, "Chr");
		PrintTestECSWorldObj_Chr_IsValid = NativeReflection.ValidatePropertyClass(PrintTestECSWorldObj_FunctionAddress, "Chr", Classes.FObjectProperty);
		PrintTestECSWorldObj_IsValid = PrintTestECSWorldObj_FunctionAddress != IntPtr.Zero && PrintTestECSWorldObj_Chr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibGMCS:PrintTestECSWorldObj", PrintTestECSWorldObj_IsValid);
		TestDestroyECSWorldObj_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestDestroyECSWorldObj");
		TestDestroyECSWorldObj_ParamsSize = NativeReflection.GetFunctionParamsSize(TestDestroyECSWorldObj_FunctionAddress);
		TestDestroyECSWorldObj_Chr_Offset = NativeReflection.GetPropertyOffset(TestDestroyECSWorldObj_FunctionAddress, "Chr");
		TestDestroyECSWorldObj_Chr_IsValid = NativeReflection.ValidatePropertyClass(TestDestroyECSWorldObj_FunctionAddress, "Chr", Classes.FObjectProperty);
		TestDestroyECSWorldObj_IsValid = TestDestroyECSWorldObj_FunctionAddress != IntPtr.Zero && TestDestroyECSWorldObj_Chr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibGMCS:TestDestroyECSWorldObj", TestDestroyECSWorldObj_IsValid);
		TestReleaseECSWorldObjRef_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestReleaseECSWorldObjRef");
		TestReleaseECSWorldObjRef_ParamsSize = NativeReflection.GetFunctionParamsSize(TestReleaseECSWorldObjRef_FunctionAddress);
		TestReleaseECSWorldObjRef_Chr_Offset = NativeReflection.GetPropertyOffset(TestReleaseECSWorldObjRef_FunctionAddress, "Chr");
		TestReleaseECSWorldObjRef_Chr_IsValid = NativeReflection.ValidatePropertyClass(TestReleaseECSWorldObjRef_FunctionAddress, "Chr", Classes.FObjectProperty);
		TestReleaseECSWorldObjRef_IsValid = TestReleaseECSWorldObjRef_FunctionAddress != IntPtr.Zero && TestReleaseECSWorldObjRef_Chr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibGMCS:TestReleaseECSWorldObjRef", TestReleaseECSWorldObjRef_IsValid);
	}
}
