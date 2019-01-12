/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendBool : OSCTransmitterSend<FsmBool, bool>
	{
        #region Protected Methods

		protected override void FillMessage(OSCMessage message, bool value)
		{
			message.AddValue(OSCValue.Bool(value));
		}

        #endregion
    }
}

#endif