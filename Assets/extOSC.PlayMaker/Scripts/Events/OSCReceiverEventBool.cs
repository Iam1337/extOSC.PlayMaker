/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventBool : OSCReceiverEvent<FsmBool, bool>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out bool value)
        {
            value = false;

            if (message.ToBool(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif