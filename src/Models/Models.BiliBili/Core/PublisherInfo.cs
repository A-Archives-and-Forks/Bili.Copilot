// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��������Ϣ.
/// </summary>
public class PublisherInfo
{
    /// <summary>
    /// ��Ƶ�����ߵ�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public long Mid { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Publisher { get; set; }

    /// <summary>
    /// ��Ƶ�����ߵ�ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string PublisherAvatar { get; set; }
}

