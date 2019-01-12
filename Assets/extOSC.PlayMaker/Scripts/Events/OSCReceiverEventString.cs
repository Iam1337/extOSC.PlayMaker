/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventString : OSCReceiverEvent<FsmString, string>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out string value)
        {
            value = string.Empty;

            if (message.ToString(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif