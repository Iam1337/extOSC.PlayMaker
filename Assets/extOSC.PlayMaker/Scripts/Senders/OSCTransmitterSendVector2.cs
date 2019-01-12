/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendVector2 : OSCTransmitterSend<FsmVector2, Vector2>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, Vector2 value)
		{
			message.AddValue(OSCValue.Float(value.x));
			message.AddValue(OSCValue.Float(value.y));
		}

		#endregion
	}
}

#endif