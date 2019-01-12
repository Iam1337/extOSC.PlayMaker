/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendInt : OSCTransmitterSend<FsmInt, int>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, int value)
		{
			message.AddValue(OSCValue.Int(value));
		}

		#endregion
	}
}

#endif