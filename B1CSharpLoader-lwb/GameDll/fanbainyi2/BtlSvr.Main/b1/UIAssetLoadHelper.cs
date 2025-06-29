using System;
using System.Collections.Generic;
using b1.BGW;
using B1UI.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.MediaAssets;
using UnrealEngine.Plugins.Paper2D;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

public class UIAssetLoadHelper
{
	private static int _ReqId;

	private static Dictionary<IntPtr, int> AsyncCacheObjReqDic = new Dictionary<IntPtr, int>();

	private static BGW_PreloadAssetMgr PreloadAssetMgr;

	private static UTexture DefaultTex;

	protected static UObject WorldContext;

	private static int ReqId => ++_ReqId;

	public static void Init(UObject InWorldCtx)
	{
		WorldContext = InWorldCtx;
		PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
		ClearAsyncCache();
	}

	private static UTexture TryGetDefaultTex()
	{
		if (DefaultTex.IsNullOrDestroyed())
		{
			DefaultTex = PreloadAssetMgr.RequestSyncLoadForUIResource<UObject>(GSUIResPathUtil.GetDefaultPath()) as UTexture;
		}
		return DefaultTex;
	}

	public static void ClearAsyncCache()
	{
		AsyncCacheObjReqDic.Clear();
	}

	private static bool TryCacheObjReq(UObject BindObj, out int NewReqId)
	{
		if (BindObj.IsNullOrDestroyed())
		{
			NewReqId = -1;
			return false;
		}
		IntPtr address = BindObj.GetAddress();
		NewReqId = ReqId;
		AsyncCacheObjReqDic[address] = NewReqId;
		return true;
	}

	private static bool CheckAsyncLoadActionReq<T>(string ResPath, UObject BindObj, T LoadObj, int ReqId, bool NeedRemove, Action<T> CallBack) where T : UObject
	{
		if (BindObj.IsNullOrDestroyed())
		{
			EditorLogErr("[UIAssetLoadHelper] AsyncLoad fail, BindObj is null, ResPath = " + ResPath);
			return false;
		}
		IntPtr address = BindObj.GetAddress();
		if (AsyncCacheObjReqDic.TryGetValue(address, out var value))
		{
			if (value != ReqId)
			{
				return false;
			}
			if (NeedRemove)
			{
				AsyncCacheObjReqDic.Remove(address);
			}
			if (LoadObj == null)
			{
				EditorLogErr("[UIAssetLoadHelper] AsyncLoad fail, LoadObj is null, ResPath = " + ResPath);
				return false;
			}
			CallBack?.Invoke(LoadObj);
			return false;
		}
		return false;
	}

	public static bool StopObjLoadReq(UObject Obj)
	{
		if (Obj.IsNullOrDestroyed())
		{
			return false;
		}
		return AsyncCacheObjReqDic.Remove(Obj.GetAddress());
	}

	private static void DoCopyParams(UImage Img, bool CopyParams, bool OnlyQuickParams, UMaterialInstance OriDynMat)
	{
		if (CopyParams)
		{
			UMaterialInstanceDynamic dynamicMaterial = Img.GetDynamicMaterial();
			if (OriDynMat != null && dynamicMaterial != null)
			{
				dynamicMaterial.CopyMaterialInstanceParameters(OriDynMat, OnlyQuickParams);
			}
		}
	}

	private static void EditorLogErr(string Log)
	{
		if (FGlobals.IsEditor && !UGSE_EngineFuncLib.IsStandaloneGame())
		{
			BGW_LogUtil.LogError(Log);
		}
	}

	private static void AsyncLoadForUIResourceInner<T>(UObject WorldContext, string ResPath, Action<int, T, bool> AsyncLoadFinishCallBack, bool NeedCache = false) where T : UObject
	{
		if (!WorldContext.IsNullOrDestroyed() && !string.IsNullOrEmpty(ResPath))
		{
			if (typeof(T) == typeof(UTexture))
			{
				AsyncLoadFinishCallBack(-2, TryGetDefaultTex() as T, arg3: false);
			}
			EUIResourceLoadType uIResourceLoadType = ((!NeedCache) ? EUIResourceLoadType.NoCache : EUIResourceLoadType.CacheAndReleaseWhenChangeLevel);
			PreloadAssetMgr?.RequestAsyncLoadForUIResource<UObject>(ResPath, EAssetPriority.High, CallBack, -1, uIResourceLoadType);
		}
		void CallBack(int ReqID, UObject LoadObj)
		{
			if (LoadObj == null)
			{
				EditorLogErr("[UIAssetLoadHelper] AsyncLoad fail, LoadObj is null, ResPath = " + ResPath);
			}
			else if (!(LoadObj is T))
			{
				EditorLogErr($"[UIAssetLoadHelper] AsyncLoad fail, Type is not match, ResPath = {ResPath}, Type = {typeof(T)}");
			}
			else
			{
				AsyncLoadFinishCallBack?.Invoke(ReqID, LoadObj as T, arg3: true);
			}
		}
	}

