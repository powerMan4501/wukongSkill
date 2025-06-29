using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ArchiveB1;
using b1.BGW;
using b1.Editor;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using b1.Plugins.GSAnimationKeyBlender;
using b1.Plugins.GSInput;
using b1.UI;
using b1.UI.Comm;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using GSDispLib;
using GSE.GSNet;
using GSE.GSSdk;
using GSE.OnlineBase;
using GurGsPersistent;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Generated;
using ILRuntime.Runtime.Intepreter;
using LitJson;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.MediaAssets;
using UnrealEngine.MovieScene;
using UnrealEngine.Plugins.BinkMediaPlayer;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ILRuntimeMgr")]
public class BGW_ILRuntimeMgr : BGW_ScriptMgr
{
	private enum EILRuntimeFileExtension
	{
		Dll,
		Pdb,
		Mdb
	}

	private ILRuntime.Runtime.Enviorment.AppDomain _appdomain;

	private object[] params0 = new object[0];

	private object[] params1 = new object[1];

	private object[] params2 = new object[2];

	private object[] params3 = new object[3];

	private object[] params4 = new object[4];

	private object[] params5 = new object[5];

	private float DeltaTimeSkipLock;

	private Dictionary<string, IMethod> ILRuntimeMethodCache;

	private static List<Stream> DllFileStreams;

	private static List<Stream> SymbolFileStreams;

	private bool GameAssemblyLoaded;

