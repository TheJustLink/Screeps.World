using System;

using Bridge;

namespace Screeps.World
{
    public static class Game
    {
        public static Action Loop
        {
            set => Script.Set("module.exports.loop", value);
        }

        public static ulong Time => Script.Get<ulong>("Game.time");
    }
}