	private static void AsyncLoadTexForImageInner(UObject WorldContext, UImage Img, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadTexCallBack ReqCallBack, bool NeedCache = false)
	{
		if (TryCacheObjReq(Img, out var CacheObjReq))
		{
			AsyncLoadForUIResourceInner<UTexture>(WorldContext, ResPath, AsyncLoadFinishCallBack, NeedCache);
		}
		void AsyncLoadFinishCallBack(int ReqID, UTexture Obj, bool NeedRemove)
		{
			CheckAsyncLoadActionReq(ResPath, Img, Obj, CacheObjReq, NeedRemove, delegate(UTexture LoadObj)
			{
				ReqCallBack?.Invoke(LoadObj);
			});
		}
	}

	private static void AsyncLoadSpriteForImageInner(UObject WorldContext, UImage Img, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadSpriteCallBack ReqCallBack, bool NeedCache = false)
	{
		if (TryCacheObjReq(Img, out var CacheObjReq))
		{
			AsyncLoadForUIResourceInner<UPaperSprite>(WorldContext, ResPath, AsyncLoadFinishCallBack, NeedCache);
		}
		void AsyncLoadFinishCallBack(int ReqID, UPaperSprite Obj, bool NeedRemove)
		{
			CheckAsyncLoadActionReq(ResPath, Img, Obj, CacheObjReq, NeedRemove, delegate(UPaperSprite LoadObj)
			{
				ReqCallBack?.Invoke(LoadObj);
			});
		}
	}

	private static void AsyncLoadForImageToSetMatParamInner(UObject WorldContext, UImage Img, string ResPath, bool NeedCache = false)
	{
		if (TryCacheObjReq(Img, out var CacheObjReq))
		{
			AsyncLoadForUIResourceInner<UTexture>(WorldContext, ResPath, AsyncLoadFinishCallBack, NeedCache);
		}
		void AsyncLoadFinishCallBack(int ReqID, UTexture Obj, bool NeedRemove)
		{
			CheckAsyncLoadActionReq(ResPath, Img, Obj, CacheObjReq, NeedRemove, delegate(UTexture LoadObj)
			{
				UMaterialInstanceDynamic dynamicMaterial = Img.GetDynamicMaterial();
				if (dynamicMaterial == null)
				{
					EditorLogErr("[UIAssetLoadHelper] Img.GetDynamicMaterial Failed.");
				}
				else
				{
					dynamicMaterial.SetTextureParameterValue(B1Names.GSMatParamNameMainTex, LoadObj);
				}
			});
		}
	}

	private static void AsyncLoadMatToSetImgBrushInner(UObject WorldContext, UImage Img, string ResPath, bool CopyParams = false, bool OnlyQuickParams = true, bool NeedCache = false)
	{
		if (TryCacheObjReq(Img, out var CacheObjReq))
		{
			AsyncLoadForUIResourceInner<UMaterialInstance>(WorldContext, ResPath, AsyncLoadFinishCallBack, NeedCache);
		}
		void AsyncLoadFinishCallBack(int ReqId, UMaterialInstance Obj, bool NeedRemove)
		{
			CheckAsyncLoadActionReq(ResPath, Img, Obj, CacheObjReq, NeedRemove, delegate(UMaterialInstance LoadObj)
			{
				UMaterialInstanceDynamic dynamicMaterial = Img.GetDynamicMaterial();
				Img.SetBrushFromMaterial(LoadObj);
				DoCopyParams(Img, CopyParams, OnlyQuickParams, dynamicMaterial);
			});
		}
	}

	private static void AysncLoadForMatInstInner(UObject WorldContext, UMaterialInstanceDynamic MatInstDynamic, FName ParameterName, string ResPath, bool NeedCache = false)
	{
		if (TryCacheObjReq(MatInstDynamic, out var CacheObjReq))
		{
			AsyncLoadForUIResourceInner<UTexture>(WorldContext, ResPath, AsyncLoadFinishCallBack, NeedCache);
		}
		void AsyncLoadFinishCallBack(int ReqId, UTexture Obj, bool NeedRemove)
		{
			CheckAsyncLoadActionReq(ResPath, MatInstDynamic, Obj, CacheObjReq, NeedRemove, delegate(UTexture LoadObj)
			{
				MatInstDynamic.SetTextureParameterValue(ParameterName, LoadObj);
			});
		}
	}

	public static void AsyncLoadTexForImage(UObject WorldContext, UImage Img, string ResPath, bool IsNeedSetBrushParam = false, bool NeedCache = false)
	{
		AsyncLoadTexForImageInner(WorldContext, Img, ResPath, delegate(UTexture Tex)
		{
			if (Tex != null)
			{
				if (IsNeedSetBrushParam)
				{
					Img.SetBrushFromTexture(Tex as UTexture2D, bMatchSize: true);
					Img?.ForceLayoutPrepass();
				}
				else
				{
					FSlateBrush brush = Img.Brush;
					brush.ResourceObject = Tex;
					Img.SetBrush(brush);
					Img.InvalidateLayoutAndVolatility();
				}
			}
		}, NeedCache);
	}

