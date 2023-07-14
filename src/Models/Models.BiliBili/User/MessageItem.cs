// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ϣ��Ŀ.
/// </summary>
public class MessageItem
{
    /// <summary>
    /// ��ĿID.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

/// <summary>
/// ��Ϣ��Ŀ����.
/// </summary>
public class MessageItemDetail
{
    /// <summary>
    /// ��Ϣ����.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ��Ϣ����.
    /// </summary>
    [JsonPropertyName("business")]
    public string Business { get; set; }

    /// <summary>
    /// ��Ϣ����Id.
    /// </summary>
    [JsonPropertyName("business_id")]
    public string BusinessId { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// �����а�����ͼƬ.
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>
    /// ԭʼ��ַ.
    /// </summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>
/// ��Ϣָ��.
/// </summary>
public class MessageCursor
{
    /// <summary>
    /// �Ƿ��ѵ�ĩβ.
    /// </summary>
    [JsonPropertyName("is_end")]
    public bool IsEnd { get; set; }

    /// <summary>
    /// ��ʶ��.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("time")]
    public long Time { get; set; }
}

