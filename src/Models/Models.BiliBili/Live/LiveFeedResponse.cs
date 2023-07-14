// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ�б���Ӧ����.
/// </summary>
public class LiveFeedResponse
{
    /// <summary>
    /// ֱ��Դ��Ƭ�б�.
    /// </summary>
    [JsonPropertyName("card_list")]
    public List<LiveFeedCard> CardList { get; set; }
}

