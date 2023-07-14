// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��������Ŀ.
/// </summary>
public class LiveSearchItem : SearchItemBase
{
    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("roomid")]
    public int RoomId { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public long UserId { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ��ע��.
    /// </summary>
    [JsonPropertyName("attentions")]
    public int FollowerCount { get; set; }

    /// <summary>
    /// ֱ��״̬.
    /// </summary>
    [JsonPropertyName("live_status")]
    public int LiveStatus { get; set; }

    /// <summary>
    /// ֱ�����ǩ.
    /// </summary>
    [JsonPropertyName("tags")]
    public string Tags { get; set; }

    /// <summary>
    /// ֱ������.
    /// </summary>
    [JsonPropertyName("region")]
    public int Region { get; set; }

    /// <summary>
    /// �ۿ�����.
    /// </summary>
    [JsonPropertyName("online")]
    public int ViewerCount { get; set; }

    /// <summary>
    /// ֱ����������.
    /// </summary>
    [JsonPropertyName("area_v2_name")]
    public string AreaName { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }

    /// <summary>
    /// ֱ����ַ.
    /// </summary>
    [JsonPropertyName("live_link")]
    public string LiveLink { get; set; }
}

