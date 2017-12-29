﻿using System.Collections.Generic;
using Leveling.Levels;
using Newtonsoft.Json;

namespace Leveling.Classes
{
    /// <summary>
    ///     Represents a class definition.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class ClassDefinition
    {
        /// <summary>
        ///     Gets a value indicating whether to allow switching the class after mastery.
        /// </summary>
        [JsonProperty(Order = 6)]
        public bool AllowSwitching { get; private set; } = true;

        /// <summary>
        ///     Gets a value indicating whether to allow switching the class before mastery.
        /// </summary>
        [JsonProperty(Order = 7)]
        public bool AllowSwitchingBeforeMastery { get; private set; }

        /// <summary>
        ///     Gets the death penalty multiplier override.
        /// </summary>
        [JsonProperty(Order = 9)]
        public double? DeathPenaltyMultiplierOverride { get; private set; }

        /// <summary>
        ///     Gets the display name.
        /// </summary>
        [JsonProperty("DisplayName", Order = 1)]
        public string DisplayName { get; private set; }

        /// <summary>
        ///     Gets the EXP multiplier override.
        /// </summary>
        [JsonProperty(Order = 8)]
        public double? ExpMultiplierOverride { get; private set; }

		/// <summary>
		///     Gets the list of level definitions.
		/// </summary>
		[JsonProperty("Levels", Order = 2)]
		public IList<LevelDefinition> LevelDefinitions { get; private set; } = new List<LevelDefinition>();

        /// <summary>
        ///     Gets the name.
        /// </summary>
        [JsonProperty("Name", Order = 0)]
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the list of prerequisite levels.
        /// </summary>
        [JsonProperty("PrerequisiteLevels", Order = 3)]
        public IList<string> PrerequisiteLevelNames { get; private set; } = new List<string>();

        /// <summary>
        ///     Gets the list of prerequisite permissions.
        /// </summary>
        [JsonProperty(Order = 4)]
        public IList<string> PrerequisitePermissions { get; private set; } = new List<string>();

        /// <summary>
        ///     Gets the SEconomy cost to enter this class.
        /// </summary>
        [JsonProperty(Order = 5)]
        public long SEconomyCost { get; private set; }
    }
}
