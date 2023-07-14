// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ���ӿ�Ƭ����.
/// </summary>
public class LiveFeedExtraCardBase
{
    /// <summary>
    /// ��ʶ��.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ������ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("pic")]
    public string Cover { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