	public static BGW_ILRuntimeMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ILRuntimeMgr>(WorldContext);
	}

	public override void OnInit()
	{
		ILRuntimeMethodCache = new Dictionary<string, IMethod>();
		InitILRuntime();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		StopILRuntime();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GameAssemblyLoaded)
		{
			DeltaTimeSkipLock += DeltaTime;
			params1[0] = DeltaTimeSkipLock;
			DeltaTimeSkipLock = 0f;
			GameProcessTick(_appdomain, null, params1);
		}
	}

	public static void LoadScriptAssemblyFile(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		LoadAssemblyFile(appdomain, "B1UI_GSE.Script.dll", bClrbinding: false);
	}

	public static void LoadAssemblyFileForClrbinding(ILRuntime.Runtime.Enviorment.AppDomain appdomain, int bClrbinding)
	{
		if (bClrbinding == 1)
		{
			LoadAssemblyFile(appdomain, "B1UI_GSE.Script.dll", bClrbinding: true);
		}
		else
		{
			LoadAssemblyFile(appdomain, "B1UI_GSE.Script.dll", bClrbinding: false);
		}
	}

	public void LoadGameAssemblyFile()
	{
		LoadScriptAssemblyFile(_appdomain);
	}

	public void StartILRuntime()
	{
		if (_appdomain == null)
		{
			if (DebugConfig.ILRuntimeJITOnDemand)
			{
				_appdomain = new ILRuntime.Runtime.Enviorment.AppDomain(1);
			}
			else
			{
				_appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
			}
		}
	}

	private void InitILRuntime()
	{
		if (_appdomain == null)
		{
			StartILRuntime();
		}
		RegisterCrossBinding(_appdomain);
		if (DebugConfig.Clrbinding)
		{
			ILRuntime.Runtime.Generated.CLRBindings.Initialize(_appdomain);
		}
		LoadGameAssemblyFile();
		GameAssemblyLoaded = true;
		GameProcessInit(_appdomain, null);
		if (DebugConfig.ILRuntimeDebugger)
		{
			_appdomain.DebugService.StartDebugService();
		}
	}

	public void InitILRuntimeDebugger(int Port, bool boardcastDebuggerInfo = true)
	{
		if (_appdomain == null)
		{
			throw new Exception("InitILRuntimeDebugger fail, _appdomain == null");
		}
		_appdomain.DebugService.StartDebugService(Port, boardcastDebuggerInfo);
		DebugConfig.ILRuntimeDebugger = true;
		BGW_LogUtil.LogError($"InitILRuntimeDebugger Port = {Process.GetCurrentProcess().Id + Port}");
	}

	public static void ClearFileStreams()
	{
		foreach (Stream dllFileStream in DllFileStreams)
		{
			dllFileStream.Close();
		}
		DllFileStreams.Clear();
		foreach (Stream symbolFileStream in SymbolFileStreams)
		{
			symbolFileStream.Close();
		}
		SymbolFileStreams.Clear();
	}

	public static void RegisterAllAutoGenCrossBindAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_BooleanAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_ByteStringAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_DoubleAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_Int32Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_Int64Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_SingleAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_StringAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_UInt32Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_UInt64Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_BooleanAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerableAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_ByteStringAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_DoubleAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_Int32Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_Int64Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_SingleAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_StringAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_UInt32Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_UInt64Adapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerable_1_ILTypeInstanceAdapter());
		appdomain.RegisterCrossBindingAdaptor(new IEnumerator_1_ILTypeInstanceAdapter());
		appdomain.RegisterCrossBindingAdaptor(new ISerializedManagedUnrealModuleInfoAdapter());
	}

	public static void RegisterCrossBinding(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		JsonMapper.RegisterILRuntimeCLRRedirection(appdomain);
		appdomain.RegisterCrossBindingAdaptor(new Adapt_IMessage());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_UUserWidget());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_CrashTest());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_Exception());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_IGSMUIDestruct());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_IGSMUITickable());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_IAutoSizeItem());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_FSMState_GI_GlobalBase());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_FSMState_GI_LoadingBase());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_FSMConditionBase());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_BGU_LeakLogUtil());
		appdomain.RegisterCrossBindingAdaptor(new Adapt_TravelLevelTemplateBase());
		appdomain.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor());
		RegisterDelegateAdapter(appdomain);
		RegisterDelegateConvertor(appdomain);
	}

	public static void LoadAssemblyFile(ILRuntime.Runtime.Enviorment.AppDomain appdomain, string FileName, bool bClrbinding)
	{
		FileName = Regex.Replace(FileName, "^(.*?)(\\.dll)?$", "$1");
		LoadAssemblyFileAndSymbol(appdomain, FileName, bClrbinding, IsWithSymbol: false);
	}

	private static bool TryGetStream(string FileName, EILRuntimeFileExtension Extension, bool bClrBinding, out Stream OutStream)
	{
		OutStream = null;
		string text = ((!bClrBinding) ? FPaths.Combine("/Binary", "Win64/Managed", FileName) : FPaths.Combine("/Tool", "ClrbindingGen", "Shipping", FileName));
		if (UGSFileHelper.ReadFile(text + "." + StringParseHelper.SafeToLower(Extension.ToString()), out var BytesToRead))
		{
			OutStream = new MemoryStream(BytesToRead.ToArray());
			return true;
		}
		return false;
	}

	private static bool TryGetSymbolStream(string FileName, bool bClrBinding, out Stream OutStream, out EILRuntimeFileExtension SymbolExtension)
	{
		if (TryGetStream(FileName, EILRuntimeFileExtension.Pdb, bClrBinding, out OutStream))
		{
			SymbolExtension = EILRuntimeFileExtension.Pdb;
			return true;
		}
		if (TryGetStream(FileName, EILRuntimeFileExtension.Mdb, bClrBinding, out OutStream))
		{
			SymbolExtension = EILRuntimeFileExtension.Mdb;
			return true;
		}
		SymbolExtension = EILRuntimeFileExtension.Dll;
		return false;
	}

	public static void LoadAssemblyFileAndSymbol(ILRuntime.Runtime.Enviorment.AppDomain appdomain, string FileName, bool bClrBinding, bool IsWithSymbol)
	{
		if (!TryGetStream(FileName, EILRuntimeFileExtension.Dll, bClrBinding, out var OutStream))
		{
			return;
		}
		DllFileStreams.Add(OutStream);
		Stream OutStream2;
		EILRuntimeFileExtension SymbolExtension;
		if (!IsWithSymbol)
		{
			appdomain.LoadAssembly(OutStream);
		}
		else if (TryGetSymbolStream(FileName, bClrBinding, out OutStream2, out SymbolExtension))
		{
			SymbolFileStreams.Add(OutStream2);
			switch (SymbolExtension)
			{
			case EILRuntimeFileExtension.Pdb:
				appdomain.LoadAssemblyPDB(OutStream, OutStream2);
				break;
			case EILRuntimeFileExtension.Mdb:
				appdomain.LoadAssemblyMDB(OutStream, OutStream2);
				break;
			default:
				throw new FileNotFoundException("Can not find symbol of " + FileName);
			}
		}
	}

	public static void RegisterDelegateConvertor(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<float>>((Delegate act) => (Comparison<float>)((float x, float y) => ((Func<float, float, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<string>>((Delegate act) => (Comparison<string>)((string x, string y) => ((Func<string, string, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<ExporterFunc<float>>((Delegate act) => (ExporterFunc<float>)delegate(float obj, JsonWriter writer)
		{
			((Action<float, JsonWriter>)act)(obj, writer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ImporterFunc<double, float>>((Delegate act) => (ImporterFunc<double, float>)((double input) => ((Func<double, float>)act)(input)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_AcitveBlackOutWithCallback>((Delegate act) => (Del_AcitveBlackOutWithCallback)delegate(bool IsActive, Del_Void Callback, float DelayTime, FColor Color, bool IsPauseWorld)
		{
			((Action<bool, Del_Void, float, FColor, bool>)act)(IsActive, Callback, DelayTime, Color, IsPauseWorld);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnUserScrolledEvent.Signature>((Delegate act) => (FOnUserScrolledEvent.Signature)delegate(float CurrentOffset)
		{
			((Action<float>)act)(CurrentOffset);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_ActorActor>((Delegate act) => (Del_Void_ActorActor)delegate(AActor Actor1, AActor Actor2)
		{
			((Action<AActor, AActor>)act)(Actor1, Actor2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ActiveCricketName>((Delegate act) => (BGW_UIEventCollection.Del_UI_ActiveCricketName)delegate(bool B1, int P1, string S1, float F1)
		{
			((Action<bool, int, string, float>)act)(B1, P1, S1, F1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnMovieSceneSequencePlayerEvent.Signature>((Delegate act) => (FOnMovieSceneSequencePlayerEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<ILTypeInstance>>((Delegate act) => (Comparison<ILTypeInstance>)((ILTypeInstance x, ILTypeInstance y) => ((Func<ILTypeInstance, ILTypeInstance, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<ILTypeInstance>>((Delegate act) => (Predicate<ILTypeInstance>)((ILTypeInstance obj) => ((Func<ILTypeInstance, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void>((Delegate act) => (Del_Void)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGWGameInstanceCS.Del_PreLoginHandle>((Delegate act) => (BGWGameInstanceCS.Del_PreLoginHandle)((string Options, string LoginAddress, string UniqueId) => ((Func<string, string, string, string>)act)(Options, LoginAddress, UniqueId)));
		appdomain.DelegateManager.RegisterDelegateConvertor<GSLocalPlayerCS.Del_FillGameLoginOptions>((Delegate act) => (GSLocalPlayerCS.Del_FillGameLoginOptions)((GSLocalPlayerCS LocalPlayer) => ((Func<GSLocalPlayerCS, string>)act)(LocalPlayer)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowDropMainSpacial>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowDropMainSpacial)delegate(ItemOne ItemData)
		{
			((Action<ItemOne>)act)(ItemData);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ReverseProxyChannel.OnClientMsgBuffRecvHandler>((Delegate act) => (ReverseProxyChannel.OnClientMsgBuffRecvHandler)delegate(ulong roleid, byte[] buffer)
		{
			((Action<ulong, byte[]>)act)(roleid, buffer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_Bool>((Delegate act) => (Del_Void_Bool)delegate(bool param)
		{
			((Action<bool>)act)(param);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_DraggableV2.OnScrollingDelegate>((Delegate act) => (BUI_DraggableV2.OnScrollingDelegate)delegate(float curDragOffset, float totlaDragOffset, bool isPressed)
		{
			((Action<float, float, bool>)act)(curDragOffset, totlaDragOffset, isPressed);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_DraggableV2.OnDragIngDelegate>((Delegate act) => (BUI_DraggableV2.OnDragIngDelegate)delegate(FVector2D curDragOffset, FVector2D totalDragOffset, float curSpeed)
		{
			((Action<FVector2D, FVector2D, float>)act)(curDragOffset, totalDragOffset, curSpeed);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_DraggableV2.OnDragBeginDelegate>((Delegate act) => (BUI_DraggableV2.OnDragBeginDelegate)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_DraggableV2.OnDragEndDelegate>((Delegate act) => (BUI_DraggableV2.OnDragEndDelegate)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_Widget.OnMouseButtonDelegate>((Delegate act) => (BUI_Widget.OnMouseButtonDelegate)delegate(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			((Action<FGeometry, FPointerEvent>)act)(MyGeometry, MouseEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnCheckBoxComponentStateChanged.Signature>((Delegate act) => (FOnCheckBoxComponentStateChanged.Signature)delegate(bool bIsChecked)
		{
			((Action<bool>)act)(bIsChecked);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnMediaPlayerMediaEvent.Signature>((Delegate act) => (FOnMediaPlayerMediaEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnBinkMediaPlayerMediaReachedEnd.Signature>((Delegate act) => (FOnBinkMediaPlayerMediaReachedEnd.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnButtonClickedEvent.Signature>((Delegate act) => (FOnButtonClickedEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnButtonPressedEvent.Signature>((Delegate act) => (FOnButtonPressedEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UWidget.FOnPointerEvent.Signature>((Delegate act) => (UWidget.FOnPointerEvent.Signature)((FGeometry MyGeometry, FPointerEvent MouseEvent) => ((Func<FGeometry, FPointerEvent, FEventReply>)act)(MyGeometry, MouseEvent)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnUserScrolledEvent.Signature>((Delegate act) => (FOnUserScrolledEvent.Signature)delegate(float CurrentOffset)
		{
			((Action<float>)act)(CurrentOffset);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnMovieSceneSequencePlayerEvent.Signature>((Delegate act) => (FOnMovieSceneSequencePlayerEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnButtonCheckStateChanged.Signature>((Delegate act) => (FGSOnButtonCheckStateChanged.Signature)delegate(int GSID, bool bIsChecked)
		{
			((Action<int, bool>)act)(GSID, bIsChecked);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UEditableTextBox.FOnEditableTextBoxCommittedEvent.Signature>((Delegate act) => (UEditableTextBox.FOnEditableTextBoxCommittedEvent.Signature)delegate(FText Text, ETextCommit CommitMethod)
		{
			((Action<FText, ETextCommit>)act)(Text, CommitMethod);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UEditableTextBox.FOnEditableTextBoxChangedEvent.Signature>((Delegate act) => (UEditableTextBox.FOnEditableTextBoxChangedEvent.Signature)delegate(FText Text)
		{
			((Action<FText>)act)(Text);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent>((Delegate act) => (BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent)delegate(EGI_Global Evnet, object InputParams)
		{
			((Action<EGI_Global, object>)act)(Evnet, InputParams);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature>((Delegate act) => (UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature)delegate(FText Text, ETextCommit CommitMethod)
		{
			((Action<FText, ETextCommit>)act)(Text, CommitMethod);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FWidgetAnimationDynamicEvent.Signature>((Delegate act) => (FWidgetAnimationDynamicEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnFloatValueChangedEvent.Signature>((Delegate act) => (FOnFloatValueChangedEvent.Signature)delegate(float Value)
		{
			((Action<float>)act)(Value);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnAkPostEventCallback.Signature>((Delegate act) => (FOnAkPostEventCallback.Signature)delegate(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			((Action<EAkCallbackType, UAkCallbackInfo>)act)(CallbackType, CallbackInfo);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UComboBoxString.FOnSelectionChangedEvent.Signature>((Delegate act) => (UComboBoxString.FOnSelectionChangedEvent.Signature)delegate(string SelectedItem, ESelectInfo SelectionType)
		{
			((Action<string, ESelectInfo>)act)(SelectedItem, SelectionType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateBegin.Signature>((Delegate act) => (FGSOnAKBStateBegin.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateInterupt.Signature>((Delegate act) => (FGSOnAKBStateInterupt.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateEnd.Signature>((Delegate act) => (FGSOnAKBStateEnd.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnInputAction.Signature>((Delegate act) => (FOnInputAction.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnMediaPlayerMediaEvent.Signature>((Delegate act) => (FOnMediaPlayerMediaEvent.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnCheckBoxComponentStateChanged.Signature>((Delegate act) => (FOnCheckBoxComponentStateChanged.Signature)delegate(bool bIsChecked)
		{
			((Action<bool>)act)(bIsChecked);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UInputKeySelector.FOnIsSelectingKeyChanged.Signature>((Delegate act) => (UInputKeySelector.FOnIsSelectingKeyChanged.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UInputKeySelector.FOnKeySelected.Signature>((Delegate act) => (UInputKeySelector.FOnKeySelected.Signature)delegate(FInputChord SelectedKey)
		{
			((Action<FInputChord>)act)(SelectedKey);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UInputKeySelector.FOnKeySelected.Signature>((Delegate act) => (UInputKeySelector.FOnKeySelected.Signature)delegate(FInputChord SelectedKey)
		{
			((Action<FInputChord>)act)(SelectedKey);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<uint>>((Delegate act) => (Predicate<uint>)((uint obj) => ((Func<uint, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature>((Delegate act) => (UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature)delegate(FText a, ETextCommit b)
		{
			((Action<FText, ETextCommit>)act)(a, b);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_LevelStreamingManger.LevelLatentActionDel>((Delegate act) => (BGW_LevelStreamingManger.LevelLatentActionDel)delegate(FName LevelName, int state)
		{
			((Action<FName, int>)act)(LevelName, state);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<Adapt_IMessage.Adaptor>>((Delegate act) => (Comparison<Adapt_IMessage.Adaptor>)((Adapt_IMessage.Adaptor x, Adapt_IMessage.Adaptor y) => ((Func<Adapt_IMessage.Adaptor, Adapt_IMessage.Adaptor, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<CrashTest.Del_Void>((Delegate act) => (CrashTest.Del_Void)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<int>>((Delegate act) => (Predicate<int>)((int obj) => ((Func<int, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<int>>((Delegate act) => (Comparison<int>)((int x, int y) => ((Func<int, int, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FOnAkPostEventCallback.Signature>((Delegate act) => (FOnAkPostEventCallback.Signature)delegate(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			((Action<EAkCallbackType, UAkCallbackInfo>)act)(CallbackType, CallbackInfo);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ObjectsLoadedCallBack>((Delegate act) => (ObjectsLoadedCallBack)delegate(List<FSoftObjectPath> RequestPaths, List<UObject> LoadedObjects, object UserData)
		{
			((Action<List<FSoftObjectPath>, List<UObject>, object>)act)(RequestPaths, LoadedObjects, UserData);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_PlayerController>((Delegate act) => (BGW_EventCollection.Del_PlayerController)delegate(APlayerController PlayerController)
		{
			((Action<APlayerController>)act)(PlayerController);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<WaitCallback>((Delegate act) => (WaitCallback)delegate(object state)
		{
			((Action<object>)act)(state);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UWidget.FOnPointerEvent.Signature>((Delegate act) => (UWidget.FOnPointerEvent.Signature)((FGeometry MyGeometry, FPointerEvent MouseEvent) => ((Func<FGeometry, FPointerEvent, FEventReply>)act)(MyGeometry, MouseEvent)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BWS_DispLibEventCollection.Del_VoidTwoIntString>((Delegate act) => (BWS_DispLibEventCollection.Del_VoidTwoIntString)delegate(int IntValue0, int IntValue1, string StringValue)
		{
			((Action<int, int, string>)act)(IntValue0, IntValue1, StringValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FSimpleMulticastDelegate>((Delegate act) => (FSimpleMulticastDelegate)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UApplicationLifecycleComponent.FApplicationLifetimeDelegate.Signature>((Delegate act) => (UApplicationLifecycleComponent.FApplicationLifetimeDelegate.Signature)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GlobalAudioMgr.OnAppBackGroundDelegate>((Delegate act) => (GlobalAudioMgr.OnAppBackGroundDelegate)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GlobalAudioMgr.OnAppForeGroundDelegate>((Delegate act) => (GlobalAudioMgr.OnAppForeGroundDelegate)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_Srt>((Delegate act) => (BGW_UIEventCollection.Del_UI_Srt)delegate(Srt Srt)
		{
			((Action<Srt>)act)(Srt);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_Void_Bool>((Delegate act) => (BGW_UIEventCollection.Del_UI_Void_Bool)delegate(bool B1)
		{
			((Action<bool>)act)(B1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_Void>((Delegate act) => (BGW_UIEventCollection.Del_UI_Void)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_UnitCastSkillFail>((Delegate act) => (Del_UnitCastSkillFail)delegate(int SkillID, ECanCastSkillResult FailReason)
		{
			((Action<int, ECanCastSkillResult>)act)(SkillID, FailReason);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Param_APawn>((Delegate act) => (Del_Param_APawn)delegate(APawn Pawn)
		{
			((Action<APawn>)act)(Pawn);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_BossBornOrDead>((Delegate act) => (BGW_UIEventCollection.Del_UI_BossBornOrDead)delegate(AActor BossActor, bool IsBorn)
		{
			((Action<AActor, bool>)act)(BossActor, IsBorn);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_Void_Int>((Delegate act) => (BGW_UIEventCollection.Del_UI_Void_Int)delegate(int p1)
		{
			((Action<int>)act)(p1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_MultiKill>((Delegate act) => (BGW_UIEventCollection.Del_UI_MultiKill)delegate(float P1, int P2, int P3, float P4)
		{
			((Action<float, int, int, float>)act)(P1, P2, P3, P4);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_IntBool>((Delegate act) => (BGW_UIEventCollection.Del_UI_IntBool)delegate(int P1, bool B1)
		{
			((Action<int, bool>)act)(P1, B1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_IntInt>((Delegate act) => (BGW_UIEventCollection.Del_UI_IntInt)delegate(int P1, int P2)
		{
			((Action<int, int>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_BoolBoolInt>((Delegate act) => (Del_Void_BoolBoolInt)delegate(bool P1, bool P2, int P3)
		{
			((Action<bool, bool, int>)act)(P1, P2, P3);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_Int>((Delegate act) => (Del_Void_Int)delegate(int P1)
		{
			((Action<int>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_TriggerDropItemEffect>((Delegate act) => (Del_TriggerDropItemEffect)delegate(ItemOne DropItemOne)
		{
			((Action<ItemOne>)act)(DropItemOne);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_StringFloat>((Delegate act) => (BGW_UIEventCollection.Del_UI_StringFloat)delegate(string S1, float F1)
		{
			((Action<string, float>)act)(S1, F1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_StrStrFloat>((Delegate act) => (BGW_UIEventCollection.Del_UI_StrStrFloat)delegate(string S1, string S2, float F1, bool B1, bool B2)
		{
			((Action<string, string, float, bool, bool>)act)(S1, S2, F1, B1, B2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_AbnormalRemoved>((Delegate act) => (Del_AbnormalRemoved)delegate(EAbnormalStateType AbnormalType)
		{
			((Action<EAbnormalStateType>)act)(AbnormalType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_OnTrigerAbnormalFinalEffect>((Delegate act) => (Del_OnTrigerAbnormalFinalEffect)delegate(EAbnormalStateType AbnormalType, int BuffID)
		{
			((Action<EAbnormalStateType, int>)act)(AbnormalType, BuffID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_HandleAbnormal>((Delegate act) => (Del_HandleAbnormal)delegate(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel)
		{
			((Action<EAbnormalStateType, AActor, EAccAbnormalValueType, float, int>)act)(AbnormalType, Attacker, AccType, IncreaseValue, AbnormalLevel);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_Actor>((Delegate act) => (Del_Void_Actor)delegate(AActor Actor)
		{
			((Action<AActor>)act)(Actor);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_AddTeamPlayer>((Delegate act) => (BGW_UIEventCollection.Del_UI_AddTeamPlayer)delegate(AActor Player)
		{
			((Action<AActor>)act)(Player);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_RemoveTeamPlayer>((Delegate act) => (BGW_UIEventCollection.Del_UI_RemoveTeamPlayer)delegate(AActor Player)
		{
			((Action<AActor>)act)(Player);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowRebirthPointUI>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowRebirthPointUI)delegate(int RebirthPointID)
		{
			((Action<int>)act)(RebirthPointID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_OnPlayerPostLogin>((Delegate act) => (Del_OnPlayerPostLogin)delegate(APlayerController PlayerController)
		{
			((Action<APlayerController>)act)(PlayerController);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Param_RoleData>((Delegate act) => (Del_Param_RoleData)delegate(List<byte> RoleData)
		{
			((Action<List<byte>>)act)(RoleData);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_IntInt>((Delegate act) => (Del_Void_IntInt)delegate(int P1, int P2)
		{
			((Action<int, int>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_EnterInteractActiveArea>((Delegate act) => (Del_EnterInteractActiveArea)delegate(AActor Actor, EInteractType InType)
		{
			((Action<AActor, EInteractType>)act)(Actor, InType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_UnitRebirth>((Delegate act) => (Del_UnitRebirth)delegate(ERebirthType RebirthType)
		{
			((Action<ERebirthType>)act)(RebirthType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UComboBoxString.FOnSelectionChangedEvent.Signature>((Delegate act) => (UComboBoxString.FOnSelectionChangedEvent.Signature)delegate(string SelectedItem, ESelectInfo SelectionType)
		{
			((Action<string, ESelectInfo>)act)(SelectedItem, SelectionType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_Float>((Delegate act) => (BGW_UIEventCollection.Del_UI_Float)delegate(float P1)
		{
			((Action<float>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_BoolInt>((Delegate act) => (Del_Void_BoolInt)delegate(bool P1, int P2)
		{
			((Action<bool, int>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<RoleItem>>((Delegate act) => (Predicate<RoleItem>)((RoleItem obj) => ((Func<RoleItem, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BGS_OnUnitTransited>((Delegate act) => (Del_BGS_OnUnitTransited)delegate(AActor OldUnit, AActor NewlySpawnedUnit)
		{
			((Action<AActor, AActor>)act)(OldUnit, NewlySpawnedUnit);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<RoleEquip>>((Delegate act) => (Predicate<RoleEquip>)((RoleEquip obj) => ((Func<RoleEquip, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<TalentOne>>((Delegate act) => (Predicate<TalentOne>)((TalentOne obj) => ((Func<TalentOne, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<SpellType>>((Delegate act) => (Predicate<SpellType>)((SpellType obj) => ((Func<SpellType, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_StringList>((Delegate act) => (Del_Void_StringList)delegate(List<string> P)
		{
			((Action<List<string>>)act)(P);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_PlayerState>((Delegate act) => (BGW_EventCollection.Del_PlayerState)delegate(APlayerState State)
		{
			((Action<APlayerState>)act)(State);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_UnitDeadDropItem>((Delegate act) => (Del_UnitDeadDropItem)delegate(AActor Victim, AActor Attacker, EDeadReason DeadReason)
		{
			((Action<AActor, AActor, EDeadReason>)act)(Victim, Attacker, DeadReason);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BGS_Void>((Delegate act) => (Del_BGS_Void)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<MonsterCollection>>((Delegate act) => (Predicate<MonsterCollection>)((MonsterCollection obj) => ((Func<MonsterCollection, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineAchievement.Del_OnAchievementsWritten>((Delegate act) => (BGW_OnlineAchievement.Del_OnAchievementsWritten)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineCloud.Del_OnEnumerateUserFiles>((Delegate act) => (BGW_OnlineCloud.Del_OnEnumerateUserFiles)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineCloud.Del_OnReadUserFiles>((Delegate act) => (BGW_OnlineCloud.Del_OnReadUserFiles)delegate(string filename, bool bWasSuccessful)
		{
			((Action<string, bool>)act)(filename, bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineCloud.Del_OnWriteUserCloudFile>((Delegate act) => (BGW_OnlineCloud.Del_OnWriteUserCloudFile)delegate(string filename, bool bWasSuccessful)
		{
			((Action<string, bool>)act)(filename, bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineActivity.Del_OnStartActivityComplete>((Delegate act) => (BGW_OnlineActivity.Del_OnStartActivityComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineActivity.Del_OnResetAllActiveActivitiesComplete>((Delegate act) => (BGW_OnlineActivity.Del_OnResetAllActiveActivitiesComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ActiveName>((Delegate act) => (BGW_UIEventCollection.Del_UI_ActiveName)delegate(bool B1, int P1, float F1)
		{
			((Action<bool, int, float>)act)(B1, P1, F1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_BoolIntFloat>((Delegate act) => (Del_Void_BoolIntFloat)delegate(bool P1, int P2, float P3)
		{
			((Action<bool, int, float>)act)(P1, P2, P3);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_IntBool>((Delegate act) => (Del_Void_IntBool)delegate(int P1, bool P2)
		{
			((Action<int, bool>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineFriend.Del_OnReadFriendList>((Delegate act) => (BGW_OnlineFriend.Del_OnReadFriendList)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<FItemWithTag>>((Delegate act) => (Comparison<FItemWithTag>)((FItemWithTag x, FItemWithTag y) => ((Func<FItemWithTag, FItemWithTag, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineActivity.Del_OnResumeActivityComplete>((Delegate act) => (BGW_OnlineActivity.Del_OnResumeActivityComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_BoolBool>((Delegate act) => (Del_Void_BoolBool)delegate(bool P1, bool P2)
		{
			((Action<bool, bool>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FCustomWidgetNavigationDelegate.Signature>((Delegate act) => (FCustomWidgetNavigationDelegate.Signature)((EUINavigation Navigation) => ((Func<EUINavigation, UWidget>)act)(Navigation)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_UnitTriggerDead>((Delegate act) => (Del_UnitTriggerDead)delegate(AActor Attacker, EDeadReason DeadReason, int DmgID)
		{
			((Action<AActor, EDeadReason, int>)act)(Attacker, DeadReason, DmgID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BUI_Button.Del_SetBtnStateEvent.Signature>((Delegate act) => (BUI_Button.Del_SetBtnStateEvent.Signature)delegate(ButtonUIStat BtnStat)
		{
			((Action<ButtonUIStat>)act)(BtnStat);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<Action<EBGUAttrFloat, float>>>((Delegate act) => (Predicate<Action<EBGUAttrFloat, float>>)((Action<EBGUAttrFloat, float> obj) => ((Func<Action<EBGUAttrFloat, float>, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_PlayerStateBeginPlay>((Delegate act) => (Del_PlayerStateBeginPlay)delegate(AActor PlayerState)
		{
			((Action<AActor>)act)(PlayerState);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowMapTips>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowMapTips)delegate(bool IsUIWord, int Id)
		{
			((Action<bool, int>)act)(IsUIWord, Id);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_SendOnlineScreenMsg>((Delegate act) => (Del_SendOnlineScreenMsg)delegate(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
		{
			((Action<EScreenMsgType, string, int>)act)(ScreenMsgType, Msg, TipsDuration);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<FIntPoint>>((Delegate act) => (Comparison<FIntPoint>)((FIntPoint x, FIntPoint y) => ((Func<FIntPoint, FIntPoint, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<FIntPoint>>((Delegate act) => (Predicate<FIntPoint>)((FIntPoint obj) => ((Func<FIntPoint, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_TriggerCostItemSvr>((Delegate act) => (Del_TriggerCostItemSvr)delegate(List<ItemOne> ItemList, OPReason Reason)
		{
			((Action<List<ItemOne>, OPReason>)act)(ItemList, Reason);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<string>>((Delegate act) => (Predicate<string>)((string obj) => ((Func<string, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BGS_Int>((Delegate act) => (Del_BGS_Int)delegate(int P1)
		{
			((Action<int>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_ItemDropToUI>((Delegate act) => (Del_ItemDropToUI)delegate(FDropItem ItemData)
		{
			((Action<FDropItem>)act)(ItemData);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_BGW_Bool>((Delegate act) => (BGW_EventCollection.Del_BGW_Bool)delegate(bool P1)
		{
			((Action<bool>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ChangeUnitBlood>((Delegate act) => (BGW_UIEventCollection.Del_UI_ChangeUnitBlood)delegate(EBGUBloodBarType BloodBarType, BGUCharacterCS Unit)
		{
			((Action<EBGUBloodBarType, BGUCharacterCS>)act)(BloodBarType, Unit);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_String>((Delegate act) => (Del_Void_String)delegate(string P1)
		{
			((Action<string>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_FText>((Delegate act) => (Del_Void_FText)delegate(FText P1)
		{
			((Action<FText>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<ArchiveSummaryData>>((Delegate act) => (Predicate<ArchiveSummaryData>)((ArchiveSummaryData obj) => ((Func<ArchiveSummaryData, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateEnd.Signature>((Delegate act) => (FGSOnAKBStateEnd.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateBegin.Signature>((Delegate act) => (FGSOnAKBStateBegin.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FGSOnAKBStateInterupt.Signature>((Delegate act) => (FGSOnAKBStateInterupt.Signature)delegate(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
		{
			((Action<FName, FName, bool>)act)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BGS_AttrInsuff>((Delegate act) => (Del_BGS_AttrInsuff)delegate(EAttrCostType CostType)
		{
			((Action<EAttrCostType>)act)(CostType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BGS_BoolInt>((Delegate act) => (Del_BGS_BoolInt)delegate(bool B1, int P2)
		{
			((Action<bool, int>)act)(B1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_FIntPoint>((Delegate act) => (Del_Void_FIntPoint)delegate(FIntPoint P1)
		{
			((Action<FIntPoint>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FSMRuntimeInstance_GI_Loading.Del_ConditionCreate>((Delegate act) => (FSMRuntimeInstance_GI_Loading.Del_ConditionCreate)((FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object Inputparams) => ((Func<FSMRuntimeInstance_GI_Loading, FCalliopeNode, object, FSMConditionBase>)act)(RuntimeInstance, Node, Inputparams)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FSMRuntimeInstance_GI_Loading.Del_StateCreate>((Delegate act) => (FSMRuntimeInstance_GI_Loading.Del_StateCreate)((FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object Inputparams) => ((Func<FSMRuntimeInstance_GI_Loading, FCalliopeNode, object, FSMState_GI_LoadingBase>)act)(RuntimeInstance, Node, Inputparams)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FSMRuntimeInstance_GI_Global.Del_ConditionCreate>((Delegate act) => (FSMRuntimeInstance_GI_Global.Del_ConditionCreate)((FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object Inputparams) => ((Func<FSMRuntimeInstance_GI_Global, FCalliopeNode, object, FSMConditionBase>)act)(RuntimeInstance, Node, Inputparams)));
		appdomain.DelegateManager.RegisterDelegateConvertor<FSMRuntimeInstance_GI_Global.Del_StateCreate>((Delegate act) => (FSMRuntimeInstance_GI_Global.Del_StateCreate)((FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object Inputparams) => ((Func<FSMRuntimeInstance_GI_Global, FCalliopeNode, object, FSMState_GI_GlobalBase>)act)(RuntimeInstance, Node, Inputparams)));
		appdomain.DelegateManager.RegisterDelegateConvertor<DelCustomWidgetNavigation>((Delegate act) => (DelCustomWidgetNavigation)((EUINavigation Navigation, bool IsReapeated) => ((Func<EUINavigation, bool, UWidget>)act)(Navigation, IsReapeated)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_Float>((Delegate act) => (Del_Void_Float)delegate(float P1)
		{
			((Action<float>)act)(P1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget>((Delegate act) => (BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget)((BGUCharacterCS OwnerUnit, EBGUBloodBarType BloodBarType, bool IsSelfTeam, bool IsPlayer) => ((Func<BGUCharacterCS, EBGUBloodBarType, bool, bool, BUI_MBarBase>)act)(OwnerUnit, BloodBarType, IsSelfTeam, IsPlayer)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget>((Delegate act) => (BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget)((BGUCharacterCS OwnerUnit) => ((Func<BGUCharacterCS, BUI_MPlayerInfo>)act)(OwnerUnit)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowHPChangeNum>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowHPChangeNum)delegate(DamageNumParam Param)
		{
			((Action<DamageNumParam>)act)(Param);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_SetPageActive>((Delegate act) => (BGW_UIEventCollection.Del_UI_SetPageActive)delegate(EUIPageID PageId, bool IsActive)
		{
			((Action<EUIPageID, bool>)act)(PageId, IsActive);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_SwitchPageActive>((Delegate act) => (BGW_UIEventCollection.Del_UI_SwitchPageActive)delegate(EUIPageID PageId)
		{
			((Action<EUIPageID>)act)(PageId);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineIdentity.Del_OnGetUserPrivilege>((Delegate act) => (BGW_OnlineIdentity.Del_OnGetUserPrivilege)delegate(EBGWUserPrivileges Privilege, EBGWPrivilegeResult PrivilegeResult)
		{
			((Action<EBGWUserPrivileges, EBGWPrivilegeResult>)act)(Privilege, PrivilegeResult);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineSession.Del_OnCreateSessionComplete>((Delegate act) => (BGW_OnlineSession.Del_OnCreateSessionComplete)delegate(bool Success)
		{
			((Action<bool>)act)(Success);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineSession.Del_OnSearchSessionsComplete>((Delegate act) => (BGW_OnlineSession.Del_OnSearchSessionsComplete)delegate(bool Success)
		{
			((Action<bool>)act)(Success);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineSession.Del_OnJoinSessionComplete>((Delegate act) => (BGW_OnlineSession.Del_OnJoinSessionComplete)delegate(EBGWJoinSessionResult Result)
		{
			((Action<EBGWJoinSessionResult>)act)(Result);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineSession.Del_OnFindSessionByIdComplete>((Delegate act) => (BGW_OnlineSession.Del_OnFindSessionByIdComplete)delegate(bool Success)
		{
			((Action<bool>)act)(Success);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGWGameInstanceCS.Del_UnrealPostLoginHandler>((Delegate act) => (BGWGameInstanceCS.Del_UnrealPostLoginHandler)delegate(APlayerController NewController)
		{
			((Action<APlayerController>)act)(NewController);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ScreenDebugDraw>((Delegate act) => (BGW_UIEventCollection.Del_UI_ScreenDebugDraw)delegate(FVector2D Point, FLinearColor Color, float Size, string InName)
		{
			((Action<FVector2D, FLinearColor, float, string>)act)(Point, Color, Size, InName);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_String>((Delegate act) => (BGW_UIEventCollection.Del_UI_String)delegate(string InName)
		{
			((Action<string>)act)(InName);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonPressed>((Delegate act) => (DelButtonPressed)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonClicked>((Delegate act) => (DelButtonClicked)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonLockClicked>((Delegate act) => (DelButtonLockClicked)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonReleased>((Delegate act) => (DelButtonReleased)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonFocused>((Delegate act) => (DelButtonFocused)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonUnfocused>((Delegate act) => (DelButtonUnfocused)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonHovered>((Delegate act) => (DelButtonHovered)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonUnhovered>((Delegate act) => (DelButtonUnhovered)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonPressing>((Delegate act) => (DelButtonPressing)delegate(int GSID, float InDeltaTime, float PressedTotalTime)
		{
			((Action<int, float, float>)act)(GSID, InDeltaTime, PressedTotalTime);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonHoveredChange>((Delegate act) => (DelButtonHoveredChange)delegate(int GSID, bool IsHovered)
		{
			((Action<int, bool>)act)(GSID, IsHovered);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonFocusedChange>((Delegate act) => (DelButtonFocusedChange)delegate(int GSID, bool IsFocused)
		{
			((Action<int, bool>)act)(GSID, IsFocused);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonAimingChange>((Delegate act) => (DelButtonAimingChange)delegate(int GSID, bool IsAiming)
		{
			((Action<int, bool>)act)(GSID, IsAiming);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonMouseStayIn>((Delegate act) => (DelButtonMouseStayIn)delegate(int GSID)
		{
			((Action<int>)act)(GSID);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<DelButtonCheckStateChanged>((Delegate act) => (DelButtonCheckStateChanged)delegate(int GSID, bool IsChecked)
		{
			((Action<int, bool>)act)(GSID, IsChecked);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.KeyDown>((Delegate act) => (FInputDelegate.KeyDown)delegate(FKeyEvent KeyEvent)
		{
			((Action<FKeyEvent>)act)(KeyEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.KeyUp>((Delegate act) => (FInputDelegate.KeyUp)delegate(FKeyEvent KeyEvent)
		{
			((Action<FKeyEvent>)act)(KeyEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.MouseButtonDown>((Delegate act) => (FInputDelegate.MouseButtonDown)delegate(FPointerEvent PointerEvent)
		{
			((Action<FPointerEvent>)act)(PointerEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.MouseButtonUp>((Delegate act) => (FInputDelegate.MouseButtonUp)delegate(FPointerEvent PointerEvent)
		{
			((Action<FPointerEvent>)act)(PointerEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.AnalogEvent>((Delegate act) => (FInputDelegate.AnalogEvent)delegate(FAnalogInputEvent AnalogInputEvent)
		{
			((Action<FAnalogInputEvent>)act)(AnalogInputEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<TStrongObjectPtr<UserObjectListEntryParams>>>((Delegate act) => (Predicate<TStrongObjectPtr<UserObjectListEntryParams>>)((TStrongObjectPtr<UserObjectListEntryParams> obj) => ((Func<TStrongObjectPtr<UserObjectListEntryParams>, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineAchievement.Del_OnQueryAchievements>((Delegate act) => (BGW_OnlineAchievement.Del_OnQueryAchievements)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<ArchiveSummaryData>>((Delegate act) => (Comparison<ArchiveSummaryData>)((ArchiveSummaryData x, ArchiveSummaryData y) => ((Func<ArchiveSummaryData, ArchiveSummaryData, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<Tuple<ILTypeInstance, ILTypeInstance>>>((Delegate act) => (Predicate<Tuple<ILTypeInstance, ILTypeInstance>>)((Tuple<ILTypeInstance, ILTypeInstance> obj) => ((Func<Tuple<ILTypeInstance, ILTypeInstance>, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_InteractOpenUI>((Delegate act) => (BGW_EventCollection.Del_InteractOpenUI)delegate(AActor InteractiveActor, string UIName, int Param)
		{
			((Action<AActor, string, int>)act)(InteractiveActor, UIName, Param);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_RepPlayerLoc>((Delegate act) => (Del_Void_RepPlayerLoc)delegate(UnrealEngine.Runtime.FVector FVector, string MemberId)
		{
			((Action<UnrealEngine.Runtime.FVector, string>)act)(FVector, MemberId);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_UIShowMapTips>((Delegate act) => (Del_UIShowMapTips)delegate(bool IsUIWord, int Id)
		{
			((Action<bool, int>)act)(IsUIWord, Id);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_PlayerTeleportToFinished>((Delegate act) => (BGW_EventCollection.Del_PlayerTeleportToFinished)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<bool>.ValueChangedHandler>((Delegate act) => (GSBindProp<bool>.ValueChangedHandler)delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			((Action<EChangeReason, bool, bool>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineActivity.Del_OnSetActivityAvailabilityComplete>((Delegate act) => (BGW_OnlineActivity.Del_OnSetActivityAvailabilityComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<ILTypeInstance>.ValueChangedHandler>((Delegate act) => (GSBindProp<ILTypeInstance>.ValueChangedHandler)delegate(EChangeReason Reason, ILTypeInstance OldValue, ILTypeInstance NewValue)
		{
			((Action<EChangeReason, ILTypeInstance, ILTypeInstance>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineActivity.Del_OnEndActivityComplete>((Delegate act) => (BGW_OnlineActivity.Del_OnEndActivityComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_FetchRoleData>((Delegate act) => (Del_FetchRoleData)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_CheckIsPlayerReadySave>((Delegate act) => (Del_CheckIsPlayerReadySave)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Bool_Void>((Delegate act) => (Del_Bool_Void)(() => ((Func<bool>)act)()));
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_OnStopSaveArchiveFinish>((Delegate act) => (Del_OnStopSaveArchiveFinish)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowSaveArchiveUI>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowSaveArchiveUI)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_HideSaveArchiveUI>((Delegate act) => (BGW_UIEventCollection.Del_UI_HideSaveArchiveUI)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_InputTrigger>((Delegate act) => (Del_InputTrigger)delegate(EGSInputType InputType)
		{
			((Action<EGSInputType>)act)(InputType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_EGSInputType>((Delegate act) => (Del_Void_EGSInputType)delegate(EGSInputType InputType)
		{
			((Action<EGSInputType>)act)(InputType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FInputDelegate.UIInputActionTrigger>((Delegate act) => (FInputDelegate.UIInputActionTrigger)((FInputActionValue Value) => ((Func<FInputActionValue, bool>)act)(Value)));
		appdomain.DelegateManager.RegisterDelegateConvertor<GSScrollBox.DelScrollOffsetChanged>((Delegate act) => (GSScrollBox.DelScrollOffsetChanged)delegate(float Offset)
		{
			((Action<float>)act)(Offset);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_FKeyEvent>((Delegate act) => (Del_Void_FKeyEvent)delegate(FKeyEvent KeyEvent)
		{
			((Action<FKeyEvent>)act)(KeyEvent);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_SetUIBlock>((Delegate act) => (BGW_UIEventCollection.Del_UI_SetUIBlock)delegate(EBlockReason BlockReason, bool IsBlock)
		{
			((Action<EBlockReason, bool>)act)(BlockReason, IsBlock);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_AsyncLoadMatCallBack>((Delegate act) => (BGW_UIEventCollection.Del_UI_AsyncLoadMatCallBack)delegate(UMaterialInstance Mat)
		{
			((Action<UMaterialInstance>)act)(Mat);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_AsyncLoadMediaSourceCallBack>((Delegate act) => (BGW_UIEventCollection.Del_UI_AsyncLoadMediaSourceCallBack)delegate(UFileMediaSource MediaSource)
		{
			((Action<UFileMediaSource>)act)(MediaSource);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<ABGPPlayerState>.ValueChangedHandler>((Delegate act) => (GSBindProp<ABGPPlayerState>.ValueChangedHandler)delegate(EChangeReason Reason, ABGPPlayerState OldValue, ABGPPlayerState NewValue)
		{
			((Action<EChangeReason, ABGPPlayerState, ABGPPlayerState>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<AActor>.ValueChangedHandler>((Delegate act) => (GSBindProp<AActor>.ValueChangedHandler)delegate(EChangeReason Reason, AActor OldValue, AActor NewValue)
		{
			((Action<EChangeReason, AActor, AActor>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<UEditableText.FOnEditableTextChangedEvent.Signature>((Delegate act) => (UEditableText.FOnEditableTextChangedEvent.Signature)delegate(FText Text)
		{
			((Action<FText>)act)(Text);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGUFuncLibWXLogin.DelQywxQuerySuccessCallBack>((Delegate act) => (BGUFuncLibWXLogin.DelQywxQuerySuccessCallBack)delegate(JsonData RetData)
		{
			((Action<JsonData>)act)(RetData);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_BossRushSetPauseTimeTick>((Delegate act) => (Del_BossRushSetPauseTimeTick)delegate(bool Pause, float Time)
		{
			((Action<bool, float>)act)(Pause, Time);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGUFuncLibWXLogin.DelQywxQueryFailCallBack>((Delegate act) => (BGUFuncLibWXLogin.DelQywxQueryFailCallBack)delegate(int ErrorCode, string Msg)
		{
			((Action<int, string>)act)(ErrorCode, Msg);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<FDownloadImageDelegate.Signature>((Delegate act) => (FDownloadImageDelegate.Signature)delegate(UTexture2DDynamic Texture)
		{
			((Action<UTexture2DDynamic>)act)(Texture);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_AsyncLoadTexCallBack>((Delegate act) => (BGW_UIEventCollection.Del_UI_AsyncLoadTexCallBack)delegate(UTexture LoadeTex)
		{
			((Action<UTexture>)act)(LoadeTex);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GameSDKManager.OnLoginCallback>((Delegate act) => (GameSDKManager.OnLoginCallback)delegate(bool Succ, string Msg)
		{
			((Action<bool, string>)act)(Succ, Msg);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineAchievement.Del_OnStatUpdated>((Delegate act) => (BGW_OnlineAchievement.Del_OnStatUpdated)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_OnlineSubsystem.Del_OnQueryAdditionComplete>((Delegate act) => (BGW_OnlineSubsystem.Del_OnQueryAdditionComplete)delegate(bool bWasSuccessful)
		{
			((Action<bool>)act)(bWasSuccessful);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Converter<UIConversationCfg.EConversationContent, int>>((Delegate act) => (Converter<UIConversationCfg.EConversationContent, int>)((UIConversationCfg.EConversationContent input) => ((Func<UIConversationCfg.EConversationContent, int>)act)(input)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_PlayerTeleportToTriggered>((Delegate act) => (BGW_EventCollection.Del_PlayerTeleportToTriggered)delegate(ETeleportTypeV2 TeleportType)
		{
			((Action<ETeleportTypeV2>)act)(TeleportType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<EBuffAndSkillEffectType>>((Delegate act) => (Comparison<EBuffAndSkillEffectType>)((EBuffAndSkillEffectType x, EBuffAndSkillEffectType y) => ((Func<EBuffAndSkillEffectType, EBuffAndSkillEffectType, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<EInteractUIState>.ValueChangedHandler>((Delegate act) => (GSBindProp<EInteractUIState>.ValueChangedHandler)delegate(EChangeReason Reason, EInteractUIState OldValue, EInteractUIState NewValue)
		{
			((Action<EChangeReason, EInteractUIState, EInteractUIState>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_EventCollection.Del_BGW_BoolInt>((Delegate act) => (BGW_EventCollection.Del_BGW_BoolInt)delegate(bool P1, int P2)
		{
			((Action<bool, int>)act)(P1, P2);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ShowLoginNotice>((Delegate act) => (BGW_UIEventCollection.Del_UI_ShowLoginNotice)delegate(Action InAction)
		{
			((Action<Action>)act)(InAction);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<GMCmdPackOne>>((Delegate act) => (Comparison<GMCmdPackOne>)((GMCmdPackOne x, GMCmdPackOne y) => ((Func<GMCmdPackOne, GMCmdPackOne, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_RecvAntiAddictionActions>((Delegate act) => (BGW_UIEventCollection.Del_RecvAntiAddictionActions)delegate(bool NeedHalt, string Title, string Content, int DisplayDurationSec)
		{
			((Action<bool, string, string, int>)act)(NeedHalt, Title, Content, DisplayDurationSec);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_Void_FKey>((Delegate act) => (Del_Void_FKey)delegate(FKey Key)
		{
			((Action<FKey>)act)(Key);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_SettingValueChanged>((Delegate act) => (Del_SettingValueChanged)delegate(int OldValue, int NewValue, UISettingConfigType SettingType)
		{
			((Action<int, int, UISettingConfigType>)act)(OldValue, NewValue, SettingType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Predicate<ItemOne>>((Delegate act) => (Predicate<ItemOne>)((ItemOne obj) => ((Func<ItemOne, bool>)act)(obj)));
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<(int, string)>>((Delegate act) => (Comparison<(int, string)>)(((int, string) x, (int, string) y) => ((Func<(int, string), (int, string), int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_SettingValue>((Delegate act) => (BGW_UIEventCollection.Del_UI_SettingValue)delegate(int OldValue, int NewValue, UISettingConfigType SettingType)
		{
			((Action<int, int, UISettingConfigType>)act)(OldValue, NewValue, SettingType);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSScrollBox.DelScrollReciveInput>((Delegate act) => (GSScrollBox.DelScrollReciveInput)delegate(float ScrollValue)
		{
			((Action<float>)act)(ScrollValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<MatchEvaluator>((Delegate act) => (MatchEvaluator)((Match match) => ((Func<Match, string>)act)(match)));
		appdomain.DelegateManager.RegisterDelegateConvertor<UMultiLineEditableText.FOnMultiLineEditableTextChangedEvent.Signature>((Delegate act) => (UMultiLineEditableText.FOnMultiLineEditableTextChangedEvent.Signature)delegate(FText Text)
		{
			((Action<FText>)act)(Text);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<NpcLocationOne>>((Delegate act) => (Comparison<NpcLocationOne>)((NpcLocationOne x, NpcLocationOne y) => ((Func<NpcLocationOne, NpcLocationOne, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_IntBoolAction>((Delegate act) => (BGW_UIEventCollection.Del_UI_IntBoolAction)delegate(int I1, bool B1, Action A1)
		{
			((Action<int, bool, Action>)act)(I1, B1, A1);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<float>.ValueChangedHandler>((Delegate act) => (GSBindProp<float>.ValueChangedHandler)delegate(EChangeReason Reason, float OldValue, float NewValue)
		{
			((Action<EChangeReason, float, float>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<int>.ValueChangedHandler>((Delegate act) => (GSBindProp<int>.ValueChangedHandler)delegate(EChangeReason Reason, int OldValue, int NewValue)
		{
			((Action<EChangeReason, int, int>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<string>.ValueChangedHandler>((Delegate act) => (GSBindProp<string>.ValueChangedHandler)delegate(EChangeReason Reason, string OldValue, string NewValue)
		{
			((Action<EChangeReason, string, string>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<GSBindProp<FVector2D>.ValueChangedHandler>((Delegate act) => (GSBindProp<FVector2D>.ValueChangedHandler)delegate(EChangeReason Reason, FVector2D OldValue, FVector2D NewValue)
		{
			((Action<EChangeReason, FVector2D, FVector2D>)act)(Reason, OldValue, NewValue);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<Comparison<Adapt_IGSMUIDestruct.Adaptor>>((Delegate act) => (Comparison<Adapt_IGSMUIDestruct.Adaptor>)((Adapt_IGSMUIDestruct.Adaptor x, Adapt_IGSMUIDestruct.Adaptor y) => ((Func<Adapt_IGSMUIDestruct.Adaptor, Adapt_IGSMUIDestruct.Adaptor, int>)act)(x, y)));
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_AsyncLoadDACallBack>((Delegate act) => (BGW_UIEventCollection.Del_UI_AsyncLoadDACallBack)delegate(UDataAsset DataAsset)
		{
			((Action<UDataAsset>)act)(DataAsset);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BGW_UIEventCollection.Del_UI_ActiveBlackOut>((Delegate act) => (BGW_UIEventCollection.Del_UI_ActiveBlackOut)delegate(bool IsActive, Del_Void Callback, bool IsPauseWorld)
		{
			((Action<bool, Del_Void, bool>)act)(IsActive, Callback, IsPauseWorld);
		});
		BattleToFluxDelegateUtil.RegisterDelegateConvertor(appdomain);
	}

	public static void RegisterDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterFunctionDelegate<Adapt_IMessage.Adaptor>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FGeometry, FPointerEvent, FEventReply>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, Del_Void, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<float>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, float, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<float>();
		appdomain.DelegateManager.RegisterMethodDelegate<float, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<float, float, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<float, float, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<FVector2D, FVector2D, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<EAkCallbackType, UAkCallbackInfo>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, int, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<ulong, byte[]>();
		appdomain.DelegateManager.RegisterFunctionDelegate<string, string, string, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<GSLocalPlayerCS, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<DropLibConfig, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FSMRuntimeInstance_GI_Loading, FCalliopeNode, object, FSMState_GI_LoadingBase>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FSMRuntimeInstance_GI_Global, FCalliopeNode, object, FSMState_GI_LoadingBase>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FSMRuntimeInstance_GI_Loading, FCalliopeNode, object, FSMConditionBase>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FSMRuntimeInstance_GI_Global, FCalliopeNode, object, FSMConditionBase>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, uint, uint>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance>();
		appdomain.DelegateManager.RegisterMethodDelegate<Action>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, ILTypeInstance, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<uint, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Adapt_IMessage.Adaptor, Adapt_IMessage.Adaptor, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<ItemOne>();
		appdomain.DelegateManager.RegisterMethodDelegate<APlayerState>();
		appdomain.DelegateManager.RegisterFunctionDelegate<int, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<string, FText>();
		appdomain.DelegateManager.RegisterFunctionDelegate<DictDeltaMsgInt_Int, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<FGeometry, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, ESelectInfo>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<FSoftObjectPtr>, object>();
		appdomain.DelegateManager.RegisterMethodDelegate<EScreenMsgType, string, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Tuple<ILTypeInstance, ILTypeInstance>, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, ILTypeInstance>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossReChallengeDesc, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossIterationsDesc, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<FText, ETextCommit>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, FHitResult, UnrealEngine.Runtime.FVector>();
		appdomain.DelegateManager.RegisterMethodDelegate<UnrealEngine.Runtime.FVector>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, int, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<int, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<int, int, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<FSoftObjectPtr>>();
		appdomain.DelegateManager.RegisterMethodDelegate<FGeometry, FPointerEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<FVector2D>();
		appdomain.DelegateManager.RegisterMethodDelegate<FVector2D, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<FPointerEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<FGeometry, FKeyEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<FGeometry, FAnalogInputEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, ECanCastSkillResult>();
		appdomain.DelegateManager.RegisterMethodDelegate<APlayerController>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<byte>>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<float, int, int, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<EKeys, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, bool, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<EAbnormalStateType>();
		appdomain.DelegateManager.RegisterMethodDelegate<EAbnormalStateType, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<EAbnormalStateType, AActor, EAccAbnormalValueType, float, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor>();
		appdomain.DelegateManager.RegisterMethodDelegate<EInteractUIState, EInteractUIState>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, EInteractType>();
		appdomain.DelegateManager.RegisterMethodDelegate<ERebirthType>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<EGI_Global, object>();
		appdomain.DelegateManager.RegisterFunctionDelegate<RoleItem, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, AActor>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<RoleEquip, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<TalentOne, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EGSInputType>();
		appdomain.DelegateManager.RegisterFunctionDelegate<SpellType, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<string>>();
		appdomain.DelegateManager.RegisterMethodDelegate<ButtonStat>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, int, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<IFocusWidget, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<FAnalogInputEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<FKeyEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, Del_Void, float, FColor, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ReadOnlyBossRushContinuousFightGroup, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<ILTypeInstance>, List<ILTypeInstance>>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<int>, List<int>>();
		appdomain.DelegateManager.RegisterMethodDelegate<FUStBEDArchivesData>();
		appdomain.DelegateManager.RegisterFunctionDelegate<EUINavigation, UWidget>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, EDeadReason, FEffectInstReq, FSkillDamageConfig, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<APawn>();
		appdomain.DelegateManager.RegisterMethodDelegate<ButtonUIStat>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBGUAttrFloat, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Action<EBGUAttrFloat, float>, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, AActor, EDeadReason>();
		appdomain.DelegateManager.RegisterMethodDelegate<EFaBaoState, EFaBaoState>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FUStBEDArchivesData, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FIntPoint, FIntPoint, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FIntPoint, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<ItemOne>, OPReason>();
		appdomain.DelegateManager.RegisterMethodDelegate<AwardList, AwardList>();
		appdomain.DelegateManager.RegisterFunctionDelegate<string, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, int, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, bool, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, EGSInputType>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBGUBloodBarType, BGUCharacterCS>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, string, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<string>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, AActor>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ArchiveSummaryData, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EAttrCostType>();
		appdomain.DelegateManager.RegisterMethodDelegate<FFocusEvent>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, EquipPosition, EquipPosition>();
		appdomain.DelegateManager.RegisterMethodDelegate<FText>();
		appdomain.DelegateManager.RegisterFunctionDelegate<EUINavigation, bool, UWidget>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, IAutoSizeItem>();
		appdomain.DelegateManager.RegisterFunctionDelegate<bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<float, float, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<string, string, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<float, JsonWriter>();
		appdomain.DelegateManager.RegisterFunctionDelegate<double, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<RandomWeight, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<DropItemOne, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<LoadingTipsRandomMgr.TipsCategory, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<RandomItem, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<Srt>();
		appdomain.DelegateManager.RegisterMethodDelegate<UUserWidget>();
		appdomain.DelegateManager.RegisterMethodDelegate<UObject>();
		appdomain.DelegateManager.RegisterMethodDelegate<UObject, UUserWidget>();
		appdomain.DelegateManager.RegisterMethodDelegate<FName, FName, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<FIntPoint>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<FSoftObjectPath>, List<UObject>, object>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BGUCharacterCS, EBGUBloodBarType, bool, bool, BUI_MBarBase>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BGUCharacterCS, BUI_MPlayerInfo>();
		appdomain.DelegateManager.RegisterMethodDelegate<BGUCharacterCS, DamageNumParam>();
		appdomain.DelegateManager.RegisterMethodDelegate<BGUCharacterCS>();
		appdomain.DelegateManager.RegisterMethodDelegate<EUIPageID, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EUIPageID>();
		appdomain.DelegateManager.RegisterMethodDelegate<AActor, EDeadReason, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBGWUserPrivileges, EBGWPrivilegeResult>();
		appdomain.DelegateManager.RegisterFunctionDelegate<EFocusReason, IFocusWidget, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBGWJoinSessionResult>();
		appdomain.DelegateManager.RegisterMethodDelegate<FVector2D, FLinearColor, float, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<UImage, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<string, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<MonsterCollection, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<UMaterialInstanceDynamic, FName, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<int, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<UImage, string, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EnMainShowState>();
		appdomain.DelegateManager.RegisterMethodDelegate<UImage, string, bool, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, GainPerformanceType>();
		appdomain.DelegateManager.RegisterFunctionDelegate<RedPointType, int, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<TStrongObjectPtr<UserObjectListEntryParams>, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, int, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<ETravelNotesTabType, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, UObject>();
		appdomain.DelegateManager.RegisterMethodDelegate<UWidget>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ArchiveSummaryData, ArchiveSummaryData, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<UnrealEngine.Runtime.FVector, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<MsgErrCode, CSMsgBagMultiplayerDropReq, CSMsgBagMultiplayerDropRes>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, GainPerformanceType>();
		appdomain.DelegateManager.RegisterMethodDelegate<MsgErrCode, CSMsgShopRefreshReq, CSMsgShopRefreshRes>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, bool, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, ILTypeInstance, ILTypeInstance>();
		appdomain.DelegateManager.RegisterMethodDelegate<RoleData>();
		appdomain.DelegateManager.RegisterMethodDelegate<FName>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBGUAttrFloat, float, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FInputActionValue, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, int, ILTypeInstance>();
		appdomain.DelegateManager.RegisterFunctionDelegate<int>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, Del_Void>();
		appdomain.DelegateManager.RegisterMethodDelegate<ECustomizedInputType>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, ButtonStat, ButtonStat>();
		appdomain.DelegateManager.RegisterMethodDelegate<EBlockReason, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<UMaterialInstance>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, ABGPPlayerState, ABGPPlayerState>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, AActor, AActor>();
		appdomain.DelegateManager.RegisterMethodDelegate<JsonData>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, JsonData, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<UTexture2DDynamic>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Adapt_IGSMUIDestruct.Adaptor, Adapt_IGSMUIDestruct.Adaptor, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<FDropItem>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FItemWithTag, FItemWithTag, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<UIConversationCfg.EConversationContent, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<UFileMediaSource>();
		appdomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<EUIPageType, int>, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<EUIPageType, int>, EUIPageType>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, ILTypeInstance, ILTypeInstance>();
		appdomain.DelegateManager.RegisterFunctionDelegate<UUserWidget, ILTypeInstance, ILTypeInstance, ILTypeInstance>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<ETeleportTypeV2>();
		appdomain.DelegateManager.RegisterFunctionDelegate<EBuffAndSkillEffectType, EBuffAndSkillEffectType, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<UTexture>();
		appdomain.DelegateManager.RegisterFunctionDelegate<PS5ActivityTaskDesc, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<AchievementOne, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ReadOnlyQuestStageOne, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, EInteractUIState, EInteractUIState>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, Del_Void, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<AccessoryProp, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, string, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<List<EnMainAreaType>>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Task>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, int, string, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FUStInteractionMappingDesc, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FUStInteractionMappingDesc, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ShopOne, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<CardStoryStage, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<CardPortraitStage, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<GMCmdPackOne, GMCmdPackOne, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<bool, string, string, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<InteractionFuncDesc, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<InteractionFuncDesc, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<UWidgetAnimation, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<FKey>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FUStRebirthPointDesc, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, string, float, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<FUStRebirthPointDesc, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<LevelDesc, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<LevelDesc, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, int, UISettingConfigType>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, bool, Action>();
		appdomain.DelegateManager.RegisterFunctionDelegate<QuestStageOne, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<ItemOne, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<(int, string), (int, string), int>();
		appdomain.DelegateManager.RegisterMethodDelegate<string, string, float, bool, bool>();
		appdomain.DelegateManager.RegisterFunctionDelegate<Match, string>();
		appdomain.DelegateManager.RegisterFunctionDelegate<SoundTrackDesc, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<NpcLocationOne, NpcLocationOne, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<EDaShengStage, EDaShengStage>();
		appdomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<int, int>, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<DSMapSymbol>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, float, float>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, int, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, string, string>();
		appdomain.DelegateManager.RegisterMethodDelegate<EChangeReason, FVector2D, FVector2D>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushRefightRecord, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushRefightRecord, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushRefightRecord, double>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushRefightRecord, ulong>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushContinuousFightRecord, int>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushContinuousFightRecord, float>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushContinuousFightRecord, double>();
		appdomain.DelegateManager.RegisterFunctionDelegate<BossRushContinuousFightRecord, ulong>();
		appdomain.DelegateManager.RegisterMethodDelegate<UDataAsset>();
		appdomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance, EInputTipsType, EInputTipsType>();
		BattleToFluxDelegateUtil.DelegateRegister(appdomain);
		GSE.OnlineBase.ILRuntimeBinding.Register(appdomain);
		GSE.GSSdk.ILRuntimeBinding.Register(appdomain);
		GSE.GSNet.ILRuntimeBinding.Register(appdomain);
		EventReporter.DelegateRegister(appdomain);
	}

	public override void RegisterUIDelegateConvertor<Signature, Wrapper>(BUI_Widget HolderWidget)
	{
		base.RegisterUIDelegateConvertor<Signature, Wrapper>(HolderWidget);
	}

	private void StopILRuntime()
	{
		try
		{
			GameProcessEnd(_appdomain, null);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
		}
		ClearFileStreams();
		_appdomain.DebugService.StopDebugService();
		_appdomain = null;
	}

	public static object ILRuntimeInvoke(UObject WorldCtx, string Type, string Method, object Instance, params object[] ParamList)
	{
		if (DebugConfig.ILRuntime)
		{
			BGW_ILRuntimeMgr bGW_ILRuntimeMgr = Get(WorldCtx);
			IMethod iLRuntimeMethod = bGW_ILRuntimeMgr.GetILRuntimeMethod(Type, Method, ParamList.Length);
			return bGW_ILRuntimeMgr._appdomain.Invoke(iLRuntimeMethod, Instance, ParamList);
		}
		return BGW_ManagedReflectMgr.Get(WorldCtx).FindMethodInfo(Type, Method, ParamList).Invoke(Instance, ParamList);
	}

	public IMethod FreshILRuntimeMethodCache(string Type, string Method, int ParamCount)
	{
		string key = $"{Type}:{Method}";
		if (GSEUtil.Ensure(_appdomain.LoadedTypes.TryGetValue(Type, out var value), "FreshILRuntimeMethodCache " + Type + ":" + Method + " Not Found"))
		{
			IMethod method = value.GetMethod(Method, ParamCount);
			ILRuntimeMethodCache[key] = method;
			return method;
		}
		return null;
	}

	public IMethod GetILRuntimeMethod(string Type, string Method, int ParamCount)
	{
		string key = $"{Type}:{Method}";
		if (ILRuntimeMethodCache.ContainsKey(key))
		{
			return ILRuntimeMethodCache[key];
		}
		return FreshILRuntimeMethodCache(Type, Method, ParamCount);
	}

	public override void LoadHotScriptAssemblyDo(string LocalPath, string EntryClass, string EntryMethod, string TickMethod)
	{
		LoadAssemblyFileAndSymbol(_appdomain, LocalPath, bClrBinding: false, IsWithSymbol: false);
		FreshILRuntimeMethodCache(EntryClass, EntryMethod, 0);
		if (!string.IsNullOrEmpty(TickMethod))
		{
			FreshILRuntimeMethodCache(EntryClass, TickMethod, 1);
		}
		ILRuntimeInvoke(this, EntryClass, EntryMethod, null);
	}

	static BGW_ILRuntimeMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ILRuntimeMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ILRuntimeMgr));
		DllFileStreams = new List<Stream>();
		SymbolFileStreams = new List<Stream>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ILRuntimeMgr");
	}
}
