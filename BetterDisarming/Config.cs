using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterDisarming
{
    public class Config : IConfig
    {
        [Description("Wether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = false;
        [Description("How long before every escape check in seconds.")]
        public float CheckInterval { get; set; } = 1f;
        [Description("A list of roles who can escape and what they turn into. Format EntryTeam:ExitTeam")]
        public Dictionary<int, int> Escapelist { get; set; } = new Dictionary<int, int>() { { 15, 8 }, { 13, 8 }, { 4, 8 }, { 11, 8 }, { 12, 8 }, { 8, 13 } };
        [Description("How many respawn tickets to give to the disarmed person's new team when they escape while cuffed.")]
        public int GiveTickets { get; set; } = 1;
    }
}
