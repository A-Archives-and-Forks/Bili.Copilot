// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ���.
/// </summary>
public class LiveFeedBanner : LiveFeedExtraCardBase
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }

    /// <summary>
    /// �Ự��ʶ��.
    /// </summary>
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }
}

/// <summary>
/// ֱ��Դ����б�.
/// </summary>
public class LiveFeedBannerList
{
    /// <summary>
    /// �б�����.
    /// </summary>
    [JsonPropertyName("list")]
    public List<LiveFeedBanner> List { get; set; }
}

