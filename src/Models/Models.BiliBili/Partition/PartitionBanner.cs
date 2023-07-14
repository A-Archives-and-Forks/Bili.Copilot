// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �������.
/// </summary>
public class PartitionBanner
{
    /// <summary>
    /// ���Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// �������.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ���ͼƬ��ַ.
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>
    /// ��ϣ����ֵ.
    /// </summary>
    [JsonPropertyName("hash")]
    public string Hash { get; set; }

    /// <summary>
    /// ������ַ.
    /// </summary>
    [JsonPropertyName("uri")]
    public string NavigateUri { get; set; }

    /// <summary>
    /// ��Ӧ��Դ��Idֵ.
    /// </summary>
    [JsonPropertyName("resource_id")]
    public int ResourceId { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ���.
    /// </summary>
    [JsonPropertyName("is_ad")]
    public bool IsAD { get; set; }

    /// <summary>
    /// �ڼ����е�����ֵ.
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }
}

