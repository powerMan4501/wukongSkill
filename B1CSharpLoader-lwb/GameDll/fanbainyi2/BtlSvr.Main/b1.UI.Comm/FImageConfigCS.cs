using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.UI.Comm;

public class FImageConfigCS
{
	public FSlateBrush ImgBrush;

	public bool UseImgSize;

	public FVector2D ImgSize;

	public bool UseImgPos;

	public FVector2D ImgPos;

	public EMatSyncType MatSyncType;

	public List<FMatSyncConfigCS> ExMatSyncList;

	public bool UseAtlas;

	public bool SyncSprite;

	public UObject Sprite;
}
