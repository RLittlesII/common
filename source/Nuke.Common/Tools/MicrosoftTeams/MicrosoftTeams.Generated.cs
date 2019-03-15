// Generated from https://github.com/RLittlesII/common/blob/master/build/specifications/MicrosoftTeams.json
// Generated with Nuke.CodeGeneration version LOCAL (Windows,.NETStandard,Version=v2.0)

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.MicrosoftTeams
{
    #region MicrosoftTeamsMessageCard
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class MicrosoftTeamsMessageCard : ISettingsEntity
    {
        /// <summary>
        ///    A string used for summarizing card content. This will be shown as the message subject. This is required if the text parameter isn't populated.
        /// </summary>
        [JsonProperty("summary")]
        public virtual string Summary { get; internal set; }
        /// <summary>
        ///   Specifies a custom brand color for the card. The color will be displayed in a non-obtrusive manner.
        /// </summary>
        [JsonProperty("themeColor")]
        public virtual string ThemeColor { get; internal set; }
        /// <summary>
        ///   The main text of the card. This will be rendered below the sender information and optional title, and above any sections or actions present.
        /// </summary>
        [JsonProperty("text")]
        public virtual string Text { get; internal set; }
        /// <summary>
        ///   A title for the Connector message. Shown at the top of the message.
        /// </summary>
        [JsonProperty("title")]
        public virtual string Title { get; internal set; }
        [JsonProperty("sections")]
        public virtual IReadOnlyList<MicrosoftTeamsMessageSection> Sections => SectionsInternal.AsReadOnly();
        internal List<MicrosoftTeamsMessageSection> SectionsInternal { get; set; } = new List<MicrosoftTeamsMessageSection>();
        [JsonProperty("potentialAction")]
        public virtual IReadOnlyList<MicrosoftTeamsMessagePotentialAction> PotentialAction => PotentialActionInternal.AsReadOnly();
        internal List<MicrosoftTeamsMessagePotentialAction> PotentialActionInternal { get; set; } = new List<MicrosoftTeamsMessagePotentialAction>();
    }
    #endregion
    #region MicrosoftTeamsMessageFacts
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class MicrosoftTeamsMessageFacts : ISettingsEntity
    {
        /// <summary>
        ///   The key.
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The value.
        /// </summary>
        [JsonProperty("value")]
        public virtual string Value { get; internal set; }
    }
    #endregion
    #region MicrosoftTeamsMessagePotentialAction
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class MicrosoftTeamsMessagePotentialAction : ISettingsEntity
    {
        /// <summary>
        ///   Actions can be presented to the user by including a Schema.org JSON-LD object.
        /// </summary>
        [JsonProperty("@context")]
        public virtual string Context { get; internal set; }
        /// <summary>
        ///   Currently only supports ViewAction, which creates a hyperlinked action button at the bottom of the connector card.
        /// </summary>
        [JsonProperty("@type")]
        public virtual string Type { get; internal set; }
        /// <summary>
        ///   Name of the action. (Shown as the Button text).
        /// </summary>
        [JsonProperty("short")]
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Target of the action. (The destination hyperlink).
        /// </summary>
        [JsonProperty("target")]
        public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
        internal List<string> TargetInternal { get; set; } = new List<string>();
    }
    #endregion
    #region MicrosoftTeamsMessageSection
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class MicrosoftTeamsMessageSection : ISettingsEntity
    {
        /// <summary>
        ///   The title is displayed as larger, bold text near the top of a message attachment.
        /// </summary>
        [JsonProperty("title")]
        public virtual string Title { get; internal set; }
        /// <summary>
        ///   Title of the event or action. Often this will be the name of the "actor".
        /// </summary>
        [JsonProperty("activityTitle")]
        public virtual string ActivityTitle { get; internal set; }
        /// <summary>
        ///   A subtitle describing the event or action. Often this will be a summary of the action.
        /// </summary>
        [JsonProperty("activitySubtitle")]
        public virtual string ActivitySubtitle { get; internal set; }
        /// <summary>
        ///   An image representing the action. Often this is an avatar of the "actor" of the activity.
        /// </summary>
        [JsonProperty("activityImage")]
        public virtual string ActivityImage { get; internal set; }
        /// <summary>
        ///   A full description of the action.
        /// </summary>
        [JsonProperty("activityText")]
        public virtual string ActivityText { get; internal set; }
        /// <summary>
        ///   A list of facts, displayed as key-value pairs.
        /// </summary>
        [JsonProperty("facts")]
        public virtual IReadOnlyList<MicrosoftTeamsMessageFacts> Facts => FactsInternal.AsReadOnly();
        internal List<MicrosoftTeamsMessageFacts> FactsInternal { get; set; } = new List<MicrosoftTeamsMessageFacts>();
        /// <summary>
        ///   Optional text that will appear before the activity.
        /// </summary>
        [JsonProperty("text")]
        public virtual string Text { get; internal set; }
        /// <summary>
        ///   Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.
        /// </summary>
        [JsonProperty("markdown")]
        public virtual bool? Markdown { get; internal set; }
    }
    #endregion
    #region MicrosoftTeamsMessageCardExtensions
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class MicrosoftTeamsMessageCardExtensions
    {
        #region Summary
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.Summary"/></em></p>
        ///   <p> A string used for summarizing card content. This will be shown as the message subject. This is required if the text parameter isn't populated.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetSummary(this MicrosoftTeamsMessageCard toolSettings, string summary)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Summary = summary;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageCard.Summary"/></em></p>
        ///   <p> A string used for summarizing card content. This will be shown as the message subject. This is required if the text parameter isn't populated.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ResetSummary(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Summary = null;
            return toolSettings;
        }
        #endregion
        #region ThemeColor
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.ThemeColor"/></em></p>
        ///   <p>Specifies a custom brand color for the card. The color will be displayed in a non-obtrusive manner.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetThemeColor(this MicrosoftTeamsMessageCard toolSettings, string themeColor)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThemeColor = themeColor;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageCard.ThemeColor"/></em></p>
        ///   <p>Specifies a custom brand color for the card. The color will be displayed in a non-obtrusive manner.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ResetThemeColor(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThemeColor = null;
            return toolSettings;
        }
        #endregion
        #region Text
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.Text"/></em></p>
        ///   <p>The main text of the card. This will be rendered below the sender information and optional title, and above any sections or actions present.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetText(this MicrosoftTeamsMessageCard toolSettings, string text)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = text;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageCard.Text"/></em></p>
        ///   <p>The main text of the card. This will be rendered below the sender information and optional title, and above any sections or actions present.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ResetText(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = null;
            return toolSettings;
        }
        #endregion
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.Title"/></em></p>
        ///   <p>A title for the Connector message. Shown at the top of the message.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetTitle(this MicrosoftTeamsMessageCard toolSettings, string title)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageCard.Title"/></em></p>
        ///   <p>A title for the Connector message. Shown at the top of the message.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ResetTitle(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region Sections
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.Sections"/> to a new list</em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetSections(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessageSection[] sections)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SectionsInternal = sections.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.Sections"/> to a new list</em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetSections(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessageSection> sections)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SectionsInternal = sections.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageCard.Sections"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard AddSections(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessageSection[] sections)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SectionsInternal.AddRange(sections);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageCard.Sections"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard AddSections(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessageSection> sections)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SectionsInternal.AddRange(sections);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="MicrosoftTeamsMessageCard.Sections"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ClearSections(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SectionsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageCard.Sections"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard RemoveSections(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessageSection[] sections)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessageSection>(sections);
            toolSettings.SectionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageCard.Sections"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard RemoveSections(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessageSection> sections)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessageSection>(sections);
            toolSettings.SectionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PotentialAction
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.PotentialAction"/> to a new list</em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetPotentialAction(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessagePotentialAction[] potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PotentialActionInternal = potentialAction.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageCard.PotentialAction"/> to a new list</em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard SetPotentialAction(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessagePotentialAction> potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PotentialActionInternal = potentialAction.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageCard.PotentialAction"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard AddPotentialAction(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessagePotentialAction[] potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PotentialActionInternal.AddRange(potentialAction);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageCard.PotentialAction"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard AddPotentialAction(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessagePotentialAction> potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PotentialActionInternal.AddRange(potentialAction);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="MicrosoftTeamsMessageCard.PotentialAction"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard ClearPotentialAction(this MicrosoftTeamsMessageCard toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PotentialActionInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageCard.PotentialAction"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard RemovePotentialAction(this MicrosoftTeamsMessageCard toolSettings, params MicrosoftTeamsMessagePotentialAction[] potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessagePotentialAction>(potentialAction);
            toolSettings.PotentialActionInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageCard.PotentialAction"/></em></p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageCard RemovePotentialAction(this MicrosoftTeamsMessageCard toolSettings, IEnumerable<MicrosoftTeamsMessagePotentialAction> potentialAction)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessagePotentialAction>(potentialAction);
            toolSettings.PotentialActionInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MicrosoftTeamsMessageFactsExtensions
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class MicrosoftTeamsMessageFactsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageFacts.Name"/></em></p>
        ///   <p>The key.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageFacts SetName(this MicrosoftTeamsMessageFacts toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageFacts.Name"/></em></p>
        ///   <p>The key.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageFacts ResetName(this MicrosoftTeamsMessageFacts toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageFacts.Value"/></em></p>
        ///   <p>The value.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageFacts SetValue(this MicrosoftTeamsMessageFacts toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageFacts.Value"/></em></p>
        ///   <p>The value.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageFacts ResetValue(this MicrosoftTeamsMessageFacts toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MicrosoftTeamsMessagePotentialActionExtensions
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class MicrosoftTeamsMessagePotentialActionExtensions
    {
        #region Context
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessagePotentialAction.Context"/></em></p>
        ///   <p>Actions can be presented to the user by including a Schema.org JSON-LD object.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction SetContext(this MicrosoftTeamsMessagePotentialAction toolSettings, string context)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = context;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessagePotentialAction.Context"/></em></p>
        ///   <p>Actions can be presented to the user by including a Schema.org JSON-LD object.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction ResetContext(this MicrosoftTeamsMessagePotentialAction toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessagePotentialAction.Type"/></em></p>
        ///   <p>Currently only supports ViewAction, which creates a hyperlinked action button at the bottom of the connector card.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction SetType(this MicrosoftTeamsMessagePotentialAction toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessagePotentialAction.Type"/></em></p>
        ///   <p>Currently only supports ViewAction, which creates a hyperlinked action button at the bottom of the connector card.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction ResetType(this MicrosoftTeamsMessagePotentialAction toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessagePotentialAction.Name"/></em></p>
        ///   <p>Name of the action. (Shown as the Button text).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction SetName(this MicrosoftTeamsMessagePotentialAction toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessagePotentialAction.Name"/></em></p>
        ///   <p>Name of the action. (Shown as the Button text).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction ResetName(this MicrosoftTeamsMessagePotentialAction toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessagePotentialAction.Target"/> to a new list</em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction SetTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessagePotentialAction.Target"/> to a new list</em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction SetTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessagePotentialAction.Target"/></em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction AddTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessagePotentialAction.Target"/></em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction AddTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="MicrosoftTeamsMessagePotentialAction.Target"/></em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction ClearTarget(this MicrosoftTeamsMessagePotentialAction toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessagePotentialAction.Target"/></em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction RemoveTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessagePotentialAction.Target"/></em></p>
        ///   <p>Target of the action. (The destination hyperlink).</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessagePotentialAction RemoveTarget(this MicrosoftTeamsMessagePotentialAction toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MicrosoftTeamsMessageSectionExtensions
    /// <summary>
    ///   Used within <see cref="MicrosoftTeamsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class MicrosoftTeamsMessageSectionExtensions
    {
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.Title"/></em></p>
        ///   <p>The title is displayed as larger, bold text near the top of a message attachment.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetTitle(this MicrosoftTeamsMessageSection toolSettings, string title)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.Title"/></em></p>
        ///   <p>The title is displayed as larger, bold text near the top of a message attachment.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetTitle(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region ActivityTitle
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.ActivityTitle"/></em></p>
        ///   <p>Title of the event or action. Often this will be the name of the "actor".</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetActivityTitle(this MicrosoftTeamsMessageSection toolSettings, string activityTitle)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityTitle = activityTitle;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.ActivityTitle"/></em></p>
        ///   <p>Title of the event or action. Often this will be the name of the "actor".</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetActivityTitle(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityTitle = null;
            return toolSettings;
        }
        #endregion
        #region ActivitySubtitle
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.ActivitySubtitle"/></em></p>
        ///   <p>A subtitle describing the event or action. Often this will be a summary of the action.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetActivitySubtitle(this MicrosoftTeamsMessageSection toolSettings, string activitySubtitle)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivitySubtitle = activitySubtitle;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.ActivitySubtitle"/></em></p>
        ///   <p>A subtitle describing the event or action. Often this will be a summary of the action.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetActivitySubtitle(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivitySubtitle = null;
            return toolSettings;
        }
        #endregion
        #region ActivityImage
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.ActivityImage"/></em></p>
        ///   <p>An image representing the action. Often this is an avatar of the "actor" of the activity.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetActivityImage(this MicrosoftTeamsMessageSection toolSettings, string activityImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityImage = activityImage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.ActivityImage"/></em></p>
        ///   <p>An image representing the action. Often this is an avatar of the "actor" of the activity.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetActivityImage(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityImage = null;
            return toolSettings;
        }
        #endregion
        #region ActivityText
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.ActivityText"/></em></p>
        ///   <p>A full description of the action.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetActivityText(this MicrosoftTeamsMessageSection toolSettings, string activityText)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityText = activityText;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.ActivityText"/></em></p>
        ///   <p>A full description of the action.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetActivityText(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActivityText = null;
            return toolSettings;
        }
        #endregion
        #region Facts
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.Facts"/> to a new list</em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetFacts(this MicrosoftTeamsMessageSection toolSettings, params MicrosoftTeamsMessageFacts[] facts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FactsInternal = facts.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.Facts"/> to a new list</em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetFacts(this MicrosoftTeamsMessageSection toolSettings, IEnumerable<MicrosoftTeamsMessageFacts> facts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FactsInternal = facts.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageSection.Facts"/></em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection AddFacts(this MicrosoftTeamsMessageSection toolSettings, params MicrosoftTeamsMessageFacts[] facts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FactsInternal.AddRange(facts);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="MicrosoftTeamsMessageSection.Facts"/></em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection AddFacts(this MicrosoftTeamsMessageSection toolSettings, IEnumerable<MicrosoftTeamsMessageFacts> facts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FactsInternal.AddRange(facts);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="MicrosoftTeamsMessageSection.Facts"/></em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ClearFacts(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FactsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageSection.Facts"/></em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection RemoveFacts(this MicrosoftTeamsMessageSection toolSettings, params MicrosoftTeamsMessageFacts[] facts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessageFacts>(facts);
            toolSettings.FactsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="MicrosoftTeamsMessageSection.Facts"/></em></p>
        ///   <p>A list of facts, displayed as key-value pairs.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection RemoveFacts(this MicrosoftTeamsMessageSection toolSettings, IEnumerable<MicrosoftTeamsMessageFacts> facts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<MicrosoftTeamsMessageFacts>(facts);
            toolSettings.FactsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Text
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.Text"/></em></p>
        ///   <p>Optional text that will appear before the activity.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetText(this MicrosoftTeamsMessageSection toolSettings, string text)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = text;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.Text"/></em></p>
        ///   <p>Optional text that will appear before the activity.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetText(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = null;
            return toolSettings;
        }
        #endregion
        #region Markdown
        /// <summary>
        ///   <p><em>Sets <see cref="MicrosoftTeamsMessageSection.Markdown"/></em></p>
        ///   <p>Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection SetMarkdown(this MicrosoftTeamsMessageSection toolSettings, bool? markdown)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = markdown;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="MicrosoftTeamsMessageSection.Markdown"/></em></p>
        ///   <p>Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ResetMarkdown(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="MicrosoftTeamsMessageSection.Markdown"/></em></p>
        ///   <p>Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection EnableMarkdown(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="MicrosoftTeamsMessageSection.Markdown"/></em></p>
        ///   <p>Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection DisableMarkdown(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="MicrosoftTeamsMessageSection.Markdown"/></em></p>
        ///   <p>Set this to false to disable markdown parsing on this section's content. Markdown parsing is enabled by default.</p>
        /// </summary>
        [Pure]
        public static MicrosoftTeamsMessageSection ToggleMarkdown(this MicrosoftTeamsMessageSection toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = !toolSettings.Markdown;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
