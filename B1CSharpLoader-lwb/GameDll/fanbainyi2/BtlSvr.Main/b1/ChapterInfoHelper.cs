using b1.BGW;
using b1.Localization;
using b1.Plugins.AsyncLoadingScreen;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ChapterInfoHelper
{
	private UObject WorldContext;

	private BGW_PreloadAssetMgr PreloadAssetMgr;

	private int TargetLevelId;

	public ChapterInfoHelper(UObject InWorldContext, int InTargetLevelId)
	{
		WorldContext = InWorldContext;
		PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
		TargetLevelId = InTargetLevelId;
	}

	public FChapterInfo GetChapterInfo()
	{
		ChapterDesc chapterDescByLevelId = GameDBRuntime.GetChapterDescByLevelId(TargetLevelId);
		if (chapterDescByLevelId != null)
		{
			return new FChapterInfo
			{
				IsNeedShow = !GSLocalization.IsZHCulture(),
				ChapterPreName = chapterDescByLevelId.ChapterPreName.ToFText(),
				ChapterName = chapterDescByLevelId.ChapterName.ToFText(),
				ImageObj = GetImage(chapterDescByLevelId.Id)
			};
		}
		return default(FChapterInfo);
	}

	private UTexture2D GetImage(int ChapterId)
	{
		return PreloadAssetMgr.RequestSyncLoadForUIResource<UTexture2D>(GSUIResPathUtil.GetChapterImagePath(ChapterId), EUIResourceLoadType.NoCache);
	}
}
