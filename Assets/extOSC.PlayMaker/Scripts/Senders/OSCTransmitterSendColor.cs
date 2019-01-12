/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendColor : OSCTransmitterSend<FsmColor, Color>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, Color value)
		{
			message.AddValue(OSCValue.Color(value));
		}

		#endregion
	}
}

#endif