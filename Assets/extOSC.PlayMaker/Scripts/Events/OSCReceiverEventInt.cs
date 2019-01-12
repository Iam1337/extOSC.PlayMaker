/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventInt : OSCReceiverEvent<FsmInt, int>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out int value)
        {
            value = 0;

            if (message.ToInt(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif