// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ƶ������.
/// </summary>
public class VideoBase
{
    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ��Ƶ����ʱ�� (Unixʱ���).
    /// </summary>
    [JsonPropertyName("pubdate")]
    public long PublishDateTime { get; set; }

    /// <summary>
    /// ��Ƶʱ�� (��).
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}

