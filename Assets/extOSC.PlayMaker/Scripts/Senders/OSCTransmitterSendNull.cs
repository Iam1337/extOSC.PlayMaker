/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendNull : OSCTransmitterSend
	{
		#region Protected Methods

		protected override bool FillMessage(OSCMessage message)
		{
			message.AddValue(OSCValue.Null());

			return true;
		}

		#endregion
	}
}

#endif