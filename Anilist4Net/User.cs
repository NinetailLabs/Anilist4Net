﻿using Anilist4Net.Enums;

namespace Anilist4Net
{
	public class User
	{
		/// <summary>
		///     The ID of the user
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     The username of the user
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     The user's bio / about in Markdown
		/// </summary>
		public string AboutMd { get; set; }

		/// <summary>
		///     The user's bio / about in HTML
		/// </summary>
		public string AboutHtml { get; set; }

		public UserAvatar Avatar { get; set; }

		/// <summary>
		///     The user's avatar URL, large size
		/// </summary>
		public string LargeAvatar => Avatar.Large;

		/// <summary>
		///     The user's avatar URL, medium size
		/// </summary>
		public string MediumAvatar => Avatar.Medium;

		/// <summary>
		///     The user's banner image URL
		/// </summary>
		public string BannerImage { get; set; }

		public UserOptions Options { get; set; }

		/// <summary>
		///     What language the user likes titles to be displayed in
		/// </summary>
		public UserTitleLanguages TitleLanguage => Options.TitleLanguage;

		/// <summary>
		///     Whether or not the user has enabled seeing adult content
		/// </summary>
		public bool DisplayAdultContent => Options.DisplayAdultContent;

		/// <summary>
		///     Whether or not the user gets notifications for their watching shows' new episodes
		/// </summary>
		public bool AiringNotifications => Options.AiringNotifications;

		/// <summary>
		///     The color of the user's profile
		/// </summary>
		public UserProfileColours ProfileColour => Options.ProfileColor;

		public UserMediaListOptions MediaListOptions { get; set; }

		/// <summary>
		///     The user's chosen scoring format
		/// </summary>
		public ScoreFormats ScoreFormat => MediaListOptions.ScoreFormat;

		/// <summary>
		///     The user's chosen row order
		/// </summary>
		public string RowOrder => MediaListOptions.RowOrder;

		/// <summary>
		///     The user's anime list options
		/// </summary>
		public UserMediaListTypeOptions AnimeList => MediaListOptions.AnimeList;

		/// <summary>
		///     The user's manga list options
		/// </summary>
		public UserMediaListTypeOptions MangaList => MediaListOptions.MangaList;

		/// <summary>
		///     The user's amount of unread notifications
		/// </summary>
		public int? UnreadNotificationCount { get; set; }

		/// <summary>
		///     The user's Anilist site URL
		/// </summary>
		public string SiteUrl { get; set; }

		/// <summary>
		///     The user's donator tier
		/// </summary>
		public int DonatorTier { get; set; }

		/// <summary>
		///     What the user wants their donator badge to say
		/// </summary>
		public string DonatorBadge { get; set; }

		/// <summary>
		///     The user's moderator status
		/// </summary>
		public string ModeratorStatus { get; set; }

		/// <summary>
		///     When the user was last updated
		/// </summary>
		public int UpdatedAt { get; set; }
	}

	public class UserResponse
	{
		public User User { get; set; }
	}

	public class UserAvatar
	{
		public string Large  { get; set; }
		public string Medium { get; set; }
	}

	public class UserOptions
	{
		public UserTitleLanguages TitleLanguage       { get; set; }
		public bool               DisplayAdultContent { get; set; }
		public bool               AiringNotifications { get; set; }
		public UserProfileColours ProfileColor        { get; set; }
	}

	public class UserMediaListOptions
	{
		public ScoreFormats             ScoreFormat { get; set; }
		public string                   RowOrder    { get; set; }
		public UserMediaListTypeOptions AnimeList   { get; set; }
		public UserMediaListTypeOptions MangaList   { get; set; }
	}

	public class UserMediaListTypeOptions
	{
		/// <summary>
		///     What order the user's sections appear in
		/// </summary>
		public string[] SectionOrder { get; set; }

		/// <summary>
		///     If the completed section should be split by format
		/// </summary>
		public bool SplitCompletedSectionByFormat { get; set; }

		/// <summary>
		///     The user's custom lists
		/// </summary>
		public string[] CustomLists { get; set; }

		/// <summary>
		///     The user's advanced scoring sections / criteria
		/// </summary>
		public string[] AdvancedScoring { get; set; }

		/// <summary>
		///     Whether the user is using advanced scoring
		/// </summary>
		public bool AdvancedScoringEnabled { get; set; }
	}
}