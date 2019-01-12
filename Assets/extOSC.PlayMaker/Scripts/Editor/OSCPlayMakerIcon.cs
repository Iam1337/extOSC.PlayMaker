/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEditor;

using HutongGames.PlayMakerEditor;

using extOSC.Editor;

namespace extOSC.PlayMaker.Editor
{
	[InitializeOnLoad]
	public class OSCPlayMakerIcon
	{
        #region Static Constructor

		static OSCPlayMakerIcon()
		{
			Actions.AddCategoryIcon("extOSC", OSCEditorTextures.IronWallSmall);
		}

        #endregion
    }
}

#endif