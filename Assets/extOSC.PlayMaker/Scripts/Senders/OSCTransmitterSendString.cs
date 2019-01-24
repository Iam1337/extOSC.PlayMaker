/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendString : OSCTransmitterSend<FsmString, string>
	{
        #region Protected Methods

		protected override void FillMessage(OSCMessage message, string value)
		{
			message.AddValue(OSCValue.String(value));
		}

        #endregion
    }
}

#endif