	public static void AsyncLoadSpriteForImage(UObject WorldContext, UImage Img, string ResPath, bool NeedCache = false)
	{
		AsyncLoadSpriteForImageInner(WorldContext, Img, ResPath, delegate(UPaperSprite Sprite)
		{
			if (Sprite != null)
			{
				Img.SetImageSprite(Sprite);
			}
		}, NeedCache);
	}

	public static void AsyncLoadTexToSetImgMatParam(UObject WorldContext, UImage Img, string ResPath, bool NeedCache = false)
	{
		AsyncLoadForImageToSetMatParamInner(WorldContext, Img, ResPath, NeedCache);
	}

	public static void AsyncLoadTexForMatInstToSetParam(UObject WorldContext, UMaterialInstanceDynamic Mat, FName ParameterName, string ResPath, bool NeedCache = false)
	{
		AysncLoadForMatInstInner(WorldContext, Mat, ParameterName, ResPath, NeedCache);
	}

	public static void AsyncLoadMatToSetImgBrush(UObject WorldContext, UImage Img, string ResPath, bool CopyParams = false, bool OnlyQuickParams = true, bool NeedCache = false)
	{
		AsyncLoadMatToSetImgBrushInner(WorldContext, Img, ResPath, CopyParams, OnlyQuickParams, NeedCache);
	}

	public static void AsyncLoadTexForMatInstToSetParamV2(UObject WorldContext, UMaterialInstanceDynamic Mat, FName ParameterName, string ResPath, bool NeedCache = false)
	{
		if (Mat.IsNullOrDestroyed())
		{
			return;
		}
		AsyncLoadForUIResourceInner(WorldContext, ResPath, delegate(int ReqID, UTexture Obj, bool NeedRemove)
		{
			if (Obj == null)
			{
				EditorLogErr("AysncLoadForMatInstInnerV2 objects.Count == 0");
			}
			else if (!Mat.IsNullOrDestroyed())
			{
				Mat.SetTextureParameterValue(ParameterName, Obj);
			}
		}, NeedCache);
	}

	public static void AsyncLoadTexForAction(UObject WorldContext, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadTexCallBack LoadedCallBack, bool NeedCache = false)
	{
		AsyncLoadForUIResourceInner(WorldContext, ResPath, delegate(int ReqID, UObject Obj, bool NeedRemove)
		{
			if (Obj == null)
			{
				EditorLogErr("AysncLoadForMatInst objects.Count == 0");
			}
			else if (Obj != null)
			{
				UTexture uTexture = Obj as UTexture;
				if (uTexture == null)
				{
					EditorLogErr("AysncLoadForMatInst To UTexture Failed.ResPath:" + ResPath);
				}
				else
				{
					LoadedCallBack(uTexture);
				}
			}
		}, NeedCache);
	}

	public static void AsyncLoadMatForAction(UObject WorldContext, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadMatCallBack LoadedCallBack, bool NeedCache = false)
	{
		AsyncLoadForUIResourceInner(WorldContext, ResPath, delegate(int ReqID, UObject Obj, bool NeedRemove)
		{
			if (Obj == null)
			{
				EditorLogErr("AysncLoadForMatInst objects.Count == 0");
			}
			else if (Obj != null)
			{
				UMaterialInstance uMaterialInstance = Obj as UMaterialInstance;
				if (uMaterialInstance == null)
				{
					EditorLogErr("AysncLoadForMatInst To UMaterialInstance Failed.");
				}
				else
				{
					LoadedCallBack?.Invoke(uMaterialInstance);
				}
			}
		}, NeedCache);
	}

	public static void AsyncLoadMediaSourceForAction(UObject WorldContext, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadMediaSourceCallBack LoadedCallBack, bool NeedCache = false)
	{
		AsyncLoadForUIResourceInner(WorldContext, ResPath, delegate(int ReqID, UObject Obj, bool NeedRemove)
		{
			if (Obj == null)
			{
				EditorLogErr("AysncLoadForMatInst objects.Count == 0");
			}
			else if (Obj != null)
			{
				UFileMediaSource uFileMediaSource = Obj as UFileMediaSource;
				if (uFileMediaSource == null)
				{
					EditorLogErr("AsyncLoadMediaSource To UFileMediaSource Failed.");
				}
				else
				{
					LoadedCallBack?.Invoke(uFileMediaSource);
				}
			}
		}, NeedCache);
	}

	public static void AsyncLoadDAForAction(UObject WorldContext, string ResPath, BGW_UIEventCollection.Del_UI_AsyncLoadDACallBack LoadedCallBack, bool NeedCache = false)
	{
		AsyncLoadForUIResourceInner(WorldContext, ResPath, delegate(int ReqID, UObject Obj, bool NeedRemove)
		{
			if (Obj == null)
			{
				EditorLogErr("AysncLoadForMatInst objects.Count == 0");
			}
			else if (Obj != null)
			{
				UDataAsset uDataAsset = Obj as UDataAsset;
				if (uDataAsset == null)
				{
					EditorLogErr("AsyncLoadMediaSource To UDataAsset Failed.");
				}
				else
				{
					LoadedCallBack?.Invoke(uDataAsset);
				}
			}
		}, NeedCache);
	}
}
